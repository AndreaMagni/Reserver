using System.Drawing;

namespace Reserver
{
    partial class Reserver
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reserver));
            this.metroPanelSideMenu = new MetroFramework.Controls.MetroPanel();
            this.buttonAcceptanceTestsActive = new MetroFramework.Controls.MetroLabel();
            this.buttonHistoryActive = new MetroFramework.Controls.MetroLabel();
            this.buttonServerStatusActive = new MetroFramework.Controls.MetroLabel();
            this.buttonAcceptanceTests = new MetroFramework.Controls.MetroLabel();
            this.buttonAcceptanceTestsImage = new System.Windows.Forms.PictureBox();
            this.buttonHistory = new MetroFramework.Controls.MetroLabel();
            this.buttonHistoryImage = new System.Windows.Forms.PictureBox();
            this.buttonServerStatus = new MetroFramework.Controls.MetroLabel();
            this.buttonServerStatusImage = new System.Windows.Forms.PictureBox();
            this.metroPanelLogo = new MetroFramework.Controls.MetroPanel();
            this.minimizeProgram = new System.Windows.Forms.Label();
            this.closeProgram = new System.Windows.Forms.Label();
            this.metroLabelCurrentUser = new MetroFramework.Controls.MetroLabel();
            this.pageLogin = new Login();
            this.pageReleaseHistory = new ReleaseHistory();
            this.pageSlotReservations = new SlotReservation();
            this.pageAcceptanceTests = new AcceptanceTests();
            this.pageServerStatus = new ServerStatus();
            this.metroPanelSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAcceptanceTestsImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHistoryImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonServerStatusImage)).BeginInit();
            this.metroPanelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanelSideMenu
            // 
            this.metroPanelSideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroPanelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.metroPanelSideMenu.Controls.Add(this.buttonAcceptanceTestsActive);
            this.metroPanelSideMenu.Controls.Add(this.buttonHistoryActive);
            this.metroPanelSideMenu.Controls.Add(this.buttonServerStatusActive);
            this.metroPanelSideMenu.Controls.Add(this.buttonAcceptanceTests);
            this.metroPanelSideMenu.Controls.Add(this.buttonAcceptanceTestsImage);
            this.metroPanelSideMenu.Controls.Add(this.buttonHistory);
            this.metroPanelSideMenu.Controls.Add(this.buttonHistoryImage);
            this.metroPanelSideMenu.Controls.Add(this.buttonServerStatus);
            this.metroPanelSideMenu.Controls.Add(this.buttonServerStatusImage);
            this.metroPanelSideMenu.HorizontalScrollbarBarColor = true;
            this.metroPanelSideMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelSideMenu.HorizontalScrollbarSize = 10;
            this.metroPanelSideMenu.Location = new System.Drawing.Point(0, 80);
            this.metroPanelSideMenu.Name = "metroPanelSideMenu";
            this.metroPanelSideMenu.Size = new System.Drawing.Size(200, 420);
            this.metroPanelSideMenu.TabIndex = 0;
            this.metroPanelSideMenu.UseCustomBackColor = true;
            this.metroPanelSideMenu.VerticalScrollbarBarColor = true;
            this.metroPanelSideMenu.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelSideMenu.VerticalScrollbarSize = 10;
            // 
            // buttonAcceptanceTestsActive
            // 
            this.buttonAcceptanceTestsActive.Location = new System.Drawing.Point(190, 280);
            this.buttonAcceptanceTestsActive.Name = "buttonAcceptanceTestsActive";
            this.buttonAcceptanceTestsActive.Size = new System.Drawing.Size(10, 140);
            this.buttonAcceptanceTestsActive.TabIndex = 16;
            this.buttonAcceptanceTestsActive.UseCustomBackColor = true;
            // 
            // buttonHistoryActive
            // 
            this.buttonHistoryActive.Location = new System.Drawing.Point(190, 140);
            this.buttonHistoryActive.Name = "buttonHistoryActive";
            this.buttonHistoryActive.Size = new System.Drawing.Size(10, 140);
            this.buttonHistoryActive.TabIndex = 15;
            this.buttonHistoryActive.UseCustomBackColor = true;
            // 
            // buttonServerStatusActive
            // 
            this.buttonServerStatusActive.Location = new System.Drawing.Point(190, 0);
            this.buttonServerStatusActive.Name = "buttonServerStatusActive";
            this.buttonServerStatusActive.Size = new System.Drawing.Size(10, 140);
            this.buttonServerStatusActive.TabIndex = 14;
            this.buttonServerStatusActive.UseCustomBackColor = true;
            this.buttonServerStatusActive.Click += new System.EventHandler(this.buttonServerStatusActive_Click);
            // 
            // buttonAcceptanceTests
            // 
            this.buttonAcceptanceTests.FontSize = MetroFramework.MetroLabelSize.Small;
            this.buttonAcceptanceTests.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.buttonAcceptanceTests.Location = new System.Drawing.Point(60, 280);
            this.buttonAcceptanceTests.Name = "buttonAcceptanceTests";
            this.buttonAcceptanceTests.Size = new System.Drawing.Size(130, 140);
            this.buttonAcceptanceTests.TabIndex = 13;
            this.buttonAcceptanceTests.Text = "COLLAUDI";
            this.buttonAcceptanceTests.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAcceptanceTests.UseCustomBackColor = true;
            this.buttonAcceptanceTests.Click += new System.EventHandler(this.SideMenuButton_Click);
            this.buttonAcceptanceTests.MouseEnter += new System.EventHandler(this.SideMenuButton_MouseEnter);
            this.buttonAcceptanceTests.MouseLeave += new System.EventHandler(this.SideMenuButton_MouseLeave);
            // 
            // buttonAcceptanceTestsImage
            // 
            this.buttonAcceptanceTestsImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAcceptanceTestsImage.BackgroundImage")));
            this.buttonAcceptanceTestsImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAcceptanceTestsImage.Location = new System.Drawing.Point(0, 280);
            this.buttonAcceptanceTestsImage.Name = "buttonAcceptanceTestsImage";
            this.buttonAcceptanceTestsImage.Size = new System.Drawing.Size(60, 140);
            this.buttonAcceptanceTestsImage.TabIndex = 12;
            this.buttonAcceptanceTestsImage.TabStop = false;
            // 
            // buttonHistory
            // 
            this.buttonHistory.FontSize = MetroFramework.MetroLabelSize.Small;
            this.buttonHistory.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.buttonHistory.Location = new System.Drawing.Point(60, 140);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(130, 140);
            this.buttonHistory.TabIndex = 11;
            this.buttonHistory.Text = "STORICO RILASCI";
            this.buttonHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHistory.UseCustomBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.SideMenuButton_Click);
            this.buttonHistory.MouseEnter += new System.EventHandler(this.SideMenuButton_MouseEnter);
            this.buttonHistory.MouseLeave += new System.EventHandler(this.SideMenuButton_MouseLeave);
            // 
            // buttonHistoryImage
            // 
            this.buttonHistoryImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHistoryImage.BackgroundImage")));
            this.buttonHistoryImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonHistoryImage.Location = new System.Drawing.Point(0, 140);
            this.buttonHistoryImage.Name = "buttonHistoryImage";
            this.buttonHistoryImage.Size = new System.Drawing.Size(60, 140);
            this.buttonHistoryImage.TabIndex = 10;
            this.buttonHistoryImage.TabStop = false;
            // 
            // buttonServerStatus
            // 
            this.buttonServerStatus.FontSize = MetroFramework.MetroLabelSize.Small;
            this.buttonServerStatus.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.buttonServerStatus.Location = new System.Drawing.Point(60, 0);
            this.buttonServerStatus.Name = "buttonServerStatus";
            this.buttonServerStatus.Size = new System.Drawing.Size(130, 140);
            this.buttonServerStatus.TabIndex = 9;
            this.buttonServerStatus.Text = "STATO SERVER";
            this.buttonServerStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonServerStatus.UseCustomBackColor = true;
            this.buttonServerStatus.Click += new System.EventHandler(this.SideMenuButton_Click);
            this.buttonServerStatus.MouseEnter += new System.EventHandler(this.SideMenuButton_MouseEnter);
            this.buttonServerStatus.MouseLeave += new System.EventHandler(this.SideMenuButton_MouseLeave);
            // 
            // buttonServerStatusImage
            // 
            this.buttonServerStatusImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonServerStatusImage.BackgroundImage")));
            this.buttonServerStatusImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonServerStatusImage.Location = new System.Drawing.Point(0, 0);
            this.buttonServerStatusImage.Name = "buttonServerStatusImage";
            this.buttonServerStatusImage.Size = new System.Drawing.Size(60, 140);
            this.buttonServerStatusImage.TabIndex = 8;
            this.buttonServerStatusImage.TabStop = false;
            // 
            // metroPanelLogo
            // 
            this.metroPanelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.metroPanelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanelLogo.BackgroundImage")));
            this.metroPanelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroPanelLogo.Controls.Add(this.minimizeProgram);
            this.metroPanelLogo.Controls.Add(this.closeProgram);
            this.metroPanelLogo.Controls.Add(this.metroLabelCurrentUser);
            this.metroPanelLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroPanelLogo.HorizontalScrollbarBarColor = true;
            this.metroPanelLogo.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelLogo.HorizontalScrollbarSize = 10;
            this.metroPanelLogo.Location = new System.Drawing.Point(0, 0);
            this.metroPanelLogo.Name = "metroPanelLogo";
            this.metroPanelLogo.Size = new System.Drawing.Size(900, 80);
            this.metroPanelLogo.TabIndex = 2;
            this.metroPanelLogo.UseCustomBackColor = true;
            this.metroPanelLogo.VerticalScrollbarBarColor = true;
            this.metroPanelLogo.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelLogo.VerticalScrollbarSize = 10;
            this.metroPanelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.metroPanelLogo_MouseDown);
            this.metroPanelLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.metroPanelLogo_MouseMove);
            // 
            // minimizeProgram
            // 
            this.minimizeProgram.AutoSize = true;
            this.minimizeProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeProgram.Location = new System.Drawing.Point(854, 9);
            this.minimizeProgram.Name = "minimizeProgram";
            this.minimizeProgram.Size = new System.Drawing.Size(15, 15);
            this.minimizeProgram.TabIndex = 8;
            this.minimizeProgram.Text = "_";
            this.minimizeProgram.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.minimizeProgram.Click += new System.EventHandler(this.minimizeProgram_Click);
            // 
            // closeProgram
            // 
            this.closeProgram.AutoSize = true;
            this.closeProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeProgram.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closeProgram.Location = new System.Drawing.Point(875, 9);
            this.closeProgram.Name = "closeProgram";
            this.closeProgram.Size = new System.Drawing.Size(16, 15);
            this.closeProgram.TabIndex = 7;
            this.closeProgram.Text = "X";
            this.closeProgram.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closeProgram.Click += new System.EventHandler(this.closeProgram_Click);
            // 
            // metroLabelCurrentUser
            // 
            this.metroLabelCurrentUser.BackColor = System.Drawing.Color.Transparent;
            this.metroLabelCurrentUser.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabelCurrentUser.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelCurrentUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabelCurrentUser.Location = new System.Drawing.Point(640, 49);
            this.metroLabelCurrentUser.MaximumSize = new System.Drawing.Size(250, 20);
            this.metroLabelCurrentUser.Name = "metroLabelCurrentUser";
            this.metroLabelCurrentUser.Size = new System.Drawing.Size(250, 20);
            this.metroLabelCurrentUser.TabIndex = 5;
            this.metroLabelCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabelCurrentUser.UseCustomBackColor = true;
            this.metroLabelCurrentUser.UseCustomForeColor = true;
            // 
            // pageLogin
            // 
            this.pageLogin.BackColor = System.Drawing.Color.SlateGray;
            this.pageLogin.Location = new System.Drawing.Point(210, 90);
            this.pageLogin.Name = "pageLogin";
            this.pageLogin.ParentForm = null;
            this.pageLogin.Size = new System.Drawing.Size(680, 400);
            this.pageLogin.TabIndex = 6;
            // 
            // pageReleaseHistory
            // 
            this.pageReleaseHistory.BackColor = System.Drawing.Color.SlateGray;
            this.pageReleaseHistory.Location = new System.Drawing.Point(210, 90);
            this.pageReleaseHistory.Name = "pageReleaseHistory";
            this.pageReleaseHistory.ParentForm = null;
            this.pageReleaseHistory.Size = new System.Drawing.Size(680, 400);
            this.pageReleaseHistory.TabIndex = 5;
            // 
            // pageSlotReservations
            // 
            this.pageSlotReservations.BackColor = System.Drawing.Color.SlateGray;
            this.pageSlotReservations.Location = new System.Drawing.Point(210, 90);
            this.pageSlotReservations.Name = "pageSlotReservations";
            this.pageSlotReservations.ParentForm = null;
            this.pageSlotReservations.Size = new System.Drawing.Size(680, 400);
            this.pageSlotReservations.TabIndex = 5;
            // 
            // pageAcceptanceTests
            // 
            this.pageAcceptanceTests.BackColor = System.Drawing.Color.SlateGray;
            this.pageAcceptanceTests.Location = new System.Drawing.Point(210, 90);
            this.pageAcceptanceTests.Name = "pageAcceptanceTests";
            this.pageAcceptanceTests.ParentForm = null;
            this.pageAcceptanceTests.Size = new System.Drawing.Size(680, 400);
            this.pageAcceptanceTests.TabIndex = 6;
            // 
            // pageServerStatus
            // 
            this.pageServerStatus.BackColor = System.Drawing.Color.SlateGray;
            this.pageServerStatus.Location = new System.Drawing.Point(210, 90);
            this.pageServerStatus.Name = "pageServerStatus";
            this.pageServerStatus.ParentForm = null;
            this.pageServerStatus.Size = new System.Drawing.Size(680, 400);
            this.pageServerStatus.TabIndex = 5;
            // 
            // Reserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.ControlBox = false;
            this.Controls.Add(this.pageAcceptanceTests);
            this.Controls.Add(this.pageReleaseHistory);
            this.Controls.Add(this.metroPanelLogo);
            this.Controls.Add(this.pageLogin);
            this.Controls.Add(this.metroPanelSideMenu);
            this.Controls.Add(this.pageSlotReservations);
            this.Controls.Add(this.pageServerStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Reserver";
            this.metroPanelSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonAcceptanceTestsImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHistoryImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonServerStatusImage)).EndInit();
            this.metroPanelLogo.ResumeLayout(false);
            this.metroPanelLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabelCurrentUser;
        private MetroFramework.Controls.MetroPanel metroPanelLogo;
        private MetroFramework.Controls.MetroPanel metroPanelSideMenu;
        private SlotReservation pageSlotReservations;
        private Login pageLogin;
        public ServerStatus pageServerStatus;
        private ReleaseHistory pageReleaseHistory;
        private AcceptanceTests pageAcceptanceTests;
        private System.Windows.Forms.Label closeProgram;
        private System.Windows.Forms.Label minimizeProgram;
        private MetroFramework.Controls.MetroLabel buttonAcceptanceTests;
        private System.Windows.Forms.PictureBox buttonAcceptanceTestsImage;
        private MetroFramework.Controls.MetroLabel buttonHistory;
        private System.Windows.Forms.PictureBox buttonHistoryImage;
        private MetroFramework.Controls.MetroLabel buttonServerStatus;
        private System.Windows.Forms.PictureBox buttonServerStatusImage;
        private MetroFramework.Controls.MetroLabel buttonAcceptanceTestsActive;
        private MetroFramework.Controls.MetroLabel buttonHistoryActive;
        private MetroFramework.Controls.MetroLabel buttonServerStatusActive;
    }
}

