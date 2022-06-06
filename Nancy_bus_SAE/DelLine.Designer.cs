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
            this.cboLine.Location = new System.Drawing.Point(21, 30);
            this.cboLine.Margin = new System.Windows.Forms.Padding(2);
            this.cboLine.Name = "cboLine";
            this.cboLine.Size = new System.Drawing.Size(209, 21);
            this.cboLine.TabIndex = 0;
            // 
            // cmdDel
            // 
            this.cmdDel.Location = new System.Drawing.Point(21, 172);
            this.cmdDel.Margin = new System.Windows.Forms.Padding(2);
            this.cmdDel.Name = "cmdDel";
            this.cmdDel.Size = new System.Drawing.Size(207, 21);
            this.cmdDel.TabIndex = 1;
            this.cmdDel.Text = "Supprimer";
            this.cmdDel.UseVisualStyleBackColor = true;
            this.cmdDel.Click += new System.EventHandler(this.cmdDel_Click);
            // 
            // cmdQuit
            // 
            this.cmdQuit.Location = new System.Drawing.Point(21, 213);
            this.cmdQuit.Margin = new System.Windows.Forms.Padding(2);
            this.cmdQuit.Name = "cmdQuit";
            this.cmdQuit.Size = new System.Drawing.Size(207, 21);
            this.cmdQuit.TabIndex = 2;
            this.cmdQuit.Text = "Quitter";
            this.cmdQuit.UseVisualStyleBackColor = true;
            this.cmdQuit.Click += new System.EventHandler(this.cmdQuit_Click);
            // 
            // DelLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 274);
            this.Controls.Add(this.cmdQuit);
            this.Controls.Add(this.cmdDel);
            this.Controls.Add(this.cboLine);
            this.Margin = new System.Windows.Forms.Padding(2);
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