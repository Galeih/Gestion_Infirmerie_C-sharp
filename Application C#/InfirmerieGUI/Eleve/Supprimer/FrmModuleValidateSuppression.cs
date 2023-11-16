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
    public partial class FrmModuleValidateSuppression : Form
    {
        private FrmModuleSupprimerSelectEleve parentFormSupprimer;
        //Constructeur de "FrmModuleValidateSuppression"
        public FrmModuleValidateSuppression()
        {
            InitializeComponent();
        }

        //Bouton qui supprime l'élève selectionner
        private void buttonValidateYes_Click(object sender, EventArgs e)
        {

        }
        //Bouton qui renvoie vers la page de selection de l'élève à supprimer
        private void buttonValidateNo_Click(object sender, EventArgs e)
        {
            parentFormSupprimer.Show();
            this.Close();
        }
    }
}
