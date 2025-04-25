using MySql.Data.MySqlClient;
using Projeto_ViraPagina.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ViraPagina.DAO
{
    class InstrumentoDAO
    {
        private string connectionString = "Server=localhost;Database=bd_virapagina;Uid=root;Pwd=";

        public bool AdicionarInstrumentoNoBanco(Instrumento instrumento)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("inserirInstrumento", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_categoria", instrumento.Categoria);
                        cmd.Parameters.AddWithValue("@p_marca", instrumento.Marca);
                        cmd.Parameters.AddWithValue("@p_modelo", instrumento.Modelo);
                        cmd.Parameters.AddWithValue("@p_numeroSerie", instrumento.NumeroSerie);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show($"Registro {instrumento.NumeroSerie} inserido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                return false;
            }
        }

        public Instrumento LerInstrumento(string id)
        {
            Instrumento instrumento = new Instrumento();
            UtilDAO utilDAO = new UtilDAO();

            bool redistroExistente = utilDAO.IdInstrumentoExiste(id);

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                if (redistroExistente)
                {

                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand("lerInstrumento", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_idInstrumento", id);

                        // Obtém a senha armazenada no banco
                        using (MySqlDataReader resultado = cmd.ExecuteReader())
                        {
                            if (resultado.Read())
                            {
                                instrumento.IdInstrumento = resultado["idInstrumento"].ToString();
                                instrumento.Categoria = resultado["categoria"].ToString();
                                instrumento.Marca = resultado["marca"].ToString(); ;
                                instrumento.Modelo = resultado["modelo"].ToString();
                                instrumento.NumeroSerie = resultado["numeroSerie"].ToString();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"Instrumento {id} inexistente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            return instrumento;
        }

        public bool AtualizarInstrumentoNoBanco(Instrumento instrumento)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("atualizarInstrumento", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_idInstrumento", instrumento.IdInstrumento);
                        cmd.Parameters.AddWithValue("@p_categoria", instrumento.Categoria);
                        cmd.Parameters.AddWithValue("@p_marca", instrumento.Marca);
                        cmd.Parameters.AddWithValue("@p_modelo", instrumento.Modelo);
                        cmd.Parameters.AddWithValue("@p_numeroSerie", instrumento.NumeroSerie);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show($"Registro {instrumento.IdInstrumento} atualizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return true;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                return false;
            }
        }

        public Instrumento LerInstrumentoPeloNueroDeSerie(string numeroSerie)
        {
            Instrumento instrumento = new Instrumento();
            UtilDAO utilDAO = new UtilDAO();

            bool redistroExistente = utilDAO.NumeroDeSerieExiste(numeroSerie);

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                if (redistroExistente)
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand("buscarInstrumentoPorNumeroSerie", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_numeroSerie", numeroSerie);

                        // Obtém a senha armazenada no banco
                        using (MySqlDataReader resultado = cmd.ExecuteReader())
                        {
                            if (resultado.Read())
                            {
                                instrumento.IdInstrumento = resultado["idInstrumento"].ToString();
                                instrumento.Categoria = resultado["categoria"].ToString();
                                instrumento.Marca = resultado["marca"].ToString(); ;
                                instrumento.Modelo = resultado["modelo"].ToString();
                                instrumento.NumeroSerie = resultado["numeroSerie"].ToString();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"Instrumento {numeroSerie} inexistente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            return instrumento;
        }

        public List<Instrumento> BuscarInstrumentos()
        {
            List<Instrumento> lista = new List<Instrumento>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("lerInstrumentos", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Instrumento instrumento = new Instrumento()
                            {
                                IdInstrumento = reader["idInstrumento"].ToString(),
                                Categoria = reader["categoria"].ToString(),
                                Marca = reader["marca"].ToString(),
                                Modelo = reader["modelo"].ToString(),
                                NumeroSerie = reader["numeroSerie"].ToString()
                            };

                            lista.Add(instrumento);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }

            return lista;
        }

        public bool ExcluirInstrumentoNoBanco(string id)
        {
            UtilDAO utilDAO = new UtilDAO();
            bool redistroExistente = utilDAO.IdInstrumentoExiste(id);

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                if (redistroExistente)
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand("deletarInstrumento", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("p_idInstrumento", id);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show($"Instrumento {id} deletado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show($"Instrumento {id} inesistente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            return false;
        }
    }
}