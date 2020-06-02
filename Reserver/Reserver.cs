using FirebirdSql.Data.FirebirdClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Reserver
{
    public partial class Reserver : Form
    {

        private Point lastPoint;
        private string connectionStringExternalDB = "User=SYSDBA;Password=chiavemaestra;Database=/var/lib/firebird/2.5/data/RESERVER.FDB;DataSource=51.83.76.255;Port=3050;";
        private bool logged = false;
        private int idutente = -1;

        public Reserver()
        {
            InitializeComponent();
            metroPanelPageLogin.Visible = true;
            metroPanelPageHistory.Visible = true;
            metroPanelPageReserve.Visible = true;
            metroPanelPageServerStatus.Visible = true;
            metroPanelPageLogin.BringToFront();
        }

        private void metroPanelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void metroPanelLogo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void metroButtonLogin_Click(object sender, EventArgs e)
        {
            using (FbConnection connection = new FbConnection(connectionStringExternalDB))
            {
                try
                {
                    connection.Open();
                    string query = string.Format("SELECT idutente, denominazione FROM utenti WHERE username = '{0}' and psw = '{1}'", metroTextBoxLoginUsername.Text, metroTextBoxLoginPassword.Text);
                    FbCommand select = new FbCommand(query, connection);
                    FbDataReader readerUtente = select.ExecuteReader();
                    if (readerUtente.Read())
                    {
                        idutente = readerUtente.GetInt32(0);
                        metroLabelCurrentUser.Text = readerUtente.GetString(1);
                        logged = true;
                        MessageBox.Show("Utente censito a sistema", "Stato connessione", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
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

        private void MetroPanelButtonServerStatus_Click(object sender, EventArgs e)
        {
            if (logged)
            {
                metroPanelPageServerStatus.BringToFront();
            }
            else
            {
                MessageBox.Show("Per visualizzare la pagina è necessario effettuare il login", "Necessario login", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                metroPanelPageLogin.BringToFront();
            }
        }


        private void MetroPanelButtonReserve_Click(object sender, EventArgs e)
        {
            if (logged)
            {
                metroPanelPageReserve.BringToFront();
            }
            else
            {
                MessageBox.Show("Per visualizzare la pagina è necessario effettuare il login", "Necessario login", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                metroPanelPageLogin.BringToFront();
            }
        }

        private void MetroPanelButtonHistory_Click(object sender, EventArgs e)
        {
            if (logged)
            {
                metroPanelPageHistory.BringToFront();
            }
            else
            {
                MessageBox.Show("Per visualizzare la pagina è necessario effettuare il login", "Necessario login", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                metroPanelPageLogin.BringToFront();
            }
        }
    }
}
