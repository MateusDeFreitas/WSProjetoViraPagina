using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
                    using (MySqlCommand cmd = new MySqlCommand("contarMaterialImpressoPorId", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_idMaterialImpresso", id);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return (count > 0); 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar identificador: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    using (MySqlCommand cmd = new MySqlCommand("contarInstrumentoPorId", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_idInstrumento", id);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return (count > 0); 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar identificador: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    using (MySqlCommand cmd = new MySqlCommand("contarJogoPorId", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_idJogo", id);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return (count > 0); 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar identificador: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    using (MySqlCommand cmd = new MySqlCommand("contarMidiaPorId", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_idMidia", id);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return (count > 0); 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar identificador: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    using (MySqlCommand cmd = new MySqlCommand("contarEmprestimoPorId", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_id", id);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return (count > 0); 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar identificador: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    using (MySqlCommand cmd = new MySqlCommand("contarTomadorPorId", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_id", id);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return (count > 0); 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar identificador: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    using (MySqlCommand cmd = new MySqlCommand("contarPenalidadePorId", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_id", id);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        redistroExistente = (count > 0); 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar identificador: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    using (MySqlCommand cmd = new MySqlCommand("contarInstrumentoPorNumeroSerie", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_numeroSerie", numeroSerie);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return (count > 0); 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar número de série: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                return false;
            }
        }

        public bool IdReservaExiste(string id)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand("contarReservaPorId", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_id", id);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return (count > 0);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar identificador: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                return false;
            }
        }
    }
}
