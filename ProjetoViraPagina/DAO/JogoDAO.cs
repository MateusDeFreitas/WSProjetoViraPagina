using MySql.Data.MySqlClient;
using Projeto_ViraPagina.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ViraPagina.DAO
{
    class JogoDAO
    {
        private string connectionString = "Server=localhost;Database=bd_virapagina;Uid=root;Pwd=";
        public bool AdicionarJogoNoBanco(Jogo jogo)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("InserirJogo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_nome", jogo.Nome);
                        cmd.Parameters.AddWithValue("@p_marca", jogo.Marca);
                        cmd.Parameters.AddWithValue("@p_material", jogo.Material);
                        cmd.Parameters.AddWithValue("@p_numeroJogadores", jogo.NumeroJogadores);
                        cmd.Parameters.AddWithValue("@p_genero", jogo.Genero);

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

        public Jogo lerJogo(string id)
        {
            Jogo jogo = new Jogo();
            UtilDAO utilDAO = new UtilDAO();

            bool redistroExistente = utilDAO.IdJogoExiste(id);

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                if (redistroExistente)
                {
                    string query = "SELECT * FROM jogo WHERE idJogo = @id";

                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        // Obtém a senha armazenada no banco
                        using (MySqlDataReader resultado = cmd.ExecuteReader())
                        {
                            if (resultado.Read())
                            {
                                jogo.IdJogo = resultado["idJogo"].ToString();
                                jogo.Nome = resultado["nome"].ToString();
                                jogo.Marca = resultado["marca"].ToString();
                                jogo.Material = resultado["material"].ToString();
                                jogo.NumeroJogadores = resultado["numeroJogadores"].ToString();
                                jogo.Genero = resultado["genero"].ToString();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Jogo inesistente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            return jogo;
        }

        public bool AtualizarJogoNoBanco(Jogo jogo)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("atualizarJogo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_idJogo", jogo.IdJogo);
                        cmd.Parameters.AddWithValue("@p_nome", jogo.Nome);
                        cmd.Parameters.AddWithValue("@p_marca", jogo.Marca);
                        cmd.Parameters.AddWithValue("@p_material", jogo.Material);
                        cmd.Parameters.AddWithValue("@p_numeroJogadores", jogo.NumeroJogadores);
                        cmd.Parameters.AddWithValue("@p_genero", jogo.Genero);

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
    }
}
