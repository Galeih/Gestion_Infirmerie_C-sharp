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
    public partial class FrmModuleAfficherEleve : Form
    {
        private FrmModuleAccueil retourAccueil;
        private FrmModuleAjouterEleve frmModuleAjouterEleve;

        //Constructeur de "FrmModuleAfficherEleve"
        public FrmModuleAfficherEleve()
        {
            InitializeComponent();
        }


        //Bouton qui renvoie vers la page d'accueil
        private void btnRetourMenu_Click(object sender, EventArgs e)
        {
            retourAccueil.Show();
            this.Close();
        }

        private void FrmModuleAfficherEleve_Load(object sender, EventArgs e)
        {

        }
    }
}
