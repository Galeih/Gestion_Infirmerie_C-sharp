using InfirmerieBO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InfirmerieBLL;
using InfirmerieBO;

namespace InfirmerieGUI
{
    public partial class FrmModuleAjouterEleve : Form
    {

        private GestionEleves eleveBLL;
        private string prenomEleve;
        private string nomEleve;
        private DateTime dateNaissanceEleve;
        private string numeroEleve;
        private string numeroTuteur;
        private string tiersTemps;
        private string commentaire;
        private int classeEleve;

        public FrmModuleAjouterEleve()
        {
            InitializeComponent();

            eleveBLL = new GestionEleves();
        }

        private void buttonAfficherEleve_Click(object sender, EventArgs e)
        {
            FrmModuleAfficherEleve RetourAfficherEleve = new FrmModuleAfficherEleve();
            RetourAfficherEleve.Show();
            this.Close();
        }

        private void buttonModifierEleve_Click(object sender, EventArgs e)
        {
            Eleve nouvelEleve = new Eleve
            {
                NomEleve = nomEleve,
                PrenomEleve = prenomEleve,
                DateNaissance = dateNaissanceEleve,
                NumTel = numeroEleve,
                NumTelLegal = numeroTuteur,
                TiersTemps = tiersTemps,
                Commentaire = commentaire,

            };
            int rowsAffected = eleveBLL.AjouterEleve(nouvelEleve);

            if (rowsAffected > 0)
            {
                MessageBox.Show("L'élève a été ajouté avec succès à la base de données.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erreur lors de l'ajout de l'élève à la base de données.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxClasseEleve_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelClasseEleve_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCommentaire_TextChanged(object sender, EventArgs e)
        {
            commentaire = textBoxCommentaire.Text;
        }

        private void labelCommentaire_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxTiersTemps_CheckedChanged(object sender, EventArgs e)
        {
            tiersTemps = "y";
        }

        private void labelTiersTemps_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNumeroTuteur_TextChanged(object sender, EventArgs e)
        {
            numeroEleve = textBoxNumeroTuteur.Text;
        }

        private void textBoxNumeroTel_TextChanged(object sender, EventArgs e)
        {
            numeroTuteur = textBoxNumeroTuteur.Text;
        }

        private void textBoxDateNaissanceEleve_TextChanged(object sender, EventArgs e)
        {
            DateTime.TryParse(textBoxDateNaissanceEleve.Text, out dateNaissanceEleve);
        }
        private void textBoxPrenomEleve_TextChanged(object sender, EventArgs e)
        {
            prenomEleve = textBoxPrenomEleve.Text;

        }

        private void textBoxNomEleve_TextChanged(object sender, EventArgs e)
        {
            nomEleve = textBoxNomEleve.Text;
        }

        private void labelNumeroTuteur_Click(object sender, EventArgs e)
        {

        }

        private void labelNumeroEleve_Click(object sender, EventArgs e)
        {

        }

        private void labelDateNaissanceEleve_Click(object sender, EventArgs e)
        {

        }

        private void labelPrenomEleve_Click(object sender, EventArgs e)
        {

        }

        private void labelNomEleve_Click(object sender, EventArgs e)
        {

        }

        private void labelAjouterEleve_Click(object sender, EventArgs e)
        {

        }
    }
}
