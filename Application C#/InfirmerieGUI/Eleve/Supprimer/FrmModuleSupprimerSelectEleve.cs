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
    public partial class FrmModuleSupprimerSelectEleve : Form
    {
        private FrmModuleAccueil RetourAccueil;

        //Constructeur de "FrmModuleSupprimerSelectEleve"
        public FrmModuleSupprimerSelectEleve()
        {
            InitializeComponent();
        }

        //Bouton qui renvoie vers la page d'accueil
        private void buttonRetourAccueil_Click(object sender, EventArgs e)
        {
            FrmModuleAfficherEleve RetourAfficherEleve = new FrmModuleAfficherEleve();
            RetourAfficherEleve.Show();
            this.Close();
        }
        //Bouton qui selectionne l'élève à supprimer
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
        }
    }
}
