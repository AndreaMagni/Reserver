using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Reserver
{
    public partial class Reserver : Form
    {
        private Point lastPoint;
        public string connectionStringExternalDB = "User=SYSDBA;Password=chiavemaestra;Database=/var/lib/firebird/2.5/data/RESERVER.FDB;DataSource=51.83.76.255;Port=3050;";
        public bool logged = false;
        public int idutente = -1;

        public Reserver()
        {
            InitializeComponent();
            SetPageVisibility(true, false, false, false, false);
            this.pageLogin.ParentForm = this;
            this.pageReleaseHistory.ParentForm = this;
            this.pageServerStatus.ParentForm = this;
            this.pageSlotReservations.ParentForm = this;
            this.pageAcceptanceTests.ParentForm = this;
        }

        #region Getter and Setter
        public string CurrentUser
        {
            set { metroLabelCurrentUser.Text = value; }
            get { return metroLabelCurrentUser.Text; }
        }
        public int IDUtente
        {
            set { idutente = value; }
            get { return idutente; }
        }
        public bool Logged
        {
            set { logged = value; }
            get { return logged; }
        }
        public string ConnectionStringExternalDB
        {
            get { return connectionStringExternalDB; }
        }
        public bool PageLogin
        {
            set { pageLogin.Visible = value; }
            get { return pageLogin.Visible; }
        }
        public bool PageSlotReservationsVisibility
        {
            set { pageSlotReservations.Visible = value; }
            get { return pageSlotReservations.Visible; }
        }
        public bool PageServerStatusVisibility
        {
            set { pageServerStatus.Visible = value; }
            get { return pageServerStatus.Visible; }
        }
        public bool PageReleaseHistoryVisibility
        {
            set { pageReleaseHistory.Visible = value; }
            get { return pageReleaseHistory.Visible; }
        }
        public bool PageAcceptanceTests
        {
            set { pageAcceptanceTests.Visible = value; }
            get { return pageAcceptanceTests.Visible; }
        }
        #endregion Getter and Setter

        #region Side menu behavior
        private void MetroLabelButtonServerStatus_Click(object sender, EventArgs e)
        {
            if (logged)
            {
                SetPageVisibility(false, true, false, false, false);
            }
            else
            {
                MessageBox.Show("Per visualizzare la pagina è necessario effettuare il login", "Necessario login", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                SetPageVisibility(true, false, false, false, false);
            }
        }

        private void MetroLabelButtonReserve_Click(object sender, EventArgs e)
        {
            if (logged)
            {
                SetPageVisibility(false, false, true, false, false);
            }
            else
            {
                MessageBox.Show("Per visualizzare la pagina è necessario effettuare il login", "Necessario login", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                SetPageVisibility(true, false, false, false, false);
            }
        }

        private void MetroLabelButtonHistory_Click(object sender, EventArgs e)
        {
            if (logged)
            {
                SetPageVisibility(false, false, false, true, false);
            }
            else
            {
                MessageBox.Show("Per visualizzare la pagina è necessario effettuare il login", "Necessario login", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                SetPageVisibility(true, false, false, false, false);
            }
        }

        private void metroLabelAcceptanceTests_Click(object sender, EventArgs e)
        {
            if (logged)
            {
                SetPageVisibility(false, false, false, false, true);
            }
            else
            {
                MessageBox.Show("Per visualizzare la pagina è necessario effettuare il login", "Necessario login", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                SetPageVisibility(true, false, false, false, false);
            }
        }

        // TEST SEMBRA OK
        private void metroLabelTest_MouseEnter(object sender, EventArgs e)
        {
            string labelName = ((Control)sender).Name;
            MetroFramework.Controls.MetroLabel metroLabel = this.Controls.Find(labelName, true).FirstOrDefault() as MetroFramework.Controls.MetroLabel;
            metroLabel.BackColor = Color.FromArgb(39, 39, 58);
        }

        private void metroLabelTest_MouseLeave(object sender, EventArgs e)
        {
            string labelName = ((Control)sender).Name;
            MetroFramework.Controls.MetroLabel metroLabel = this.Controls.Find(labelName, true).FirstOrDefault() as MetroFramework.Controls.MetroLabel;
            metroLabel.BackColor = Color.FromArgb(51, 51, 76);
        }
        // TEST SEMBRA OK

            /*
        private void metroLabelButtonServerStatus_MouseEnter(object sender, EventArgs e)
        {
            metroLabelButtonServerStatus.BackColor = Color.FromArgb(39, 39, 58);
        }

        private void metroLabelButtonServerStatus_MouseLeave(object sender, EventArgs e)
        {
            metroLabelButtonServerStatus.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void metroLabelButtonReserve_MouseEnter(object sender, EventArgs e)
        {
            metroLabelButtonReserve.BackColor = Color.FromArgb(39, 39, 58);
        }

        private void metroLabelButtonReserve_MouseLeave(object sender, EventArgs e)
        {
            metroLabelButtonReserve.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void metroLabelButtonHistory_MouseEnter(object sender, EventArgs e)
        {
            metroLabelButtonHistory.BackColor = Color.FromArgb(39, 39, 58);
        }

        private void metroLabelButtonHistory_MouseLeave(object sender, EventArgs e)
        {
            metroLabelButtonHistory.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void metroLabelAcceptanceTests_MouseEnter(object sender, EventArgs e)
        {
            metroLabelAcceptanceTests.BackColor = Color.FromArgb(39, 39, 58);
        }

        private void metroLabelAcceptanceTests_MouseLeave(object sender, EventArgs e)
        {
            metroLabelAcceptanceTests.BackColor = Color.FromArgb(51, 51, 76);
        }
        */
        #endregion  Side menu behavior

        #region Form movement
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
        #endregion Form movement
        
        private void SetPageVisibility(bool login, bool serverStatus, bool slotReservation, bool releaseHistory, bool acceptanceTests)
        {
            PageLogin = login;
            PageServerStatusVisibility = serverStatus;
            PageSlotReservationsVisibility = slotReservation;
            PageReleaseHistoryVisibility = releaseHistory;
            PageAcceptanceTests = acceptanceTests;
        }

    }
}
