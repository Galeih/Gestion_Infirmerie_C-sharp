using InfirmerieBO;
using System.Configuration;
using System.Windows.Forms;
using System;
using UtilisateurDAL;

namespace InfirmerieGUI
{
    public partial class FrmModuleConnexion : Form
    {
        public FrmModuleConnexion()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringSetting"]?.ConnectionString;

            // Vérification que la chaîne de connexion est présente avant de la passer à UtilisateurDao
            if (!string.IsNullOrEmpty(connectionString))
            {
                UtilisateurDao.GetunUtilisateurDAO().SetchaineConnexion(connectionString);
            }
            else
            {
                MessageBox.Show("La chaîne de connexion est manquante ou invalide. Veuillez vérifier la configuration.");
                // Vous pouvez ajouter d'autres actions à prendre en cas de chaîne de connexion manquante/invalide
            }
        }

        private void btnValidConnex_Click(object sender, EventArgs e)
        {
            // Récupérer l'identifiant et le mot de passe depuis les contrôles du formulaire
            Login utilisateur = new Login(textBoxIdentifiant.Text, textBoxPassword.Text);

            // Vérifier les identifiants dans la base de données
            if (UtilisateurDao.GetunUtilisateurDAO().ValidateLogin(utilisateur)) //Passer par la BLL
            {
                MessageBox.Show("Connexion réussie!");
                // Ajouter le code pour passer à la prochaine fenêtre ou effectuer d'autres actions après la connexion réussie.
            }
            else
            {
                MessageBox.Show("Identifiant ou mot de passe incorrect.");
            }
        }

        private void textBoxIdentifiant_TextChanged(object sender, EventArgs e)
        {
            // Optionnel : Ajouter du code en réponse à des modifications dans le champ de l'identifiant.
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            // Optionnel : Ajouter du code en réponse à des modifications dans le champ du mot de passe.
        }
    }
}
