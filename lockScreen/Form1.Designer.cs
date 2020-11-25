namespace lockScreen
{
    partial class freezeScreen
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblMsg = new System.Windows.Forms.Label();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.BackColor = System.Drawing.Color.DarkGray;
            this.lblMsg.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(0, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(880, 172);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "Security Screen";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMsg.Click += new System.EventHandler(this.lblMsg_Click);
            // 
            // tmr
            // 
            this.tmr.Enabled = true;
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.LightGray;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(0, 172);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(880, 338);
            this.lblTime.TabIndex = 1;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // freezeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 510);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "freezeScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Freeze Screen";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.freezeScreen_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.freezeScreen_FormClosed);
            this.Load += new System.EventHandler(this.freezeScreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.freezeScreen_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.freezeScreen_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Label lblTime;
    }
}

