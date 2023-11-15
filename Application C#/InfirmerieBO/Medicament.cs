using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfirmerieBO
{
    internal class Medicament
    {
        private int id_medicament;
        private string nom_medicament;
        private string quantite_medic;

        public Medicament(int id_medicament, string nom_medicament, string quantite_medicament)
        {
            this.id_medicament = id_medicament;
            this.nom_medicament = nom_medicament;
            this.quantite_medic = quantite_medicament;
        }
    }
}
