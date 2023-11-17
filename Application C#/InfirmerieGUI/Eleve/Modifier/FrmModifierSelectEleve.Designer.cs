namespace InfirmerieGUI
{
    partial class FrmModifierSelectEleve
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
            this.labelClasseEleve = new System.Windows.Forms.Label();
            this.labelModifierEleve = new System.Windows.Forms.Label();
            this.labelEleveModifier = new System.Windows.Forms.Label();
            this.comboBoxClasseEleve = new System.Windows.Forms.ComboBox();
            this.comboBoxEleveModifier = new System.Windows.Forms.ComboBox();
            this.buttonModifierEleve = new System.Windows.Forms.Button();
            this.buttonRetourAccueil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelClasseEleve
            // 
            this.labelClasseEleve.AutoSize = true;
            this.labelClasseEleve.Location = new System.Drawing.Point(126, 147);
            this.labelClasseEleve.Name = "labelClasseEleve";
            this.labelClasseEleve.Size = new System.Drawing.Size(92, 13);
            this.labelClasseEleve.TabIndex = 0;
            this.labelClasseEleve.Text = "Classe de l\'élève :";
            // 
            // labelModifierEleve
            // 
            this.labelModifierEleve.AutoSize = true;
            this.labelModifierEleve.Location = new System.Drawing.Point(233, 66);
            this.labelModifierEleve.Name = "labelModifierEleve";
            this.labelModifierEleve.Size = new System.Drawing.Size(80, 13);
            this.labelModifierEleve.TabIndex = 1;
            this.labelModifierEleve.Text = "Mofier un élève";
            // 
            // labelEleveModifier
            // 
            this.labelEleveModifier.AutoSize = true;
            this.labelEleveModifier.Location = new System.Drawing.Point(126, 195);
            this.labelEleveModifier.Name = "labelEleveModifier";
            this.labelEleveModifier.Size = new System.Drawing.Size(91, 13);
            this.labelEleveModifier.TabIndex = 2;
            this.labelEleveModifier.Text = "Elève à modifier : ";
            // 
            // comboBoxClasseEleve
            // 
            this.comboBoxClasseEleve.FormattingEnabled = true;
            this.comboBoxClasseEleve.Items.AddRange(new object[] {
            "Seconde ",
            "Première",
            "Terminale",
            "BTS1",
            "BTS2"});
            this.comboBoxClasseEleve.Location = new System.Drawing.Point(236, 144);
            this.comboBoxClasseEleve.Name = "comboBoxClasseEleve";
            this.comboBoxClasseEleve.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClasseEleve.TabIndex = 3;
            this.comboBoxClasseEleve.SelectedIndexChanged += new System.EventHandler(this.comboBoxClasseEleve_SelectedIndexChanged);
            // 
            // comboBoxEleveModifier
            // 
            this.comboBoxEleveModifier.FormattingEnabled = true;
            this.comboBoxEleveModifier.Location = new System.Drawing.Point(236, 195);
            this.comboBoxEleveModifier.Name = "comboBoxEleveModifier";
            this.comboBoxEleveModifier.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEleveModifier.TabIndex = 4;
            // 
            // buttonModifierEleve
            // 
            this.buttonModifierEleve.Location = new System.Drawing.Point(113, 273);
            this.buttonModifierEleve.Name = "buttonModifierEleve";
            this.buttonModifierEleve.Size = new System.Drawing.Size(75, 23);
            this.buttonModifierEleve.TabIndex = 5;
            this.buttonModifierEleve.Text = "Modifier";
            this.buttonModifierEleve.UseVisualStyleBackColor = true;
            this.buttonModifierEleve.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonRetourAccueil
            // 
            this.buttonRetourAccueil.Location = new System.Drawing.Point(345, 273);
            this.buttonRetourAccueil.Name = "buttonRetourAccueil";
            this.buttonRetourAccueil.Size = new System.Drawing.Size(75, 23);
            this.buttonRetourAccueil.TabIndex = 6;
            this.buttonRetourAccueil.Text = "Retour";
            this.buttonRetourAccueil.UseVisualStyleBackColor = true;
            this.buttonRetourAccueil.Click += new System.EventHandler(this.buttonRetourAccueil_Click);
            // 
            // FrmModifierSelectEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRetourAccueil);
            this.Controls.Add(this.buttonModifierEleve);
            this.Controls.Add(this.comboBoxEleveModifier);
            this.Controls.Add(this.comboBoxClasseEleve);
            this.Controls.Add(this.labelEleveModifier);
            this.Controls.Add(this.labelModifierEleve);
            this.Controls.Add(this.labelClasseEleve);
            this.Name = "FrmModifierSelectEleve";
            this.Text = "FrmModifierSelectEleve";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClasseEleve;
        private System.Windows.Forms.Label labelModifierEleve;
        private System.Windows.Forms.Label labelEleveModifier;
        private System.Windows.Forms.ComboBox comboBoxClasseEleve;
        private System.Windows.Forms.ComboBox comboBoxEleveModifier;
        private System.Windows.Forms.Button buttonModifierEleve;
        private System.Windows.Forms.Button buttonRetourAccueil;
    }
}