using System;
using System.Windows.Forms;

namespace InfirmerieGUI
{
    public partial class FrmModifierSelectEleve : Form
    {
        private FrmModuleModifierEleve frmModuleModifierEleve;

        public FrmModifierSelectEleve()
        {
            InitializeComponent();
        }

        public FrmModifierSelectEleve(FrmModuleModifierEleve frmModuleModifierEleve)
        {
            this.frmModuleModifierEleve = frmModuleModifierEleve;
        }

        private void buttonRetourAccueil_Click(object sender, EventArgs e)
        {

        }
        //Bouton qui renvoie vers la page de modification de l'élève
        private void buttonRetour_Click(object sender, EventArgs e)
        {
            FrmModuleModifierEleve form2 = new FrmModuleModifierEleve(this);
            form2.Show();
            this.Close();
        }

        //Bouton qui renvoie vers la page de modification de l'élève
        private void buttonModifier_Click(object sender, EventArgs e)
        {
            FrmModuleModifierEleve form2 = new FrmModuleModifierEleve(this);
            form2.Show();
            this.Close();
        }
    }
}
