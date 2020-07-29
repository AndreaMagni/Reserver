﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        public string CurrentUserName
        {
            set { metroLabelCurrentUser.Text = value; }
            get { return metroLabelCurrentUser.Text; }
        }
        //public string CurrentAvatar
        //{
        //    set { avatarBox.ImageLocation = value; }
        //    get { return avatarBox.ImageLocation; }
        //}
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
        public bool PageLoginVisibility
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
        public bool PageAcceptanceTestsVisibility
        {
            set { pageAcceptanceTests.Visible = value; }
            get { return pageAcceptanceTests.Visible; }
        }
        #endregion Getter and Setter

        #region Side menu behavior
        private void SideMenuButton_Click(object sender, EventArgs e)
        {
            if(logged)
            {
                string buttonLabelName = ((Control)sender).Name;
                LoadPage(buttonLabelName);
                SetActivePage(buttonLabelName);
            }
            else
            {
                MessageBox.Show("Per visualizzare la pagina è necessario effettuare il login", "Necessario login", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                LoadPage("");
            }
        }

        private void SideMenuButton_MouseEnter(object sender, EventArgs e)
        {
            string labelName = ((Control)sender).Name;
            string pictureBoxName = labelName + "Image";
            MetroFramework.Controls.MetroLabel metroLabel = this.Controls.Find(labelName, true).FirstOrDefault() as MetroFramework.Controls.MetroLabel;
            metroLabel.BackColor = Color.FromArgb(39, 39, 58);
            PictureBox pictureBox = this.Controls.Find(pictureBoxName, true).FirstOrDefault() as PictureBox;
            pictureBox.BackColor = Color.FromArgb(39, 39, 58);
            //string activeName = labelName + "Active";
            //MetroFramework.Controls.MetroLabel metroLabelActive = this.Controls.Find(activeName, true).FirstOrDefault() as MetroFramework.Controls.MetroLabel;
            //metroLabelActive.BackColor = Color.FromArgb(39, 39, 58);
        }

        private void SideMenuButton_MouseLeave(object sender, EventArgs e)
        {
            string labelName = ((Control)sender).Name;
            string pictureBoxName = labelName + "Image";
            MetroFramework.Controls.MetroLabel metroLabel = this.Controls.Find(labelName, true).FirstOrDefault() as MetroFramework.Controls.MetroLabel;
            metroLabel.BackColor = Color.FromArgb(51, 51, 76); 
            PictureBox pictureBox = this.Controls.Find(pictureBoxName, true).FirstOrDefault() as PictureBox;
            pictureBox.BackColor = Color.FromArgb(51, 51, 76);
            //string activeName = labelName + "Active";
            //MetroFramework.Controls.MetroLabel metroLabelActive = this.Controls.Find(activeName, true).FirstOrDefault() as MetroFramework.Controls.MetroLabel;
            //metroLabelActive.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void LoadPage(string buttonName)
        {
            switch (buttonName)
            {
                case "buttonServerStatus":
                    SetPageVisibility(false, true, false, false, false);
                    break;

                case "buttonReserve":
                    SetPageVisibility(false, false, true, false, false);
                    break;

                case "buttonHistory":
                    SetPageVisibility(false, false, false, true, false);
                    break;

                case "buttonAcceptanceTests":
                    SetPageVisibility(false, false, false, false, true);
                    break;

                default:
                    SetPageVisibility(true, false, false, false, false);
                    break;
            }
        }

        private void SetActivePage(string buttonName)
        {
            MetroFramework.Controls.MetroLabel metroLabelServerStatus = this.Controls.Find("buttonServerStatusActive", true).FirstOrDefault() as MetroFramework.Controls.MetroLabel;
            metroLabelServerStatus.BackColor = Color.FromArgb(51, 51, 76);
            MetroFramework.Controls.MetroLabel metroLabelHistory = this.Controls.Find("buttonHistoryActive", true).FirstOrDefault() as MetroFramework.Controls.MetroLabel;
            metroLabelHistory.BackColor = Color.FromArgb(51, 51, 76);
            MetroFramework.Controls.MetroLabel metroLabelAcceptanceTests = this.Controls.Find("buttonAcceptanceTestsActive", true).FirstOrDefault() as MetroFramework.Controls.MetroLabel;
            metroLabelAcceptanceTests.BackColor = Color.FromArgb(51, 51, 76);

            string labelName = buttonName + "Active";
            MetroFramework.Controls.MetroLabel metroLabel = this.Controls.Find(labelName, true).FirstOrDefault() as MetroFramework.Controls.MetroLabel;
            metroLabel.BackColor = Color.FromArgb(39, 39, 58);
        }

        private void SetPageVisibility(bool login, bool serverStatus, bool slotReservation, bool releaseHistory, bool acceptanceTests)
        {
            PageLoginVisibility = login;
            PageServerStatusVisibility = serverStatus;
            PageSlotReservationsVisibility = slotReservation;
            PageReleaseHistoryVisibility = releaseHistory;
            PageAcceptanceTestsVisibility = acceptanceTests;
        }
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

        #region Generic Methods
        //public void SetToolTip(string username)
        //{
        //    ToolTip toolTip = new ToolTip();
        //    toolTip.SetToolTip(this.avatarBox, username);
        //}

        private void closeProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeProgram_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion Generic Methods

        private void buttonServerStatusActive_Click(object sender, EventArgs e)
        {

        }
    }
}
