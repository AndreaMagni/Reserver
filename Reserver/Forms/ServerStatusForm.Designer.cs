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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerStatusForm));
            this.buttonUpdateStatus = new System.Windows.Forms.Button();
            this.panelServerStatus = new MetroFramework.Controls.MetroPanel();
            this.metroScrollBar1 = new MetroFramework.Controls.MetroScrollBar();
            this.panelServerStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUpdateStatus
            // 
            this.buttonUpdateStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdateStatus.BackColor = System.Drawing.Color.Transparent;
            this.buttonUpdateStatus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUpdateStatus.BackgroundImage")));
            this.buttonUpdateStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUpdateStatus.Location = new System.Drawing.Point(662, 12);
            this.buttonUpdateStatus.Margin = new System.Windows.Forms.Padding(15);
            this.buttonUpdateStatus.Name = "buttonUpdateStatus";
            this.buttonUpdateStatus.Size = new System.Drawing.Size(32, 32);
            this.buttonUpdateStatus.TabIndex = 1;
            this.buttonUpdateStatus.UseVisualStyleBackColor = true;
            // 
            // panelServerStatus
            // 
            this.panelServerStatus.AutoScroll = true;
            this.panelServerStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.panelServerStatus.Controls.Add(this.buttonUpdateStatus);
            this.panelServerStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelServerStatus.HorizontalScrollbar = true;
            this.panelServerStatus.HorizontalScrollbarBarColor = true;
            this.panelServerStatus.HorizontalScrollbarHighlightOnWheel = false;
            this.panelServerStatus.HorizontalScrollbarSize = 10;
            this.panelServerStatus.Location = new System.Drawing.Point(0, 0);
            this.panelServerStatus.Name = "panelServerStatus";
            this.panelServerStatus.Size = new System.Drawing.Size(734, 434);
            this.panelServerStatus.TabIndex = 3;
            this.panelServerStatus.UseCustomBackColor = true;
            this.panelServerStatus.VerticalScrollbar = true;
            this.panelServerStatus.VerticalScrollbarBarColor = true;
            this.panelServerStatus.VerticalScrollbarHighlightOnWheel = false;
            this.panelServerStatus.VerticalScrollbarSize = 10;
            // 
            // metroScrollBar1
            // 
            this.metroScrollBar1.LargeChange = 10;
            this.metroScrollBar1.Location = new System.Drawing.Point(712, 12);
            this.metroScrollBar1.Maximum = 100;
            this.metroScrollBar1.Minimum = 0;
            this.metroScrollBar1.MouseWheelBarPartitions = 10;
            this.metroScrollBar1.Name = "metroScrollBar1";
            this.metroScrollBar1.Orientation = MetroFramework.Controls.MetroScrollOrientation.Vertical;
            this.metroScrollBar1.ScrollbarSize = 10;
            this.metroScrollBar1.Size = new System.Drawing.Size(10, 50);
            this.metroScrollBar1.TabIndex = 4;
            this.metroScrollBar1.UseSelectable = true;
            this.metroScrollBar1.Visible = false;
            // 
            // ServerStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(734, 434);
            this.ControlBox = false;
            this.Controls.Add(this.metroScrollBar1);
            this.Controls.Add(this.panelServerStatus);
            this.Name = "ServerStatusForm";
            this.ShowIcon = false;
            this.panelServerStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdateStatus;
        private MetroFramework.Controls.MetroPanel panelServerStatus;
        private MetroFramework.Controls.MetroScrollBar metroScrollBar1;
    }
}