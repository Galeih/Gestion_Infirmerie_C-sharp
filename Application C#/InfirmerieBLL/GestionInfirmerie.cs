using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using InfirmerieBO; // Référence la couche BO
using UtilisateurDAL; // Référence la couche DAL
using System.Data.SqlClient;

namespace InfirmerieBLL
{
    public class GestionUtilisateurs
    {
        private static GestionUtilisateurs uneGestionUtilisateurs; // objet BLL

        // Accesseur en lecture
        public static GestionUtilisateurs GetGestionUtilisateurs()
        {
            if (uneGestionUtilisateurs == null)
            {
                uneGestionUtilisateurs = new GestionUtilisateurs();
            }
            return uneGestionUtilisateurs;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        //Passer par la DAL (fontion ValidateLogin)
        public static bool ValidateLogin(Login uti)
        {
            SqlDataReader result;
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM utilisateur WHERE utilisateur_login = '@login' AND utilisateur_mdp = '@mdp'";
            cmd.Parameters.AddWithValue("@login", uti.GetUser());
            cmd.Parameters.AddWithValue("@mdp", uti.GetPassword());
            result = cmd.ExecuteReader();
            bool res = result.HasRows;
            maConnexion.Close();

            return (res);
        }
    }
}