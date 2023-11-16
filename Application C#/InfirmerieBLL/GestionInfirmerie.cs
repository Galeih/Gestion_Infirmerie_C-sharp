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


/*Utilisation de la déclaration using pour garantir la fermeture automatique de la connexion à la base de données après utilisation (dans la méthode ValidateLogin).
Correction de la requête SQL en supprimant les guillemets simples autour des paramètres @login et @mdp. Les paramètres dans une requête paramétrée ne doivent pas être entourés de guillemets simples ou doubles.
Changement de la variable res pour être déclarée et initialisée à false au début de la méthode ValidateLogin.
Utilisation de bool res = result.HasRows; pour déterminer si des lignes ont été renvoyées par la requête SQL.
*/