namespace Reserver.Forms
{
    partial class ServerStatusForm
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
            this.panelServerStatus = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1Old = new MetroFramework.Controls.MetroLabel();
            this.buttonUpdateStatus = new System.Windows.Forms.Button();
            this.metroLabel1 = new System.Windows.Forms.Label();
            this.panelServerStatus.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelServerStatus
            // 
            this.panelServerStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(229)))), ((int)(((byte)(224)))));
            this.panelServerStatus.Controls.Add(this.metroLabel1Old);
            this.panelServerStatus.Controls.Add(this.metroPanel1);
            this.panelServerStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelServerStatus.HorizontalScrollbarBarColor = true;
            this.panelServerStatus.HorizontalScrollbarHighlightOnWheel = false;
            this.panelServerStatus.HorizontalScrollbarSize = 10;
            this.panelServerStatus.Location = new System.Drawing.Point(0, 0);
            this.panelServerStatus.Name = "panelServerStatus";
            this.panelServerStatus.Size = new System.Drawing.Size(734, 479);
            this.panelServerStatus.TabIndex = 3;
            this.panelServerStatus.UseCustomBackColor = true;
            this.panelServerStatus.VerticalScrollbarBarColor = true;
            this.panelServerStatus.VerticalScrollbarHighlightOnWheel = false;
            this.panelServerStatus.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(198)))), ((int)(((byte)(189)))));
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.buttonUpdateStatus);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(210, 15);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(330, 40);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1Old
            // 
            this.metroLabel1Old.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1Old.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1Old.Location = new System.Drawing.Point(424, 9);
            this.metroLabel1Old.Name = "metroLabel1Old";
            this.metroLabel1Old.Size = new System.Drawing.Size(298, 22);
            this.metroLabel1Old.TabIndex = 2;
            this.metroLabel1Old.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1Old.UseCustomBackColor = true;
            this.metroLabel1Old.Visible = false;
            // 
            // buttonUpdateStatus
            // 
            this.buttonUpdateStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdateStatus.BackColor = System.Drawing.Color.Transparent;
            this.buttonUpdateStatus.BackgroundImage = global::Reserver.Properties.Resources.refresh;
            this.buttonUpdateStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUpdateStatus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(198)))), ((int)(((byte)(189)))));
            this.buttonUpdateStatus.FlatAppearance.BorderSize = 0;
            this.buttonUpdateStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonUpdateStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonUpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateStatus.Location = new System.Drawing.Point(9, 8);
            this.buttonUpdateStatus.Margin = new System.Windows.Forms.Padding(9);
            this.buttonUpdateStatus.Name = "buttonUpdateStatus";
            this.buttonUpdateStatus.Size = new System.Drawing.Size(22, 22);
            this.buttonUpdateStatus.TabIndex = 1;
            this.buttonUpdateStatus.UseVisualStyleBackColor = true;
            this.buttonUpdateStatus.Click += new System.EventHandler(this.ButtonUpdateStatus_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(43, 8);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(278, 22);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ServerStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(229)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(734, 479);
            this.ControlBox = false;
            this.Controls.Add(this.panelServerStatus);
            this.Name = "ServerStatusForm";
            this.ShowIcon = false;
            this.panelServerStatus.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdateStatus;
        private MetroFramework.Controls.MetroPanel panelServerStatus;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1Old;
        private System.Windows.Forms.Label metroLabel1;
    }
}