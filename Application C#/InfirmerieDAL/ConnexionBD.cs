using System;
using System.Data.SqlClient;

namespace UtilisateurDAL
{
    //Classe de gestion de la connexion à la BD
    public class ConnexionBD
    {
        private SqlConnection maConnexion;
        private static ConnexionBD uneConnexionBD; // Instance d'une connexion
        private string chaineConnexion; // Chaîne de connexion à la BDD

        //Accesseur en lecture de la chaîne de connexion
        public string GetchaineConnexion()
        {
            return chaineConnexion;
        }

        //Accesseur en écriture de la chaîne de connexion
        public void SetchaineConnexion(string ch)
        {
            chaineConnexion = ch;
        }

        // Accesseur en lecture, renvoi une instance de connexion
        public static ConnexionBD GetConnexionBD()
        {
            if (uneConnexionBD == null)
            {
                uneConnexionBD = new ConnexionBD();
            }
            return uneConnexionBD;
        }

        // Constructeur privé
        private ConnexionBD()
        {
        }

        // Modification effectuée sur la gestion de la connexion avec affichage d'erreurs
        public SqlConnection GetSqlConnexion()
        {
            if (maConnexion == null)
            {
                maConnexion = new SqlConnection(chaineConnexion);
                try
                {
                    maConnexion.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erreur de connexion à la base de données : " + ex.Message);
                    throw;
                }
            }
            return maConnexion;
        }

        public void CloseConnexion()
        {
            if (maConnexion != null && maConnexion.State != System.Data.ConnectionState.Closed)
            {
                maConnexion.Close();
                maConnexion = null; // Réinitialiser la connexion après la fermeture
            }
        }
    }
}

// Plusieurs points sont à évoquer :
// La méthode GetSqlConnexion() utilise maConnexion pour stocker la connexion et la retourne si elle existe déjà.
// La méthode CloseConnexion() ferme la connexion et réinitialise maConnexion à null après la fermeture.
// Cette approche indique qu'une seule connexion est utilisée et qu'elle est correctement gérée lors de l'ouverture et/ou la fermeture.