namespace Nancy_bus_SAE
{
    partial class Home
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitleHome = new System.Windows.Forms.Label();
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.optAddStop = new System.Windows.Forms.RadioButton();
            this.optAddLine = new System.Windows.Forms.RadioButton();
            this.grpDelete = new System.Windows.Forms.GroupBox();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.optDeleteStop = new System.Windows.Forms.RadioButton();
            this.optDeleteLine = new System.Windows.Forms.RadioButton();
            this.grpPrint = new System.Windows.Forms.GroupBox();
            this.lstLine = new System.Windows.Forms.ListBox();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.grpModify = new System.Windows.Forms.GroupBox();
            this.cmdModify = new System.Windows.Forms.Button();
            this.grpAdd.SuspendLayout();
            this.grpDelete.SuspendLayout();
            this.grpPrint.SuspendLayout();
            this.grpModify.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleHome
            // 
            this.lblTitleHome.AutoSize = true;
            this.lblTitleHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleHome.Location = new System.Drawing.Point(131, 30);
            this.lblTitleHome.Name = "lblTitleHome";
            this.lblTitleHome.Size = new System.Drawing.Size(542, 32);
            this.lblTitleHome.TabIndex = 0;
            this.lblTitleHome.Text = "Gestionnaire du Réseau de Bus de Nancy";
            // 
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.cmdAdd);
            this.grpAdd.Controls.Add(this.optAddStop);
            this.grpAdd.Controls.Add(this.optAddLine);
            this.grpAdd.Location = new System.Drawing.Point(83, 94);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(278, 147);
            this.grpAdd.TabIndex = 1;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "Ajouter";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(94, 96);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(85, 30);
            this.cmdAdd.TabIndex = 2;
            this.cmdAdd.Text = "Ajouter";
            this.cmdAdd.UseVisualStyleBackColor = true;
            // 
            // optAddStop
            // 
            this.optAddStop.AutoSize = true;
            this.optAddStop.Location = new System.Drawing.Point(161, 41);
            this.optAddStop.Name = "optAddStop";
            this.optAddStop.Size = new System.Drawing.Size(69, 24);
            this.optAddStop.TabIndex = 1;
            this.optAddStop.TabStop = true;
            this.optAddStop.Text = "Arrêt";
            this.optAddStop.UseVisualStyleBackColor = true;
            // 
            // optAddLine
            // 
            this.optAddLine.AutoSize = true;
            this.optAddLine.Location = new System.Drawing.Point(48, 41);
            this.optAddLine.Name = "optAddLine";
            this.optAddLine.Size = new System.Drawing.Size(73, 24);
            this.optAddLine.TabIndex = 0;
            this.optAddLine.TabStop = true;
            this.optAddLine.Text = "Ligne";
            this.optAddLine.UseVisualStyleBackColor = true;
            // 
            // grpDelete
            // 
            this.grpDelete.Controls.Add(this.cmdDelete);
            this.grpDelete.Controls.Add(this.optDeleteStop);
            this.grpDelete.Controls.Add(this.optDeleteLine);
            this.grpDelete.Location = new System.Drawing.Point(444, 94);
            this.grpDelete.Name = "grpDelete";
            this.grpDelete.Size = new System.Drawing.Size(278, 147);
            this.grpDelete.TabIndex = 2;
            this.grpDelete.TabStop = false;
            this.grpDelete.Text = "Supprimer";
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(100, 96);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(85, 30);
            this.cmdDelete.TabIndex = 5;
            this.cmdDelete.Text = "Supprimer";
            this.cmdDelete.UseVisualStyleBackColor = true;
            // 
            // optDeleteStop
            // 
            this.optDeleteStop.AutoSize = true;
            this.optDeleteStop.Location = new System.Drawing.Point(168, 41);
            this.optDeleteStop.Name = "optDeleteStop";
            this.optDeleteStop.Size = new System.Drawing.Size(69, 24);
            this.optDeleteStop.TabIndex = 4;
            this.optDeleteStop.TabStop = true;
            this.optDeleteStop.Text = "Arrêt";
            this.optDeleteStop.UseVisualStyleBackColor = true;
            // 
            // optDeleteLine
            // 
            this.optDeleteLine.AutoSize = true;
            this.optDeleteLine.Location = new System.Drawing.Point(48, 41);
            this.optDeleteLine.Name = "optDeleteLine";
            this.optDeleteLine.Size = new System.Drawing.Size(73, 24);
            this.optDeleteLine.TabIndex = 3;
            this.optDeleteLine.TabStop = true;
            this.optDeleteLine.Text = "Ligne";
            this.optDeleteLine.UseVisualStyleBackColor = true;
            // 
            // grpPrint
            // 
            this.grpPrint.Controls.Add(this.lstLine);
            this.grpPrint.Controls.Add(this.cmdPrint);
            this.grpPrint.Location = new System.Drawing.Point(444, 278);
            this.grpPrint.Name = "grpPrint";
            this.grpPrint.Size = new System.Drawing.Size(278, 147);
            this.grpPrint.TabIndex = 3;
            this.grpPrint.TabStop = false;
            this.grpPrint.Text = "Afficher Ligne";
            // 
            // lstLine
            // 
            this.lstLine.FormattingEnabled = true;
            this.lstLine.ItemHeight = 20;
            this.lstLine.Items.AddRange(new object[] {
            "Ligne 1",
            "Ligne 2",
            "Ligne 3",
            "Ligne 4"});
            this.lstLine.Location = new System.Drawing.Point(120, 16);
            this.lstLine.Name = "lstLine";
            this.lstLine.Size = new System.Drawing.Size(152, 124);
            this.lstLine.TabIndex = 1;
            // 
            // cmdPrint
            // 
            this.cmdPrint.Location = new System.Drawing.Point(20, 67);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(85, 30);
            this.cmdPrint.TabIndex = 0;
            this.cmdPrint.Text = "Afficher";
            this.cmdPrint.UseVisualStyleBackColor = true;
            //
            // grpModify
            // 
            this.grpModify.Controls.Add(this.cmdModify);
            this.grpModify.Location = new System.Drawing.Point(83, 278);
            this.grpModify.Name = "grpModify";
            this.grpModify.Size = new System.Drawing.Size(278, 147);
            this.grpModify.TabIndex = 4;
            this.grpModify.TabStop = false;
            this.grpModify.Text = "Modifier Intervalle Ligne";
            // 
            // cmdModify
            // 
            this.cmdModify.Location = new System.Drawing.Point(94, 67);
            this.cmdModify.Name = "cmdModify";
            this.cmdModify.Size = new System.Drawing.Size(85, 30);
            this.cmdModify.TabIndex = 0;
            this.cmdModify.Text = "Modifier";
            this.cmdModify.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpModify);
            this.Controls.Add(this.grpPrint);
            this.Controls.Add(this.grpDelete);
            this.Controls.Add(this.grpAdd);
            this.Controls.Add(this.lblTitleHome);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            this.grpDelete.ResumeLayout(false);
            this.grpDelete.PerformLayout();
            this.grpPrint.ResumeLayout(false);
            this.grpModify.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleHome;
        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.RadioButton optAddStop;
        private System.Windows.Forms.RadioButton optAddLine;
        private System.Windows.Forms.GroupBox grpDelete;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.RadioButton optDeleteStop;
        private System.Windows.Forms.RadioButton optDeleteLine;
        private System.Windows.Forms.GroupBox grpPrint;
        private System.Windows.Forms.ListBox lstLine;
        private System.Windows.Forms.Button cmdPrint;
        private System.Windows.Forms.GroupBox grpModify;
        private System.Windows.Forms.Button cmdModify;
    }
}

