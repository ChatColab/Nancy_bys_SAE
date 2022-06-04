namespace Nancy_bus_SAE
{
    partial class Modify
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblFirstStopInput = new System.Windows.Forms.Label();
            this.lblNextStopInput = new System.Windows.Forms.Label();
            this.cmdValidate = new System.Windows.Forms.Button();
            this.cmdQuit = new System.Windows.Forms.Button();
            this.lblModifyStop = new System.Windows.Forms.Label();
            this.lblNewValue = new System.Windows.Forms.Label();
            this.nudNewValue = new System.Windows.Forms.NumericUpDown();
            this.lblFirstStop = new System.Windows.Forms.Label();
            this.lblNextStop = new System.Windows.Forms.Label();
            this.lblArrow = new System.Windows.Forms.Label();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cboFirstStopInput = new System.Windows.Forms.ComboBox();
            this.cboNextStopInput = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewValue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saisir les arrêts concernés";
            // 
            // lblFirstStopInput
            // 
            this.lblFirstStopInput.AutoSize = true;
            this.lblFirstStopInput.Location = new System.Drawing.Point(43, 80);
            this.lblFirstStopInput.Name = "lblFirstStopInput";
            this.lblFirstStopInput.Size = new System.Drawing.Size(160, 20);
            this.lblFirstStopInput.TabIndex = 1;
            this.lblFirstStopInput.Text = "Saisir le premier Arrêt";
            // 
            // lblNextStopInput
            // 
            this.lblNextStopInput.AutoSize = true;
            this.lblNextStopInput.Location = new System.Drawing.Point(43, 234);
            this.lblNextStopInput.Name = "lblNextStopInput";
            this.lblNextStopInput.Size = new System.Drawing.Size(147, 20);
            this.lblNextStopInput.TabIndex = 2;
            this.lblNextStopInput.Text = "Saisir l\'Arrêt suivant";
            // 
            // cmdValidate
            // 
            this.cmdValidate.Location = new System.Drawing.Point(43, 333);
            this.cmdValidate.Name = "cmdValidate";
            this.cmdValidate.Size = new System.Drawing.Size(160, 37);
            this.cmdValidate.TabIndex = 5;
            this.cmdValidate.Text = "Valider";
            this.cmdValidate.UseVisualStyleBackColor = true;
            // 
            // cmdQuit
            // 
            this.cmdQuit.Location = new System.Drawing.Point(43, 393);
            this.cmdQuit.Name = "cmdQuit";
            this.cmdQuit.Size = new System.Drawing.Size(160, 37);
            this.cmdQuit.TabIndex = 6;
            this.cmdQuit.Text = "Quitter";
            this.cmdQuit.UseVisualStyleBackColor = true;
            // 
            // lblModifyStop
            // 
            this.lblModifyStop.AutoSize = true;
            this.lblModifyStop.Location = new System.Drawing.Point(341, 31);
            this.lblModifyStop.Name = "lblModifyStop";
            this.lblModifyStop.Size = new System.Drawing.Size(136, 20);
            this.lblModifyStop.TabIndex = 7;
            this.lblModifyStop.Text = "Modifier les Arrêts";
            // 
            // lblNewValue
            // 
            this.lblNewValue.AutoSize = true;
            this.lblNewValue.Location = new System.Drawing.Point(341, 80);
            this.lblNewValue.Name = "lblNewValue";
            this.lblNewValue.Size = new System.Drawing.Size(115, 20);
            this.lblNewValue.TabIndex = 8;
            this.lblNewValue.Text = "Nouvelle valeur";
            // 
            // nudNewValue
            // 
            this.nudNewValue.Location = new System.Drawing.Point(345, 117);
            this.nudNewValue.Name = "nudNewValue";
            this.nudNewValue.Size = new System.Drawing.Size(120, 26);
            this.nudNewValue.TabIndex = 9;
            // 
            // lblFirstStop
            // 
            this.lblFirstStop.AutoSize = true;
            this.lblFirstStop.Location = new System.Drawing.Point(345, 188);
            this.lblFirstStop.Name = "lblFirstStop";
            this.lblFirstStop.Size = new System.Drawing.Size(51, 20);
            this.lblFirstStop.TabIndex = 10;
            this.lblFirstStop.Text = "label2";
            // 
            // lblNextStop
            // 
            this.lblNextStop.AutoSize = true;
            this.lblNextStop.Location = new System.Drawing.Point(461, 188);
            this.lblNextStop.Name = "lblNextStop";
            this.lblNextStop.Size = new System.Drawing.Size(51, 20);
            this.lblNextStop.TabIndex = 11;
            this.lblNextStop.Text = "label2";
            // 
            // lblArrow
            // 
            this.lblArrow.AutoSize = true;
            this.lblArrow.Location = new System.Drawing.Point(402, 188);
            this.lblArrow.Name = "lblArrow";
            this.lblArrow.Size = new System.Drawing.Size(38, 20);
            this.lblArrow.TabIndex = 12;
            this.lblArrow.Text = "---->";
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(345, 333);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(179, 37);
            this.cmdSave.TabIndex = 13;
            this.cmdSave.Text = "Valider et Enregistrer";
            this.cmdSave.UseVisualStyleBackColor = true;
            // 
            // cboFirstStopInput
            // 
            this.cboFirstStopInput.FormattingEnabled = true;
            this.cboFirstStopInput.Location = new System.Drawing.Point(47, 117);
            this.cboFirstStopInput.Name = "cboFirstStopInput";
            this.cboFirstStopInput.Size = new System.Drawing.Size(156, 28);
            this.cboFirstStopInput.TabIndex = 14;
            // 
            // cboNextStopInput
            // 
            this.cboNextStopInput.FormattingEnabled = true;
            this.cboNextStopInput.Location = new System.Drawing.Point(47, 257);
            this.cboNextStopInput.Name = "cboNextStopInput";
            this.cboNextStopInput.Size = new System.Drawing.Size(156, 28);
            this.cboNextStopInput.TabIndex = 15;
            // 
            // Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboNextStopInput);
            this.Controls.Add(this.cboFirstStopInput);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.lblArrow);
            this.Controls.Add(this.lblNextStop);
            this.Controls.Add(this.lblFirstStop);
            this.Controls.Add(this.nudNewValue);
            this.Controls.Add(this.lblNewValue);
            this.Controls.Add(this.lblModifyStop);
            this.Controls.Add(this.cmdQuit);
            this.Controls.Add(this.cmdValidate);
            this.Controls.Add(this.lblNextStopInput);
            this.Controls.Add(this.lblFirstStopInput);
            this.Controls.Add(this.label1);
            this.Name = "Modify";
            this.Text = "Modifier l\'intervalle de temps entre 2 arrêts";
            ((System.ComponentModel.ISupportInitialize)(this.nudNewValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFirstStopInput;
        private System.Windows.Forms.Label lblNextStopInput;
        private System.Windows.Forms.Button cmdValidate;
        private System.Windows.Forms.Button cmdQuit;
        private System.Windows.Forms.Label lblModifyStop;
        private System.Windows.Forms.Label lblNewValue;
        private System.Windows.Forms.NumericUpDown nudNewValue;
        private System.Windows.Forms.Label lblFirstStop;
        private System.Windows.Forms.Label lblNextStop;
        private System.Windows.Forms.Label lblArrow;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.ComboBox cboFirstStopInput;
        private System.Windows.Forms.ComboBox cboNextStopInput;
    }
}