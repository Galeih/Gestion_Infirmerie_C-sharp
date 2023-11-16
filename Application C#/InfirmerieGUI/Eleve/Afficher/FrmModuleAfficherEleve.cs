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

        public FrmModuleAfficherEleve(FrmModuleAccueil retourAccueil)
        {
            InitializeComponent();
            this.retourAccueil = retourAccueil;
        }

        public FrmModuleAfficherEleve(FrmModuleAjouterEleve frmModuleAjouterEleve)
        {
            this.frmModuleAjouterEleve = frmModuleAjouterEleve;
        }

        private void btnRetourMenu_Click(object sender, EventArgs e)
        {
            retourAccueil.Show();
            this.Close();
        }
    }
}
