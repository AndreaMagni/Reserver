using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace Reserver
{
    public partial class Login : UserControl
    {
        new public Reserver ParentForm { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void metroButtonLogin_Click_1(object sender, EventArgs e)
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
                    string queryUserInfo = string.Format("SELECT idutente, denominazione FROM utenti WHERE username = '{0}' and psw = '{1}'", metroTextBoxLoginUsername.Text, metroTextBoxLoginPassword.Text);
                    FbCommand getUserInfo = new FbCommand(queryUserInfo, connection);
                    FbDataReader readerUserInfo = getUserInfo.ExecuteReader();
                    if (readerUserInfo.Read())
                    {
                        ParentForm.IsLogged = true;
                        ParentForm.CurrentUserID = readerUserInfo.GetInt32(0);
                        ParentForm.CurrentUserName = readerUserInfo.GetString(1);
                        ParentForm.PageLoginVisibility = false;
                        ParentForm.pageServerStatus.FirstTimeLoad();
                        ParentForm.PageServerStatusVisibility = true;
                    }
                    else
                    {
                        MessageBox.Show("Utente non censito a sistema", "Stato connessione", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
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
