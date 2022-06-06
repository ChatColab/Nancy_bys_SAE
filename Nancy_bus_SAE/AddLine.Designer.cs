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
            this.lblLine.Location = new System.Drawing.Point(48, 20);
            this.lblLine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(65, 24);
            this.lblLine.TabIndex = 0;
            this.lblLine.Text = "lblLine";
            // 
            // lblStartStop
            // 
            this.lblStartStop.AutoSize = true;
            this.lblStartStop.Location = new System.Drawing.Point(43, 66);
            this.lblStartStop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartStop.Name = "lblStartStop";
            this.lblStartStop.Size = new System.Drawing.Size(79, 13);
            this.lblStartStop.TabIndex = 1;
            this.lblStartStop.Text = "Arrêt de Départ";
            // 
            // lblNewStartHourly
            // 
            this.lblNewStartHourly.AutoSize = true;
            this.lblNewStartHourly.Location = new System.Drawing.Point(24, 170);
            this.lblNewStartHourly.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewStartHourly.Name = "lblNewStartHourly";
            this.lblNewStartHourly.Size = new System.Drawing.Size(126, 13);
            this.lblNewStartHourly.TabIndex = 3;
            this.lblNewStartHourly.Text = "Nouvel horaire de Départ";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(24, 249);
            this.cmdAdd.Margin = new System.Windows.Forms.Padding(2);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(123, 24);
            this.cmdAdd.TabIndex = 5;
            this.cmdAdd.Text = "Ajouter";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // lblStartHourly
            // 
            this.lblStartHourly.AutoSize = true;
            this.lblStartHourly.Location = new System.Drawing.Point(191, 27);
            this.lblStartHourly.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartHourly.Name = "lblStartHourly";
            this.lblStartHourly.Size = new System.Drawing.Size(91, 13);
            this.lblStartHourly.TabIndex = 6;
            this.lblStartHourly.Text = "Horaire de Départ";
            // 
            // lstHourly
            // 
            this.lstHourly.FormattingEnabled = true;
            this.lstHourly.Location = new System.Drawing.Point(194, 66);
            this.lstHourly.Margin = new System.Windows.Forms.Padding(2);
            this.lstHourly.Name = "lstHourly";
            this.lstHourly.Size = new System.Drawing.Size(125, 134);
            this.lstHourly.TabIndex = 7;
            // 
            // cmdValidate
            // 
            this.cmdValidate.Location = new System.Drawing.Point(193, 208);
            this.cmdValidate.Margin = new System.Windows.Forms.Padding(2);
            this.cmdValidate.Name = "cmdValidate";
            this.cmdValidate.Size = new System.Drawing.Size(123, 24);
            this.cmdValidate.TabIndex = 8;
            this.cmdValidate.Text = "Valider";
            this.cmdValidate.UseVisualStyleBackColor = true;
            // 
            // cmdQuit
            // 
            this.cmdQuit.Location = new System.Drawing.Point(193, 249);
            this.cmdQuit.Margin = new System.Windows.Forms.Padding(2);
            this.cmdQuit.Name = "cmdQuit";
            this.cmdQuit.Size = new System.Drawing.Size(123, 24);
            this.cmdQuit.TabIndex = 9;
            this.cmdQuit.Text = "Quitter";
            this.cmdQuit.UseVisualStyleBackColor = true;
            this.cmdQuit.Click += new System.EventHandler(this.cmdQuit_Click);
            // 
            // cboStop
            // 
            this.cboStop.FormattingEnabled = true;
            this.cboStop.Location = new System.Drawing.Point(43, 86);
            this.cboStop.Margin = new System.Windows.Forms.Padding(2);
            this.cboStop.Name = "cboStop";
            this.cboStop.Size = new System.Drawing.Size(82, 21);
            this.cboStop.TabIndex = 10;
            this.cboStop.Text = "Arrêt X";
            this.cboStop.SelectedIndexChanged += new System.EventHandler(this.cboStop_SelectedIndexChanged);
            // 
            // nudHours
            // 
            this.nudHours.Location = new System.Drawing.Point(27, 213);
            this.nudHours.Name = "nudHours";
            this.nudHours.Size = new System.Drawing.Size(37, 20);
            this.nudHours.TabIndex = 12;
            this.nudHours.ValueChanged += new System.EventHandler(this.nudHours_ValueChanged);
            // 
            // nudMinutes
            // 
            this.nudMinutes.Location = new System.Drawing.Point(70, 213);
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(37, 20);
            this.nudMinutes.TabIndex = 13;
            this.nudMinutes.ValueChanged += new System.EventHandler(this.nudMinutes_ValueChanged);
            // 
            // nudSeconds
            // 
            this.nudSeconds.Location = new System.Drawing.Point(113, 213);
            this.nudSeconds.Name = "nudSeconds";
            this.nudSeconds.Size = new System.Drawing.Size(37, 20);
            this.nudSeconds.TabIndex = 14;
            this.nudSeconds.ValueChanged += new System.EventHandler(this.nudSeconds_ValueChanged);
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(28, 197);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(36, 13);
            this.lblHours.TabIndex = 15;
            this.lblHours.Text = "Heure";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(110, 197);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(50, 13);
            this.lblSeconds.TabIndex = 16;
            this.lblSeconds.Text = "Seconde";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(66, 197);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(39, 13);
            this.lblMinutes.TabIndex = 17;
            this.lblMinutes.Text = "Minute";
            // 
            // AddLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 292);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddLine";
            this.Text = "Ajouter une ligne";
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