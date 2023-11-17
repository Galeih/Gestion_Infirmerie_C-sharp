using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using InfirmerieBO;

namespace InfirmerieDAL
{
    public class EleveDao
    {
        private string chaineConnexion;

        public void SetChaineConnexion(string chaine)
        {
            chaineConnexion = chaine;
        }

        public List<Eleve> GetEleves()
        {
            List<Eleve> listeEleves = new List<Eleve>();

            using (SqlConnection connexion = new SqlConnection(chaineConnexion))
            {
                connexion.Open();
                string query = "SELECT * FROM ELEVE, CLASSE WHERE ELEVE.id_Classe = CLASSE.id_classe";

                using (SqlCommand cmd = new SqlCommand(query, connexion))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            Eleve eleve = new Eleve
                            {
                                IdEleve = Convert.ToInt32(reader["id_eleve"]),
                                NomEleve = reader["nom_eleve"].ToString(),
                                PrenomEleve = reader["prenom_eleve"].ToString(),
                                DateNaissance = Convert.ToDateTime(reader["date_naissance"]),
                                NumTel = reader["num_tel"].ToString(),
                                NumTelLegal = reader["num_tel_legal"].ToString(),
                                TiersTemps = reader["tiers_temps"].ToString(),
                                Commentaire = reader["commentaire"].ToString()
                            };

                            listeEleves.Add(eleve);
                        }
                    }
                }
            }

            return listeEleves;
        }

        public int InsertEleve(Eleve unEleve)
        {
            int rowsAffected = 0;

            using (SqlConnection connexion = new SqlConnection(chaineConnexion))
            {
                connexion.Open();
                string query = "INSERT INTO ELEVE (nom_eleve, prenom_eleve, date_naissance, num_tel, num_tel_legal, tiers_temps, commentaire) " +
                               "VALUES (@nom, @prenom, @dateNaissance, @numTel, @numTelLegal, @tiersTemps, @commentaire)";

                using (SqlCommand cmd = new SqlCommand(query, connexion))
                {
                    cmd.Parameters.AddWithValue("@nom", unEleve.NomEleve);
                    cmd.Parameters.AddWithValue("@prenom", unEleve.PrenomEleve);
                    cmd.Parameters.AddWithValue("@dateNaissance", unEleve.DateNaissance);
                    cmd.Parameters.AddWithValue("@numTel", unEleve.NumTel);
                    cmd.Parameters.AddWithValue("@numTelLegal", unEleve.NumTelLegal);
                    cmd.Parameters.AddWithValue("@tiersTemps", unEleve.TiersTemps);
                    cmd.Parameters.AddWithValue("@commentaire", unEleve.Commentaire);

                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }

            return rowsAffected;
        }

        public int UpdateEleve(Eleve unEleve)
        {
            int rowsAffected = 0;

            using (SqlConnection connexion = new SqlConnection(chaineConnexion))
            {
                connexion.Open();
                string query = "UPDATE ELEVE SET nom_eleve = @nom, prenom_eleve = @prenom, " +
                               "date_naissance = @dateNaissance, num_tel = @numTel, num_tel_legal = @numTelLegal, " +
                               "tiers_temps = @tiersTemps, commentaire = @commentaire " +
                               "WHERE id_eleve = @idEleve";

                using (SqlCommand cmd = new SqlCommand(query, connexion))
                {
                    cmd.Parameters.AddWithValue("@nom", unEleve.NomEleve);
                    cmd.Parameters.AddWithValue("@prenom", unEleve.PrenomEleve);
                    cmd.Parameters.AddWithValue("@dateNaissance", unEleve.DateNaissance);
                    cmd.Parameters.AddWithValue("@numTel", unEleve.NumTel);
                    cmd.Parameters.AddWithValue("@numTelLegal", unEleve.NumTelLegal);
                    cmd.Parameters.AddWithValue("@tiersTemps", unEleve.TiersTemps);
                    cmd.Parameters.AddWithValue("@commentaire", unEleve.Commentaire);
                    cmd.Parameters.AddWithValue("@idEleve", unEleve.IdEleve);

                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }

            return rowsAffected;
        }

        public int DeleteEleve(Eleve unEleve)
        {
            int rowsAffected = 0;

            using (SqlConnection connexion = new SqlConnection(chaineConnexion))
            {
                connexion.Open();
                string query = "DELETE FROM ELEVE WHERE id_eleve = @idEleve";

                using (SqlCommand cmd = new SqlCommand(query, connexion))
                {
                    cmd.Parameters.AddWithValue("@idEleve", unEleve.IdEleve);

                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }

            return rowsAffected;
        }

        public List<Eleve> GetElevesByName(string nomEleve)
        {
            List<Eleve> listeEleves = new List<Eleve>();

            using (SqlConnection connexion = new SqlConnection(chaineConnexion))
            {
                connexion.Open();
                string query = "SELECT * FROM ELEVE WHERE nom_eleve LIKE @nomEleve";

                using (SqlCommand cmd = new SqlCommand(query, connexion))
                {
                    cmd.Parameters.AddWithValue("@nomEleve", "%" + nomEleve + "%");

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Eleve eleve = new Eleve
                            {
                                IdEleve = Convert.ToInt32(reader["id_eleve"]),
                                NomEleve = reader["nom_eleve"].ToString(),
                                PrenomEleve = reader["prenom_eleve"].ToString(),
                                DateNaissance = Convert.ToDateTime(reader["date_naissance"]),
                                NumTel = reader["num_tel"].ToString(),
                                NumTelLegal = reader["num_tel_legal"].ToString(),
                                TiersTemps = reader["tiers_temps"].ToString(),
                                Commentaire = reader["commentaire"].ToString()
                            };

                            listeEleves.Add(eleve);
                        }
                    }
                }
            }

            return listeEleves;
        }

        public List<Eleve> GetElevesByClasse(int idClasse)
        {
            List<Eleve> listeEleves = new List<Eleve>();

            using (SqlConnection connexion = new SqlConnection(chaineConnexion))
            {
                connexion.Open();

                string query = "SELECT id_eleve, nom_eleve FROM ELEVE WHERE id_classe = @idClasse";

                using (SqlCommand cmd = new SqlCommand(query, connexion))
                {
                    cmd.Parameters.AddWithValue("@idClasse", idClasse);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Eleve eleve = new Eleve
                            {
                                IdEleve = Convert.ToInt32(reader["id_eleve"]),
                                NomEleve = reader["nom_eleve"].ToString()
                            };

                            listeEleves.Add(eleve);
                        }
                    }
                }
            }

            return listeEleves;
        }
    }
}