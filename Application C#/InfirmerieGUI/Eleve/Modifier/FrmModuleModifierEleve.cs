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
    public partial class FrmModuleModifierEleve : Form
    {
        private FrmModifierSelectEleve frmModifierSelectEleve;

        public FrmModuleModifierEleve()
        {
            InitializeComponent();
        }

        public FrmModuleModifierEleve(FrmModifierSelectEleve frmModifierSelectEleve)
        {
            this.frmModifierSelectEleve = frmModifierSelectEleve;
        }

        private void labelModifierEleve_Click(object sender, EventArgs e)
        {

        }

        //Bouton retour vers la selection de l'élève à modifier
        private void buttonRetourAfficherEleve_Click(object sender, EventArgs e)
        {
            FrmModifierSelectEleve form2 = new FrmModifierSelectEleve(this);
            form2.Show();
            this.Close();
        }
    }
}
