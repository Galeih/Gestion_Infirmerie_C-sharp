namespace InfirmerieGUI
{
    partial class FrmModuleValidateSuppression
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
            this.buttonValidateYes = new System.Windows.Forms.Button();
            this.buttonValidateNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supprimer un élève";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Voulez-vous supprimer cet élève ?";
            // 
            // buttonValidateYes
            // 
            this.buttonValidateYes.Location = new System.Drawing.Point(177, 193);
            this.buttonValidateYes.Name = "buttonValidateYes";
            this.buttonValidateYes.Size = new System.Drawing.Size(75, 23);
            this.buttonValidateYes.TabIndex = 2;
            this.buttonValidateYes.Text = "Oui";
            this.buttonValidateYes.UseVisualStyleBackColor = true;
            this.buttonValidateYes.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonValidateNo
            // 
            this.buttonValidateNo.Location = new System.Drawing.Point(341, 193);
            this.buttonValidateNo.Name = "buttonValidateNo";
            this.buttonValidateNo.Size = new System.Drawing.Size(75, 23);
            this.buttonValidateNo.TabIndex = 3;
            this.buttonValidateNo.Text = "Non";
            this.buttonValidateNo.UseVisualStyleBackColor = true;
            this.buttonValidateNo.Click += new System.EventHandler(this.buttonValidateNo_Click);
            // 
            // FrmModuleValidateSuppression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonValidateNo);
            this.Controls.Add(this.buttonValidateYes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmModuleValidateSuppression";
            this.Text = "FrmModulationValidateSuppression";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonValidateYes;
        private System.Windows.Forms.Button buttonValidateNo;
    }
}