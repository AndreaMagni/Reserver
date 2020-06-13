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
            //Reserver myParent = (Reserver)this.ParentForm;
        }

        private void metroButtonLogin_Click_1(object sender, EventArgs e)
        {
            if (ParentForm == null)
            {
                MessageBox.Show("Errore parent form", "Errore parent form", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }

            using (FbConnection connection = new FbConnection(ParentForm.ConnectionStringExternalDB))
            {
                try
                {
                    connection.Open();
                    string getUserInfo = string.Format("SELECT idutente, denominazione FROM utenti WHERE username = '{0}' and psw = '{1}'", metroTextBoxLoginUsername.Text, metroTextBoxLoginPassword.Text);
                    FbCommand select = new FbCommand(getUserInfo, connection);
                    FbDataReader readerUserInfo = select.ExecuteReader();
                    if (readerUserInfo.Read())
                    {
                        ParentForm.IDUtente = readerUserInfo.GetInt32(0);
                        ParentForm.CurrentUser = readerUserInfo.GetString(1);
                        ParentForm.PageLogin = false;
                        ParentForm.PageServerStatusVisibility = true;
                        ParentForm.Logged = true;
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
