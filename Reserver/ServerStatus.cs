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

        private bool firstTime = true;
        private Timer serverStatusTimer;

        public ServerStatus()
        {
            InitializeComponent();
        }

        public void InitTimer()
        {
            serverStatusTimer = new Timer();
            serverStatusTimer.Tick += new EventHandler(ServerStatusTimer_Tick);
            serverStatusTimer.Interval = 30000;
            serverStatusTimer.Start();
        }

        private void ServerStatusTimer_Tick(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void FirstTimeLoad()
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
                        button.Top = top;
                        button.Name = "button" + row["CODICE"].ToString();
                        button.Text = "Rilascia";
                        this.Controls.Add(button);

                        Label panelLabel = new Label();
                        panelLabel.Left = left + 200;
                        panelLabel.Top = top;
                        panelLabel.Size = new Size(25, 25);
                        panelLabel.Name = "panel" + row["CODICE"].ToString();
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

        private void UpdateStatus()
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
                        SELECT r.STATO, s.CODICE
                        FROM STATISERVERS r
                        JOIN SERVERS s ON s.IDSERVER = r.IDSERVER");
                    FbCommand getStatusInfo = new FbCommand(queryStatusInfo, connection);
                    FbDataAdapter dataReader = new FbDataAdapter(getStatusInfo);
                    DataTable tableStatusInfo = new DataTable();
                    dataReader.Fill(tableStatusInfo);

                    foreach (DataRow row in tableStatusInfo.Rows)
                    {
                        string label = "panel" + row["CODICE"].ToString();
                        Label panelLabel = this.Controls.Find(label, true).FirstOrDefault() as Label;
                        panelLabel.Visible = true;
                        panelLabel.BackColor = (row["STATO"].ToString() == "OCCUPATO") ? Color.Red : Color.Green;
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

        private void VisibleChange(object sender, EventArgs e)
        {
            bool visible = this.Visible;

            if (firstTime && visible)
            {
                FirstTimeLoad();
                firstTime = false;
            }

            if (visible)
            {
                InitTimer();
            }
        }

        //private void metroButton1_Click(object sender, EventArgs e)
        //{
        //    if (ParentForm == null)
        //    {
        //        MessageBox.Show("Errore parent form", "Errore parent form", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        //    }

        //    using (FbConnection connection = new FbConnection(ParentForm.ConnectionString))
        //    {
        //        try
        //        {
        //            int serverId;
        //            string serverStatus;
        //            connection.Open();
        //            string queryServerInfo = string.Format(@"SELECT s.idserver, ss.stato
        //                                                     FROM servers s
        //                                                     JOIN statiservers ss ON ss.idserver = s.idserver
        //                                                     WHERE s.descrizione = '{0}'", server["metroButton1"]);
        //            FbCommand getServerInfo = new FbCommand(queryServerInfo, connection);
        //            FbDataReader readerServerInfo = getServerInfo.ExecuteReader();
        //            serverId = readerServerInfo.GetInt32(0);
        //            /* Non dovrebbe essere necessario fare tutto questo, andrà sempre a buon fine
        //                if (readerServerInfo.Read())
        //                {
        //                    serverID = readerServerInfo.GetInt32(0); 
        //                    MessageBox.Show(serverID.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Utente non censito a sistema", "Stato connessione", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        //                }
        //            */
        //            serverStatus = readerServerInfo.GetString(1);

        //            if (serverStatus == "OCCUPATO")
        //            {
        //                MessageBox.Show("Rilascio in corso, aspettare o effettuare una prenotazione", "Rilascio", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        //            }
        //            else
        //            {

        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Richiesta al database fallita", "Errore DB", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        //        }
        //        finally
        //        {
        //            connection.Close();
        //        }
        //    }
        //}

    }
}
