using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfirmerieBO
{
    public class Eleve
    {
        // Propriétés de la classe Eleve (En PascalCase pour le nom des propriétés)
        public int IdEleve { get; set; }
        public string NomEleve { get; set; }
        public string PrenomEleve { get; set; }
        public DateTime DateNaissance { get; set; }
        public string NumTel { get; set; }
        public string NumTelLegal { get; set; }
        public string TiersTemps { get; set; }
        public string Commentaire { get; set; }
        public Classe ClasseFk { get; set; }

        // Constructeur de la classe Eleve (En camelCase pour les paramètres du constructeur)
        public Eleve(int idEleve, string nomEleve, string prenomEleve, DateTime dateNaissance, string numTel, string numTelLegal, string tiersTemps, string commentaire, Classe classeFk)
        {
            IdEleve = idEleve;
            NomEleve = nomEleve;
            PrenomEleve = prenomEleve;
            DateNaissance = dateNaissance;
            NumTel = numTel;
            NumTelLegal = numTelLegal;
            TiersTemps = tiersTemps;
            Commentaire = commentaire;
            ClasseFk = classeFk;
        }

        // Constructeur par défaut si nécessaire (Initialisation de certains objets, Utilisation dans les tableaux, Sérialisation / Désérialisation)
        public Eleve()
        {
        }
    }
}