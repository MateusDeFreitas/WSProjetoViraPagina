using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ViraPagina.DAO
{
    public class UtilDAO
    {
        private string connectionString = "Server=localhost;Database=bd_virapagina;Uid=root;Pwd=";

        public bool IdMaterialImpressoExiste(string id)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query1 = "SELECT COUNT(1) FROM materialimpresso WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query1, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return (count > 0); 
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao buscar identificdor: " + ex.Message);
                }
                return false;
            }
        }

        public bool IdInstrumentoExiste(string id)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query1 = "SELECT COUNT(1) FROM instrumento WHERE idInstrumento = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query1, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return (count > 0); 
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao buscar identificdor: " + ex.Message);
                }
                return false;
            }
        }

        public bool IdJogoExiste(string id)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query1 = "SELECT COUNT(1) FROM jogo WHERE idJogo = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query1, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return (count > 0); 
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao buscar identificdor: " + ex.Message);
                }
                return false;
            }
        }

        public bool IdMidiaExiste(string id)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query1 = "SELECT COUNT(1) FROM midia WHERE idMidia = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query1, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return (count > 0); 
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao buscar identificdor: " + ex.Message);
                }
                return false;
            }
        }

        public bool IdEmprestimoExiste(string id)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query1 = "SELECT COUNT(1) FROM emprestimo WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query1, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return (count > 0); 
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao buscar identificdor: " + ex.Message);
                }
                return false;
            }
        }

        public bool IdTomadorExiste(string id)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query1 = "SELECT COUNT(1) FROM tomadores WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query1, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return (count > 0); 
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao buscar identificdor: " + ex.Message);
                }
                return false;
            }
        }

        public bool IdPenalidadeExiste(string id)
        {
            bool redistroExistente = false;

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query1 = "SELECT COUNT(*) FROM penalidade WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query1, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        redistroExistente = (count > 0); 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar registro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                return redistroExistente;
            }
        }

        public bool NumeroDeSerieExiste(string numeroSerie)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query1 = "SELECT COUNT(1) FROM instrumento WHERE numeroSerie = @numeroSerie";
                    using (MySqlCommand cmd = new MySqlCommand(query1, con))
                    {
                        cmd.Parameters.AddWithValue("@numeroSerie", numeroSerie);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return (count > 0); 
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao buscar identificdor: " + ex.Message);
                }
                return false;
            }
        }

        //public bool idMaterialImpressoExiste(string id)
        //{
        //    bool redistroExistente = false;

        //    using (MySqlConnection con = new MySqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            con.Open();
        //            string query1 = "SELECT COUNT(*) FROM materialimpresso WHERE id = @id";
        //            using (MySqlCommand cmd = new MySqlCommand(query1, con))
        //            {
        //                cmd.Parameters.AddWithValue("@id", id);
        //                int count = Convert.ToInt32(cmd.ExecuteScalar());
        //                redistroExistente = (count > 0); // Se existir algum registro com esse email
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Erro ao buscar registro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        }

        //        return redistroExistente;
        //    }
        //}
    }
}
