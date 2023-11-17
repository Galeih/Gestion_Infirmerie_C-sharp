using System;

namespace InfirmerieGUI
{
    partial class FrmModuleModifierEleve
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
            this.buttonRetourSelectEleve = new System.Windows.Forms.Button();
            this.buttonModifierEleve = new System.Windows.Forms.Button();
            this.textBoxClasseEleve = new System.Windows.Forms.TextBox();
            this.labelClasseEleve = new System.Windows.Forms.Label();
            this.textBoxCommentaire = new System.Windows.Forms.TextBox();
            this.labelCommentaire = new System.Windows.Forms.Label();
            this.checkBoxTiersTemps = new System.Windows.Forms.CheckBox();
            this.labelTiersTemps = new System.Windows.Forms.Label();
            this.textBoxNumeroTuteur = new System.Windows.Forms.TextBox();
            this.textBoxNumeroTel = new System.Windows.Forms.TextBox();
            this.textBoxDateNaissanceEleve = new System.Windows.Forms.TextBox();
            this.textBoxPrenomEleve = new System.Windows.Forms.TextBox();
            this.textBoxNomEleve = new System.Windows.Forms.TextBox();
            this.labelNumeroTuteur = new System.Windows.Forms.Label();
            this.labelNumeroEleve = new System.Windows.Forms.Label();
            this.labelDateNaissanceEleve = new System.Windows.Forms.Label();
            this.labelPrenomEleve = new System.Windows.Forms.Label();
            this.labelNomEleve = new System.Windows.Forms.Label();
            this.labelModifierEleve = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRetourSelectEleve
            // 
            this.buttonRetourSelectEleve.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonRetourSelectEleve.Location = new System.Drawing.Point(422, 395);
            this.buttonRetourSelectEleve.Name = "buttonRetourSelectEleve";
            this.buttonRetourSelectEleve.Size = new System.Drawing.Size(75, 23);
            this.buttonRetourSelectEleve.TabIndex = 56;
            this.buttonRetourSelectEleve.Text = "Retour";
            this.buttonRetourSelectEleve.UseVisualStyleBackColor = false;
            this.buttonRetourSelectEleve.Click += new System.EventHandler(this.buttonRetourAfficherEleve_Click);
            // 
            // buttonModifierEleve
            // 
            this.buttonModifierEleve.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonModifierEleve.Location = new System.Drawing.Point(147, 395);
            this.buttonModifierEleve.Name = "buttonModifierEleve";
            this.buttonModifierEleve.Size = new System.Drawing.Size(75, 23);
            this.buttonModifierEleve.TabIndex = 55;
            this.buttonModifierEleve.Text = "Modifier";
            this.buttonModifierEleve.UseVisualStyleBackColor = false;
            this.buttonModifierEleve.Click += new System.EventHandler(this.buttonModifierEleve_Click);
            // 
            // textBoxClasseEleve
            // 
            this.textBoxClasseEleve.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxClasseEleve.Location = new System.Drawing.Point(459, 282);
            this.textBoxClasseEleve.Name = "textBoxClasseEleve";
            this.textBoxClasseEleve.Size = new System.Drawing.Size(100, 20);
            this.textBoxClasseEleve.TabIndex = 54;
            // 
            // labelClasseEleve
            // 
            this.labelClasseEleve.AutoSize = true;
            this.labelClasseEleve.Location = new System.Drawing.Point(358, 285);
            this.labelClasseEleve.Name = "labelClasseEleve";
            this.labelClasseEleve.Size = new System.Drawing.Size(95, 13);
            this.labelClasseEleve.TabIndex = 53;
            this.labelClasseEleve.Text = "Classe de l\'élève : ";
            // 
            // textBoxCommentaire
            // 
            this.textBoxCommentaire.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxCommentaire.Location = new System.Drawing.Point(459, 152);
            this.textBoxCommentaire.Multiline = true;
            this.textBoxCommentaire.Name = "textBoxCommentaire";
            this.textBoxCommentaire.Size = new System.Drawing.Size(113, 87);
            this.textBoxCommentaire.TabIndex = 52;
            // 
            // labelCommentaire
            // 
            this.labelCommentaire.AutoSize = true;
            this.labelCommentaire.Location = new System.Drawing.Point(347, 155);
            this.labelCommentaire.Name = "labelCommentaire";
            this.labelCommentaire.Size = new System.Drawing.Size(106, 13);
            this.labelCommentaire.TabIndex = 51;
            this.labelCommentaire.Text = "Commentaire santé : ";
            // 
            // checkBoxTiersTemps
            // 
            this.checkBoxTiersTemps.AutoSize = true;
            this.checkBoxTiersTemps.Location = new System.Drawing.Point(472, 105);
            this.checkBoxTiersTemps.Name = "checkBoxTiersTemps";
            this.checkBoxTiersTemps.Size = new System.Drawing.Size(15, 14);
            this.checkBoxTiersTemps.TabIndex = 50;
            this.checkBoxTiersTemps.UseVisualStyleBackColor = true;
            // 
            // labelTiersTemps
            // 
            this.labelTiersTemps.AutoSize = true;
            this.labelTiersTemps.Location = new System.Drawing.Point(383, 106);
            this.labelTiersTemps.Name = "labelTiersTemps";
            this.labelTiersTemps.Size = new System.Drawing.Size(70, 13);
            this.labelTiersTemps.TabIndex = 49;
            this.labelTiersTemps.Text = "Tiers temps : ";
            // 
            // textBoxNumeroTuteur
            // 
            this.textBoxNumeroTuteur.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxNumeroTuteur.Location = new System.Drawing.Point(209, 325);
            this.textBoxNumeroTuteur.Name = "textBoxNumeroTuteur";
            this.textBoxNumeroTuteur.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeroTuteur.TabIndex = 48;
            // 
            // textBoxNumeroTel
            // 
            this.textBoxNumeroTel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxNumeroTel.Location = new System.Drawing.Point(209, 269);
            this.textBoxNumeroTel.Name = "textBoxNumeroTel";
            this.textBoxNumeroTel.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeroTel.TabIndex = 47;
            // 
            // textBoxDateNaissanceEleve
            // 
            this.textBoxDateNaissanceEleve.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxDateNaissanceEleve.Location = new System.Drawing.Point(209, 210);
            this.textBoxDateNaissanceEleve.Name = "textBoxDateNaissanceEleve";
            this.textBoxDateNaissanceEleve.Size = new System.Drawing.Size(100, 20);
            this.textBoxDateNaissanceEleve.TabIndex = 46;
            // 
            // textBoxPrenomEleve
            // 
            this.textBoxPrenomEleve.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxPrenomEleve.Location = new System.Drawing.Point(209, 152);
            this.textBoxPrenomEleve.Name = "textBoxPrenomEleve";
            this.textBoxPrenomEleve.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrenomEleve.TabIndex = 45;
            // 
            // textBoxNomEleve
            // 
            this.textBoxNomEleve.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxNomEleve.Location = new System.Drawing.Point(209, 104);
            this.textBoxNomEleve.Name = "textBoxNomEleve";
            this.textBoxNomEleve.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomEleve.TabIndex = 44;
            // 
            // labelNumeroTuteur
            // 
            this.labelNumeroTuteur.AutoSize = true;
            this.labelNumeroTuteur.Location = new System.Drawing.Point(37, 325);
            this.labelNumeroTuteur.Name = "labelNumeroTuteur";
            this.labelNumeroTuteur.Size = new System.Drawing.Size(163, 13);
            this.labelNumeroTuteur.TabIndex = 43;
            this.labelNumeroTuteur.Text = "Numéro de téléphone du tuteur : ";
            // 
            // labelNumeroEleve
            // 
            this.labelNumeroEleve.AutoSize = true;
            this.labelNumeroEleve.Location = new System.Drawing.Point(37, 269);
            this.labelNumeroEleve.Name = "labelNumeroEleve";
            this.labelNumeroEleve.Size = new System.Drawing.Size(166, 13);
            this.labelNumeroEleve.TabIndex = 42;
            this.labelNumeroEleve.Text = "Numéro de téléphone de l\'élève : ";
            // 
            // labelDateNaissanceEleve
            // 
            this.labelDateNaissanceEleve.AutoSize = true;
            this.labelDateNaissanceEleve.Location = new System.Drawing.Point(39, 210);
            this.labelDateNaissanceEleve.Name = "labelDateNaissanceEleve";
            this.labelDateNaissanceEleve.Size = new System.Drawing.Size(153, 13);
            this.labelDateNaissanceEleve.TabIndex = 41;
            this.labelDateNaissanceEleve.Text = "Date de naissance de l\'élève : ";
            // 
            // labelPrenomEleve
            // 
            this.labelPrenomEleve.AutoSize = true;
            this.labelPrenomEleve.Location = new System.Drawing.Point(39, 155);
            this.labelPrenomEleve.Name = "labelPrenomEleve";
            this.labelPrenomEleve.Size = new System.Drawing.Size(100, 13);
            this.labelPrenomEleve.TabIndex = 40;
            this.labelPrenomEleve.Text = "Prénom de l\'élève : ";
            // 
            // labelNomEleve
            // 
            this.labelNomEleve.AutoSize = true;
            this.labelNomEleve.Location = new System.Drawing.Point(39, 111);
            this.labelNomEleve.Name = "labelNomEleve";
            this.labelNomEleve.Size = new System.Drawing.Size(86, 13);
            this.labelNomEleve.TabIndex = 39;
            this.labelNomEleve.Text = "Nom de l\'élève : ";
            // 
            // labelModifierEleve
            // 
            this.labelModifierEleve.AutoSize = true;
            this.labelModifierEleve.Location = new System.Drawing.Point(279, 25);
            this.labelModifierEleve.Name = "labelModifierEleve";
            this.labelModifierEleve.Size = new System.Drawing.Size(88, 13);
            this.labelModifierEleve.TabIndex = 38;
            this.labelModifierEleve.Text = "Modifier un élève";
            this.labelModifierEleve.Click += new System.EventHandler(this.labelModifierEleve_Click);
            // 
            // FrmModuleModifierEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRetourSelectEleve);
            this.Controls.Add(this.buttonModifierEleve);
            this.Controls.Add(this.textBoxClasseEleve);
            this.Controls.Add(this.labelClasseEleve);
            this.Controls.Add(this.textBoxCommentaire);
            this.Controls.Add(this.labelCommentaire);
            this.Controls.Add(this.checkBoxTiersTemps);
            this.Controls.Add(this.labelTiersTemps);
            this.Controls.Add(this.textBoxNumeroTuteur);
            this.Controls.Add(this.textBoxNumeroTel);
            this.Controls.Add(this.textBoxDateNaissanceEleve);
            this.Controls.Add(this.textBoxPrenomEleve);
            this.Controls.Add(this.textBoxNomEleve);
            this.Controls.Add(this.labelNumeroTuteur);
            this.Controls.Add(this.labelNumeroEleve);
            this.Controls.Add(this.labelDateNaissanceEleve);
            this.Controls.Add(this.labelPrenomEleve);
            this.Controls.Add(this.labelNomEleve);
            this.Controls.Add(this.labelModifierEleve);
            this.Name = "FrmModuleModifierEleve";
            this.Text = "FrmModuleModifierEleve";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRetourSelectEleve;
        private System.Windows.Forms.Button buttonModifierEleve;
        private System.Windows.Forms.TextBox textBoxClasseEleve;
        private System.Windows.Forms.Label labelClasseEleve;
        private System.Windows.Forms.TextBox textBoxCommentaire;
        private System.Windows.Forms.Label labelCommentaire;
        private System.Windows.Forms.CheckBox checkBoxTiersTemps;
        private System.Windows.Forms.Label labelTiersTemps;
        private System.Windows.Forms.TextBox textBoxNumeroTuteur;
        private System.Windows.Forms.TextBox textBoxNumeroTel;
        private System.Windows.Forms.TextBox textBoxDateNaissanceEleve;
        private System.Windows.Forms.TextBox textBoxPrenomEleve;
        private System.Windows.Forms.TextBox textBoxNomEleve;
        private System.Windows.Forms.Label labelNumeroTuteur;
        private System.Windows.Forms.Label labelNumeroEleve;
        private System.Windows.Forms.Label labelDateNaissanceEleve;
        private System.Windows.Forms.Label labelPrenomEleve;
        private System.Windows.Forms.Label labelNomEleve;
        private System.Windows.Forms.Label labelModifierEleve;
        private EventHandler buttonRetourAfficherEleve_Click;
    }
}