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
    class MidiaDAO
    {
        private string connectionString = "Server=localhost;Database=bd_virapagina;Uid=root;Pwd=";
        public bool AdicionarMidiaNoBanco(Midia midia)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("inserirMidia", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_titulo", midia.Titulo);
                        cmd.Parameters.AddWithValue("@p_diretor", midia.Diretor);
                        cmd.Parameters.AddWithValue("@p_genero", midia.Genero);
                        cmd.Parameters.AddWithValue("@p_anoLancamento", midia.AnoLancamento);
                        cmd.Parameters.AddWithValue("@p_produtora", midia.Produtora);
                        cmd.Parameters.AddWithValue("@p_tipo", midia.Tipo);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Registro inserido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        public Midia lerMidia(string id)
        {
            Midia midia = new Midia();
            UtilDAO utilDAO = new UtilDAO();

            bool redistroExistente = utilDAO.IdMidiaExiste(id);

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                if (redistroExistente)
                {
                    string query = "SELECT * FROM midia WHERE idMidia = @id";

                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        // Obtém a senha armazenada no banco
                        using (MySqlDataReader resultado = cmd.ExecuteReader())
                        {
                            if (resultado.Read())
                            {
                                midia.IdMidia = resultado["idMidia"].ToString();
                                midia.Titulo = resultado["titulo"].ToString();
                                midia.Diretor = resultado["diretor"].ToString();
                                midia.Genero = resultado["genero"].ToString();
                                midia.AnoLancamento = resultado["anoLancamento"].ToString();
                                midia.Produtora = resultado["produtora"].ToString();
                                midia.Tipo = resultado["tipo"].ToString();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Midia inesistente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            return midia;
        }

        public bool AtualizarMidiaNoBanco(Midia midia)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("atualizarMidia", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_idMidia", midia.IdMidia);
                        cmd.Parameters.AddWithValue("@p_titulo", midia.Titulo);
                        cmd.Parameters.AddWithValue("@p_diretor", midia.Diretor);
                        cmd.Parameters.AddWithValue("@p_genero", midia.Genero);
                        cmd.Parameters.AddWithValue("@p_anoLancamento", midia.AnoLancamento);
                        cmd.Parameters.AddWithValue("@p_produtora", midia.Produtora);
                        cmd.Parameters.AddWithValue("@p_tipo", midia.Tipo);


                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Registro atualizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        public List<Midia> BuscarMidias()
        {
            List<Midia> lista = new List<Midia>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("lerMidias", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Midia midia = new Midia()
                            {
                                IdMidia = reader["idMidia"].ToString(),
                                Titulo = reader["titulo"].ToString(),
                                Diretor = reader["diretor"].ToString(),
                                Genero = reader["genero"].ToString(),
                                AnoLancamento = reader["anoLancamento"].ToString(),
                            };
                            
                            lista.Add(midia);
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

        public bool ExcluirMidiaNoBanco(string id)
        {
            UtilDAO utilDAO = new UtilDAO();
            bool redistroExistente = utilDAO.IdMidiaExiste(id);

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                if (redistroExistente)
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand("deletarMidia", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("p_idMidia", id);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show($"Mídia {id} deletado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Mídia inesistente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            return false;
        }
    }
}
