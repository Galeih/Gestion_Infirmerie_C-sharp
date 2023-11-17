using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfirmerieBO
{
    public class Medicament
    {
        public int Id_medicament { get; set; }
        public string Nom_medicament { get; set; }
        public string Quantite_medic { get; set; }

        public Medicament(int id_medicament, string nom_medicament, string quantite_medicament)
        {
            Id_medicament = id_medicament;
            Nom_medicament = nom_medicament;
            Quantite_medic = quantite_medicament;
        }
    }
}
