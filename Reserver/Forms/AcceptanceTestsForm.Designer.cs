namespace Reserver.Forms
{
    partial class AcceptanceTestsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGridAcceptanceTests = new MetroFramework.Controls.MetroGrid();
            this.CONCLUDI = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroTextBoxAcceptanceTestDescription = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonSave = new MetroFramework.Controls.MetroButton();
            this.metroComboBoxServers = new MetroFramework.Controls.MetroComboBox();
            this.metroDateTimeStartDate = new MetroFramework.Controls.MetroDateTime();
            this.metroComboBoxStartHour = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxEndHour = new MetroFramework.Controls.MetroComboBox();
            this.metroDateTimeEndDate = new MetroFramework.Controls.MetroDateTime();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridAcceptanceTests)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroGridAcceptanceTests
            // 
            this.metroGridAcceptanceTests.AllowUserToAddRows = false;
            this.metroGridAcceptanceTests.AllowUserToDeleteRows = false;
            this.metroGridAcceptanceTests.AllowUserToResizeColumns = false;
            this.metroGridAcceptanceTests.AllowUserToResizeRows = false;
            this.metroGridAcceptanceTests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGridAcceptanceTests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGridAcceptanceTests.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridAcceptanceTests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridAcceptanceTests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridAcceptanceTests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(162)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(162)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridAcceptanceTests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridAcceptanceTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridAcceptanceTests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CONCLUDI});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(198)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridAcceptanceTests.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridAcceptanceTests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.metroGridAcceptanceTests.EnableHeadersVisualStyles = false;
            this.metroGridAcceptanceTests.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridAcceptanceTests.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridAcceptanceTests.Location = new System.Drawing.Point(14, 114);
            this.metroGridAcceptanceTests.Name = "metroGridAcceptanceTests";
            this.metroGridAcceptanceTests.ReadOnly = true;
            this.metroGridAcceptanceTests.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(162)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(162)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridAcceptanceTests.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridAcceptanceTests.RowHeadersWidth = 15;
            this.metroGridAcceptanceTests.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridAcceptanceTests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.metroGridAcceptanceTests.Size = new System.Drawing.Size(706, 308);
            this.metroGridAcceptanceTests.TabIndex = 44;
            // 
            // CONCLUDI
            // 
            this.CONCLUDI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CONCLUDI.HeaderText = " STOP ";
            this.CONCLUDI.Name = "CONCLUDI";
            this.CONCLUDI.ReadOnly = true;
            this.CONCLUDI.Text = "X";
            this.CONCLUDI.UseColumnTextForButtonValue = true;
            this.CONCLUDI.Width = 43;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.metroTextBoxAcceptanceTestDescription);
            this.groupBox1.Controls.Add(this.metroButtonSave);
            this.groupBox1.Controls.Add(this.metroComboBoxServers);
            this.groupBox1.Controls.Add(this.metroDateTimeStartDate);
            this.groupBox1.Controls.Add(this.metroComboBoxStartHour);
            this.groupBox1.Controls.Add(this.metroComboBoxEndHour);
            this.groupBox1.Controls.Add(this.metroDateTimeEndDate);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 92);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuovo Collaudo";
            // 
            // metroTextBoxAcceptanceTestDescription
            // 
            this.metroTextBoxAcceptanceTestDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.metroTextBoxAcceptanceTestDescription.CustomButton.Image = null;
            this.metroTextBoxAcceptanceTestDescription.CustomButton.Location = new System.Drawing.Point(437, 1);
            this.metroTextBoxAcceptanceTestDescription.CustomButton.Name = "";
            this.metroTextBoxAcceptanceTestDescription.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.metroTextBoxAcceptanceTestDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxAcceptanceTestDescription.CustomButton.TabIndex = 1;
            this.metroTextBoxAcceptanceTestDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxAcceptanceTestDescription.CustomButton.UseSelectable = true;
            this.metroTextBoxAcceptanceTestDescription.CustomButton.Visible = false;
            this.metroTextBoxAcceptanceTestDescription.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxAcceptanceTestDescription.Lines = new string[0];
            this.metroTextBoxAcceptanceTestDescription.Location = new System.Drawing.Point(233, 20);
            this.metroTextBoxAcceptanceTestDescription.Margin = new System.Windows.Forms.Padding(5);
            this.metroTextBoxAcceptanceTestDescription.MaxLength = 32767;
            this.metroTextBoxAcceptanceTestDescription.Name = "metroTextBoxAcceptanceTestDescription";
            this.metroTextBoxAcceptanceTestDescription.PasswordChar = '\0';
            this.metroTextBoxAcceptanceTestDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxAcceptanceTestDescription.SelectedText = "";
            this.metroTextBoxAcceptanceTestDescription.SelectionLength = 0;
            this.metroTextBoxAcceptanceTestDescription.SelectionStart = 0;
            this.metroTextBoxAcceptanceTestDescription.ShortcutsEnabled = true;
            this.metroTextBoxAcceptanceTestDescription.Size = new System.Drawing.Size(465, 29);
            this.metroTextBoxAcceptanceTestDescription.TabIndex = 44;
            this.metroTextBoxAcceptanceTestDescription.UseSelectable = true;
            this.metroTextBoxAcceptanceTestDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxAcceptanceTestDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButtonSave
            // 
            this.metroButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButtonSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroButtonSave.Location = new System.Drawing.Point(623, 59);
            this.metroButtonSave.Margin = new System.Windows.Forms.Padding(5);
            this.metroButtonSave.Name = "metroButtonSave";
            this.metroButtonSave.Size = new System.Drawing.Size(75, 23);
            this.metroButtonSave.TabIndex = 43;
            this.metroButtonSave.Text = "Salva";
            this.metroButtonSave.UseSelectable = true;
            this.metroButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // metroComboBoxServers
            // 
            this.metroComboBoxServers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroComboBoxServers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBoxServers.FormattingEnabled = true;
            this.metroComboBoxServers.ItemHeight = 23;
            this.metroComboBoxServers.Location = new System.Drawing.Point(8, 20);
            this.metroComboBoxServers.Margin = new System.Windows.Forms.Padding(5);
            this.metroComboBoxServers.Name = "metroComboBoxServers";
            this.metroComboBoxServers.Size = new System.Drawing.Size(215, 29);
            this.metroComboBoxServers.TabIndex = 43;
            this.metroComboBoxServers.UseSelectable = true;
            // 
            // metroDateTimeStartDate
            // 
            this.metroDateTimeStartDate.CustomFormat = "";
            this.metroDateTimeStartDate.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.metroDateTimeStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTimeStartDate.Location = new System.Drawing.Point(8, 59);
            this.metroDateTimeStartDate.Margin = new System.Windows.Forms.Padding(5);
            this.metroDateTimeStartDate.MinimumSize = new System.Drawing.Size(0, 25);
            this.metroDateTimeStartDate.Name = "metroDateTimeStartDate";
            this.metroDateTimeStartDate.Size = new System.Drawing.Size(90, 25);
            this.metroDateTimeStartDate.TabIndex = 22;
            // 
            // metroComboBoxStartHour
            // 
            this.metroComboBoxStartHour.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.metroComboBoxStartHour.FormattingEnabled = true;
            this.metroComboBoxStartHour.ItemHeight = 19;
            this.metroComboBoxStartHour.Items.AddRange(new object[] {
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00"});
            this.metroComboBoxStartHour.Location = new System.Drawing.Point(108, 59);
            this.metroComboBoxStartHour.Margin = new System.Windows.Forms.Padding(5);
            this.metroComboBoxStartHour.Name = "metroComboBoxStartHour";
            this.metroComboBoxStartHour.Size = new System.Drawing.Size(60, 25);
            this.metroComboBoxStartHour.TabIndex = 23;
            this.metroComboBoxStartHour.UseSelectable = true;
            // 
            // metroComboBoxEndHour
            // 
            this.metroComboBoxEndHour.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.metroComboBoxEndHour.FormattingEnabled = true;
            this.metroComboBoxEndHour.ItemHeight = 19;
            this.metroComboBoxEndHour.Items.AddRange(new object[] {
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00"});
            this.metroComboBoxEndHour.Location = new System.Drawing.Point(278, 59);
            this.metroComboBoxEndHour.Margin = new System.Windows.Forms.Padding(5);
            this.metroComboBoxEndHour.Name = "metroComboBoxEndHour";
            this.metroComboBoxEndHour.Size = new System.Drawing.Size(60, 25);
            this.metroComboBoxEndHour.TabIndex = 24;
            this.metroComboBoxEndHour.UseSelectable = true;
            // 
            // metroDateTimeEndDate
            // 
            this.metroDateTimeEndDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroDateTimeEndDate.CustomFormat = "";
            this.metroDateTimeEndDate.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.metroDateTimeEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTimeEndDate.Location = new System.Drawing.Point(178, 59);
            this.metroDateTimeEndDate.Margin = new System.Windows.Forms.Padding(5);
            this.metroDateTimeEndDate.MinimumSize = new System.Drawing.Size(0, 25);
            this.metroDateTimeEndDate.Name = "metroDateTimeEndDate";
            this.metroDateTimeEndDate.Size = new System.Drawing.Size(90, 25);
            this.metroDateTimeEndDate.TabIndex = 25;
            // 
            // AcceptanceTestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(229)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(734, 434);
            this.ControlBox = false;
            this.Controls.Add(this.metroGridAcceptanceTests);
            this.Controls.Add(this.groupBox1);
            this.Name = "AcceptanceTestsForm";
            ((System.ComponentModel.ISupportInitialize)(this.metroGridAcceptanceTests)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGridAcceptanceTests;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxAcceptanceTestDescription;
        private MetroFramework.Controls.MetroButton metroButtonSave;
        private MetroFramework.Controls.MetroComboBox metroComboBoxServers;
        private MetroFramework.Controls.MetroDateTime metroDateTimeStartDate;
        private MetroFramework.Controls.MetroComboBox metroComboBoxStartHour;
        private MetroFramework.Controls.MetroComboBox metroComboBoxEndHour;
        private MetroFramework.Controls.MetroDateTime metroDateTimeEndDate;
        private System.Windows.Forms.DataGridViewButtonColumn CONCLUDI;
    }
}