using FirebirdSql.Data.FirebirdClient;
using System;
using System.Drawing;
using System.Linq;
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
            metroTextBoxLoginFormPassword.PasswordChar = '*';
        }
                     
        private void BtnLoginForm_Click(object sender, EventArgs e)
        {
            using (FbConnection connection = new FbConnection(reserverForm.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string queryUserInfo = string.Format(@"
                        SELECT idutente, denominazione, avatar 
                        FROM utenti 
                        WHERE username = '{0}' 
                            AND psw = '{1}'", metroTextBoxLoginFormUsername.Text, metroTextBoxLoginFormPassword.Text);
                    FbCommand getUserInfo = new FbCommand(queryUserInfo, connection);
                    FbDataReader readerUserInfo = getUserInfo.ExecuteReader();
                    if (readerUserInfo.Read())
                    {
                        reserverForm.IsLogged = true;
                        reserverForm.CurrentUserID = readerUserInfo.GetInt32(0);
                        reserverForm.CurrentUserName = readerUserInfo.GetString(1);
                        reserverForm.externalReserver = reserverForm;
                        reserverForm.SideMenuButton_SetActivePage("btnSideMenuServerStatus");
                        reserverForm.LoadPageAfterLogin(sender, reserverForm);
                    }
                    else
                    {
                        MessageBox.Show("Utente non censito a sistema", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        metroTextBoxLoginFormUsername.Text = null;
                        metroTextBoxLoginFormPassword.Text = null;
                        Logger.Log("Tenativo di accesso fallito. Credenziali non censite a sistema.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Richiesta fallita.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    Logger.LogStack("Errore durante la fase di login.", ex.StackTrace.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void btnLoginForm_MouseEnter(object sender, EventArgs e)
        {
            string buttonName = ((Control)sender).Name; 
            MetroFramework.Controls.MetroButton metroButton = this.Controls.Find(buttonName, true).FirstOrDefault() as MetroFramework.Controls.MetroButton;
            metroButton.BackColor = Color.FromArgb(142, 198, 189);
        }

        private void btnLoginForm_MouseLeave(object sender, EventArgs e)
        {
            string buttonName = ((Control)sender).Name;
            MetroFramework.Controls.MetroButton metroButton = this.Controls.Find(buttonName, true).FirstOrDefault() as MetroFramework.Controls.MetroButton;
            metroButton.BackColor = Color.FromArgb(142, 198, 189);
        }

    }
}
