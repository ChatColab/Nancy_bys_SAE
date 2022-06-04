namespace Nancy_bus_SAE
{
    partial class DelLine
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
            this.cmdDel = new System.Windows.Forms.Button();
            this.cmdQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboLine
            // 
            this.cboLine.FormattingEnabled = true;
            this.cboLine.Location = new System.Drawing.Point(31, 46);
            this.cboLine.Name = "cboLine";
            this.cboLine.Size = new System.Drawing.Size(311, 28);
            this.cboLine.TabIndex = 0;
            // 
            // cmdDel
            // 
            this.cmdDel.Location = new System.Drawing.Point(31, 265);
            this.cmdDel.Name = "cmdDel";
            this.cmdDel.Size = new System.Drawing.Size(311, 32);
            this.cmdDel.TabIndex = 1;
            this.cmdDel.Text = "Supprimer";
            this.cmdDel.UseVisualStyleBackColor = true;
            // 
            // cmdQuit
            // 
            this.cmdQuit.Location = new System.Drawing.Point(31, 327);
            this.cmdQuit.Name = "cmdQuit";
            this.cmdQuit.Size = new System.Drawing.Size(311, 32);
            this.cmdQuit.TabIndex = 2;
            this.cmdQuit.Text = "Quitter";
            this.cmdQuit.UseVisualStyleBackColor = true;
            // 
            // DelLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 421);
            this.Controls.Add(this.cmdQuit);
            this.Controls.Add(this.cmdDel);
            this.Controls.Add(this.cboLine);
            this.Name = "DelLine";
            this.Text = "Supprimer une Ligne";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboLine;
        private System.Windows.Forms.Button cmdDel;
        private System.Windows.Forms.Button cmdQuit;
    }
}