using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfirmerieBO
{
    public class Classe
    {
        private readonly int idClasse;
        private readonly string libelleClasse;

        // Constructeur de la classe Classe
        public Classe(int idClasse, string libelleClasse)
        {
            this.idClasse = idClasse;
            this.libelleClasse = libelleClasse;
        }

        // Propriété en lecture seule pour l'identifiant de la classe
        public int IdClasse => idClasse;

        // Propriété en lecture seule pour le libellé de la classe
        public string LibelleClasse => libelleClasse;
    }
}