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
            this.lstHourly = new System.Windows.Forms.ListBox();
            this.lblLine = new System.Windows.Forms.Label();
            this.lstStop = new System.Windows.Forms.ListView();
            this.cmdQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStop
            // 
            this.lblStop.AutoSize = true;
            this.lblStop.Location = new System.Drawing.Point(346, 101);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(146, 20);
            this.lblStop.TabIndex = 0;
            this.lblStop.Text = "Arrêts et Intervalles";
            // 
            // lblHourly
            // 
            this.lblHourly.AutoSize = true;
            this.lblHourly.Location = new System.Drawing.Point(821, 101);
            this.lblHourly.Name = "lblHourly";
            this.lblHourly.Size = new System.Drawing.Size(144, 20);
            this.lblHourly.TabIndex = 1;
            this.lblHourly.Text = "Horaires de Départ";
            // 
            // lstHourly
            // 
            this.lstHourly.FormattingEnabled = true;
            this.lstHourly.ItemHeight = 20;
            this.lstHourly.Location = new System.Drawing.Point(810, 142);
            this.lstHourly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstHourly.Name = "lstHourly";
            this.lstHourly.Size = new System.Drawing.Size(176, 284);
            this.lstHourly.TabIndex = 3;
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Location = new System.Drawing.Point(61, 35);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(51, 20);
            this.lblLine.TabIndex = 4;
            this.lblLine.Text = "label1";
            // 
            // lstStop
            // 
            this.lstStop.HideSelection = false;
            this.lstStop.Location = new System.Drawing.Point(64, 142);
            this.lstStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstStop.Name = "lstStop";
            this.lstStop.Size = new System.Drawing.Size(680, 284);
            this.lstStop.TabIndex = 5;
            this.lstStop.UseCompatibleStateImageBehavior = false;
            // 
            // cmdQuit
            // 
            this.cmdQuit.Location = new System.Drawing.Point(64, 454);
            this.cmdQuit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdQuit.Name = "cmdQuit";
            this.cmdQuit.Size = new System.Drawing.Size(141, 46);
            this.cmdQuit.TabIndex = 6;
            this.cmdQuit.Text = "Quitter";
            this.cmdQuit.UseVisualStyleBackColor = true;
            this.cmdQuit.Click += new System.EventHandler(this.cmdQuit_Click);
            // 
            // PrintLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 519);
            this.Controls.Add(this.cmdQuit);
            this.Controls.Add(this.lstStop);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lstHourly);
            this.Controls.Add(this.lblHourly);
            this.Controls.Add(this.lblStop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PrintLine";
            this.Text = "Affichage Lignes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStop;
        private System.Windows.Forms.Label lblHourly;
        private System.Windows.Forms.ListBox lstHourly;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.ListView lstStop;
        private System.Windows.Forms.Button cmdQuit;
    }
}