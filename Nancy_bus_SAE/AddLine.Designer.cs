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
            this.lblNewStartHourly = new System.Windows.Forms.Label();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.lblStartHourly = new System.Windows.Forms.Label();
            this.lstHourly = new System.Windows.Forms.ListBox();
            this.cmdValidate = new System.Windows.Forms.Button();
            this.cmdQuit = new System.Windows.Forms.Button();
            this.cboStop = new System.Windows.Forms.ComboBox();
            this.nudHours = new System.Windows.Forms.NumericUpDown();
            this.nudMinutes = new System.Windows.Forms.NumericUpDown();
            this.nudSeconds = new System.Windows.Forms.NumericUpDown();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine.Location = new System.Drawing.Point(72, 31);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(99, 32);
            this.lblLine.TabIndex = 0;
            this.lblLine.Text = "lblLine";
            // 
            // lblStartStop
            // 
            this.lblStartStop.AutoSize = true;
            this.lblStartStop.Location = new System.Drawing.Point(64, 102);
            this.lblStartStop.Name = "lblStartStop";
            this.lblStartStop.Size = new System.Drawing.Size(119, 20);
            this.lblStartStop.TabIndex = 1;
            this.lblStartStop.Text = "Arrêt de Départ";
            // 
            // lblNewStartHourly
            // 
            this.lblNewStartHourly.AutoSize = true;
            this.lblNewStartHourly.Location = new System.Drawing.Point(36, 262);
            this.lblNewStartHourly.Name = "lblNewStartHourly";
            this.lblNewStartHourly.Size = new System.Drawing.Size(185, 20);
            this.lblNewStartHourly.TabIndex = 3;
            this.lblNewStartHourly.Text = "Nouvel horaire de Départ";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(36, 383);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(184, 37);
            this.cmdAdd.TabIndex = 5;
            this.cmdAdd.Text = "Ajouter";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // lblStartHourly
            // 
            this.lblStartHourly.AutoSize = true;
            this.lblStartHourly.Location = new System.Drawing.Point(286, 42);
            this.lblStartHourly.Name = "lblStartHourly";
            this.lblStartHourly.Size = new System.Drawing.Size(136, 20);
            this.lblStartHourly.TabIndex = 6;
            this.lblStartHourly.Text = "Horaire de Départ";
            // 
            // lstHourly
            // 
            this.lstHourly.FormattingEnabled = true;
            this.lstHourly.ItemHeight = 20;
            this.lstHourly.Location = new System.Drawing.Point(291, 102);
            this.lstHourly.Name = "lstHourly";
            this.lstHourly.Size = new System.Drawing.Size(186, 204);
            this.lstHourly.TabIndex = 7;
            // 
            // cmdValidate
            // 
            this.cmdValidate.Location = new System.Drawing.Point(290, 320);
            this.cmdValidate.Name = "cmdValidate";
            this.cmdValidate.Size = new System.Drawing.Size(184, 37);
            this.cmdValidate.TabIndex = 8;
            this.cmdValidate.Text = "Valider";
            this.cmdValidate.UseVisualStyleBackColor = true;
            this.cmdValidate.Click += new System.EventHandler(this.cmdValidate_Click);
            // 
            // cmdQuit
            // 
            this.cmdQuit.Location = new System.Drawing.Point(290, 383);
            this.cmdQuit.Name = "cmdQuit";
            this.cmdQuit.Size = new System.Drawing.Size(184, 37);
            this.cmdQuit.TabIndex = 9;
            this.cmdQuit.Text = "Quitter";
            this.cmdQuit.UseVisualStyleBackColor = true;
            this.cmdQuit.Click += new System.EventHandler(this.cmdQuit_Click);
            // 
            // cboStop
            // 
            this.cboStop.FormattingEnabled = true;
            this.cboStop.Location = new System.Drawing.Point(64, 132);
            this.cboStop.Name = "cboStop";
            this.cboStop.Size = new System.Drawing.Size(121, 28);
            this.cboStop.TabIndex = 10;
            this.cboStop.Text = "Arrêt X";
            this.cboStop.SelectedIndexChanged += new System.EventHandler(this.cboStop_SelectedIndexChanged);
            // 
            // nudHours
            // 
            this.nudHours.Location = new System.Drawing.Point(40, 328);
            this.nudHours.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudHours.Name = "nudHours";
            this.nudHours.Size = new System.Drawing.Size(56, 26);
            this.nudHours.TabIndex = 12;
            this.nudHours.ValueChanged += new System.EventHandler(this.nudHours_ValueChanged);
            // 
            // nudMinutes
            // 
            this.nudMinutes.Location = new System.Drawing.Point(105, 328);
            this.nudMinutes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(56, 26);
            this.nudMinutes.TabIndex = 13;
            this.nudMinutes.ValueChanged += new System.EventHandler(this.nudMinutes_ValueChanged);
            // 
            // nudSeconds
            // 
            this.nudSeconds.Location = new System.Drawing.Point(170, 328);
            this.nudSeconds.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudSeconds.Name = "nudSeconds";
            this.nudSeconds.Size = new System.Drawing.Size(56, 26);
            this.nudSeconds.TabIndex = 14;
            this.nudSeconds.ValueChanged += new System.EventHandler(this.nudSeconds_ValueChanged);
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(42, 303);
            this.lblHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(53, 20);
            this.lblHours.TabIndex = 15;
            this.lblHours.Text = "Heure";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(165, 303);
            this.lblSeconds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(73, 20);
            this.lblSeconds.TabIndex = 16;
            this.lblSeconds.Text = "Seconde";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(99, 303);
            this.lblMinutes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(57, 20);
            this.lblMinutes.TabIndex = 17;
            this.lblMinutes.Text = "Minute";
            // 
            // AddLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 449);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.nudSeconds);
            this.Controls.Add(this.nudMinutes);
            this.Controls.Add(this.nudHours);
            this.Controls.Add(this.cboStop);
            this.Controls.Add(this.cmdQuit);
            this.Controls.Add(this.cmdValidate);
            this.Controls.Add(this.lstHourly);
            this.Controls.Add(this.lblStartHourly);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.lblNewStartHourly);
            this.Controls.Add(this.lblStartStop);
            this.Controls.Add(this.lblLine);
            this.Name = "AddLine";
            this.Text = "Ajouter une ligne";
            this.Load += new System.EventHandler(this.AddLine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblStartStop;
        private System.Windows.Forms.Label lblNewStartHourly;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Label lblStartHourly;
        private System.Windows.Forms.ListBox lstHourly;
        private System.Windows.Forms.Button cmdValidate;
        private System.Windows.Forms.Button cmdQuit;
        private System.Windows.Forms.ComboBox cboStop;
        private System.Windows.Forms.NumericUpDown nudHours;
        private System.Windows.Forms.NumericUpDown nudMinutes;
        private System.Windows.Forms.NumericUpDown nudSeconds;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblMinutes;
    }
}