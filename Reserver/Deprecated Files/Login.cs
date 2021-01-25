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

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (ParentForm == null)
            {
                MessageBox.Show("Errore parent form", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            using (FbConnection connection = new FbConnection(""))
            {
                try
                {
                    connection.Open();
                    string queryUserInfo = string.Format("SELECT idutente, denominazione, avatar FROM utenti WHERE username = '{0}' and psw = '{1}'", metroTextBoxLoginUsername.Text, metroTextBoxLoginPassword.Text);
                    FbCommand getUserInfo = new FbCommand(queryUserInfo, connection);
                    FbDataReader readerUserInfo = getUserInfo.ExecuteReader();
                    if (readerUserInfo.Read())
                    {
                        ParentForm.SideMenuButton_SetActivePage("buttonServerStatus");
                    }
                    else
                    {
                        MessageBox.Show("Utente non censito a sistema", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
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
    }
}
