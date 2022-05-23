namespace Nancy_bus_SAE
{
    partial class AddLine
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
            this.lblStartStop = new System.Windows.Forms.Label();
            this.lstStop = new System.Windows.Forms.ListBox();
            this.lblNewStartHourly = new System.Windows.Forms.Label();
            this.cmdStartHourly = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.lblStartHourly = new System.Windows.Forms.Label();
            this.lstHourly = new System.Windows.Forms.ListBox();
            this.cmdValidate = new System.Windows.Forms.Button();
            this.cmdQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Location = new System.Drawing.Point(72, 41);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(54, 20);
            this.lblLine.TabIndex = 0;
            this.lblLine.Text = "lblLine";
            // 
            // lblStartStop
            // 
            this.lblStartStop.AutoSize = true;
            this.lblStartStop.Location = new System.Drawing.Point(76, 84);
            this.lblStartStop.Name = "lblStartStop";
            this.lblStartStop.Size = new System.Drawing.Size(119, 20);
            this.lblStartStop.TabIndex = 1;
            this.lblStartStop.Text = "Arrêt de Départ";
            // 
            // lstStop
            // 
            this.lstStop.FormattingEnabled = true;
            this.lstStop.ItemHeight = 20;
            this.lstStop.Location = new System.Drawing.Point(76, 126);
            this.lstStop.Name = "lstStop";
            this.lstStop.Size = new System.Drawing.Size(120, 84);
            this.lstStop.TabIndex = 2;
            // 
            // lblNewStartHourly
            // 
            this.lblNewStartHourly.AutoSize = true;
            this.lblNewStartHourly.Location = new System.Drawing.Point(76, 262);
            this.lblNewStartHourly.Name = "lblNewStartHourly";
            this.lblNewStartHourly.Size = new System.Drawing.Size(185, 20);
            this.lblNewStartHourly.TabIndex = 3;
            this.lblNewStartHourly.Text = "Nouvel horaire de Départ";
            // 
            // cmdStartHourly
            // 
            this.cmdStartHourly.Location = new System.Drawing.Point(76, 320);
            this.cmdStartHourly.Name = "cmdStartHourly";
            this.cmdStartHourly.Size = new System.Drawing.Size(185, 37);
            this.cmdStartHourly.TabIndex = 4;
            this.cmdStartHourly.Text = "cmdStartHourly";
            this.cmdStartHourly.UseVisualStyleBackColor = true;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(76, 383);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(185, 37);
            this.cmdAdd.TabIndex = 5;
            this.cmdAdd.Text = "Ajouter";
            this.cmdAdd.UseVisualStyleBackColor = true;
            // 
            // lblStartHourly
            // 
            this.lblStartHourly.AutoSize = true;
            this.lblStartHourly.Location = new System.Drawing.Point(539, 41);
            this.lblStartHourly.Name = "lblStartHourly";
            this.lblStartHourly.Size = new System.Drawing.Size(136, 20);
            this.lblStartHourly.TabIndex = 6;
            this.lblStartHourly.Text = "Horaire de Départ";
            // 
            // lstHourly
            // 
            this.lstHourly.FormattingEnabled = true;
            this.lstHourly.ItemHeight = 20;
            this.lstHourly.Location = new System.Drawing.Point(543, 104);
            this.lstHourly.Name = "lstHourly";
            this.lstHourly.Size = new System.Drawing.Size(120, 84);
            this.lstHourly.TabIndex = 7;
            // 
            // cmdValidate
            // 
            this.cmdValidate.Location = new System.Drawing.Point(543, 320);
            this.cmdValidate.Name = "cmdValidate";
            this.cmdValidate.Size = new System.Drawing.Size(185, 37);
            this.cmdValidate.TabIndex = 8;
            this.cmdValidate.Text = "Valider";
            this.cmdValidate.UseVisualStyleBackColor = true;
            // 
            // cmdQuit
            // 
            this.cmdQuit.Location = new System.Drawing.Point(543, 383);
            this.cmdQuit.Name = "cmdQuit";
            this.cmdQuit.Size = new System.Drawing.Size(185, 37);
            this.cmdQuit.TabIndex = 9;
            this.cmdQuit.Text = "Quitter";
            this.cmdQuit.UseVisualStyleBackColor = true;
            // 
            // AddLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdQuit);
            this.Controls.Add(this.cmdValidate);
            this.Controls.Add(this.lstHourly);
            this.Controls.Add(this.lblStartHourly);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.cmdStartHourly);
            this.Controls.Add(this.lblNewStartHourly);
            this.Controls.Add(this.lstStop);
            this.Controls.Add(this.lblStartStop);
            this.Controls.Add(this.lblLine);
            this.Name = "AddLine";
            this.Text = "Ajouter une ligne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblStartStop;
        private System.Windows.Forms.ListBox lstStop;
        private System.Windows.Forms.Label lblNewStartHourly;
        private System.Windows.Forms.Button cmdStartHourly;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Label lblStartHourly;
        private System.Windows.Forms.ListBox lstHourly;
        private System.Windows.Forms.Button cmdValidate;
        private System.Windows.Forms.Button cmdQuit;
    }
}