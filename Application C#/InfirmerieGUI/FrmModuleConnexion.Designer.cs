namespace InfirmerieGUI
{
    partial class FrmModuleConnexion
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
            this.btnValidConnex = new System.Windows.Forms.Button();
            this.labelIdentifiant = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxIdentifiant = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnValidConnex
            // 
            this.btnValidConnex.BackColor = System.Drawing.Color.Gray;
            this.btnValidConnex.Location = new System.Drawing.Point(376, 287);
            this.btnValidConnex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnValidConnex.Name = "btnValidConnex";
            this.btnValidConnex.Size = new System.Drawing.Size(100, 28);
            this.btnValidConnex.TabIndex = 0;
            this.btnValidConnex.Text = "Valider";
            this.btnValidConnex.UseVisualStyleBackColor = false;
            this.btnValidConnex.Click += new System.EventHandler(this.btnValidConnex_Click);
            // 
            // labelIdentifiant
            // 
            this.labelIdentifiant.AutoSize = true;
            this.labelIdentifiant.Location = new System.Drawing.Point(257, 109);
            this.labelIdentifiant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIdentifiant.Name = "labelIdentifiant";
            this.labelIdentifiant.Size = new System.Drawing.Size(72, 16);
            this.labelIdentifiant.TabIndex = 1;
            this.labelIdentifiant.Text = "Identifiant : ";
            this.labelIdentifiant.Click += new System.EventHandler(this.labelIdentifiant_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(224, 228);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(95, 16);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Mot de passe :";
            // 
            // textBoxIdentifiant
            // 
            this.textBoxIdentifiant.Location = new System.Drawing.Point(227, 153);
            this.textBoxIdentifiant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIdentifiant.Name = "textBoxIdentifiant";
            this.textBoxIdentifiant.Size = new System.Drawing.Size(226, 22);
            this.textBoxIdentifiant.TabIndex = 3;
            this.textBoxIdentifiant.TextChanged += new System.EventHandler(this.textBoxIdentifiant_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(361, 228);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(132, 22);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // FrmModuleConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 554);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxIdentifiant);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelIdentifiant);
            this.Controls.Add(this.btnValidConnex);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmModuleConnexion";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValidConnex;
        private System.Windows.Forms.Label labelIdentifiant;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxIdentifiant;
        private System.Windows.Forms.TextBox textBoxPassword;
    }
}

