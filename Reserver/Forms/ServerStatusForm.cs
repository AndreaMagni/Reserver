using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Reserver.Forms
{
    public partial class ServerStatusForm : Form
    {
        Reserver reserverForm;

        PrivateFontCollection privateFontCollection;

        public ServerStatusForm()
        {
            InitializeComponent();
        }

        public ServerStatusForm(Reserver form)
        {
            InitializeComponent();
            reserverForm = form;
            privateFontCollection = new PrivateFontCollection();
            privateFontCollection.AddFontFile(Directory.GetCurrentDirectory() + "\\font\\Quicksand-Light.ttf");
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

            // POSSIBILI TODO:
            //
            // - Nuovo stato COLLAUDO giallo al posto di rosso / verde?
            //
            // -
            //
            // -
            //

            using (FbConnection connection = new FbConnection(reserverForm.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string queryStatusInfo = string.Format(@"
                        SELECT s.DESCRIZIONE, r.STATO, s.CODICE, u.DENOMINAZIONE, u.AVATAR, sr.DATAINIZIO
                        FROM STATISERVERS r
                        JOIN SERVERS s ON s.IDSERVER = r.IDSERVER
                        LEFT OUTER JOIN UTENTI u ON u.IDUTENTE = r.IDUTENTE
                        left outer join STORICORILASCI sr on sr.IDSERVER = r.IDSERVER and u.IDUTENTE = sr.IDUTENTE and sr.DATAFINE is null");
                    FbCommand getStatusInfo = new FbCommand(queryStatusInfo, connection);
                    FbDataAdapter dataReader = new FbDataAdapter(getStatusInfo);
                    DataTable tableStatusInfo = new DataTable();
                    dataReader.Fill(tableStatusInfo);

                    int top = 70;
                    int insideLeft = 25;

                    foreach (DataRow row in tableStatusInfo.Rows)
                    {
                        Label labelServerDescription = new Label();
                        labelServerDescription.Top = top;
                        labelServerDescription.Left = 50;
                        labelServerDescription.Size = new Size(200, 60);
                        labelServerDescription.BackColor = Color.FromArgb(92, 162, 150);
                        labelServerDescription.Text = row["DESCRIZIONE"].ToString();
                        labelServerDescription.TextAlign = ContentAlignment.MiddleCenter;
                        // Esempio modifica font
                        //labelServerDescription.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
                        labelServerDescription.Font = new Font(privateFontCollection.Families[0], 11, FontStyle.Bold);
                        labelServerDescription.Name = "groupBox" + row["CODICE"].ToString();
                        panelServerStatus.Controls.Add(labelServerDescription);

                        Panel panelServerInfo = new Panel();
                        panelServerInfo.Top = top;
                        panelServerInfo.Left = 250;
                        panelServerInfo.Size = new Size(450, 60);
                        panelServerInfo.BackColor = Color.FromArgb(142, 198, 189);
                        panelServerStatus.Controls.Add(panelServerInfo);

                        MetroFramework.Controls.MetroButton button = new MetroFramework.Controls.MetroButton();
                        button.Left = insideLeft;
                        button.Size = new Size(150, 25);
                        button.Top = 20;
                        button.Name = row["CODICE"].ToString();
                        button.FontSize = MetroFramework.MetroButtonSize.Small;
                        button.FontWeight = MetroFramework.MetroButtonWeight.Regular;
                        // Inizio verifica utenti con rilasci attivi che hanno chiuso l'applicazione
                        string queryCheckRilasciAttivi = string.Format(@"
                            SELECT 
                                * 
                            FROM 
                                servers s 
                                JOIN storicorilasci sr ON s.IDSERVER = sr.IDSERVER 
                            WHERE
                                s.codice = '{0}' 
                                AND sr.idutente = {1} 
                                AND sr.attivo = 1", row["CODICE"].ToString(), reserverForm.CurrentUserID
                        );
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
                        // Fine verifica utenti con rilasci attivi che hanno chiuso l'applicazione

                        // Inizio verifica collaudi 
                        string queryCheckCollaudiAttivi = string.Format(@"
                            SELECT 
                                c.idcollaudo 
                            FROM 
                                servers s 
                                JOIN collaudi c ON c.IDSERVER = s.IDSERVER 
                            WHERE 
                                c.STATO = 'ATTIVO' 
                                AND s.codice = '{0}'", row["CODICE"].ToString()
                        );
                        FbCommand getCheckCollaudiAttivi = new FbCommand(queryCheckCollaudiAttivi, connection);
                        FbDataReader readerGetCheckCollaudiAttivi = getCheckCollaudiAttivi.ExecuteReader();
                        if (readerGetCheckCollaudiAttivi.Read())
                        {
                            button.Text = "Collaudo in corso";
                        }
                        // Fine verifica collaudi
                        button.Click += new EventHandler(this.ReleaseButton_Click);

                        Label statusLabel = new Label();
                        statusLabel.Left = insideLeft + 175;
                        statusLabel.Top = 20;
                        statusLabel.Size = new Size(25, 25);
                        statusLabel.Name = "status" + row["CODICE"].ToString();
                        statusLabel.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
                        Image statusImg = (row["STATO"].ToString() == "OCCUPATO") ? Image.FromFile(Directory.GetCurrentDirectory() + "\\img\\remove.png") : Image.FromFile(Directory.GetCurrentDirectory() + "\\img\\check.png");
                        statusImg = ResizeImage(statusImg, new Size(25, 25));
                        statusLabel.Image = statusImg;

                        Label dateLabel = new Label();
                        dateLabel.Left = insideLeft + 225;
                        dateLabel.Top = 20;
                        dateLabel.AutoSize = false;
                        dateLabel.TextAlign = ContentAlignment.MiddleCenter;
                        dateLabel.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
                        dateLabel.Size = new Size(100, 25);
                        dateLabel.Name = "date" + row["CODICE"].ToString();

                        Label avatarLabel = new Label();
                        avatarLabel.Left = insideLeft + 350;
                        avatarLabel.Top = 5;
                        avatarLabel.Size = new Size(50, 50);
                        avatarLabel.Name = "icon" + row["CODICE"].ToString();

                        if (row["STATO"].ToString() == "OCCUPATO")
                        {
                            dateLabel.Text = RelativeDate(Convert.ToDateTime(row["DATAINIZIO"].ToString()));
                            SetToolTip(dateLabel, row["DATAINIZIO"].ToString());

                            Image img = Image.FromFile(Directory.GetCurrentDirectory() + row["AVATAR"].ToString());
                            img = ResizeImage(img, new Size(50, 50));
                            SetToolTip(avatarLabel, row["DENOMINAZIONE"].ToString());
                            avatarLabel.Image = img;
                        }

                        panelServerInfo.Controls.Add(button);
                        panelServerInfo.Controls.Add(statusLabel);

                        panelServerInfo.Controls.Add(dateLabel);
                        panelServerInfo.Controls.Add(avatarLabel);
                        
                        top += labelServerDescription.Height + 10;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Richiesta fallita.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    Logger.LogStack("Errore.", ex.StackTrace.ToString());
                }
                finally
                {
                    connection.Close();
                    UpdateStatus();
                }
            }
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
                    else if (buttonText == "Collaudo in corso")
                    {
                        // dovrebbe prima verificare se effettivamente il collaudo è finito
                        MessageBox.Show("Collaudo in corso.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        UpdateStatus();
                    }
                    // gestione stato concludi collaudo
                    else
                    {
                        ConcludiRilascio(connection, buttonName);
                        UpdateStatus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Richiesta fallita.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    Logger.LogStack("Errore.", ex.StackTrace.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void IniziaRilascio(FbConnection connection, string buttonName)
        {
            string queryGetServerID = string.Format(@"
                SELECT 
                    s.idserver,
                    ss.stato,
                    ss.statocollaudo
                FROM 
                    servers s 
                    JOIN statiservers ss ON ss.idserver = s.idserver 
                WHERE s.codice = '{0}'", buttonName
            );
            FbCommand getServerID = new FbCommand(queryGetServerID, connection);
            FbDataReader readerGetServerID = getServerID.ExecuteReader();

            if (readerGetServerID.Read())
            {
                if(readerGetServerID.GetInt32(2) > 0)
                {
                    MessageBox.Show("Collaudo in corso", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                    Button currentButton = this.Controls.Find(buttonName, true).FirstOrDefault() as Button;
                    currentButton.Text = "Collaudo in corso";
                } 
                else
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
                    // Al posto di buttonname abbiamo s.codice
                    // Button currentButton = this.Controls.Find(S.CODICE, true).FirstOrDefault() as Button;
                    connection.Open();
                    string queryStatusInfo = string.Format(@"
                        SELECT r.STATO, s.CODICE, u.DENOMINAZIONE, u.AVATAR, sr.DATAINIZIO, r.STATOCOLLAUDO
                        FROM STATISERVERS r
                        JOIN SERVERS s ON s.IDSERVER = r.IDSERVER
                        LEFT OUTER JOIN UTENTI u ON u.IDUTENTE = r.IDUTENTE
                        left outer join STORICORILASCI sr on sr.IDSERVER = r.IDSERVER and u.IDUTENTE = sr.IDUTENTE and sr.DATAFINE is null");
                    FbCommand getStatusInfo = new FbCommand(queryStatusInfo, connection);
                    FbDataReader readerGetServerID = getStatusInfo.ExecuteReader();

                    metroLabel1.Text = string.Format(@"Ultimo aggiornamento dati {0}", DateTime.Now);
                    metroLabel1.Font = new Font(privateFontCollection.Families[0], 9, FontStyle.Regular);

                    while (readerGetServerID.Read())
                    {
                        Label currentLabel = this.Controls.Find("status" + readerGetServerID.GetString(1), true).FirstOrDefault() as Label;
                        Image statusImg = (readerGetServerID.GetString(0) == "OCCUPATO") ? Image.FromFile(Directory.GetCurrentDirectory() + "\\img\\remove.png") : Image.FromFile(Directory.GetCurrentDirectory() + "\\img\\check.png");
                        statusImg = ResizeImage(statusImg, new Size(25, 25));
                        currentLabel.BackColor = Color.Transparent;
                        currentLabel.Image = statusImg;

                        Label currentDateLabel = this.Controls.Find("date" + readerGetServerID.GetString(1), true).FirstOrDefault() as Label;
                        Label currentIconLabel = this.Controls.Find("icon" + readerGetServerID.GetString(1), true).FirstOrDefault() as Label;

                        if (readerGetServerID.GetString(0) == "OCCUPATO")
                        {
                            currentDateLabel.Text = RelativeDate(Convert.ToDateTime(readerGetServerID.GetString(4)));
                            currentDateLabel.Font = new Font(privateFontCollection.Families[0], 11, FontStyle.Regular);
                            // QUI PROBLEMA PER TOOLTIP 
                            SetToolTip(currentDateLabel, readerGetServerID.GetString(4));
                            Image updatedStatusImg = Image.FromFile(Directory.GetCurrentDirectory() + readerGetServerID.GetString(3));
                            updatedStatusImg = ResizeImage(updatedStatusImg, new Size(50, 50));
                            currentIconLabel.Image = updatedStatusImg;
                            // QUI PROBLEMA PER TOOLTIP 
                            SetToolTip(currentIconLabel, readerGetServerID.GetString(2));
                        }
                        else if (readerGetServerID.GetInt32(5) > 0)
                        {
                            Button currentButton = this.Controls.Find(readerGetServerID.GetString(1), true).FirstOrDefault() as Button;
                            currentButton.Text = "Collaudo in corso";
                        }
                        else
                        {
                            Button currentButton = this.Controls.Find(readerGetServerID.GetString(1), true).FirstOrDefault() as Button;
                            currentButton.Text = "Rilascia";
                            currentDateLabel.Text = string.Empty;
                            currentIconLabel.Image = null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Richiesta fallita.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    Logger.LogStack("Errore.", ex.StackTrace.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private string RelativeDate(DateTime theDate)
        {
            int minute = 60;
            int hour = 60 * minute;
            int day = 24 * hour;
            long since = (DateTime.Now.Ticks - theDate.Ticks) / 10000000;
            Dictionary<long, string> thresholds = new Dictionary<long, string>();
            thresholds.Add(60, "{0} secondi fa");
            thresholds.Add(minute * 2, "1 minuto fa");
            thresholds.Add(45 * minute, "{0} minuti fa");
            thresholds.Add(120 * minute, "1 ora fa");
            thresholds.Add(day, "{0} ore fa");
            thresholds.Add(day * 2, "ieri");
            thresholds.Add(day * 30, "{0} giorni fa");
            foreach (long threshold in thresholds.Keys)
            {
                if (since < threshold)
                {
                    TimeSpan t = new TimeSpan((DateTime.Now.Ticks - theDate.Ticks));
                    return string.Format(thresholds[threshold], (t.Days > 365 ? t.Days / 365 : (t.Days > 0 ? t.Days : (t.Hours > 0 ? t.Hours : (t.Minutes > 0 ? t.Minutes : (t.Seconds > 0 ? t.Seconds : 0))))).ToString());
                }
            }
            return "";
        }

    }
}
