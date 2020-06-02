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
            this.metroPanelButtonHistory = new MetroFramework.Controls.MetroPanel();
            this.metroLabelButtonHistory = new MetroFramework.Controls.MetroLabel();
            this.metroPanelButtonReserve = new MetroFramework.Controls.MetroPanel();
            this.metroLabelButtonReserve = new MetroFramework.Controls.MetroLabel();
            this.metroPanelButtonServerStatus = new MetroFramework.Controls.MetroPanel();
            this.metroLabelButtonServerStatus = new MetroFramework.Controls.MetroLabel();
            this.metroPanelLogo = new MetroFramework.Controls.MetroPanel();
            this.metroLabelCurrentUser = new MetroFramework.Controls.MetroLabel();
            this.metroButtonLogin = new MetroFramework.Controls.MetroButton();
            this.groupBoxLoginPassword = new System.Windows.Forms.GroupBox();
            this.metroTextBoxLoginPassword = new MetroFramework.Controls.MetroTextBox();
            this.groupBoxLoginUsername = new System.Windows.Forms.GroupBox();
            this.metroTextBoxLoginUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroPanelPageLogin = new MetroFramework.Controls.MetroPanel();
            this.metroPanelPageServerStatus = new MetroFramework.Controls.MetroPanel();
            this.metroPanelPageHistory = new MetroFramework.Controls.MetroPanel();
            this.metroPanelPageReserve = new MetroFramework.Controls.MetroPanel();
            this.metroPanelSideMenu.SuspendLayout();
            this.metroPanelButtonHistory.SuspendLayout();
            this.metroPanelButtonReserve.SuspendLayout();
            this.metroPanelButtonServerStatus.SuspendLayout();
            this.metroPanelLogo.SuspendLayout();
            this.groupBoxLoginPassword.SuspendLayout();
            this.groupBoxLoginUsername.SuspendLayout();
            this.metroPanelPageLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanelSideMenu
            // 
            this.metroPanelSideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroPanelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.metroPanelSideMenu.Controls.Add(this.metroPanelButtonHistory);
            this.metroPanelSideMenu.Controls.Add(this.metroPanelButtonReserve);
            this.metroPanelSideMenu.Controls.Add(this.metroPanelButtonServerStatus);
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
            // metroPanelButtonHistory
            // 
            this.metroPanelButtonHistory.Controls.Add(this.metroLabelButtonHistory);
            this.metroPanelButtonHistory.HorizontalScrollbarBarColor = true;
            this.metroPanelButtonHistory.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelButtonHistory.HorizontalScrollbarSize = 10;
            this.metroPanelButtonHistory.Location = new System.Drawing.Point(10, 222);
            this.metroPanelButtonHistory.Name = "metroPanelButtonHistory";
            this.metroPanelButtonHistory.Size = new System.Drawing.Size(180, 100);
            this.metroPanelButtonHistory.TabIndex = 4;
            this.metroPanelButtonHistory.UseCustomBackColor = true;
            this.metroPanelButtonHistory.VerticalScrollbarBarColor = true;
            this.metroPanelButtonHistory.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelButtonHistory.VerticalScrollbarSize = 10;
            this.metroPanelButtonHistory.Click += new System.EventHandler(this.MetroPanelButtonHistory_Click);
            // 
            // metroLabelButtonHistory
            // 
            this.metroLabelButtonHistory.AutoSize = true;
            this.metroLabelButtonHistory.Location = new System.Drawing.Point(41, 34);
            this.metroLabelButtonHistory.Name = "metroLabelButtonHistory";
            this.metroLabelButtonHistory.Size = new System.Drawing.Size(89, 19);
            this.metroLabelButtonHistory.TabIndex = 4;
            this.metroLabelButtonHistory.Text = "Storico Rilasci";
            this.metroLabelButtonHistory.UseCustomBackColor = true;
            this.metroLabelButtonHistory.Click += new System.EventHandler(this.MetroPanelButtonHistory_Click);
            // 
            // metroPanelButtonReserve
            // 
            this.metroPanelButtonReserve.Controls.Add(this.metroLabelButtonReserve);
            this.metroPanelButtonReserve.HorizontalScrollbarBarColor = true;
            this.metroPanelButtonReserve.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelButtonReserve.HorizontalScrollbarSize = 10;
            this.metroPanelButtonReserve.Location = new System.Drawing.Point(10, 116);
            this.metroPanelButtonReserve.Name = "metroPanelButtonReserve";
            this.metroPanelButtonReserve.Size = new System.Drawing.Size(180, 100);
            this.metroPanelButtonReserve.TabIndex = 3;
            this.metroPanelButtonReserve.UseCustomBackColor = true;
            this.metroPanelButtonReserve.VerticalScrollbarBarColor = true;
            this.metroPanelButtonReserve.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelButtonReserve.VerticalScrollbarSize = 10;
            this.metroPanelButtonReserve.Click += new System.EventHandler(this.MetroPanelButtonReserve_Click);
            // 
            // metroLabelButtonReserve
            // 
            this.metroLabelButtonReserve.AutoSize = true;
            this.metroLabelButtonReserve.Location = new System.Drawing.Point(48, 36);
            this.metroLabelButtonReserve.Name = "metroLabelButtonReserve";
            this.metroLabelButtonReserve.Size = new System.Drawing.Size(82, 19);
            this.metroLabelButtonReserve.TabIndex = 3;
            this.metroLabelButtonReserve.Text = "Prenotazioni";
            this.metroLabelButtonReserve.UseCustomBackColor = true;
            this.metroLabelButtonReserve.Click += new System.EventHandler(this.MetroPanelButtonReserve_Click);
            // 
            // metroPanelButtonServerStatus
            // 
            this.metroPanelButtonServerStatus.Controls.Add(this.metroLabelButtonServerStatus);
            this.metroPanelButtonServerStatus.HorizontalScrollbarBarColor = true;
            this.metroPanelButtonServerStatus.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelButtonServerStatus.HorizontalScrollbarSize = 10;
            this.metroPanelButtonServerStatus.Location = new System.Drawing.Point(10, 10);
            this.metroPanelButtonServerStatus.Name = "metroPanelButtonServerStatus";
            this.metroPanelButtonServerStatus.Size = new System.Drawing.Size(180, 100);
            this.metroPanelButtonServerStatus.TabIndex = 2;
            this.metroPanelButtonServerStatus.UseCustomBackColor = true;
            this.metroPanelButtonServerStatus.VerticalScrollbarBarColor = true;
            this.metroPanelButtonServerStatus.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelButtonServerStatus.VerticalScrollbarSize = 10;
            this.metroPanelButtonServerStatus.Click += new System.EventHandler(this.MetroPanelButtonServerStatus_Click);
            // 
            // metroLabelButtonServerStatus
            // 
            this.metroLabelButtonServerStatus.AutoSize = true;
            this.metroLabelButtonServerStatus.Location = new System.Drawing.Point(49, 37);
            this.metroLabelButtonServerStatus.Name = "metroLabelButtonServerStatus";
            this.metroLabelButtonServerStatus.Size = new System.Drawing.Size(81, 19);
            this.metroLabelButtonServerStatus.TabIndex = 2;
            this.metroLabelButtonServerStatus.Text = "Stato Server";
            this.metroLabelButtonServerStatus.UseCustomBackColor = true;
            this.metroLabelButtonServerStatus.Click += new System.EventHandler(this.MetroPanelButtonServerStatus_Click);
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
            // metroButtonLogin
            // 
            this.metroButtonLogin.Location = new System.Drawing.Point(300, 245);
            this.metroButtonLogin.Name = "metroButtonLogin";
            this.metroButtonLogin.Size = new System.Drawing.Size(80, 25);
            this.metroButtonLogin.TabIndex = 4;
            this.metroButtonLogin.Text = "Login";
            this.metroButtonLogin.UseSelectable = true;
            this.metroButtonLogin.Click += new System.EventHandler(this.metroButtonLogin_Click);
            // 
            // groupBoxLoginPassword
            // 
            this.groupBoxLoginPassword.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxLoginPassword.Controls.Add(this.metroTextBoxLoginPassword);
            this.groupBoxLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLoginPassword.Location = new System.Drawing.Point(240, 188);
            this.groupBoxLoginPassword.Name = "groupBoxLoginPassword";
            this.groupBoxLoginPassword.Size = new System.Drawing.Size(200, 50);
            this.groupBoxLoginPassword.TabIndex = 3;
            this.groupBoxLoginPassword.TabStop = false;
            this.groupBoxLoginPassword.Text = "Password";
            // 
            // metroTextBoxLoginPassword
            // 
            // 
            // 
            // 
            this.metroTextBoxLoginPassword.CustomButton.Image = null;
            this.metroTextBoxLoginPassword.CustomButton.Location = new System.Drawing.Point(162, 2);
            this.metroTextBoxLoginPassword.CustomButton.Name = "";
            this.metroTextBoxLoginPassword.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.metroTextBoxLoginPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxLoginPassword.CustomButton.TabIndex = 1;
            this.metroTextBoxLoginPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxLoginPassword.CustomButton.UseSelectable = true;
            this.metroTextBoxLoginPassword.CustomButton.Visible = false;
            this.metroTextBoxLoginPassword.Lines = new string[0];
            this.metroTextBoxLoginPassword.Location = new System.Drawing.Point(10, 20);
            this.metroTextBoxLoginPassword.MaxLength = 32767;
            this.metroTextBoxLoginPassword.Name = "metroTextBoxLoginPassword";
            this.metroTextBoxLoginPassword.PasswordChar = '●';
            this.metroTextBoxLoginPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxLoginPassword.SelectedText = "";
            this.metroTextBoxLoginPassword.SelectionLength = 0;
            this.metroTextBoxLoginPassword.SelectionStart = 0;
            this.metroTextBoxLoginPassword.ShortcutsEnabled = true;
            this.metroTextBoxLoginPassword.Size = new System.Drawing.Size(180, 20);
            this.metroTextBoxLoginPassword.TabIndex = 0;
            this.metroTextBoxLoginPassword.UseSelectable = true;
            this.metroTextBoxLoginPassword.UseSystemPasswordChar = true;
            this.metroTextBoxLoginPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxLoginPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBoxLoginUsername
            // 
            this.groupBoxLoginUsername.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxLoginUsername.Controls.Add(this.metroTextBoxLoginUsername);
            this.groupBoxLoginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLoginUsername.Location = new System.Drawing.Point(240, 132);
            this.groupBoxLoginUsername.Name = "groupBoxLoginUsername";
            this.groupBoxLoginUsername.Size = new System.Drawing.Size(200, 50);
            this.groupBoxLoginUsername.TabIndex = 2;
            this.groupBoxLoginUsername.TabStop = false;
            this.groupBoxLoginUsername.Text = "Username";
            // 
            // metroTextBoxLoginUsername
            // 
            // 
            // 
            // 
            this.metroTextBoxLoginUsername.CustomButton.Image = null;
            this.metroTextBoxLoginUsername.CustomButton.Location = new System.Drawing.Point(162, 2);
            this.metroTextBoxLoginUsername.CustomButton.Name = "";
            this.metroTextBoxLoginUsername.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.metroTextBoxLoginUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxLoginUsername.CustomButton.TabIndex = 1;
            this.metroTextBoxLoginUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxLoginUsername.CustomButton.UseSelectable = true;
            this.metroTextBoxLoginUsername.CustomButton.Visible = false;
            this.metroTextBoxLoginUsername.Lines = new string[0];
            this.metroTextBoxLoginUsername.Location = new System.Drawing.Point(10, 20);
            this.metroTextBoxLoginUsername.MaxLength = 32767;
            this.metroTextBoxLoginUsername.Name = "metroTextBoxLoginUsername";
            this.metroTextBoxLoginUsername.PasswordChar = '\0';
            this.metroTextBoxLoginUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxLoginUsername.SelectedText = "";
            this.metroTextBoxLoginUsername.SelectionLength = 0;
            this.metroTextBoxLoginUsername.SelectionStart = 0;
            this.metroTextBoxLoginUsername.ShortcutsEnabled = true;
            this.metroTextBoxLoginUsername.Size = new System.Drawing.Size(180, 20);
            this.metroTextBoxLoginUsername.TabIndex = 0;
            this.metroTextBoxLoginUsername.UseSelectable = true;
            this.metroTextBoxLoginUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxLoginUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanelPageLogin
            // 
            this.metroPanelPageLogin.Controls.Add(this.metroButtonLogin);
            this.metroPanelPageLogin.Controls.Add(this.groupBoxLoginUsername);
            this.metroPanelPageLogin.Controls.Add(this.groupBoxLoginPassword);
            this.metroPanelPageLogin.HorizontalScrollbarBarColor = true;
            this.metroPanelPageLogin.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelPageLogin.HorizontalScrollbarSize = 10;
            this.metroPanelPageLogin.Location = new System.Drawing.Point(210, 90);
            this.metroPanelPageLogin.Name = "metroPanelPageLogin";
            this.metroPanelPageLogin.Size = new System.Drawing.Size(680, 400);
            this.metroPanelPageLogin.TabIndex = 5;
            this.metroPanelPageLogin.VerticalScrollbarBarColor = true;
            this.metroPanelPageLogin.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelPageLogin.VerticalScrollbarSize = 10;
            // 
            // metroPanelPageServerStatus
            // 
            this.metroPanelPageServerStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.metroPanelPageServerStatus.HorizontalScrollbarBarColor = true;
            this.metroPanelPageServerStatus.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelPageServerStatus.HorizontalScrollbarSize = 10;
            this.metroPanelPageServerStatus.Location = new System.Drawing.Point(210, 90);
            this.metroPanelPageServerStatus.Name = "metroPanelPageServerStatus";
            this.metroPanelPageServerStatus.Size = new System.Drawing.Size(680, 400);
            this.metroPanelPageServerStatus.TabIndex = 6;
            this.metroPanelPageServerStatus.UseCustomBackColor = true;
            this.metroPanelPageServerStatus.VerticalScrollbarBarColor = true;
            this.metroPanelPageServerStatus.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelPageServerStatus.VerticalScrollbarSize = 10;
            // 
            // metroPanelPageHistory
            // 
            this.metroPanelPageHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.metroPanelPageHistory.HorizontalScrollbarBarColor = true;
            this.metroPanelPageHistory.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelPageHistory.HorizontalScrollbarSize = 10;
            this.metroPanelPageHistory.Location = new System.Drawing.Point(210, 90);
            this.metroPanelPageHistory.Name = "metroPanelPageHistory";
            this.metroPanelPageHistory.Size = new System.Drawing.Size(680, 400);
            this.metroPanelPageHistory.TabIndex = 6;
            this.metroPanelPageHistory.UseCustomBackColor = true;
            this.metroPanelPageHistory.VerticalScrollbarBarColor = true;
            this.metroPanelPageHistory.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelPageHistory.VerticalScrollbarSize = 10;
            // 
            // metroPanelPageReserve
            // 
            this.metroPanelPageReserve.HorizontalScrollbarBarColor = true;
            this.metroPanelPageReserve.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelPageReserve.HorizontalScrollbarSize = 10;
            this.metroPanelPageReserve.Location = new System.Drawing.Point(210, 90);
            this.metroPanelPageReserve.Name = "metroPanelPageReserve";
            this.metroPanelPageReserve.Size = new System.Drawing.Size(680, 400);
            this.metroPanelPageReserve.TabIndex = 5;
            this.metroPanelPageReserve.VerticalScrollbarBarColor = true;
            this.metroPanelPageReserve.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelPageReserve.VerticalScrollbarSize = 10;
            // 
            // Reserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.ControlBox = false;
            this.Controls.Add(this.metroPanelPageReserve);
            this.Controls.Add(this.metroPanelPageServerStatus);
            this.Controls.Add(this.metroPanelPageHistory);
            this.Controls.Add(this.metroPanelPageLogin);
            this.Controls.Add(this.metroPanelLogo);
            this.Controls.Add(this.metroPanelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Reserver";
            this.metroPanelSideMenu.ResumeLayout(false);
            this.metroPanelButtonHistory.ResumeLayout(false);
            this.metroPanelButtonHistory.PerformLayout();
            this.metroPanelButtonReserve.ResumeLayout(false);
            this.metroPanelButtonReserve.PerformLayout();
            this.metroPanelButtonServerStatus.ResumeLayout(false);
            this.metroPanelButtonServerStatus.PerformLayout();
            this.metroPanelLogo.ResumeLayout(false);
            this.groupBoxLoginPassword.ResumeLayout(false);
            this.groupBoxLoginUsername.ResumeLayout(false);
            this.metroPanelPageLogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLoginPassword;
        private System.Windows.Forms.GroupBox groupBoxLoginUsername;
        private MetroFramework.Controls.MetroButton metroButtonLogin;
        private MetroFramework.Controls.MetroLabel metroLabelButtonServerStatus;
        private MetroFramework.Controls.MetroLabel metroLabelButtonReserve;
        private MetroFramework.Controls.MetroLabel metroLabelButtonHistory;
        private MetroFramework.Controls.MetroLabel metroLabelCurrentUser;
        private MetroFramework.Controls.MetroPanel metroPanelLogo;
        private MetroFramework.Controls.MetroPanel metroPanelSideMenu;
        private MetroFramework.Controls.MetroPanel metroPanelButtonHistory;
        private MetroFramework.Controls.MetroPanel metroPanelButtonReserve;
        private MetroFramework.Controls.MetroPanel metroPanelButtonServerStatus;
        private MetroFramework.Controls.MetroPanel metroPanelPageLogin;
        private MetroFramework.Controls.MetroPanel metroPanelPageHistory;
        private MetroFramework.Controls.MetroPanel metroPanelPageReserve;
        private MetroFramework.Controls.MetroPanel metroPanelPageServerStatus;
        private MetroFramework.Controls.MetroTextBox metroTextBoxLoginPassword;
        private MetroFramework.Controls.MetroTextBox metroTextBoxLoginUsername;
    }
}

