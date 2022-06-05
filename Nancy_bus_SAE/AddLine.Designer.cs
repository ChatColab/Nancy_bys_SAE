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
            this.txtStartHourly = new System.Windows.Forms.TextBox();
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
            this.lblNewStartHourly.Location = new System.Drawing.Point(24, 179);
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
            // 
            // txtStartHourly
            // 
            this.txtStartHourly.Location = new System.Drawing.Point(27, 212);
            this.txtStartHourly.Name = "txtStartHourly";
            this.txtStartHourly.Size = new System.Drawing.Size(120, 20);
            this.txtStartHourly.TabIndex = 11;
            this.txtStartHourly.TextChanged += new System.EventHandler(this.txtStartHourly_TextChanged);
            // 
            // AddLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 292);
            this.Controls.Add(this.txtStartHourly);
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
        private System.Windows.Forms.TextBox txtStartHourly;
    }
}