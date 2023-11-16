namespace InfirmerieGUI
{
    partial class FrmModuleAfficherEleve
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRechercherEleve = new System.Windows.Forms.TextBox();
            this.dataGridViewEleve = new System.Windows.Forms.DataGridView();
            this.btnRetourMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEleve)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rechercher un élève";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rechercher un éléve :";
            // 
            // textBoxRechercherEleve
            // 
            this.textBoxRechercherEleve.Location = new System.Drawing.Point(234, 58);
            this.textBoxRechercherEleve.Name = "textBoxRechercherEleve";
            this.textBoxRechercherEleve.Size = new System.Drawing.Size(100, 20);
            this.textBoxRechercherEleve.TabIndex = 2;
            // 
            // dataGridViewEleve
            // 
            this.dataGridViewEleve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEleve.Location = new System.Drawing.Point(63, 123);
            this.dataGridViewEleve.Name = "dataGridViewEleve";
            this.dataGridViewEleve.Size = new System.Drawing.Size(487, 181);
            this.dataGridViewEleve.TabIndex = 3;
            // 
            // btnRetourMenu
            // 
            this.btnRetourMenu.Location = new System.Drawing.Point(263, 352);
            this.btnRetourMenu.Name = "btnRetourMenu";
            this.btnRetourMenu.Size = new System.Drawing.Size(75, 23);
            this.btnRetourMenu.TabIndex = 5;
            this.btnRetourMenu.Text = "Retour";
            this.btnRetourMenu.UseVisualStyleBackColor = true;
            this.btnRetourMenu.Click += new System.EventHandler(this.btnRetourMenu_Click);
            // 
            // FrmModuleAfficherEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetourMenu);
            this.Controls.Add(this.dataGridViewEleve);
            this.Controls.Add(this.textBoxRechercherEleve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmModuleAfficherEleve";
            this.Text = "FrmModuleAfficherEleve";
            this.Load += new System.EventHandler(this.FrmModuleAfficherEleve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEleve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRechercherEleve;
        private System.Windows.Forms.DataGridView dataGridViewEleve;
        private System.Windows.Forms.Button btnRetourMenu;
    }
}