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
            this.Id_visite = id_visite;
            this.Date_visite = date_visite;
            this.Heure_arrive = heure_arrive;
            this.Heure_depart = heure_depart;
            this.Motif = motif;
            this.Commentaire = commentaire;
            this.Rentre_maison = rentre_maison;
            this.Rentre_classe = rentre_classe;
            this.Hopital = hopital;
            this.Notification_tuteur = notification_tuteur;
        }

        public int Id_visite { get => id_visite; set => id_visite = value; }
        public DateTime Date_visite { get => date_visite; set => date_visite = value; }
        public string Heure_arrive { get => heure_arrive; set => heure_arrive = value; }
        public string Heure_depart { get => heure_depart; set => heure_depart = value; }
        public string Motif { get => motif; set => motif = value; }
        public string Commentaire { get => commentaire; set => commentaire = value; }
        public string Rentre_maison { get => rentre_maison; set => rentre_maison = value; }
        public string Rentre_classe { get => rentre_classe; set => rentre_classe = value; }
        public string Hopital { get => hopital; set => hopital = value; }
        public string Notification_tuteur { get => notification_tuteur; set => notification_tuteur = value; }
    }
}
