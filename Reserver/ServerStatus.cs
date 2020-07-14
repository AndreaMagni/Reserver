using System;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace Reserver
{
    public partial class ServerStatus : UserControl
    {
        new public Reserver ParentForm { get; set; }

        public ServerStatus()
        {
            InitializeComponent();
        }

        public void FirstTimeLoad()
        {
            if (ParentForm == null)
            {
                MessageBox.Show("Errore parent form", "Errore parent form", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }

            using (FbConnection connection = new FbConnection(ParentForm.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string queryStatusInfo = string.Format(@"
                        SELECT s.DESCRIZIONE, r.STATO, s.CODICE
                        FROM STATISERVERS r
                        JOIN SERVERS s ON s.IDSERVER = r.IDSERVER");
                    FbCommand getStatusInfo = new FbCommand(queryStatusInfo, connection);
                    FbDataAdapter dataReader = new FbDataAdapter(getStatusInfo);
                    DataTable tableStatusInfo = new DataTable();
                    dataReader.Fill(tableStatusInfo);

                    int top = 50;

                    foreach (DataRow row in tableStatusInfo.Rows)
                    {
                        int left = 100;

                        Label label = new Label();
                        label.Left = left;
                        label.Top = top;
                        label.Name = "label" + row["CODICE"].ToString();
                        label.Text = row["DESCRIZIONE"].ToString();
                        this.Controls.Add(label);

                        Button button = new Button();
                        button.Left = left + 100;
                        button.Size = new Size(200, 25);
                        button.Top = top;
                        button.Name = row["CODICE"].ToString();
                        // Inizio verifica utenti con rilasci attivi che hanno chiuso l'applicazione
                        string queryCheckRilasciAttivi = string.Format(@"SELECT * FROM servers s JOIN storicorilasci sr ON s.IDSERVER = sr.IDSERVER WHERE s.codice = '{0}' AND sr.idutente = {1} AND sr.attivo = 1", row["CODICE"].ToString(), ParentForm.CurrentUserID);
                        FbCommand getCheckRilasciAttivi = new FbCommand(queryCheckRilasciAttivi, connection);
                        FbDataReader readerGetCheckRilasciAttivi = getCheckRilasciAttivi.ExecuteReader();
                        if (readerGetCheckRilasciAttivi.Read())
                        {
                            button.Text = "Rilascio concluso";
                        }
                        else
                        {
                            button.Text = "Rilascia";
                        }
                        // Fine verifica
                        button.Click += new EventHandler(this.ReleaseButton_Click);
                        this.Controls.Add(button);

                        Label panelLabel = new Label();
                        panelLabel.Left = left + 350;
                        panelLabel.Top = top;
                        panelLabel.Size = new Size(25, 25);
                        panelLabel.Name = "status" + row["CODICE"].ToString();
                        panelLabel.BackColor = (row["STATO"].ToString() == "OCCUPATO") ? Color.Red : Color.Green;
                        this.Controls.Add(panelLabel);

                        top += button.Height + 5;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Richiesta al database fallita", "Errore DB", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void ReleaseButton_Click(object sender, EventArgs e)
        {
            string buttonName = ((Control)sender).Name;
            string buttonText = ((Control)sender).Text;

            using (FbConnection connection = new FbConnection(ParentForm.ConnectionString))
            {
                try
                {
                    connection.Open();
                    if (buttonText == "Rilascia")
                    {
                        IniziaRilascio(connection, buttonName);
                    }
                    else
                    {
                        ConcludiRilascio(connection, buttonName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Richiesta al database fallita", "Errore DB", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void IniziaRilascio(FbConnection connection, string buttonName)
        {
            string queryGetServerID = string.Format(@"SELECT s.idserver, ss.stato FROM servers s JOIN statiservers ss ON ss.idserver = s.idserver WHERE s.codice = '{0}'", buttonName);
            FbCommand getServerID = new FbCommand(queryGetServerID, connection);
            FbDataReader readerGetServerID = getServerID.ExecuteReader();

            if (readerGetServerID.Read())
            {
                int serverID = readerGetServerID.GetInt32(0);
                string serverStatus = readerGetServerID.GetString(1);

                if (serverStatus == "LIBERO")
                {
                    string queryUpdateServerStatus = string.Format(@"UPDATE STATISERVERS SET STATO = 'OCCUPATO' WHERE IDSERVER = {0}", serverID);
                    FbCommand updateServerStatus = new FbCommand(queryUpdateServerStatus, connection);
                    updateServerStatus.ExecuteNonQuery();

                    Button currentButton = this.Controls.Find(buttonName, true).FirstOrDefault() as Button;
                    currentButton.Text = "Rilascio concluso";

                    Label currentLabel = this.Controls.Find("status" + buttonName, true).FirstOrDefault() as Label;
                    currentLabel.BackColor = Color.Red;

                    string queryStatusInfo = string.Format(@"INSERT INTO STORICORILASCI (IDSERVER, IDUTENTE, attivo, DESCRIZIONE, DATAINIZIO) VALUES ({0}, {1}, {2}, '', '{3}')", serverID, ParentForm.CurrentUserID, 1, DateTime.Now);
                    FbCommand getStatusInfo = new FbCommand(queryStatusInfo, connection);
                    getStatusInfo.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Rilascio in corso, aspettare o effettuare una prenotazione", "Rilascio", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
            }
            else
            {
                MessageBox.Show("Errore query lettura", "Stato connessione", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void ConcludiRilascio(FbConnection connection, string buttonName)
        {
            string queryGetServerID = string.Format(@"SELECT s.idserver, ss.stato FROM servers s JOIN statiservers ss ON ss.idserver = s.idserver WHERE s.codice = '{0}'", buttonName);
            FbCommand getServerID = new FbCommand(queryGetServerID, connection);
            FbDataReader readerGetServerID = getServerID.ExecuteReader();

            if (readerGetServerID.Read())
            {
                int serverID = readerGetServerID.GetInt32(0);

                string queryUpdateServerStatus = string.Format(@"UPDATE STATISERVERS SET STATO = 'LIBERO' WHERE IDSERVER = {0}", serverID);
                FbCommand updateServerStatus = new FbCommand(queryUpdateServerStatus, connection);
                updateServerStatus.ExecuteNonQuery();

                Button currentButton = this.Controls.Find(buttonName, true).FirstOrDefault() as Button;
                currentButton.Text = "Rilascia";

                Label currentLabel = this.Controls.Find("status" + buttonName, true).FirstOrDefault() as Label;
                currentLabel.BackColor = Color.Green;

                string queryStatusInfo = string.Format(@"UPDATE storicorilasci SET attivo = 0, datafine = '{0}' WHERE idserver = {1} AND idutente = {2} AND attivo = 1", DateTime.Now, serverID, ParentForm.CurrentUserID);
                FbCommand getStatusInfo = new FbCommand(queryStatusInfo, connection);
                getStatusInfo.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Errore query lettura", "Stato connessione", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void ButtonUpdateStatus_Click(object sender, EventArgs e)
        {
            using (FbConnection connection = new FbConnection(ParentForm.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string queryStatusInfo = string.Format(@"
                        SELECT r.STATO, s.CODICE
                        FROM STATISERVERS r
                        JOIN SERVERS s ON s.IDSERVER = r.IDSERVER");
                    FbCommand getStatusInfo = new FbCommand(queryStatusInfo, connection);
                    FbDataReader readerGetServerID = getStatusInfo.ExecuteReader();

                    while (readerGetServerID.Read())
                    {
                        Label currentLabel = this.Controls.Find("status" + readerGetServerID.GetString(1), true).FirstOrDefault() as Label;
                        currentLabel.BackColor = (readerGetServerID.GetString(0) == "OCCUPATO") ? Color.Red : Color.Green;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Richiesta al database fallita", "Errore DB", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        /*
        private Timer serverStatusTimer;

        public void InitTimer()
        {
            serverStatusTimer = new Timer();
            serverStatusTimer.Tick += new EventHandler(ServerStatusTimer_Tick);
            serverStatusTimer.Interval = 10000;
            serverStatusTimer.Start();
        }

        private void ServerStatusTimer_Tick(object sender, EventArgs e)
        {
            UpdateStatus();
        }
        */

    }
}
