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
        public FrmModuleValidateSuppression(FrmModuleSupprimerSelectEleve parentFormSupprimer)
        {
            InitializeComponent();
            this.parentFormSupprimer = parentFormSupprimer;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void buttonValidateNo_Click(object sender, EventArgs e)
        {
            parentFormSupprimer.Show();
            this.Close();
        }
    }
}
