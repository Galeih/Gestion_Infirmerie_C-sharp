using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using InfirmerieBO;
using InfirmerieDAL;
using UtilisateurDAL;

namespace InfirmerieBLL
{
    public class GestionEleves
    {
        private static GestionEleves uneGestionEleves; // Objet BLL
        private EleveDao eleveDAO; // Référence vers la couche DAL

        // Accesseur en lecture
        public static GestionEleves GetGestionEleves()
        {
            if (uneGestionEleves == null)
            {
                uneGestionEleves = new GestionEleves();
            }

            return uneGestionEleves;
        }

        // Définit la chaîne de connexion
        public void SetChaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);

            // Initialisation de la couche DAL (EleveDAO)
            eleveDAO = new EleveDao();
        }

        // Récupère une liste d'objets contenant tous les élèves
        public List<Eleve> ObtenirTousLesEleves()
        {
            // Utilisation de la méthode GetEleves de la couche DAL (EleveDAO)
            return eleveDAO.GetEleves();
        }

        // Recherche d'un élève par nom
        public List<Eleve> RechercherEleveParNom(string nomEleve)
        {
            // Utilisation de la méthode GetEleves de la couche DAL (EleveDAO)
            return eleveDAO.GetElevesByName(nomEleve);
        }

        // Ajout d'un nouvel élève
        public int AjouterEleve(Eleve unEleve)
        {
            // Utilisation de la méthode InsertEleve de la couche DAL (EleveDAO)
            return eleveDAO.InsertEleve(unEleve);
        }

        // Modification d'un élève
        public int ModifierEleve(Eleve unEleve)
        {
            // Utilisation de la méthode UpdateEleve de la couche DAL (EleveDAO)
            return eleveDAO.UpdateEleve(unEleve);
        }

        // Suppression d'un élève
        public int SupprimerEleve(Eleve unEleve)
        {
            // Utilisation de la méthode DeleteEleve de la couche DAL (EleveDAO)
            return eleveDAO.DeleteEleve(unEleve);
        }
    }
}