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
            this.cboLine.Location = new System.Drawing.Point(14, 31);
            this.cboLine.Margin = new System.Windows.Forms.Padding(2);
            this.cboLine.Name = "cboLine";
            this.cboLine.Size = new System.Drawing.Size(193, 21);
            this.cboLine.TabIndex = 0;
            this.cboLine.SelectedIndexChanged += new System.EventHandler(this.cboLine_SelectedIndexChanged);
            // 
            // chkDelRef
            // 
            this.chkDelRef.AutoSize = true;
            this.chkDelRef.Location = new System.Drawing.Point(14, 66);
            this.chkDelRef.Margin = new System.Windows.Forms.Padding(2);
            this.chkDelRef.Name = "chkDelRef";
            this.chkDelRef.Size = new System.Drawing.Size(174, 17);
            this.chkDelRef.TabIndex = 1;
            this.chkDelRef.Text = "Supprimer toutes les références";
            this.chkDelRef.UseVisualStyleBackColor = true;
            // 
            // cboStop
            // 
            this.cboStop.FormattingEnabled = true;
            this.cboStop.Location = new System.Drawing.Point(14, 122);
            this.cboStop.Margin = new System.Windows.Forms.Padding(2);
            this.cboStop.Name = "cboStop";
            this.cboStop.Size = new System.Drawing.Size(193, 21);
            this.cboStop.TabIndex = 2;
            this.cboStop.SelectedIndexChanged += new System.EventHandler(this.cboStop_SelectedIndexChanged);
            // 
            // cmdDel
            // 
            this.cmdDel.Location = new System.Drawing.Point(14, 190);
            this.cmdDel.Margin = new System.Windows.Forms.Padding(2);
            this.cmdDel.Name = "cmdDel";
            this.cmdDel.Size = new System.Drawing.Size(191, 27);
            this.cmdDel.TabIndex = 3;
            this.cmdDel.Text = "Supprimer";
            this.cmdDel.UseVisualStyleBackColor = true;
            this.cmdDel.Click += new System.EventHandler(this.cmdDel_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(14, 234);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(2);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(191, 27);
            this.cmdCancel.TabIndex = 4;
            this.cmdCancel.Text = "Annuler";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // DelStop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 292);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdDel);
            this.Controls.Add(this.cboStop);
            this.Controls.Add(this.chkDelRef);
            this.Controls.Add(this.cboLine);
            this.Margin = new System.Windows.Forms.Padding(2);
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