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
        private Classe classe_fk;
        public Eleve(int id_eleve, string nom_eleve, string prenom_eleve, DateTime date_naissance, string num_tel, string num_tel_legal, string tiers_temps, string commentaire, Classe classe_fk)
        {
            this.Id_eleve = id_eleve;
            this.Nom_eleve = nom_eleve;
            this.Prenom_eleve = prenom_eleve;
            this.Date_naissance = date_naissance;
            this.Num_tel = num_tel;
            this.Num_tel_legal = num_tel_legal;
            this.Tiers_temps = tiers_temps;
            this.Commentaire = commentaire;
            this.Classe_fk = classe_fk;
        }

        public int Id_eleve { get => id_eleve; set => id_eleve = value; }
        public string Nom_eleve { get => nom_eleve; set => nom_eleve = value; }
        public string Prenom_eleve { get => prenom_eleve; set => prenom_eleve = value; }
        public DateTime Date_naissance { get => date_naissance; set => date_naissance = value; }
        public string Num_tel { get => num_tel; set => num_tel = value; }
        public string Num_tel_legal { get => num_tel_legal; set => num_tel_legal = value; }
        public string Tiers_temps { get => tiers_temps; set => tiers_temps = value; }
        public string Commentaire { get => commentaire; set => commentaire = value; }
        internal Classe Classe_fk { get => classe_fk; set => classe_fk = value; }
    }
}
