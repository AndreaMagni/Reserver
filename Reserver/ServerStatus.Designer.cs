namespace Reserver
{
    partial class ServerStatus
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
            this.buttonUpdateStatus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUpdateStatus
            // 
            this.buttonUpdateStatus.Location = new System.Drawing.Point(609, 18);
            this.buttonUpdateStatus.Name = "buttonUpdateStatus";
            this.buttonUpdateStatus.Size = new System.Drawing.Size(54, 23);
            this.buttonUpdateStatus.TabIndex = 0;
            this.buttonUpdateStatus.Text = "Update";
            this.buttonUpdateStatus.UseVisualStyleBackColor = true;
            this.buttonUpdateStatus.Click += new System.EventHandler(this.ButtonUpdateStatus_Click);
            // 
            // ServerStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.Controls.Add(this.buttonUpdateStatus);
            this.Name = "ServerStatus";
            this.Size = new System.Drawing.Size(680, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdateStatus;
    }
}
