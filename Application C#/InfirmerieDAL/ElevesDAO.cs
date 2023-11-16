using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using InfirmerieBO; // Référence la couche BO

namespace InfirmerieDAL
{
    public class EleveDAO
    {
        private static EleveDAO unEleveDAO;

        // Accesseur en lecture, renvoi une instance
        public static EleveDAO GetunEleveDAO()
        {
            if (unEleveDAO == null)
            {
                unEleveDAO = new EleveDAO();
            }

            return unEleveDAO;
        }

        public static List<Eleve> GetEleves()
        {
            int id;
            string nom;
            string prenom;
            DateTime date_de_naissance;
            string telephone;
            string telephone_parent;
            bool tiers_temps;
            string commentaire_sante;
            Classe classe;
        }