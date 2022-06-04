namespace Nancy_bus_SAE
{
    partial class DelStopX
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
            this.lblLine = new System.Windows.Forms.Label();
            this.lblPrevStop = new System.Windows.Forms.Label();
            this.lblNextStop = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdValidate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Location = new System.Drawing.Point(231, 40);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(63, 20);
            this.lblLine.TabIndex = 0;
            this.lblLine.Text = "Ligne X";
            // 
            // lblPrevStop
            // 
            this.lblPrevStop.AutoSize = true;
            this.lblPrevStop.Location = new System.Drawing.Point(41, 8);
            this.lblPrevStop.Name = "lblPrevStop";
            this.lblPrevStop.Size = new System.Drawing.Size(59, 20);
            this.lblPrevStop.TabIndex = 1;
            this.lblPrevStop.Text = "Arret A";
            // 
            // lblNextStop
            // 
            this.lblNextStop.AutoSize = true;
            this.lblNextStop.Location = new System.Drawing.Point(41, 89);
            this.lblNextStop.Name = "lblNextStop";
            this.lblNextStop.Size = new System.Drawing.Size(59, 20);
            this.lblNextStop.TabIndex = 2;
            this.lblNextStop.Text = "Arret B";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(35, 45);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(78, 26);
            this.numericUpDown1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.lblPrevStop);
            this.panel1.Controls.Add(this.lblNextStop);
            this.panel1.Location = new System.Drawing.Point(190, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 118);
            this.panel1.TabIndex = 4;
            // 
            // cmdValidate
            // 
            this.cmdValidate.Location = new System.Drawing.Point(190, 287);
            this.cmdValidate.Name = "cmdValidate";
            this.cmdValidate.Size = new System.Drawing.Size(148, 30);
            this.cmdValidate.TabIndex = 5;
            this.cmdValidate.Text = "Valider";
            this.cmdValidate.UseVisualStyleBackColor = true;
            // 
            // DelStopX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 371);
            this.Controls.Add(this.cmdValidate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblLine);
            this.Name = "DelStopX";
            this.Text = "Supprimer Arrêt X";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblPrevStop;
        private System.Windows.Forms.Label lblNextStop;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdValidate;
    }
}