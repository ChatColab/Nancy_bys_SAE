namespace Nancy_bus_SAE
{
    partial class AddStop
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpNewStop = new System.Windows.Forms.GroupBox();
            this.lblNewStop = new System.Windows.Forms.Label();
            this.txtNewStop = new System.Windows.Forms.TextBox();
            this.grpTime = new System.Windows.Forms.GroupBox();
            this.nudNextStop = new System.Windows.Forms.NumericUpDown();
            this.nudPrevStop = new System.Windows.Forms.NumericUpDown();
            this.lblNextStop = new System.Windows.Forms.Label();
            this.lblPrevStop = new System.Windows.Forms.Label();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdQuit = new System.Windows.Forms.Button();
            this.cboPrevStop = new System.Windows.Forms.ComboBox();
            this.cboNextStop = new System.Windows.Forms.ComboBox();
            this.cboStop = new System.Windows.Forms.ComboBox();
            this.cboLine = new System.Windows.Forms.ComboBox();
            this.grpNewStop.SuspendLayout();
            this.grpTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNextStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrevStop)).BeginInit();
            this.SuspendLayout();
            // 
            // grpNewStop
            // 
            this.grpNewStop.Controls.Add(this.lblNewStop);
            this.grpNewStop.Controls.Add(this.txtNewStop);
            this.grpNewStop.Location = new System.Drawing.Point(409, 31);
            this.grpNewStop.Name = "grpNewStop";
            this.grpNewStop.Size = new System.Drawing.Size(338, 123);
            this.grpNewStop.TabIndex = 4;
            this.grpNewStop.TabStop = false;
            this.grpNewStop.Text = "Création d\'un nouvel arrêt";
            // 
            // lblNewStop
            // 
            this.lblNewStop.AutoSize = true;
            this.lblNewStop.Location = new System.Drawing.Point(95, 41);
            this.lblNewStop.Name = "lblNewStop";
            this.lblNewStop.Size = new System.Drawing.Size(151, 20);
            this.lblNewStop.TabIndex = 1;
            this.lblNewStop.Text = "Nom du nouvel arrêt";
            // 
            // txtNewStop
            // 
            this.txtNewStop.Location = new System.Drawing.Point(41, 72);
            this.txtNewStop.Name = "txtNewStop";
            this.txtNewStop.Size = new System.Drawing.Size(255, 26);
            this.txtNewStop.TabIndex = 0;
            // 
            // grpTime
            // 
            this.grpTime.Controls.Add(this.nudNextStop);
            this.grpTime.Controls.Add(this.nudPrevStop);
            this.grpTime.Controls.Add(this.lblNextStop);
            this.grpTime.Controls.Add(this.lblPrevStop);
            this.grpTime.Location = new System.Drawing.Point(409, 183);
            this.grpTime.Name = "grpTime";
            this.grpTime.Size = new System.Drawing.Size(338, 243);
            this.grpTime.TabIndex = 5;
            this.grpTime.TabStop = false;
            this.grpTime.Text = "Temps de trajet (min)";
            // 
            // nudNextStop
            // 
            this.nudNextStop.Location = new System.Drawing.Point(48, 192);
            this.nudNextStop.Name = "nudNextStop";
            this.nudNextStop.Size = new System.Drawing.Size(240, 26);
            this.nudNextStop.TabIndex = 3;
            // 
            // nudPrevStop
            // 
            this.nudPrevStop.Location = new System.Drawing.Point(48, 88);
            this.nudPrevStop.Name = "nudPrevStop";
            this.nudPrevStop.Size = new System.Drawing.Size(240, 26);
            this.nudPrevStop.TabIndex = 2;
            // 
            // lblNextStop
            // 
            this.lblNextStop.AutoSize = true;
            this.lblNextStop.Location = new System.Drawing.Point(44, 160);
            this.lblNextStop.Name = "lblNextStop";
            this.lblNextStop.Size = new System.Drawing.Size(224, 20);
            this.lblNextStop.TabIndex = 1;
            this.lblNextStop.Text = "Arrêt à ajouter -> Arrêt Suivant";
            // 
            // lblPrevStop
            // 
            this.lblPrevStop.AutoSize = true;
            this.lblPrevStop.Location = new System.Drawing.Point(44, 51);
            this.lblPrevStop.Name = "lblPrevStop";
            this.lblPrevStop.Size = new System.Drawing.Size(244, 20);
            this.lblPrevStop.TabIndex = 0;
            this.lblPrevStop.Text = "Arrêt Précédent -> Arrêt à ajouter";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(84, 314);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(224, 48);
            this.cmdAdd.TabIndex = 6;
            this.cmdAdd.Text = "Ajouter";
            this.cmdAdd.UseVisualStyleBackColor = true;
            // 
            // cmdQuit
            // 
            this.cmdQuit.Location = new System.Drawing.Point(84, 378);
            this.cmdQuit.Name = "cmdQuit";
            this.cmdQuit.Size = new System.Drawing.Size(224, 48);
            this.cmdQuit.TabIndex = 7;
            this.cmdQuit.Text = "Quitter";
            this.cmdQuit.UseVisualStyleBackColor = true;
            // 
            // cboPrevStop
            // 
            this.cboPrevStop.FormattingEnabled = true;
            this.cboPrevStop.Location = new System.Drawing.Point(116, 208);
            this.cboPrevStop.Name = "cboPrevStop";
            this.cboPrevStop.Size = new System.Drawing.Size(149, 28);
            this.cboPrevStop.TabIndex = 8;
            // 
            // cboNextStop
            // 
            this.cboNextStop.FormattingEnabled = true;
            this.cboNextStop.Location = new System.Drawing.Point(116, 252);
            this.cboNextStop.Name = "cboNextStop";
            this.cboNextStop.Size = new System.Drawing.Size(149, 28);
            this.cboNextStop.TabIndex = 9;
            // 
            // cboStop
            // 
            this.cboStop.FormattingEnabled = true;
            this.cboStop.Location = new System.Drawing.Point(116, 96);
            this.cboStop.Name = "cboStop";
            this.cboStop.Size = new System.Drawing.Size(149, 28);
            this.cboStop.TabIndex = 10;
            // 
            // cboLine
            // 
            this.cboLine.FormattingEnabled = true;
            this.cboLine.Location = new System.Drawing.Point(84, 31);
            this.cboLine.Name = "cboLine";
            this.cboLine.Size = new System.Drawing.Size(224, 28);
            this.cboLine.TabIndex = 11;
            // 
            // AddStop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboLine);
            this.Controls.Add(this.cboStop);
            this.Controls.Add(this.cboNextStop);
            this.Controls.Add(this.cboPrevStop);
            this.Controls.Add(this.cmdQuit);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.grpTime);
            this.Controls.Add(this.grpNewStop);
            this.Name = "AddStop";
            this.Text = "Ajouter un Arrêt";
            this.grpNewStop.ResumeLayout(false);
            this.grpNewStop.PerformLayout();
            this.grpTime.ResumeLayout(false);
            this.grpTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNextStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrevStop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpNewStop;
        private System.Windows.Forms.GroupBox grpTime;
        private System.Windows.Forms.TextBox txtNewStop;
        private System.Windows.Forms.NumericUpDown nudNextStop;
        private System.Windows.Forms.NumericUpDown nudPrevStop;
        private System.Windows.Forms.Label lblNextStop;
        private System.Windows.Forms.Label lblPrevStop;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdQuit;
        private System.Windows.Forms.Label lblNewStop;
        private System.Windows.Forms.ComboBox cboPrevStop;
        private System.Windows.Forms.ComboBox cboNextStop;
        private System.Windows.Forms.ComboBox cboStop;
        private System.Windows.Forms.ComboBox cboLine;
    }
}