namespace Reserver
{
    partial class Login
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

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroButtonLogin = new MetroFramework.Controls.MetroButton();
            this.groupBoxLoginUsername = new System.Windows.Forms.GroupBox();
            this.metroTextBoxLoginUsername = new MetroFramework.Controls.MetroTextBox();
            this.groupBoxLoginPassword = new System.Windows.Forms.GroupBox();
            this.metroTextBoxLoginPassword = new MetroFramework.Controls.MetroTextBox();
            this.groupBoxLoginUsername.SuspendLayout();
            this.groupBoxLoginPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButtonLogin
            // 
            this.metroButtonLogin.Location = new System.Drawing.Point(300, 244);
            this.metroButtonLogin.Name = "metroButtonLogin";
            this.metroButtonLogin.Size = new System.Drawing.Size(80, 25);
            this.metroButtonLogin.TabIndex = 7;
            this.metroButtonLogin.Text = "Login";
            this.metroButtonLogin.UseSelectable = true;
            this.metroButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // groupBoxLoginUsername
            // 
            this.groupBoxLoginUsername.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxLoginUsername.Controls.Add(this.metroTextBoxLoginUsername);
            this.groupBoxLoginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLoginUsername.ForeColor = System.Drawing.Color.White;
            this.groupBoxLoginUsername.Location = new System.Drawing.Point(240, 131);
            this.groupBoxLoginUsername.Name = "groupBoxLoginUsername";
            this.groupBoxLoginUsername.Size = new System.Drawing.Size(200, 50);
            this.groupBoxLoginUsername.TabIndex = 5;
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
            // groupBoxLoginPassword
            // 
            this.groupBoxLoginPassword.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxLoginPassword.Controls.Add(this.metroTextBoxLoginPassword);
            this.groupBoxLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLoginPassword.ForeColor = System.Drawing.Color.White;
            this.groupBoxLoginPassword.Location = new System.Drawing.Point(240, 187);
            this.groupBoxLoginPassword.Name = "groupBoxLoginPassword";
            this.groupBoxLoginPassword.Size = new System.Drawing.Size(200, 50);
            this.groupBoxLoginPassword.TabIndex = 6;
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
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.metroButtonLogin);
            this.Controls.Add(this.groupBoxLoginUsername);
            this.Controls.Add(this.groupBoxLoginPassword);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(680, 400);
            this.groupBoxLoginUsername.ResumeLayout(false);
            this.groupBoxLoginPassword.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButtonLogin;
        private System.Windows.Forms.GroupBox groupBoxLoginUsername;
        private MetroFramework.Controls.MetroTextBox metroTextBoxLoginUsername;
        private System.Windows.Forms.GroupBox groupBoxLoginPassword;
        private MetroFramework.Controls.MetroTextBox metroTextBoxLoginPassword;
    }
}
