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
            this.Id_medicament = id_medicament;
            this.Nom_medicament = nom_medicament;
            this.Quantite_medic = quantite_medicament;
        }

        public int Id_medicament { get => id_medicament; set => id_medicament = value; }
        public string Nom_medicament { get => nom_medicament; set => nom_medicament = value; }
        public string Quantite_medic { get => quantite_medic; set => quantite_medic = value; }
    }
}
