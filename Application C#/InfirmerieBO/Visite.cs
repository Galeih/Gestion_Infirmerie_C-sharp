using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfirmerieBO
{
    internal class Visite
    {
        private int id_visite;
        private DateTime date_visite;
        private string heure_arrive;
        private string heure_depart;
        private string motif;
        private string commentaire;
        private string rentre_maison;
        private string rentre_classe;
        private string hopital;
        private string notification_tuteur;

        public Visite(int id_visite, DateTime date_visite, string heure_arrive, string heure_depart, string motif, string commentaire, string rentre_maison, string rentre_classe, string hopital, string notification_tuteur)
        {
            this.id_visite = id_visite;
            this.date_visite = date_visite;
            this.heure_arrive = heure_arrive;
            this.heure_depart = heure_depart;
            this.motif = motif;
            this.commentaire = commentaire;
            this.rentre_maison = rentre_maison;
            this.rentre_classe = rentre_classe;
            this.hopital = hopital;
            this.notification_tuteur = notification_tuteur;
        }
    }
}
