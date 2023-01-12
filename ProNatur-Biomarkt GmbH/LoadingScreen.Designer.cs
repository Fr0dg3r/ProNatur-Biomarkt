
namespace ProNatur_Biomarkt_GmbH
{
    partial class LoadingScreen
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbarLoading = new System.Windows.Forms.ProgressBar();
            this.lblLoading = new System.Windows.Forms.Label();
            this.lblProgPercent = new System.Windows.Forms.Label();
            this.loadingbarTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pbarLoading
            // 
            this.pbarLoading.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbarLoading.Location = new System.Drawing.Point(30, 287);
            this.pbarLoading.Name = "pbarLoading";
            this.pbarLoading.Size = new System.Drawing.Size(619, 23);
            this.pbarLoading.TabIndex = 0;
            // 
            // lblLoading
            // 
            this.lblLoading.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblLoading.AutoSize = true;
            this.lblLoading.ForeColor = System.Drawing.Color.White;
            this.lblLoading.Location = new System.Drawing.Point(291, 271);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(45, 13);
            this.lblLoading.TabIndex = 1;
            this.lblLoading.Text = "Loading";
            // 
            // lblProgPercent
            // 
            this.lblProgPercent.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblProgPercent.AutoSize = true;
            this.lblProgPercent.ForeColor = System.Drawing.Color.White;
            this.lblProgPercent.Location = new System.Drawing.Point(342, 271);
            this.lblProgPercent.Name = "lblProgPercent";
            this.lblProgPercent.Size = new System.Drawing.Size(21, 13);
            this.lblProgPercent.TabIndex = 2;
            this.lblProgPercent.Text = "0%";
            // 
            // loadingbarTimer
            // 
            this.loadingbarTimer.Tick += new System.EventHandler(this.loadingbarTimer_Tick);
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(684, 322);
            this.ControlBox = false;
            this.Controls.Add(this.lblProgPercent);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.pbarLoading);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProNatur-Biomarkt GmbH";
            this.Load += new System.EventHandler(this.LoadingScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbarLoading;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label lblProgPercent;
        private System.Windows.Forms.Timer loadingbarTimer;
    }
}

