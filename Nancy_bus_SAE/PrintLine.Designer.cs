namespace Nancy_bus_SAE
{
    partial class PrintLine
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
            this.lblStop = new System.Windows.Forms.Label();
            this.lblHourly = new System.Windows.Forms.Label();
            this.lstStop = new System.Windows.Forms.ListBox();
            this.lstHourly = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblStop
            // 
            this.lblStop.AutoSize = true;
            this.lblStop.Location = new System.Drawing.Point(60, 62);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(146, 20);
            this.lblStop.TabIndex = 0;
            this.lblStop.Text = "Arrêts et Intervalles";
            // 
            // lblHourly
            // 
            this.lblHourly.AutoSize = true;
            this.lblHourly.Location = new System.Drawing.Point(310, 62);
            this.lblHourly.Name = "lblHourly";
            this.lblHourly.Size = new System.Drawing.Size(144, 20);
            this.lblHourly.TabIndex = 1;
            this.lblHourly.Text = "Horaires de Départ";
            // 
            // lstStop
            // 
            this.lstStop.FormattingEnabled = true;
            this.lstStop.ItemHeight = 20;
            this.lstStop.Location = new System.Drawing.Point(48, 121);
            this.lstStop.Name = "lstStop";
            this.lstStop.Size = new System.Drawing.Size(173, 304);
            this.lstStop.TabIndex = 2;
            // 
            // lstHourly
            // 
            this.lstHourly.FormattingEnabled = true;
            this.lstHourly.ItemHeight = 20;
            this.lstHourly.Location = new System.Drawing.Point(298, 121);
            this.lstHourly.Name = "lstHourly";
            this.lstHourly.Size = new System.Drawing.Size(173, 304);
            this.lstHourly.TabIndex = 3;
            // 
            // PrintLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 450);
            this.Controls.Add(this.lstHourly);
            this.Controls.Add(this.lstStop);
            this.Controls.Add(this.lblHourly);
            this.Controls.Add(this.lblStop);
            this.Name = "PrintLine";
            this.Text = "Affichage Lignes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStop;
        private System.Windows.Forms.Label lblHourly;
        private System.Windows.Forms.ListBox lstStop;
        private System.Windows.Forms.ListBox lstHourly;
    }
}