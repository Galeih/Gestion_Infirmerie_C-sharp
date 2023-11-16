namespace InfirmerieGUI
{
    partial class FrmModuleSupprimerSelectEleve
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
            this.buttonRetourAccueil = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.comboBoxEleveSupprimer = new System.Windows.Forms.ComboBox();
            this.comboBoxClasseEleve = new System.Windows.Forms.ComboBox();
            this.labelEleveSupprimer = new System.Windows.Forms.Label();
            this.labelSupprimerEleve = new System.Windows.Forms.Label();
            this.labelClasseEleve = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRetourAccueil
            // 
            this.buttonRetourAccueil.Location = new System.Drawing.Point(344, 289);
            this.buttonRetourAccueil.Name = "buttonRetourAccueil";
            this.buttonRetourAccueil.Size = new System.Drawing.Size(75, 23);
            this.buttonRetourAccueil.TabIndex = 13;
            this.buttonRetourAccueil.Text = "Retour";
            this.buttonRetourAccueil.UseVisualStyleBackColor = true;
            this.buttonRetourAccueil.Click += new System.EventHandler(this.buttonRetourAccueil_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(112, 289);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(75, 23);
            this.buttonSupprimer.TabIndex = 12;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // comboBoxEleveSupprimer
            // 
            this.comboBoxEleveSupprimer.FormattingEnabled = true;
            this.comboBoxEleveSupprimer.Location = new System.Drawing.Point(235, 211);
            this.comboBoxEleveSupprimer.Name = "comboBoxEleveSupprimer";
            this.comboBoxEleveSupprimer.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEleveSupprimer.TabIndex = 11;
            // 
            // comboBoxClasseEleve
            // 
            this.comboBoxClasseEleve.FormattingEnabled = true;
            this.comboBoxClasseEleve.Location = new System.Drawing.Point(235, 160);
            this.comboBoxClasseEleve.Name = "comboBoxClasseEleve";
            this.comboBoxClasseEleve.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClasseEleve.TabIndex = 10;
            // 
            // labelEleveSupprimer
            // 
            this.labelEleveSupprimer.AutoSize = true;
            this.labelEleveSupprimer.Location = new System.Drawing.Point(125, 211);
            this.labelEleveSupprimer.Name = "labelEleveSupprimer";
            this.labelEleveSupprimer.Size = new System.Drawing.Size(100, 13);
            this.labelEleveSupprimer.TabIndex = 9;
            this.labelEleveSupprimer.Text = "Elève à supprimer : ";
            // 
            // labelSupprimerEleve
            // 
            this.labelSupprimerEleve.AutoSize = true;
            this.labelSupprimerEleve.Location = new System.Drawing.Point(232, 88);
            this.labelSupprimerEleve.Name = "labelSupprimerEleve";
            this.labelSupprimerEleve.Size = new System.Drawing.Size(98, 13);
            this.labelSupprimerEleve.TabIndex = 8;
            this.labelSupprimerEleve.Text = "Supprimer un élève";
            // 
            // labelClasseEleve
            // 
            this.labelClasseEleve.AutoSize = true;
            this.labelClasseEleve.Location = new System.Drawing.Point(125, 163);
            this.labelClasseEleve.Name = "labelClasseEleve";
            this.labelClasseEleve.Size = new System.Drawing.Size(92, 13);
            this.labelClasseEleve.TabIndex = 7;
            this.labelClasseEleve.Text = "Classe de l\'élève :";
            // 
            // FrmModuleSupprimerSelectEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRetourAccueil);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.comboBoxEleveSupprimer);
            this.Controls.Add(this.comboBoxClasseEleve);
            this.Controls.Add(this.labelEleveSupprimer);
            this.Controls.Add(this.labelSupprimerEleve);
            this.Controls.Add(this.labelClasseEleve);
            this.Name = "FrmModuleSupprimerSelectEleve";
            this.Text = "FrmModuleSupprimerSelectEleve";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRetourAccueil;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.ComboBox comboBoxEleveSupprimer;
        private System.Windows.Forms.ComboBox comboBoxClasseEleve;
        private System.Windows.Forms.Label labelEleveSupprimer;
        private System.Windows.Forms.Label labelSupprimerEleve;
        private System.Windows.Forms.Label labelClasseEleve;
    }
}