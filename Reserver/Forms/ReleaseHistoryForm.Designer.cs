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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridReleaseHistory = new MetroFramework.Controls.MetroGrid();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridReleaseHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridReleaseHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(134)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridReleaseHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridReleaseHistory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridReleaseHistory.EnableHeadersVisualStyles = false;
            this.gridReleaseHistory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridReleaseHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridReleaseHistory.Location = new System.Drawing.Point(12, 84);
            this.gridReleaseHistory.Name = "gridReleaseHistory";
            this.gridReleaseHistory.ReadOnly = true;
            this.gridReleaseHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridReleaseHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridReleaseHistory.RowHeadersWidth = 15;
            this.gridReleaseHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridReleaseHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridReleaseHistory.Size = new System.Drawing.Size(710, 338);
            this.gridReleaseHistory.TabIndex = 44;
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFilter.Controls.Add(this.comboBoxUsers);
            this.groupBoxFilter.Controls.Add(this.buttonFilter);
            this.groupBoxFilter.Controls.Add(this.comboBoxServers);
            this.groupBoxFilter.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(710, 66);
            this.groupBoxFilter.TabIndex = 45;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filtri";
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.ItemHeight = 23;
            this.comboBoxUsers.Location = new System.Drawing.Point(238, 21);
            this.comboBoxUsers.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(220, 29);
            this.comboBoxUsers.TabIndex = 46;
            this.comboBoxUsers.UseSelectable = true;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFilter.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonFilter.Location = new System.Drawing.Point(627, 21);
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
            this.comboBoxServers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxServers.FormattingEnabled = true;
            this.comboBoxServers.ItemHeight = 23;
            this.comboBoxServers.Location = new System.Drawing.Point(8, 21);
            this.comboBoxServers.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxServers.Name = "comboBoxServers";
            this.comboBoxServers.Size = new System.Drawing.Size(220, 29);
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
    }
}