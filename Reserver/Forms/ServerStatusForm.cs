using FirebirdSql.Data.FirebirdClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Reserver.Forms
{
    public partial class ServerStatusForm : Form
    {
        Reserver reserverForm;

        public ServerStatusForm()
        {
            InitializeComponent();
        }

        public ServerStatusForm(Reserver form)
        {
            InitializeComponent();
            reserverForm = form;
            LoadInterface(reserverForm);
        }

        public Image ResizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        public void SetToolTip(Control control, string username)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(control, username);
        }

        public void LoadInterface(Reserver reserverForm)
        {
            if (reserverForm == null)
            {
                MessageBox.Show("Errore parent form", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            using (FbConnection connection = new FbConnection(reserverForm.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string queryStatusInfo = string.Format(@"
                        SELECT  s.DESCRIZIONE, r.STATO, s.CODICE, u.DENOMINAZIONE, u.AVATAR, sr.DATAINIZIO
                        FROM STATISERVERS r
                        JOIN SERVERS s ON s.IDSERVER = r.IDSERVER
                        LEFT OUTER JOIN UTENTI u ON u.IDUTENTE = r.IDUTENTE
                        left outer join STORICORILASCI sr on sr.IDSERVER = r.IDSERVER and u.IDUTENTE = sr.IDUTENTE and sr.DATAFINE is null");
                    FbCommand getStatusInfo = new FbCommand(queryStatusInfo, connection);
                    FbDataAdapter dataReader = new FbDataAdapter(getStatusInfo);
                    DataTable tableStatusInfo = new DataTable();
                    dataReader.Fill(tableStatusInfo);

                    int top = 25;
                    int left = 25;

                    foreach (DataRow row in tableStatusInfo.Rows)
                    {
                        GroupBox serverGroupBox = new GroupBox();
                        serverGroupBox.Text = row["DESCRIZIONE"].ToString();
                        serverGroupBox.Top = top;
                        serverGroupBox.Left = 100;
                        serverGroupBox.Size = new Size(550, 70);
                        serverGroupBox.Name = "groupBox" + row["CODICE"].ToString();
                        serverGroupBox.BackColor = Color.FromArgb(160, 218, 218);
                        panelServerStatus.Controls.Add(serverGroupBox);


                        MetroFramework.Controls.MetroButton button = new MetroFramework.Controls.MetroButton();
                        button.Left = left;
                        button.Size = new Size(200, 25);
                        button.Top = 25;
                        button.Name = row["CODICE"].ToString();
                        // Inizio verifica utenti con rilasci attivi che hanno chiuso l'applicazione
                        string queryCheckRilasciAttivi = string.Format(@"SELECT * FROM servers s JOIN storicorilasci sr ON s.IDSERVER = sr.IDSERVER WHERE s.codice = '{0}' AND sr.idutente = {1} AND sr.attivo = 1", row["CODICE"].ToString(), reserverForm.CurrentUserID);
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


                        Label statusLabel = new Label();
                        statusLabel.Left = left + 220;
                        statusLabel.Top = 25;
                        statusLabel.Size = new Size(25, 25);
                        statusLabel.Name = "status" + row["CODICE"].ToString();
                        Image statusImg = (row["STATO"].ToString() == "OCCUPATO") ? Image.FromFile(Directory.GetCurrentDirectory() + "\\img\\busy.png") : Image.FromFile(Directory.GetCurrentDirectory() + "\\img\\free.png");
                        statusImg = ResizeImage(statusImg, new Size(25, 25));
                        statusLabel.Image = statusImg;


                        Label dateLabel = new Label();
                        dateLabel.Left = left + 280;
                        dateLabel.Top = 30;
                        dateLabel.Name = "date" + row["CODICE"].ToString();
                        dateLabel.AutoSize = true;


                        Label avatarLabel = new Label();
                        avatarLabel.Left = left + 460;
                        avatarLabel.Top = 10;
                        avatarLabel.Size = new Size(50, 50);
                        avatarLabel.Name = "icon" + row["CODICE"].ToString();

                        if (row["STATO"].ToString() == "OCCUPATO")
                        {                            
                            dateLabel.Text = row["DATAINIZIO"].ToString();

                            Image img = Image.FromFile(Directory.GetCurrentDirectory() + row["AVATAR"].ToString());
                            img = ResizeImage(img, new Size(50, 50));
                            SetToolTip(avatarLabel, row["DENOMINAZIONE"].ToString());
                            avatarLabel.Image = img;

                        }

                        serverGroupBox.Controls.Add(button);
                        serverGroupBox.Controls.Add(statusLabel);

                        serverGroupBox.Controls.Add(dateLabel); 
                        serverGroupBox.Controls.Add(avatarLabel);

                        top += serverGroupBox.Height + 10;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Richiesta al database fallita", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                finally
                {
                    Panel paddingBottomPanel = new Panel();
                    paddingBottomPanel.Top = (6*25) + (5*70);
                    paddingBottomPanel.Left = 75;
                    paddingBottomPanel.Size = new Size(540, 25);
                    panelServerStatus.Controls.Add(paddingBottomPanel);
                    connection.Close();
                }
            }
            
            metroScrollBar1.Scroll += (sender, e) => {
                //Normally the if statement whouldn't be needed but the metro srollbar
                //has a weird behaviour when the scroll value becomes max
                if (metroScrollBar1.Value > panelServerStatus.Height - this.Height)
                {
                    panelServerStatus.Top = -(panelServerStatus.Height - this.Height);
                }
                else
                {
                    panelServerStatus.Top = -metroScrollBar1.Value;
                };
            };

            int maxVertical = this.Height;

            // SmallChange is typically 1%.
            int smallChangeVertical = Math.Max((int)(450 / 100), 1);

            // LargeChange is one page.
            int largeChangeVertical = 450; //this.Height;

            metroScrollBar1.Minimum = 0;
            metroScrollBar1.Maximum = 450; // maxVertical;
            metroScrollBar1.SmallChange = smallChangeVertical;
            metroScrollBar1.LargeChange = largeChangeVertical;

        }


        private void ReleaseButton_Click(object sender, EventArgs e)
        {
            string buttonName = ((Control)sender).Name;
            string buttonText = ((Control)sender).Text;

            using (FbConnection connection = new FbConnection(reserverForm.ConnectionString))
            {
                try
                {
                    connection.Open();
                    if (buttonText == "Rilascia")
                    {
                        IniziaRilascio(connection, buttonName);
                        UpdateStatus();
                    }
                    else
                    {
                        ConcludiRilascio(connection, buttonName);
                        UpdateStatus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Richiesta al database fallita", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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
                    string queryUpdateServerStatus = string.Format(@"UPDATE STATISERVERS SET STATO = 'OCCUPATO', IDUTENTE = {1} WHERE IDSERVER = {0}", serverID, reserverForm.CurrentUserID);
                    FbCommand updateServerStatus = new FbCommand(queryUpdateServerStatus, connection);
                    updateServerStatus.ExecuteNonQuery();

                    Button currentButton = this.Controls.Find(buttonName, true).FirstOrDefault() as Button;
                    currentButton.Text = "Rilascio concluso";

                    Label currentLabel = this.Controls.Find("status" + buttonName, true).FirstOrDefault() as Label;
                    currentLabel.BackColor = Color.Red;

                    string queryStatusInfo = string.Format(@"INSERT INTO STORICORILASCI (IDSERVER, IDUTENTE, attivo, DESCRIZIONE, DATAINIZIO) VALUES ({0}, {1}, {2}, '', '{3}')", serverID, reserverForm.CurrentUserID, 1, DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"));
                    FbCommand getStatusInfo = new FbCommand(queryStatusInfo, connection);
                    getStatusInfo.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Rilascio in corso, aspettare o effettuare una prenotazione", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("Errore query lettura", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
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

                string queryUpdateServerStatus = string.Format(@"UPDATE STATISERVERS SET STATO = 'LIBERO', IDUTENTE = null WHERE IDSERVER = {0}", serverID);
                FbCommand updateServerStatus = new FbCommand(queryUpdateServerStatus, connection);
                updateServerStatus.ExecuteNonQuery();

                Button currentButton = this.Controls.Find(buttonName, true).FirstOrDefault() as Button;
                currentButton.Text = "Rilascia";

                Label currentLabel = this.Controls.Find("status" + buttonName, true).FirstOrDefault() as Label;
                currentLabel.BackColor = Color.Green;

                string queryStatusInfo = string.Format(@"UPDATE storicorilasci SET attivo = 0, datafine = '{0}' WHERE idserver = {1} AND idutente = {2} AND attivo = 1", DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"), serverID, reserverForm.CurrentUserID);
                FbCommand getStatusInfo = new FbCommand(queryStatusInfo, connection);
                getStatusInfo.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Errore query lettura", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void ButtonUpdateStatus_Click(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            using (FbConnection connection = new FbConnection(reserverForm.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string queryStatusInfo = string.Format(@"
                        SELECT r.STATO, s.CODICE, u.DENOMINAZIONE, u.AVATAR, sr.DATAINIZIO
                        FROM STATISERVERS r
                        JOIN SERVERS s ON s.IDSERVER = r.IDSERVER
                        LEFT OUTER JOIN UTENTI u ON u.IDUTENTE = r.IDUTENTE
                        left outer join STORICORILASCI sr on sr.IDSERVER = r.IDSERVER and u.IDUTENTE = sr.IDUTENTE and sr.DATAFINE is null");
                    FbCommand getStatusInfo = new FbCommand(queryStatusInfo, connection);
                    FbDataReader readerGetServerID = getStatusInfo.ExecuteReader();

                    while (readerGetServerID.Read())
                    {
                        Label currentLabel = this.Controls.Find("status" + readerGetServerID.GetString(1), true).FirstOrDefault() as Label;
                        Image statusImg = (readerGetServerID.GetString(0) == "OCCUPATO") ? Image.FromFile(Directory.GetCurrentDirectory() + "\\img\\busy.png") : Image.FromFile(Directory.GetCurrentDirectory() + "\\img\\free.png");
                        statusImg = ResizeImage(statusImg, new Size(25, 25));
                        currentLabel.BackColor = Color.Transparent;
                        currentLabel.Image = statusImg;

                        Label currentDateLabel = this.Controls.Find("date" + readerGetServerID.GetString(1), true).FirstOrDefault() as Label;
                        Label currentIconLabel = this.Controls.Find("icon" + readerGetServerID.GetString(1), true).FirstOrDefault() as Label;

                        if (readerGetServerID.GetString(0) == "OCCUPATO")
                        {
                            currentDateLabel.Text = readerGetServerID.GetString(4);
                            Image updatedStatusImg = Image.FromFile(Directory.GetCurrentDirectory() + readerGetServerID.GetString(3));
                            updatedStatusImg = ResizeImage(updatedStatusImg, new Size(50, 50));
                            currentIconLabel.Image = updatedStatusImg;
                            SetToolTip(currentIconLabel, readerGetServerID.GetString(2));
                        }
                        else
                        {
                            currentDateLabel.Text = string.Empty;
                            currentIconLabel.Image = null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Richiesta al database fallita", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void ServerStatusForm_Load(object sender, EventArgs e)
        {

        }
    }
}
