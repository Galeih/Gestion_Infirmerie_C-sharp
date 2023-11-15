using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfirmerieBO; // Référence la couche BO
using System.Data.SqlClient;
using System;

namespace UtilisateurDAL
{
    public class UtilisateurDAO
    {
        private static UtilisateurDAO unUtilisateurDAO;
        // Accesseur en lecture, renvoi une instance
        public static UtilisateurDAO GetunUtilisateurDAO()
        {
            if (unUtilisateurDAO == null)
            {
                unUtilisateurDAO = new UtilisateurDAO();
            }
            return unUtilisateurDAO;
        }

        //Faire une fonction pour retourner la fonction ValidateLogin
        

    }
}

