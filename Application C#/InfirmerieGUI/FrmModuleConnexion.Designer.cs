﻿namespace InfirmerieGUI
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
            this.labelAuthenfification = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnValidConnex
            // 
            this.btnValidConnex.BackColor = System.Drawing.Color.Gray;
            this.btnValidConnex.Location = new System.Drawing.Point(282, 233);
            this.btnValidConnex.Name = "btnValidConnex";
            this.btnValidConnex.Size = new System.Drawing.Size(75, 23);
            this.btnValidConnex.TabIndex = 0;
            this.btnValidConnex.Text = "Valider";
            this.btnValidConnex.UseVisualStyleBackColor = false;
            this.btnValidConnex.Click += new System.EventHandler(this.btnValidConnex_Click);
            // 
            // labelIdentifiant
            // 
            this.labelIdentifiant.AutoSize = true;
            this.labelIdentifiant.Location = new System.Drawing.Point(168, 127);
            this.labelIdentifiant.Name = "labelIdentifiant";
            this.labelIdentifiant.Size = new System.Drawing.Size(62, 13);
            this.labelIdentifiant.TabIndex = 1;
            this.labelIdentifiant.Text = "Identifiant : ";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(168, 185);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(77, 13);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Mot de passe :";
            // 
            // textBoxIdentifiant
            // 
            this.textBoxIdentifiant.Location = new System.Drawing.Point(271, 127);
            this.textBoxIdentifiant.Name = "textBoxIdentifiant";
            this.textBoxIdentifiant.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdentifiant.TabIndex = 3;
            this.textBoxIdentifiant.TextChanged += new System.EventHandler(this.textBoxIdentifiant_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(271, 185);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // labelAuthenfification
            // 
            this.labelAuthenfification.AutoSize = true;
            this.labelAuthenfification.Location = new System.Drawing.Point(294, 56);
            this.labelAuthenfification.Name = "labelAuthenfification";
            this.labelAuthenfification.Size = new System.Drawing.Size(68, 13);
            this.labelAuthenfification.TabIndex = 5;
            this.labelAuthenfification.Text = "S\'authentifier";
            this.labelAuthenfification.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmModuleConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAuthenfification);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxIdentifiant);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelIdentifiant);
            this.Controls.Add(this.btnValidConnex);
            this.Name = "FrmModuleConnexion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmModuleConnexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValidConnex;
        private System.Windows.Forms.Label labelIdentifiant;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxIdentifiant;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelAuthenfification;
    }
}

