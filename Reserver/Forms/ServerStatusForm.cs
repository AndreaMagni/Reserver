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

        public void LoadInterface(Reserver reserverForm)
        {

            // POSSIBILI TODO:
            //
            // - Nuovo stato COLLAUDO giallo al posto di rosso / verde?
            //
            // - Chiudere reader vari nel codice
            //
            // -
            //

            using (FbConnection connection = new FbConnection(reserverForm.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string queryStatusInfo = string.Format(@"
                        SELECT s.descrizione, r.stato, s.codice
                        FROM statiservers r
                        JOIN servers s ON s.idserver = r.idserver");
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
                        // Esempio modifica Font
                        // labelServerDescription.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
                        // Verifica utenti con rilasci attivi che hanno chiuso l'applicazione
                        string queryCheckRilasciAttivi = string.Format(@"
                            SELECT s.idserver 
                            FROM servers s 
                            JOIN storicorilasci sr ON s.idserver = sr.idserver 
                            WHERE s.codice = '{0}' 
                                AND sr.idutente = {1} 
                                AND sr.attivo = 1", row["CODICE"].ToString(), reserverForm.CurrentUserID);
                        FbCommand getCheckRilasciAttivi = new FbCommand(queryCheckRilasciAttivi, connection);
                        FbDataReader readerGetCheckRilasciAttivi = getCheckRilasciAttivi.ExecuteReader();
                        button.Text = readerGetCheckRilasciAttivi.Read() ? "Rilascio concluso" : "Rilascia";
                        readerGetCheckRilasciAttivi.Close();
                        button.Click += new EventHandler(this.ReleaseButton_Click);

                        Label statusLabel = new Label();
                        statusLabel.Left = insideLeft + 175;
                        statusLabel.Top = 20;
                        statusLabel.Size = new Size(25, 25);
                        statusLabel.Name = "status" + row["CODICE"].ToString();
                        statusLabel.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);

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
                    else if (buttonText == "Concludi collaudo")
                    {
                        ConcludiCollaudo(connection, buttonName);
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
                SELECT s.idserver, ss.stato, ss.statocollaudo
                FROM servers s 
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

                    string queryGetUserAcceptanceTest = string.Format(@"
                                SELECT c.idutente
                                FROM collaudi c 
                                WHERE c.stato = 'ATTIVO'
                                    AND c.idserver = {0}", readerGetServerID.GetInt32(0));
                    FbCommand getUserAcceptanceTest = new FbCommand(queryGetUserAcceptanceTest, connection);
                    int idUtenteCollaudo = (int)getUserAcceptanceTest.ExecuteScalar();

                    if (idUtenteCollaudo == reserverForm.CurrentUserID)
                    {
                        currentButton.Text = "Concludi collaudo";
                    }
                } 
                else
                {
                    int serverID = readerGetServerID.GetInt32(0);
                    string serverStatus = readerGetServerID.GetString(1);

                    if (serverStatus == "LIBERO")
                    {
                        string queryUpdateServerStatus = string.Format(@"
                            UPDATE statiservers 
                            SET stato = 'OCCUPATO', idutente = {1} 
                            WHERE idserver = {0}", serverID, reserverForm.CurrentUserID);
                        FbCommand updateServerStatus = new FbCommand(queryUpdateServerStatus, connection);
                        updateServerStatus.ExecuteNonQuery();

                        Button currentButton = this.Controls.Find(buttonName, true).FirstOrDefault() as Button;
                        currentButton.Text = "Rilascio concluso";

                        Label currentLabel = this.Controls.Find("status" + buttonName, true).FirstOrDefault() as Label;
                        currentLabel.BackColor = Color.Red;

                        string queryStatusInfo = string.Format(@"
                            INSERT INTO storicorilasci (idserver, idutente, attivo, descrizione, datainizio)
                            VALUES ({0}, {1}, {2}, '', '{3}')", serverID, reserverForm.CurrentUserID, 1, DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"));
                        FbCommand getStatusInfo = new FbCommand(queryStatusInfo, connection);
                        getStatusInfo.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Rilascio in corso", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            else
            {
                MessageBox.Show("Errore query lettura", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            readerGetServerID.Close();
        }

        private void ConcludiRilascio(FbConnection connection, string buttonName)
        {
            string queryGetServerID = string.Format(@"
                SELECT s.idserver, ss.stato 
                FROM servers s 
                JOIN statiservers ss ON ss.idserver = s.idserver 
                WHERE s.codice = '{0}'", buttonName);
            FbCommand getServerID = new FbCommand(queryGetServerID, connection);
            FbDataReader readerGetServerID = getServerID.ExecuteReader();

            if (readerGetServerID.Read())
            {
                int serverID = readerGetServerID.GetInt32(0);

                string queryUpdateServerStatus = string.Format(@"
                    UPDATE statiservers 
                    SET stato = 'LIBERO', idutente = null 
                    WHERE idserver = {0}", serverID);
                FbCommand updateServerStatus = new FbCommand(queryUpdateServerStatus, connection);
                updateServerStatus.ExecuteNonQuery();

                Button currentButton = this.Controls.Find(buttonName, true).FirstOrDefault() as Button;
                currentButton.Text = "Rilascia";

                Label currentLabel = this.Controls.Find("status" + buttonName, true).FirstOrDefault() as Label;
                currentLabel.BackColor = Color.Green;

                string queryStatusInfo = string.Format(@"
                    UPDATE storicorilasci 
                    SET attivo = 0, datafine = '{0}' 
                    WHERE idserver = {1} 
                        AND idutente = {2} 
                        AND attivo = 1", DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"), serverID, reserverForm.CurrentUserID);
                FbCommand getStatusInfo = new FbCommand(queryStatusInfo, connection);
                getStatusInfo.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Errore query lettura", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            readerGetServerID.Close();
        }

        private void ConcludiCollaudo(FbConnection connection, string buttonName)
        {
            string queryGetServerID = string.Format(@"
                SELECT s.idserver 
                FROM servers s  
                WHERE s.codice = '{0}'", buttonName);
            FbCommand getServerID = new FbCommand(queryGetServerID, connection);
            FbDataReader readerGetServerID = getServerID.ExecuteReader();

            if (readerGetServerID.Read())
            {
                string queryUpdateFineCollaudo = string.Format(@"
                    UPDATE collaudi 
                    SET finecollaudo = CURRENT_TIMESTAMP 
                    WHERE idserver = {0} 
                        AND stato = 'ATTIVO'", readerGetServerID.GetInt32(0));
                FbCommand updateFineCollaudo = new FbCommand(queryUpdateFineCollaudo, connection);
                updateFineCollaudo.ExecuteNonQuery();
            }
            readerGetServerID.Close();
        }

            private void ButtonUpdateStatus_Click(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            ToolTip toolTipDateLabel;
            ToolTip toolTipStatusImg;

            using (FbConnection connection = new FbConnection(reserverForm.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string queryStatusInfo = string.Format(@"
                        SELECT r.stato, s.codice, u.denominazione, u.avatar, sr.datainizio, r.statocollaudo, r.idserver
                        FROM statiservers r
                        JOIN servers s ON s.idserver = r.idserver
                        LEFT OUTER JOIN utenti u ON u.idutente = r.idutente
                        LEFT OUTER JOIN storicorilasci sr ON sr.idserver = r.idserver AND u.idutente = sr.idutente AND sr.datafine IS NULL");
                    FbCommand getStatusInfo = new FbCommand(queryStatusInfo, connection);
                    FbDataReader readerGetServerID = getStatusInfo.ExecuteReader();

                    metroLabel1.Text = string.Format(@"Ultimo aggiornamento dati {0}", DateTime.Now);
                    metroLabel1.Font = new Font(privateFontCollection.Families[0], 9, FontStyle.Regular);

                    while (readerGetServerID.Read())
                    {
                        Label currentLabel = this.Controls.Find("status" + readerGetServerID.GetString(1), true).FirstOrDefault() as Label;
                        Image statusImg;
                        if (readerGetServerID.GetInt32(5)>0)
                        {
                            statusImg = Image.FromFile(Directory.GetCurrentDirectory() + "\\img\\warning.png");
                        }
                        else if(readerGetServerID.GetString(0) == "OCCUPATO")
                        {
                            statusImg = Image.FromFile(Directory.GetCurrentDirectory() + "\\img\\busy.png");
                        }
                        else
                        {
                            statusImg = Image.FromFile(Directory.GetCurrentDirectory() + "\\img\\free.png");
                        }

                        statusImg = ResizeImage(statusImg, new Size(25, 25));
                        currentLabel.BackColor = Color.Transparent;
                        currentLabel.Image = statusImg;

                        Label currentDateLabel = this.Controls.Find("date" + readerGetServerID.GetString(1), true).FirstOrDefault() as Label;
                        Label currentIconLabel = this.Controls.Find("icon" + readerGetServerID.GetString(1), true).FirstOrDefault() as Label;

                        if (readerGetServerID.GetString(0) == "OCCUPATO")
                        {
                            // QUI PROBLEMA PER TOOLTIP 

                            currentDateLabel.Text = RelativeDate(Convert.ToDateTime(readerGetServerID.GetString(4)));
                            currentDateLabel.Font = new Font(privateFontCollection.Families[0], 11, FontStyle.Regular);
                            toolTipDateLabel = new ToolTip();
                            toolTipDateLabel.SetToolTip(currentDateLabel, readerGetServerID.GetString(4));

                            Image updatedStatusImg = Image.FromFile(Directory.GetCurrentDirectory() + readerGetServerID.GetString(3));
                            updatedStatusImg = ResizeImage(updatedStatusImg, new Size(50, 50));
                            currentIconLabel.Image = updatedStatusImg;
                            toolTipStatusImg = new ToolTip();
                            toolTipStatusImg.SetToolTip(currentIconLabel, readerGetServerID.GetString(2));
                        }
                        else if (readerGetServerID.GetInt32(5) > 0)
                        {
                            Button currentButton = this.Controls.Find(readerGetServerID.GetString(1), true).FirstOrDefault() as Button;
                            currentButton.Text = "Collaudo in corso";

                            string queryGetUserAcceptanceTest = string.Format(@"
                                SELECT c.idutente
                                FROM collaudi c 
                                WHERE c.stato = 'ATTIVO'
                                    AND c.idserver = {0}", readerGetServerID.GetInt32(6));
                            FbCommand getUserAcceptanceTest = new FbCommand(queryGetUserAcceptanceTest, connection);
                            int idUtenteCollaudo = (int)getUserAcceptanceTest.ExecuteScalar();

                            if (idUtenteCollaudo == reserverForm.CurrentUserID)
                            {
                                currentButton.Text = "Concludi collaudo";
                            }
                        }
                        else
                        {
                            Button currentButton = this.Controls.Find(readerGetServerID.GetString(1), true).FirstOrDefault() as Button;
                            currentButton.Text = "Rilascia";
                            currentDateLabel.Text = string.Empty;
                            currentIconLabel.Image = null;
                        }
                    }
                    readerGetServerID.Close();
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
