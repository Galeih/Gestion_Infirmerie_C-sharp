using System;
using System.Data.SqlClient;
using InfirmerieBO; // Référence la couche BO

namespace InfirmerieDAL
{
    public class UtilisateurDao
    {
        private static UtilisateurDao unUtilisateurDAO;
        private string chaineConnexion;

        // Méthode pour obtenir une instance de la classe UtilisateurDao
        public static UtilisateurDao GetunUtilisateurDAO()
        {
            if (unUtilisateurDAO == null)
            {
                unUtilisateurDAO = new UtilisateurDao();
            }
            return unUtilisateurDAO;
        }

        // Méthode pour définir la chaîne de connexion
        public void SetchaineConnexion(string connectionString)
        {
            chaineConnexion = connectionString;
        }

        // Méthode pour valider les informations d'identification
        public bool ValidateLogin(Login utilisateur)
        {
            bool loginIsValid = false;

            using (SqlConnection connection = new SqlConnection(chaineConnexion))
            {
                string query = "SELECT COUNT(*) FROM Utilisateurs WHERE NomUtilisateur = @NomUtilisateur AND MotDePasse = @MotDePasse";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@NomUtilisateur", utilisateur.User);
                cmd.Parameters.AddWithValue("@MotDePasse", utilisateur.Password);

                try
                {
                    connection.Open();
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        loginIsValid = true;
                    }
                }
                catch (Exception ex)
                {
                    // Gérer l'exception (ex) de connexion à la base de données ici
                    Console.WriteLine("Erreur de connexion à la base de données : " + ex.Message);
                }
            }

            return loginIsValid;
        }
    }
}
