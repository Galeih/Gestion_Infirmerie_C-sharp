using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfirmerieGUI
{
    public partial class FrmModuleAjouterEleve : Form
    {
        public FrmModuleAjouterEleve()
        {
            InitializeComponent();
        }

        private void buttonAfficherEleve_Click(object sender, EventArgs e)
        {
            FrmModuleAfficherEleve RetourAfficherEleve = new FrmModuleAfficherEleve();
            RetourAfficherEleve.Show();
            this.Close();
        }

        private void buttonModifierEleve_Click(object sender, EventArgs e)
        {
        }

        private void textBoxClasseEleve_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelClasseEleve_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCommentaire_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelCommentaire_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxTiersTemps_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labelTiersTemps_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNumeroTuteur_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNumeroTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDateNaissanceEleve_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrenomEleve_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNomEleve_TextChanged(object sender, EventArgs e)
        {

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
