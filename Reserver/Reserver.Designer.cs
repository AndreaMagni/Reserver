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
            this.metroLabelAcceptanceTests = new MetroFramework.Controls.MetroLabel();
            this.metroLabelButtonHistory = new MetroFramework.Controls.MetroLabel();
            this.metroLabelButtonReserve = new MetroFramework.Controls.MetroLabel();
            this.metroLabelButtonServerStatus = new MetroFramework.Controls.MetroLabel();
            this.pageSlotReservations = new SlotReservation();
            this.metroPanelLogo = new MetroFramework.Controls.MetroPanel();
            this.metroLabelCurrentUser = new MetroFramework.Controls.MetroLabel();
            this.pageServerStatus = new ServerStatus();
            this.pageReleaseHistory = new ReleaseHistory();
            this.pageLogin = new Login();
            this.pageAcceptanceTests = new AcceptanceTests();
            this.metroPanelSideMenu.SuspendLayout();
            this.metroPanelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanelSideMenu
            // 
            this.metroPanelSideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroPanelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.metroPanelSideMenu.Controls.Add(this.metroLabelAcceptanceTests);
            this.metroPanelSideMenu.Controls.Add(this.metroLabelButtonHistory);
            this.metroPanelSideMenu.Controls.Add(this.metroLabelButtonReserve);
            this.metroPanelSideMenu.Controls.Add(this.metroLabelButtonServerStatus);
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
            // metroLabelAcceptanceTests
            // 
            this.metroLabelAcceptanceTests.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelAcceptanceTests.Location = new System.Drawing.Point(10, 340);
            this.metroLabelAcceptanceTests.Name = "metroLabelAcceptanceTests";
            this.metroLabelAcceptanceTests.Size = new System.Drawing.Size(182, 71);
            this.metroLabelAcceptanceTests.TabIndex = 5;
            this.metroLabelAcceptanceTests.Text = "Collaudi";
            this.metroLabelAcceptanceTests.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabelAcceptanceTests.UseCustomBackColor = true;
            this.metroLabelAcceptanceTests.Click += new System.EventHandler(this.metroLabelAcceptanceTests_Click);
            this.metroLabelAcceptanceTests.MouseEnter += new System.EventHandler(this.metroLabelTest_MouseEnter);
            this.metroLabelAcceptanceTests.MouseLeave += new System.EventHandler(this.metroLabelTest_MouseLeave);
            // 
            // metroLabelButtonHistory
            // 
            this.metroLabelButtonHistory.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelButtonHistory.Location = new System.Drawing.Point(10, 222);
            this.metroLabelButtonHistory.Name = "metroLabelButtonHistory";
            this.metroLabelButtonHistory.Size = new System.Drawing.Size(182, 100);
            this.metroLabelButtonHistory.TabIndex = 4;
            this.metroLabelButtonHistory.Text = "Storico Rilasci";
            this.metroLabelButtonHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabelButtonHistory.UseCustomBackColor = true;
            this.metroLabelButtonHistory.Click += new System.EventHandler(this.MetroLabelButtonHistory_Click);
            this.metroLabelButtonHistory.MouseEnter += new System.EventHandler(this.metroLabelTest_MouseEnter);
            this.metroLabelButtonHistory.MouseLeave += new System.EventHandler(this.metroLabelTest_MouseLeave);
            // 
            // metroLabelButtonReserve
            // 
            this.metroLabelButtonReserve.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelButtonReserve.Location = new System.Drawing.Point(10, 116);
            this.metroLabelButtonReserve.Name = "metroLabelButtonReserve";
            this.metroLabelButtonReserve.Size = new System.Drawing.Size(182, 98);
            this.metroLabelButtonReserve.TabIndex = 3;
            this.metroLabelButtonReserve.Text = "Prenotazioni";
            this.metroLabelButtonReserve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabelButtonReserve.UseCustomBackColor = true;
            this.metroLabelButtonReserve.Click += new System.EventHandler(this.MetroLabelButtonReserve_Click);
            this.metroLabelButtonReserve.MouseEnter += new System.EventHandler(this.metroLabelTest_MouseEnter);
            this.metroLabelButtonReserve.MouseLeave += new System.EventHandler(this.metroLabelTest_MouseLeave);
            // 
            // metroLabelButtonServerStatus
            // 
            this.metroLabelButtonServerStatus.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelButtonServerStatus.Location = new System.Drawing.Point(10, 10);
            this.metroLabelButtonServerStatus.Name = "metroLabelButtonServerStatus";
            this.metroLabelButtonServerStatus.Size = new System.Drawing.Size(182, 98);
            this.metroLabelButtonServerStatus.TabIndex = 2;
            this.metroLabelButtonServerStatus.Text = "Stato Server";
            this.metroLabelButtonServerStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabelButtonServerStatus.UseCustomBackColor = true;
            this.metroLabelButtonServerStatus.Click += new System.EventHandler(this.MetroLabelButtonServerStatus_Click);
            this.metroLabelButtonServerStatus.MouseEnter += new System.EventHandler(this.metroLabelTest_MouseEnter);
            this.metroLabelButtonServerStatus.MouseLeave += new System.EventHandler(this.metroLabelTest_MouseLeave);
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
            // metroPanelLogo
            // 
            this.metroPanelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.metroPanelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanelLogo.BackgroundImage")));
            this.metroPanelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
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
            // pageServerStatus
            // 
            this.pageServerStatus.BackColor = System.Drawing.Color.SlateGray;
            this.pageServerStatus.Location = new System.Drawing.Point(210, 90);
            this.pageServerStatus.Name = "pageServerStatus";
            this.pageServerStatus.ParentForm = null;
            this.pageServerStatus.Size = new System.Drawing.Size(680, 400);
            this.pageServerStatus.TabIndex = 5;
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
            // pageLogin
            // 
            this.pageLogin.BackColor = System.Drawing.Color.SlateGray;
            this.pageLogin.Location = new System.Drawing.Point(210, 90);
            this.pageLogin.Name = "pageLogin";
            this.pageLogin.ParentForm = null;
            this.pageLogin.Size = new System.Drawing.Size(680, 400);
            this.pageLogin.TabIndex = 6;
            // 
            // pageAcceptanceTests
            // 
            this.pageAcceptanceTests.BackColor = System.Drawing.Color.SlateGray;
            this.pageAcceptanceTests.Location = new System.Drawing.Point(210, 91);
            this.pageAcceptanceTests.Name = "pageAcceptanceTests";
            this.pageAcceptanceTests.ParentForm = null;
            this.pageAcceptanceTests.Size = new System.Drawing.Size(680, 400);
            this.pageAcceptanceTests.TabIndex = 6;
            // 
            // Reserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.ControlBox = false;
            this.Controls.Add(this.pageAcceptanceTests);
            this.Controls.Add(this.pageServerStatus);
            this.Controls.Add(this.pageReleaseHistory);
            this.Controls.Add(this.metroPanelLogo);
            this.Controls.Add(this.pageLogin);
            this.Controls.Add(this.metroPanelSideMenu);
            this.Controls.Add(this.pageSlotReservations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Reserver";
            this.metroPanelSideMenu.ResumeLayout(false);
            this.metroPanelLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabelButtonReserve;
        private MetroFramework.Controls.MetroLabel metroLabelButtonHistory;
        private MetroFramework.Controls.MetroLabel metroLabelCurrentUser;
        private MetroFramework.Controls.MetroPanel metroPanelLogo;
        private MetroFramework.Controls.MetroPanel metroPanelSideMenu;
        private MetroFramework.Controls.MetroLabel metroLabelButtonServerStatus;
        private SlotReservation pageSlotReservations;
        private Login pageLogin;
        private ServerStatus pageServerStatus;
        private ReleaseHistory pageReleaseHistory;
        private MetroFramework.Controls.MetroLabel metroLabelAcceptanceTests;
        private AcceptanceTests pageAcceptanceTests;
    }
}

