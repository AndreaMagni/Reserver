using FirebirdSql.Data.FirebirdClient;
using System;
using System.Windows.Forms;

namespace Reserver.Forms
{
    public partial class LoginForm : Form
    {
        Reserver reserverForm;

        public LoginForm()
        {
            InitializeComponent();
        }

        public LoginForm(Reserver form)
        {
            InitializeComponent();
            reserverForm = form;
        }

        private void BtnLoginForm_Click(object sender, EventArgs e)
        {
            if (ParentForm == null)
            {
                MessageBox.Show("Errore parent form", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            using (FbConnection connection = new FbConnection(reserverForm.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string queryUserInfo = string.Format("SELECT idutente, denominazione, avatar FROM utenti WHERE username = '{0}' and psw = '{1}'", metroTextBoxLoginFormUsername.Text, metroTextBoxLoginFormPassword.Text);
                    FbCommand getUserInfo = new FbCommand(queryUserInfo, connection);
                    FbDataReader readerUserInfo = getUserInfo.ExecuteReader();
                    if (readerUserInfo.Read())
                    {
                        reserverForm.IsLogged = true;
                        reserverForm.CurrentUserID = readerUserInfo.GetInt32(0);
                        reserverForm.CurrentUserName = readerUserInfo.GetString(1);
                        reserverForm.SideMenuButton_SetActivePage("btnSideMenuServerStatus");
                        reserverForm.LoadPage(sender, "btnSideMenuServerStatus");
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
