namespace Nancy_bus_SAE
{
    partial class DelStop
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
            this.cboLine = new System.Windows.Forms.ComboBox();
            this.chkDelRef = new System.Windows.Forms.CheckBox();
            this.cboStop = new System.Windows.Forms.ComboBox();
            this.cmdDel = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboLine
            // 
            this.cboLine.FormattingEnabled = true;
            this.cboLine.Location = new System.Drawing.Point(21, 48);
            this.cboLine.Name = "cboLine";
            this.cboLine.Size = new System.Drawing.Size(287, 28);
            this.cboLine.TabIndex = 0;
            // 
            // chkDelRef
            // 
            this.chkDelRef.AutoSize = true;
            this.chkDelRef.Location = new System.Drawing.Point(21, 102);
            this.chkDelRef.Name = "chkDelRef";
            this.chkDelRef.Size = new System.Drawing.Size(261, 24);
            this.chkDelRef.TabIndex = 1;
            this.chkDelRef.Text = "Supprimer toutes les références";
            this.chkDelRef.UseVisualStyleBackColor = true;
            // 
            // cboStop
            // 
            this.cboStop.FormattingEnabled = true;
            this.cboStop.Location = new System.Drawing.Point(21, 188);
            this.cboStop.Name = "cboStop";
            this.cboStop.Size = new System.Drawing.Size(287, 28);
            this.cboStop.TabIndex = 2;
            // 
            // cmdDel
            // 
            this.cmdDel.Location = new System.Drawing.Point(21, 293);
            this.cmdDel.Name = "cmdDel";
            this.cmdDel.Size = new System.Drawing.Size(287, 42);
            this.cmdDel.TabIndex = 3;
            this.cmdDel.Text = "Supprimer";
            this.cmdDel.UseVisualStyleBackColor = true;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(21, 360);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(287, 42);
            this.cmdCancel.TabIndex = 4;
            this.cmdCancel.Text = "Annuler";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // DelStop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 450);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdDel);
            this.Controls.Add(this.cboStop);
            this.Controls.Add(this.chkDelRef);
            this.Controls.Add(this.cboLine);
            this.Name = "DelStop";
            this.Text = "Supprimer Arrêt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboLine;
        private System.Windows.Forms.CheckBox chkDelRef;
        private System.Windows.Forms.ComboBox cboStop;
        private System.Windows.Forms.Button cmdDel;
        private System.Windows.Forms.Button cmdCancel;
    }
}