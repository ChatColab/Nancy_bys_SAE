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
            this.dudLine = new System.Windows.Forms.DomainUpDown();
            this.dudStop = new System.Windows.Forms.DomainUpDown();
            this.dudPrevStop = new System.Windows.Forms.DomainUpDown();
            this.dudNextStop = new System.Windows.Forms.DomainUpDown();
            this.grpNewStop = new System.Windows.Forms.GroupBox();
            this.txtNewStop = new System.Windows.Forms.TextBox();
            this.grpTime = new System.Windows.Forms.GroupBox();
            this.nudNextStop = new System.Windows.Forms.NumericUpDown();
            this.nudPrevStop = new System.Windows.Forms.NumericUpDown();
            this.lblNextStop = new System.Windows.Forms.Label();
            this.lblPrevStop = new System.Windows.Forms.Label();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdQuit = new System.Windows.Forms.Button();
            this.lblNewStop = new System.Windows.Forms.Label();
            this.grpNewStop.SuspendLayout();
            this.grpTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNextStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrevStop)).BeginInit();
            this.SuspendLayout();
            // 
            // dudLine
            // 
            this.dudLine.Location = new System.Drawing.Point(84, 31);
            this.dudLine.Name = "dudLine";
            this.dudLine.Size = new System.Drawing.Size(224, 26);
            this.dudLine.TabIndex = 0;
            this.dudLine.Text = "dudLine";
            // 
            // dudStop
            // 
            this.dudStop.Location = new System.Drawing.Point(116, 96);
            this.dudStop.Name = "dudStop";
            this.dudStop.Size = new System.Drawing.Size(149, 26);
            this.dudStop.TabIndex = 1;
            this.dudStop.Text = "dudStop";
            // 
            // dudPrevStop
            // 
            this.dudPrevStop.Location = new System.Drawing.Point(116, 210);
            this.dudPrevStop.Name = "dudPrevStop";
            this.dudPrevStop.Size = new System.Drawing.Size(149, 26);
            this.dudPrevStop.TabIndex = 2;
            this.dudPrevStop.Text = "dudPrevStop";
            // 
            // dudNextStop
            // 
            this.dudNextStop.Location = new System.Drawing.Point(116, 252);
            this.dudNextStop.Name = "dudNextStop";
            this.dudNextStop.Size = new System.Drawing.Size(149, 26);
            this.dudNextStop.TabIndex = 3;
            this.dudNextStop.Text = "dudNextStop";
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
            // lblNewStop
            // 
            this.lblNewStop.AutoSize = true;
            this.lblNewStop.Location = new System.Drawing.Point(95, 41);
            this.lblNewStop.Name = "lblNewStop";
            this.lblNewStop.Size = new System.Drawing.Size(151, 20);
            this.lblNewStop.TabIndex = 1;
            this.lblNewStop.Text = "Nom du nouvel arrêt";
            // 
            // AddStop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdQuit);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.grpTime);
            this.Controls.Add(this.grpNewStop);
            this.Controls.Add(this.dudNextStop);
            this.Controls.Add(this.dudPrevStop);
            this.Controls.Add(this.dudStop);
            this.Controls.Add(this.dudLine);
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
        private System.Windows.Forms.DomainUpDown dudLine;
        private System.Windows.Forms.DomainUpDown dudStop;
        private System.Windows.Forms.DomainUpDown dudPrevStop;
        private System.Windows.Forms.DomainUpDown dudNextStop;
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
    }
}