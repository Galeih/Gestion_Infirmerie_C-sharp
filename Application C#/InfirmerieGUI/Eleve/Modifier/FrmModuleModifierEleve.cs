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
        private FrmModifierSelectEleve RetourSelectEleve;

        //Constructeur de "FrmModuleModifierEleve"
        public FrmModuleModifierEleve(FrmModifierSelectEleve RetourSelectEleve)
        {
            InitializeComponent();
            this.RetourSelectEleve = RetourSelectEleve;
        }

        private void labelModifierEleve_Click(object sender, EventArgs e)
        {

        }

        //Bouton retour vers la selection de l'élève à modifier
        private void buttonRetourSelectEleve_Click(object sender, EventArgs e)
        {
            RetourSelectEleve.Show();
            this.Close();
        }

        private void buttonModifierEleve_Click(object sender, EventArgs e)
        {

        }
    }
}
