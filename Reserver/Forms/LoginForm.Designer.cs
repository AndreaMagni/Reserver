namespace Reserver.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoginForm = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxLoginFormPassword = new MetroFramework.Controls.MetroTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroTextBoxLoginFormUsername = new MetroFramework.Controls.MetroTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoginForm
            // 
            this.btnLoginForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLoginForm.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnLoginForm.Location = new System.Drawing.Point(303, 262);
            this.btnLoginForm.Name = "btnLoginForm";
            this.btnLoginForm.Size = new System.Drawing.Size(125, 25);
            this.btnLoginForm.TabIndex = 0;
            this.btnLoginForm.Text = "Login";
            this.btnLoginForm.UseSelectable = true;
            this.btnLoginForm.Click += new System.EventHandler(this.BtnLoginForm_Click);
            // 
            // metroTextBoxLoginFormPassword
            // 
            this.metroTextBoxLoginFormPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.metroTextBoxLoginFormPassword.CustomButton.Image = null;
            this.metroTextBoxLoginFormPassword.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.metroTextBoxLoginFormPassword.CustomButton.Name = "";
            this.metroTextBoxLoginFormPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxLoginFormPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxLoginFormPassword.CustomButton.TabIndex = 1;
            this.metroTextBoxLoginFormPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxLoginFormPassword.CustomButton.UseSelectable = true;
            this.metroTextBoxLoginFormPassword.CustomButton.Visible = false;
            this.metroTextBoxLoginFormPassword.Lines = new string[0];
            this.metroTextBoxLoginFormPassword.Location = new System.Drawing.Point(272, 219);
            this.metroTextBoxLoginFormPassword.MaxLength = 32767;
            this.metroTextBoxLoginFormPassword.Name = "metroTextBoxLoginFormPassword";
            this.metroTextBoxLoginFormPassword.PasswordChar = '\0';
            this.metroTextBoxLoginFormPassword.PromptText = "Password";
            this.metroTextBoxLoginFormPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxLoginFormPassword.SelectedText = "";
            this.metroTextBoxLoginFormPassword.SelectionLength = 0;
            this.metroTextBoxLoginFormPassword.SelectionStart = 0;
            this.metroTextBoxLoginFormPassword.ShortcutsEnabled = true;
            this.metroTextBoxLoginFormPassword.Size = new System.Drawing.Size(188, 25);
            this.metroTextBoxLoginFormPassword.TabIndex = 2;
            this.metroTextBoxLoginFormPassword.UseSelectable = true;
            this.metroTextBoxLoginFormPassword.WaterMark = "Password";
            this.metroTextBoxLoginFormPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxLoginFormPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.metroTextBoxLoginFormPassword, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.metroTextBoxLoginFormUsername, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnLoginForm, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(734, 434);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // metroTextBoxLoginFormUsername
            // 
            this.metroTextBoxLoginFormUsername.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.metroTextBoxLoginFormUsername.CustomButton.Image = null;
            this.metroTextBoxLoginFormUsername.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.metroTextBoxLoginFormUsername.CustomButton.Name = "";
            this.metroTextBoxLoginFormUsername.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxLoginFormUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxLoginFormUsername.CustomButton.TabIndex = 1;
            this.metroTextBoxLoginFormUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxLoginFormUsername.CustomButton.UseSelectable = true;
            this.metroTextBoxLoginFormUsername.CustomButton.Visible = false;
            this.metroTextBoxLoginFormUsername.Lines = new string[0];
            this.metroTextBoxLoginFormUsername.Location = new System.Drawing.Point(272, 188);
            this.metroTextBoxLoginFormUsername.MaxLength = 32767;
            this.metroTextBoxLoginFormUsername.Name = "metroTextBoxLoginFormUsername";
            this.metroTextBoxLoginFormUsername.PasswordChar = '\0';
            this.metroTextBoxLoginFormUsername.PromptText = "Username";
            this.metroTextBoxLoginFormUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxLoginFormUsername.SelectedText = "";
            this.metroTextBoxLoginFormUsername.SelectionLength = 0;
            this.metroTextBoxLoginFormUsername.SelectionStart = 0;
            this.metroTextBoxLoginFormUsername.ShortcutsEnabled = true;
            this.metroTextBoxLoginFormUsername.Size = new System.Drawing.Size(188, 25);
            this.metroTextBoxLoginFormUsername.TabIndex = 1;
            this.metroTextBoxLoginFormUsername.UseSelectable = true;
            this.metroTextBoxLoginFormUsername.WaterMark = "Username";
            this.metroTextBoxLoginFormUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxLoginFormUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(229)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(734, 434);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnLoginForm;
        private MetroFramework.Controls.MetroTextBox metroTextBoxLoginFormPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxLoginFormUsername;
    }
}