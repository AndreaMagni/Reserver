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
            this.panelHeader = new MetroFramework.Controls.MetroPanel();
            this.panelHeaderInfo = new MetroFramework.Controls.MetroPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.minimizeProgram = new System.Windows.Forms.Label();
            this.labelCurrentUser = new MetroFramework.Controls.MetroLabel();
            this.closeProgram = new System.Windows.Forms.Label();
            this.panelSideMenu = new MetroFramework.Controls.MetroPanel();
            this.panelSideMenuAcceptanceTests = new MetroFramework.Controls.MetroPanel();
            this.panelSideMenuReleaseHistory = new MetroFramework.Controls.MetroPanel();
            this.panelSideMenuServerStatus = new MetroFramework.Controls.MetroPanel();
            this.panelPage = new MetroFramework.Controls.MetroPanel();
            this.btnSideMenuAcceptanceTests = new System.Windows.Forms.Button();
            this.btnSideMenuReleaseHistory = new System.Windows.Forms.Button();
            this.btnSideMenuServerStatus = new System.Windows.Forms.Button();
            this.panelHeaderLogo = new MetroFramework.Controls.MetroPanel();
            this.panelHeader.SuspendLayout();
            this.panelHeaderInfo.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.panelSideMenuAcceptanceTests.SuspendLayout();
            this.panelSideMenuReleaseHistory.SuspendLayout();
            this.panelSideMenuServerStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.panelHeaderInfo);
            this.panelHeader.Controls.Add(this.panelHeaderLogo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.HorizontalScrollbarBarColor = true;
            this.panelHeader.HorizontalScrollbarHighlightOnWheel = false;
            this.panelHeader.HorizontalScrollbarSize = 10;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 100);
            this.panelHeader.TabIndex = 19;
            this.panelHeader.VerticalScrollbarBarColor = true;
            this.panelHeader.VerticalScrollbarHighlightOnWheel = false;
            this.panelHeader.VerticalScrollbarSize = 10;
            // 
            // panelHeaderInfo
            // 
            this.panelHeaderInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(162)))), ((int)(((byte)(150)))));
            this.panelHeaderInfo.Controls.Add(this.label1);
            this.panelHeaderInfo.Controls.Add(this.minimizeProgram);
            this.panelHeaderInfo.Controls.Add(this.labelCurrentUser);
            this.panelHeaderInfo.Controls.Add(this.closeProgram);
            this.panelHeaderInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeaderInfo.HorizontalScrollbarBarColor = true;
            this.panelHeaderInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.panelHeaderInfo.HorizontalScrollbarSize = 10;
            this.panelHeaderInfo.Location = new System.Drawing.Point(320, 0);
            this.panelHeaderInfo.Name = "panelHeaderInfo";
            this.panelHeaderInfo.Size = new System.Drawing.Size(680, 100);
            this.panelHeaderInfo.TabIndex = 17;
            this.panelHeaderInfo.UseCustomBackColor = true;
            this.panelHeaderInfo.VerticalScrollbarBarColor = true;
            this.panelHeaderInfo.VerticalScrollbarHighlightOnWheel = false;
            this.panelHeaderInfo.VerticalScrollbarSize = 10;
            this.panelHeaderInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(596, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "[]";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // minimizeProgram
            // 
            this.minimizeProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeProgram.Location = new System.Drawing.Point(622, 9);
            this.minimizeProgram.Name = "minimizeProgram";
            this.minimizeProgram.Size = new System.Drawing.Size(20, 20);
            this.minimizeProgram.TabIndex = 8;
            this.minimizeProgram.Text = "_";
            this.minimizeProgram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minimizeProgram.Click += new System.EventHandler(this.BntMinimize_Click);
            // 
            // labelCurrentUser
            // 
            this.labelCurrentUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCurrentUser.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentUser.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelCurrentUser.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelCurrentUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCurrentUser.Location = new System.Drawing.Point(368, 66);
            this.labelCurrentUser.MaximumSize = new System.Drawing.Size(300, 20);
            this.labelCurrentUser.Name = "labelCurrentUser";
            this.labelCurrentUser.Size = new System.Drawing.Size(300, 20);
            this.labelCurrentUser.TabIndex = 5;
            this.labelCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelCurrentUser.UseCustomBackColor = true;
            this.labelCurrentUser.UseCustomForeColor = true;
            // 
            // closeProgram
            // 
            this.closeProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeProgram.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closeProgram.Location = new System.Drawing.Point(648, 9);
            this.closeProgram.Name = "closeProgram";
            this.closeProgram.Size = new System.Drawing.Size(20, 20);
            this.closeProgram.TabIndex = 7;
            this.closeProgram.Text = "X";
            this.closeProgram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeProgram.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(125)))));
            this.panelSideMenu.Controls.Add(this.panelSideMenuAcceptanceTests);
            this.panelSideMenu.Controls.Add(this.panelSideMenuReleaseHistory);
            this.panelSideMenu.Controls.Add(this.panelSideMenuServerStatus);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.HorizontalScrollbarBarColor = true;
            this.panelSideMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.panelSideMenu.HorizontalScrollbarSize = 10;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 100);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 495);
            this.panelSideMenu.TabIndex = 20;
            this.panelSideMenu.UseCustomBackColor = true;
            this.panelSideMenu.VerticalScrollbarBarColor = true;
            this.panelSideMenu.VerticalScrollbarHighlightOnWheel = false;
            this.panelSideMenu.VerticalScrollbarSize = 10;
            // 
            // panelSideMenuAcceptanceTests
            // 
            this.panelSideMenuAcceptanceTests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(198)))), ((int)(((byte)(189)))));
            this.panelSideMenuAcceptanceTests.Controls.Add(this.btnSideMenuAcceptanceTests);
            this.panelSideMenuAcceptanceTests.HorizontalScrollbarBarColor = true;
            this.panelSideMenuAcceptanceTests.HorizontalScrollbarHighlightOnWheel = false;
            this.panelSideMenuAcceptanceTests.HorizontalScrollbarSize = 10;
            this.panelSideMenuAcceptanceTests.Location = new System.Drawing.Point(0, 330);
            this.panelSideMenuAcceptanceTests.Name = "panelSideMenuAcceptanceTests";
            this.panelSideMenuAcceptanceTests.Size = new System.Drawing.Size(250, 165);
            this.panelSideMenuAcceptanceTests.TabIndex = 4;
            this.panelSideMenuAcceptanceTests.UseCustomBackColor = true;
            this.panelSideMenuAcceptanceTests.VerticalScrollbarBarColor = true;
            this.panelSideMenuAcceptanceTests.VerticalScrollbarHighlightOnWheel = false;
            this.panelSideMenuAcceptanceTests.VerticalScrollbarSize = 10;
            // 
            // panelSideMenuReleaseHistory
            // 
            this.panelSideMenuReleaseHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(198)))), ((int)(((byte)(189)))));
            this.panelSideMenuReleaseHistory.Controls.Add(this.btnSideMenuReleaseHistory);
            this.panelSideMenuReleaseHistory.HorizontalScrollbarBarColor = true;
            this.panelSideMenuReleaseHistory.HorizontalScrollbarHighlightOnWheel = false;
            this.panelSideMenuReleaseHistory.HorizontalScrollbarSize = 10;
            this.panelSideMenuReleaseHistory.Location = new System.Drawing.Point(0, 165);
            this.panelSideMenuReleaseHistory.Name = "panelSideMenuReleaseHistory";
            this.panelSideMenuReleaseHistory.Size = new System.Drawing.Size(250, 165);
            this.panelSideMenuReleaseHistory.TabIndex = 3;
            this.panelSideMenuReleaseHistory.UseCustomBackColor = true;
            this.panelSideMenuReleaseHistory.VerticalScrollbarBarColor = true;
            this.panelSideMenuReleaseHistory.VerticalScrollbarHighlightOnWheel = false;
            this.panelSideMenuReleaseHistory.VerticalScrollbarSize = 10;
            // 
            // panelSideMenuServerStatus
            // 
            this.panelSideMenuServerStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(198)))), ((int)(((byte)(189)))));
            this.panelSideMenuServerStatus.Controls.Add(this.btnSideMenuServerStatus);
            this.panelSideMenuServerStatus.HorizontalScrollbarBarColor = true;
            this.panelSideMenuServerStatus.HorizontalScrollbarHighlightOnWheel = false;
            this.panelSideMenuServerStatus.HorizontalScrollbarSize = 10;
            this.panelSideMenuServerStatus.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenuServerStatus.Name = "panelSideMenuServerStatus";
            this.panelSideMenuServerStatus.Size = new System.Drawing.Size(250, 165);
            this.panelSideMenuServerStatus.TabIndex = 2;
            this.panelSideMenuServerStatus.UseCustomBackColor = true;
            this.panelSideMenuServerStatus.VerticalScrollbarBarColor = true;
            this.panelSideMenuServerStatus.VerticalScrollbarHighlightOnWheel = false;
            this.panelSideMenuServerStatus.VerticalScrollbarSize = 10;
            // 
            // panelPage
            // 
            this.panelPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(229)))), ((int)(((byte)(224)))));
            this.panelPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPage.HorizontalScrollbarBarColor = true;
            this.panelPage.HorizontalScrollbarHighlightOnWheel = false;
            this.panelPage.HorizontalScrollbarSize = 10;
            this.panelPage.Location = new System.Drawing.Point(250, 100);
            this.panelPage.Name = "panelPage";
            this.panelPage.Size = new System.Drawing.Size(750, 495);
            this.panelPage.TabIndex = 21;
            this.panelPage.UseCustomBackColor = true;
            this.panelPage.VerticalScrollbarBarColor = true;
            this.panelPage.VerticalScrollbarHighlightOnWheel = false;
            this.panelPage.VerticalScrollbarSize = 10;
            // 
            // btnSideMenuAcceptanceTests
            // 
            this.btnSideMenuAcceptanceTests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(198)))), ((int)(((byte)(189)))));
            this.btnSideMenuAcceptanceTests.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSideMenuAcceptanceTests.Enabled = false;
            this.btnSideMenuAcceptanceTests.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(198)))), ((int)(((byte)(189)))));
            this.btnSideMenuAcceptanceTests.FlatAppearance.BorderSize = 0;
            this.btnSideMenuAcceptanceTests.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(162)))), ((int)(((byte)(150)))));
            this.btnSideMenuAcceptanceTests.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(162)))), ((int)(((byte)(150)))));
            this.btnSideMenuAcceptanceTests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideMenuAcceptanceTests.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSideMenuAcceptanceTests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(96)))));
            this.btnSideMenuAcceptanceTests.Image = ((System.Drawing.Image)(resources.GetObject("btnSideMenuAcceptanceTests.Image")));
            this.btnSideMenuAcceptanceTests.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSideMenuAcceptanceTests.Location = new System.Drawing.Point(0, 0);
            this.btnSideMenuAcceptanceTests.Name = "btnSideMenuAcceptanceTests";
            this.btnSideMenuAcceptanceTests.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSideMenuAcceptanceTests.Size = new System.Drawing.Size(240, 165);
            this.btnSideMenuAcceptanceTests.TabIndex = 4;
            this.btnSideMenuAcceptanceTests.Text = "            COLLAUDI";
            this.btnSideMenuAcceptanceTests.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSideMenuAcceptanceTests.UseVisualStyleBackColor = false;
            this.btnSideMenuAcceptanceTests.Click += new System.EventHandler(this.SideMenuButton_Click);
            // 
            // btnSideMenuReleaseHistory
            // 
            this.btnSideMenuReleaseHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(198)))), ((int)(((byte)(189)))));
            this.btnSideMenuReleaseHistory.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSideMenuReleaseHistory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(198)))), ((int)(((byte)(189)))));
            this.btnSideMenuReleaseHistory.FlatAppearance.BorderSize = 0;
            this.btnSideMenuReleaseHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(162)))), ((int)(((byte)(150)))));
            this.btnSideMenuReleaseHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(162)))), ((int)(((byte)(150)))));
            this.btnSideMenuReleaseHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideMenuReleaseHistory.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSideMenuReleaseHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(96)))));
            this.btnSideMenuReleaseHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnSideMenuReleaseHistory.Image")));
            this.btnSideMenuReleaseHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSideMenuReleaseHistory.Location = new System.Drawing.Point(0, 0);
            this.btnSideMenuReleaseHistory.Name = "btnSideMenuReleaseHistory";
            this.btnSideMenuReleaseHistory.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSideMenuReleaseHistory.Size = new System.Drawing.Size(240, 165);
            this.btnSideMenuReleaseHistory.TabIndex = 3;
            this.btnSideMenuReleaseHistory.Text = "            STORICO RILASCI";
            this.btnSideMenuReleaseHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSideMenuReleaseHistory.UseVisualStyleBackColor = false;
            this.btnSideMenuReleaseHistory.Click += new System.EventHandler(this.SideMenuButton_Click);
            // 
            // btnSideMenuServerStatus
            // 
            this.btnSideMenuServerStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(198)))), ((int)(((byte)(189)))));
            this.btnSideMenuServerStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSideMenuServerStatus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(198)))), ((int)(((byte)(189)))));
            this.btnSideMenuServerStatus.FlatAppearance.BorderSize = 0;
            this.btnSideMenuServerStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(162)))), ((int)(((byte)(150)))));
            this.btnSideMenuServerStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(162)))), ((int)(((byte)(150)))));
            this.btnSideMenuServerStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideMenuServerStatus.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSideMenuServerStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(96)))));
            this.btnSideMenuServerStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnSideMenuServerStatus.Image")));
            this.btnSideMenuServerStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSideMenuServerStatus.Location = new System.Drawing.Point(0, 0);
            this.btnSideMenuServerStatus.Name = "btnSideMenuServerStatus";
            this.btnSideMenuServerStatus.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSideMenuServerStatus.Size = new System.Drawing.Size(240, 165);
            this.btnSideMenuServerStatus.TabIndex = 2;
            this.btnSideMenuServerStatus.Text = "            STATO SERVER";
            this.btnSideMenuServerStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSideMenuServerStatus.UseVisualStyleBackColor = false;
            this.btnSideMenuServerStatus.Click += new System.EventHandler(this.SideMenuButton_Click);
            // 
            // panelHeaderLogo
            // 
            this.panelHeaderLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(162)))), ((int)(((byte)(150)))));
            this.panelHeaderLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelHeaderLogo.BackgroundImage")));
            this.panelHeaderLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelHeaderLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelHeaderLogo.HorizontalScrollbarBarColor = true;
            this.panelHeaderLogo.HorizontalScrollbarHighlightOnWheel = false;
            this.panelHeaderLogo.HorizontalScrollbarSize = 10;
            this.panelHeaderLogo.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderLogo.Name = "panelHeaderLogo";
            this.panelHeaderLogo.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.panelHeaderLogo.Size = new System.Drawing.Size(320, 100);
            this.panelHeaderLogo.TabIndex = 17;
            this.panelHeaderLogo.UseCustomBackColor = true;
            this.panelHeaderLogo.VerticalScrollbarBarColor = true;
            this.panelHeaderLogo.VerticalScrollbarHighlightOnWheel = false;
            this.panelHeaderLogo.VerticalScrollbarSize = 10;
            this.panelHeaderLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            // 
            // Reserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1000, 595);
            this.ControlBox = false;
            this.Controls.Add(this.panelPage);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reserver";
            this.panelHeader.ResumeLayout(false);
            this.panelHeaderInfo.ResumeLayout(false);
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenuAcceptanceTests.ResumeLayout(false);
            this.panelSideMenuReleaseHistory.ResumeLayout(false);
            this.panelSideMenuServerStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelSideMenu;
        private MetroFramework.Controls.MetroPanel panelPage;
        private MetroFramework.Controls.MetroPanel panelSideMenuAcceptanceTests;
        private MetroFramework.Controls.MetroPanel panelSideMenuReleaseHistory;
        private MetroFramework.Controls.MetroPanel panelSideMenuServerStatus;
        private MetroFramework.Controls.MetroPanel panelHeaderInfo;
        private MetroFramework.Controls.MetroPanel panelHeaderLogo;
        private MetroFramework.Controls.MetroPanel panelHeader;
        private MetroFramework.Controls.MetroLabel labelCurrentUser;
        private System.Windows.Forms.Button btnSideMenuAcceptanceTests;
        private System.Windows.Forms.Button btnSideMenuReleaseHistory;
        private System.Windows.Forms.Button btnSideMenuServerStatus;
        private System.Windows.Forms.Label closeProgram;
        private System.Windows.Forms.Label minimizeProgram;
        private System.Windows.Forms.Label label1;
    }
}

