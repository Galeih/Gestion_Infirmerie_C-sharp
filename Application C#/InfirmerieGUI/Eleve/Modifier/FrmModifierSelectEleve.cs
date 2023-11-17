using System;
using System.Windows.Forms;

namespace InfirmerieGUI
{
    public partial class FrmModifierSelectEleve : Form
    {
        private FrmModuleModifierEleve modifierEleve;
        private FrmModuleAccueil voirEleve;
        private 

        //Constructeur de "FrmModifierSelectEleve"
        public FrmModifierSelectEleve()
        {
            InitializeComponent();
        }


        private void buttonRetourAccueil_Click(object sender, EventArgs e)
        {

        }
        //Bouton qui renvoie vers la page "FrmModuleAfficherEleve"
        private void buttonRetour_Click(object sender, EventArgs e)
        {
            voirEleve.Show();
            this.Close();
        }

        //Bouton qui renvoie vers la page de modification de l'élève
        private void buttonModifier_Click(object sender, EventArgs e)
        {
            modifierEleve.Show();
            this.Close();
        }

        private void comboBoxClasseEleve_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
