namespace Reserver.Forms
{
    partial class ReleaseHistoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridReleaseHistory = new MetroFramework.Controls.MetroGrid();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.dateTimeA = new MetroFramework.Controls.MetroDateTime();
            this.dateTimeDa = new MetroFramework.Controls.MetroDateTime();
            this.comboBoxUsers = new MetroFramework.Controls.MetroComboBox();
            this.buttonFilter = new MetroFramework.Controls.MetroButton();
            this.comboBoxServers = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridReleaseHistory)).BeginInit();
            this.groupBoxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridReleaseHistory
            // 
            this.gridReleaseHistory.AllowUserToAddRows = false;
            this.gridReleaseHistory.AllowUserToDeleteRows = false;
            this.gridReleaseHistory.AllowUserToResizeRows = false;
            this.gridReleaseHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridReleaseHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridReleaseHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridReleaseHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridReleaseHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridReleaseHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridReleaseHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.gridReleaseHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(134)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridReleaseHistory.DefaultCellStyle = dataGridViewCellStyle14;
            this.gridReleaseHistory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridReleaseHistory.EnableHeadersVisualStyles = false;
            this.gridReleaseHistory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridReleaseHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridReleaseHistory.Location = new System.Drawing.Point(12, 116);
            this.gridReleaseHistory.Name = "gridReleaseHistory";
            this.gridReleaseHistory.ReadOnly = true;
            this.gridReleaseHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridReleaseHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.gridReleaseHistory.RowHeadersWidth = 15;
            this.gridReleaseHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridReleaseHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridReleaseHistory.Size = new System.Drawing.Size(710, 306);
            this.gridReleaseHistory.TabIndex = 44;
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFilter.Controls.Add(this.dateTimeA);
            this.groupBoxFilter.Controls.Add(this.dateTimeDa);
            this.groupBoxFilter.Controls.Add(this.comboBoxUsers);
            this.groupBoxFilter.Controls.Add(this.buttonFilter);
            this.groupBoxFilter.Controls.Add(this.comboBoxServers);
            this.groupBoxFilter.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(710, 98);
            this.groupBoxFilter.TabIndex = 45;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filtri";
            // 
            // dateTimeA
            // 
            this.dateTimeA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeA.Location = new System.Drawing.Point(268, 58);
            this.dateTimeA.MinimumSize = new System.Drawing.Size(0, 25);
            this.dateTimeA.Name = "dateTimeA";
            this.dateTimeA.Size = new System.Drawing.Size(250, 29);
            this.dateTimeA.TabIndex = 48;
            // 
            // dateTimeDa
            // 
            this.dateTimeDa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDa.Location = new System.Drawing.Point(8, 58);
            this.dateTimeDa.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimeDa.Name = "dateTimeDa";
            this.dateTimeDa.Size = new System.Drawing.Size(250, 29);
            this.dateTimeDa.TabIndex = 47;
            this.dateTimeDa.Value = new System.DateTime(2020, 9, 1, 0, 0, 0, 0);
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.ItemHeight = 23;
            this.comboBoxUsers.Location = new System.Drawing.Point(268, 21);
            this.comboBoxUsers.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(250, 29);
            this.comboBoxUsers.TabIndex = 46;
            this.comboBoxUsers.UseSelectable = true;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFilter.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonFilter.Location = new System.Drawing.Point(585, 38);
            this.buttonFilter.Margin = new System.Windows.Forms.Padding(5);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(75, 29);
            this.buttonFilter.TabIndex = 45;
            this.buttonFilter.Text = "Filtra";
            this.buttonFilter.UseSelectable = true;
            this.buttonFilter.Click += new System.EventHandler(this.ButtonFilter_Click);
            // 
            // comboBoxServers
            // 
            this.comboBoxServers.DisplayMember = "df";
            this.comboBoxServers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxServers.FormattingEnabled = true;
            this.comboBoxServers.ItemHeight = 23;
            this.comboBoxServers.Location = new System.Drawing.Point(8, 21);
            this.comboBoxServers.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxServers.Name = "comboBoxServers";
            this.comboBoxServers.Size = new System.Drawing.Size(250, 29);
            this.comboBoxServers.TabIndex = 44;
            this.comboBoxServers.UseSelectable = true;
            // 
            // ReleaseHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(734, 434);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxFilter);
            this.Controls.Add(this.gridReleaseHistory);
            this.Name = "ReleaseHistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridReleaseHistory)).EndInit();
            this.groupBoxFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid gridReleaseHistory;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private MetroFramework.Controls.MetroComboBox comboBoxUsers;
        private MetroFramework.Controls.MetroButton buttonFilter;
        private MetroFramework.Controls.MetroComboBox comboBoxServers;
        private MetroFramework.Controls.MetroDateTime dateTimeDa;
        private MetroFramework.Controls.MetroDateTime dateTimeA;
    }
}