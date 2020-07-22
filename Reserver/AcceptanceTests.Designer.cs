namespace Reserver
{
    partial class AcceptanceTests
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroDateTimeEndDate = new MetroFramework.Controls.MetroDateTime();
            this.metroComboBoxEndHour = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxStartHour = new MetroFramework.Controls.MetroComboBox();
            this.metroDateTimeStartDate = new MetroFramework.Controls.MetroDateTime();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroTextBoxAcceptanceTestDescription = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonSave = new MetroFramework.Controls.MetroButton();
            this.metroComboBoxServers = new MetroFramework.Controls.MetroComboBox();
            this.metroGridAcceptanceTests = new MetroFramework.Controls.MetroGrid();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridAcceptanceTests)).BeginInit();
            this.SuspendLayout();
            // 
            // metroDateTimeEndDate
            // 
            this.metroDateTimeEndDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroDateTimeEndDate.CustomFormat = "";
            this.metroDateTimeEndDate.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.metroDateTimeEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTimeEndDate.Location = new System.Drawing.Point(221, 59);
            this.metroDateTimeEndDate.Margin = new System.Windows.Forms.Padding(5);
            this.metroDateTimeEndDate.MinimumSize = new System.Drawing.Size(0, 25);
            this.metroDateTimeEndDate.Name = "metroDateTimeEndDate";
            this.metroDateTimeEndDate.Size = new System.Drawing.Size(90, 25);
            this.metroDateTimeEndDate.TabIndex = 25;
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
            this.metroComboBoxEndHour.Location = new System.Drawing.Point(321, 59);
            this.metroComboBoxEndHour.Margin = new System.Windows.Forms.Padding(5);
            this.metroComboBoxEndHour.Name = "metroComboBoxEndHour";
            this.metroComboBoxEndHour.Size = new System.Drawing.Size(60, 25);
            this.metroComboBoxEndHour.TabIndex = 24;
            this.metroComboBoxEndHour.UseSelectable = true;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroTextBoxAcceptanceTestDescription);
            this.groupBox1.Controls.Add(this.metroButtonSave);
            this.groupBox1.Controls.Add(this.metroComboBoxServers);
            this.groupBox1.Controls.Add(this.metroDateTimeStartDate);
            this.groupBox1.Controls.Add(this.metroComboBoxStartHour);
            this.groupBox1.Controls.Add(this.metroComboBoxEndHour);
            this.groupBox1.Controls.Add(this.metroDateTimeEndDate);
            this.groupBox1.Location = new System.Drawing.Point(18, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 92);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuovo Collaudo";
            // 
            // metroTextBoxAcceptanceTestDescription
            // 
            // 
            // 
            // 
            this.metroTextBoxAcceptanceTestDescription.CustomButton.Image = null;
            this.metroTextBoxAcceptanceTestDescription.CustomButton.Location = new System.Drawing.Point(294, 1);
            this.metroTextBoxAcceptanceTestDescription.CustomButton.Name = "";
            this.metroTextBoxAcceptanceTestDescription.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxAcceptanceTestDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxAcceptanceTestDescription.CustomButton.TabIndex = 1;
            this.metroTextBoxAcceptanceTestDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxAcceptanceTestDescription.CustomButton.UseSelectable = true;
            this.metroTextBoxAcceptanceTestDescription.CustomButton.Visible = false;
            this.metroTextBoxAcceptanceTestDescription.Lines = new string[0];
            this.metroTextBoxAcceptanceTestDescription.Location = new System.Drawing.Point(221, 21);
            this.metroTextBoxAcceptanceTestDescription.Margin = new System.Windows.Forms.Padding(5);
            this.metroTextBoxAcceptanceTestDescription.MaxLength = 32767;
            this.metroTextBoxAcceptanceTestDescription.Name = "metroTextBoxAcceptanceTestDescription";
            this.metroTextBoxAcceptanceTestDescription.PasswordChar = '\0';
            this.metroTextBoxAcceptanceTestDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxAcceptanceTestDescription.SelectedText = "";
            this.metroTextBoxAcceptanceTestDescription.SelectionLength = 0;
            this.metroTextBoxAcceptanceTestDescription.SelectionStart = 0;
            this.metroTextBoxAcceptanceTestDescription.ShortcutsEnabled = true;
            this.metroTextBoxAcceptanceTestDescription.Size = new System.Drawing.Size(316, 23);
            this.metroTextBoxAcceptanceTestDescription.TabIndex = 44;
            this.metroTextBoxAcceptanceTestDescription.UseSelectable = true;
            this.metroTextBoxAcceptanceTestDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxAcceptanceTestDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButtonSave
            // 
            this.metroButtonSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroButtonSave.Location = new System.Drawing.Point(558, 61);
            this.metroButtonSave.Margin = new System.Windows.Forms.Padding(5);
            this.metroButtonSave.Name = "metroButtonSave";
            this.metroButtonSave.Size = new System.Drawing.Size(75, 23);
            this.metroButtonSave.TabIndex = 43;
            this.metroButtonSave.Text = "Salva";
            this.metroButtonSave.UseSelectable = true;
            this.metroButtonSave.Click += new System.EventHandler(this.metroButtonSave_Click);
            // 
            // metroComboBoxServers
            // 
            this.metroComboBoxServers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBoxServers.FormattingEnabled = true;
            this.metroComboBoxServers.ItemHeight = 23;
            this.metroComboBoxServers.Location = new System.Drawing.Point(8, 19);
            this.metroComboBoxServers.Margin = new System.Windows.Forms.Padding(5);
            this.metroComboBoxServers.Name = "metroComboBoxServers";
            this.metroComboBoxServers.Size = new System.Drawing.Size(182, 29);
            this.metroComboBoxServers.TabIndex = 43;
            this.metroComboBoxServers.UseSelectable = true;
            // 
            // metroGridAcceptanceTests
            // 
            this.metroGridAcceptanceTests.AllowUserToAddRows = false;
            this.metroGridAcceptanceTests.AllowUserToDeleteRows = false;
            this.metroGridAcceptanceTests.AllowUserToResizeColumns = false;
            this.metroGridAcceptanceTests.AllowUserToResizeRows = false;
            this.metroGridAcceptanceTests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGridAcceptanceTests.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridAcceptanceTests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridAcceptanceTests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridAcceptanceTests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridAcceptanceTests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridAcceptanceTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(134)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridAcceptanceTests.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridAcceptanceTests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.metroGridAcceptanceTests.EnableHeadersVisualStyles = false;
            this.metroGridAcceptanceTests.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridAcceptanceTests.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridAcceptanceTests.Location = new System.Drawing.Point(18, 127);
            this.metroGridAcceptanceTests.Name = "metroGridAcceptanceTests";
            this.metroGridAcceptanceTests.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridAcceptanceTests.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridAcceptanceTests.RowHeadersWidth = 15;
            this.metroGridAcceptanceTests.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridAcceptanceTests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.metroGridAcceptanceTests.Size = new System.Drawing.Size(640, 254);
            this.metroGridAcceptanceTests.TabIndex = 42;
            // 
            // AcceptanceTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(134)))), ((int)(((byte)(163)))));
            this.Controls.Add(this.metroGridAcceptanceTests);
            this.Controls.Add(this.groupBox1);
            this.Name = "AcceptanceTests";
            this.Size = new System.Drawing.Size(680, 400);
            this.Load += new System.EventHandler(this.AcceptanceTests_Load);
            this.Enter += new System.EventHandler(this.AcceptanceTests_Enter);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridAcceptanceTests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroDateTime metroDateTimeEndDate;
        private MetroFramework.Controls.MetroComboBox metroComboBoxEndHour;
        private MetroFramework.Controls.MetroComboBox metroComboBoxStartHour;
        private MetroFramework.Controls.MetroDateTime metroDateTimeStartDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroComboBox metroComboBoxServers;
        private MetroFramework.Controls.MetroButton metroButtonSave;
        private MetroFramework.Controls.MetroTextBox metroTextBoxAcceptanceTestDescription;
        private MetroFramework.Controls.MetroGrid metroGridAcceptanceTests;
    }
}
