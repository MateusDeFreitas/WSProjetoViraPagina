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
        public bool IdMaterialImpressoExixte(string id)
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
                        return (count > 0); // Se existir algum registro com esse email
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao buscar identificdor: " + ex.Message);
                }
                return false;
            }
        }

        public bool IdInstrumentoExixte(string id)
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
                        return (count > 0); // Se existir algum registro com esse email
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao buscar identificdor: " + ex.Message);
                }
                return false;
            }
        }

        public bool IdJogoExixte(string id)
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
                        return (count > 0); // Se existir algum registro com esse email
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao buscar identificdor: " + ex.Message);
                }
                return false;
            }
        }

        public bool IdMidiaExixte(string id)
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
                        return (count > 0); // Se existir algum registro com esse email
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao buscar identificdor: " + ex.Message);
                }
                return false;
            }
        }

        public bool IdEmprestimoExixte(string id)
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
                        return (count > 0); // Se existir algum registro com esse email
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao buscar identificdor: " + ex.Message);
                }
                return false;
            }
        }

        public bool IdTomadorExixte(string id)
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
                        return (count > 0); // Se existir algum registro com esse email
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao buscar identificdor: " + ex.Message);
                }
                return false;
            }
        }
    }
}
