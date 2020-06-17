using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Reserver
{
    public partial class ServerStatus : UserControl
    {
        new public Reserver ParentForm { get; set; }

        Dictionary<string, string> server = new Dictionary<string, string>();
        
        public ServerStatus()
        {
            InitializeComponent();
            metroPanel1.BackColor = Color.Green;
            metroPanel2.BackColor = Color.Green;
            metroPanel3.BackColor = Color.Red;
            server.Add("metroButton1", "Omnitest ASP");
            server.Add("metroButton2", "Omnitest Bologna");
            server.Add("metroButton3", "Omnitest Milano");
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (ParentForm == null)
            {
                MessageBox.Show("Errore parent form", "Errore parent form", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }

            using (FbConnection connection = new FbConnection(ParentForm.ConnectionString))
            {
                try
                {
                    int serverId;
                    string serverStatus;
                    connection.Open();
                    string queryServerInfo = string.Format(@"SELECT s.idserver, ss.stato
                                                             FROM servers s
                                                             JOIN statiservers ss ON ss.idserver = s.idserver
                                                             WHERE s.descrizione = '{0}'", server["metroButton1"]);
                    FbCommand getServerInfo = new FbCommand(queryServerInfo, connection);
                    FbDataReader readerServerInfo = getServerInfo.ExecuteReader();
                    serverId = readerServerInfo.GetInt32(0);
                    /* Non dovrebbe essere necessario fare tutto questo, andrà sempre a buon fine
                        if (readerServerInfo.Read())
                        {
                            serverID = readerServerInfo.GetInt32(0); 
                            MessageBox.Show(serverID.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        }
                        else
                        {
                            MessageBox.Show("Utente non censito a sistema", "Stato connessione", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        }
                    */
                    serverStatus = readerServerInfo.GetString(1);

                    if (serverStatus == "OCCUPATO")
                    {
                        MessageBox.Show("Rilascio in corso, aspettare o effettuare una prenotazione", "Rilascio", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    }
                    else
                    {

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
    }
}
