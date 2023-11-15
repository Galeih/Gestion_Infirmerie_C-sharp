using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfirmerieBO
{
    internal class Eleve
    {
        private int id_eleve;
        private string nom_eleve;
        private string prenom_eleve;
        private DateTime date_naissance;
        private string num_tel;
        private string num_tel_legal;
        private string tiers_temps;
        private string commentaire;
        private int classe_fk;
        public Eleve(int id_eleve, string nom_eleve, string prenom_eleve, DateTime date_naissance, string num_tel, string num_tel_legal, string tiers_temps, string commentaire, int classe_fk)
        {
            this.id_eleve = id_eleve;
            this.nom_eleve = nom_eleve;
            this.prenom_eleve = prenom_eleve;
            this.date_naissance = date_naissance;
            this.num_tel = num_tel;
            this.num_tel_legal = num_tel_legal;
            this.tiers_temps = tiers_temps;
            this.commentaire = commentaire;
            this.classe_fk = classe_fk;
        }

    }
}
