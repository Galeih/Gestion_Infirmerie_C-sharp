using System;
using System.Configuration;
using System.Data.SqlClient;
using InfirmerieBO;
using InfirmerieDAL;
using UtilisateurDAL;

namespace InfirmerieBLL
{
    public class GestionUtilisateurs
    {
        private static GestionUtilisateurs uneGestionUtilisateurs; // Objet BLL

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

        // Passer par la DAL (fonction ValidateLogin)
        public static bool ValidateLogin(Login uti)
        {
            bool res = false;

            using (SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = maConnexion,
                    CommandText = "SELECT * FROM utilisateur WHERE utilisateur_login = @login AND utilisateur_mdp = @mdp"
                };
                cmd.Parameters.AddWithValue("@login", uti.User); // Utilisation de la propriété User de la classe Login
                cmd.Parameters.AddWithValue("@mdp", uti.Password); // Utilisation de la propriété Password de la classe Login

                SqlDataReader result = cmd.ExecuteReader();
                res = result.HasRows;
            } // La connexion se ferme automatiquement à la fin du bloc 'using'

            return res;
        }
    }
}