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
        public FrmModuleSupprimerSelectEleve()
        {
            InitializeComponent();
        }

        private void buttonRetourSupprimer_Click(object sender, EventArgs e)
        {

        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            FrmModuleValidateSuppression validateSuppression = new FrmModuleValidateSuppression(this);
            validateSuppression.Show();
        }
    }
}
