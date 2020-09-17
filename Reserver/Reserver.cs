﻿using FirebirdSql.Data.FirebirdClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Reserver
{
    public partial class Reserver : Form
    {
        // Variable
        public string connectionStringExternalDB = "User=SYSDBA;Password=chiavemaestra;Database=/var/lib/firebird/2.5/data/RESERVER.FDB;DataSource=51.83.76.255;Port=3050;Connection Lifetime=10";
        public bool logged = false;
        public int idutente = -1;
        public object emptySender = new object();

        // Field
        private Form activeForm;
        Forms.ServerStatusForm serverStatusForm;
        Forms.ReleaseHistoryForm releaseHistoryForm;
        Forms.AcceptanceTestsForm acceptanceTestsForm;
        Forms.LoginForm loginForm;

        Reserver reserver;

        // Constructor
        public Reserver()
        {
            InitializeComponent();
            reserver = this;
            loginForm = new Forms.LoginForm(reserver);
            OpenChildForm(loginForm, emptySender);
        }

        #region Getter and Setter

        //public string CurrentAvatar
        //{
        //    set { avatarBox.ImageLocation = value; }
        //    get { return avatarBox.ImageLocation; }
        //}

        public Reserver externalReserver
        {
            set { reserver = value; }
            get { return reserver; }
        }

        public string CurrentUserName
        {
            set { labelCurrentUser.Text = value; }
            get { return labelCurrentUser.Text; }
        }

        public int CurrentUserID
        {
            set { idutente = value; }
            get { return idutente; }
        }


        public bool IsLogged
        {
            set { logged = value; }
            get { return logged; }
        }

        public string ConnectionString
        {
            get { return connectionStringExternalDB; }
        }

        #endregion Getter and Setter

        #region Form Movement

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BntMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion Form Movement

        #region Generic Methods

        private void OpenChildForm(Form childForm, object btnSender)
        {
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelPage.Controls.Add(childForm);
            this.panelPage.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void LoadPageAfterLogin(object sender, Reserver reserver)
        {
            serverStatusForm = new Forms.ServerStatusForm(reserver);
            releaseHistoryForm = new Forms.ReleaseHistoryForm(reserver);
            acceptanceTestsForm = new Forms.AcceptanceTestsForm(reserver);
            OpenChildForm(serverStatusForm, sender);
        }

        public void LoadPage(object sender, string buttonName)
        {
            switch (buttonName)
            {
                case "btnSideMenuServerStatus":
                    OpenChildForm(serverStatusForm, sender);
                    break;

                case "btnSideMenuReleaseHistory":
                    releaseHistoryForm.ReleaseHistoryGrid_Load();
                    OpenChildForm(releaseHistoryForm, sender);
                    break;

                case "btnSideMenuAcceptanceTests":
                    OpenChildForm(acceptanceTestsForm, sender);
                    break;

                default:
                    OpenChildForm(loginForm, sender);
                    break;
            }
        }

        #endregion Generic Methods

        #region Side Menu Behavior

        private void SideMenuButton_Click(object sender, EventArgs e)
        {
            if (logged)
            {
                string buttonName = ((Control)sender).Name;
                LoadPage(sender, buttonName);
                SideMenuButton_SetActivePage(buttonName);
            }
            else
            {
                MessageBox.Show("Per visualizzare la pagina è necessario effettuare il login", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        public void SideMenuButton_SetActivePage(string buttonName)
        {
            MetroFramework.Controls.MetroPanel metroPanelServerStatus = this.Controls.Find("panelSideMenuServerStatus", true).FirstOrDefault() as MetroFramework.Controls.MetroPanel;
            metroPanelServerStatus.BackColor = Color.FromArgb(124, 206, 206);
            MetroFramework.Controls.MetroPanel metroPanelHistory = this.Controls.Find("panelSideMenuReleaseHistory", true).FirstOrDefault() as MetroFramework.Controls.MetroPanel;
            metroPanelHistory.BackColor = Color.FromArgb(124, 206, 206);
            MetroFramework.Controls.MetroPanel metroPanelAcceptanceTests = this.Controls.Find("panelSideMenuAcceptanceTests", true).FirstOrDefault() as MetroFramework.Controls.MetroPanel;
            metroPanelAcceptanceTests.BackColor = Color.FromArgb(124, 206, 206);

            string panelName = "panel" + buttonName.Substring(3);
            MetroFramework.Controls.MetroPanel metroPanel = this.Controls.Find(panelName, true).FirstOrDefault() as MetroFramework.Controls.MetroPanel;
            metroPanel.BackColor = Color.FromArgb(93, 196, 196);
        }

        #endregion Side Menu Behavior

    }
}

// Vecchi colori scuro Color.FromArgb(39, 39, 58);  // test 32, 90, 255  // test2 6, 46, 96
// Vecchi colori chiaro Color.FromArgb(51, 51, 76); // test 17, 128, 255 // test2 7, 67, 125

//public void SetToolTip(string username)
//{
//    ToolTip toolTip = new ToolTip();
//    toolTip.SetToolTip(this.avatarBox, username);
//}

// Temporaneamente disabilitato in quanto creava gravi problemi prestazionali

/*

private void OpenChildForm(Form childForm, object btnSender)
{
    if (activeForm != null)
    {
        activeForm.Close();
    }
    activeForm = childForm;
    childForm.TopLevel = false;
    childForm.FormBorderStyle = FormBorderStyle.None;
    childForm.Dock = DockStyle.Fill;
    this.panelPage.Controls.Add(childForm);
    this.panelPage.Tag = childForm;
    childForm.BringToFront();
    childForm.Show();
}

public void LoadPage(object sender, string buttonName)
{
    switch (buttonName)
    {
        case "btnSideMenuServerStatus":
            OpenChildFormServerStatus(server, sender);
            break;

        case "btnSideMenuReleaseHistory":
            OpenChildForm(new Forms.ReleaseHistoryForm(this), sender);
            break;

        case "btnSideMenuAcceptanceTests":
            OpenChildForm(new Forms.AcceptanceTestsForm(this), sender);
            break;

        default:
            OpenChildForm(new Forms.LoginForm(this), sender);
            break;
    }
}
*/
