using MySql.Data.MySqlClient;
using Projeto_ViraPagina.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projeto_ViraPagina.DAO
{

    class EmprestimoDAO
    {
        private string connectionString = "Server=localhost;Database=bd_virapagina;Uid=root;Pwd=";


        public bool AdicionarEmprestimoNoBanco(Emprestimo emprestimo)
        {
            UtilDAO utilDAO = new UtilDAO();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Buscar dias de empréstimo conforme o vínculo
                    int diasEmprestimo = ObterDiasEmprestimoPorVinculo(emprestimo.IdUsuario);

                    if (diasEmprestimo <= 0)
                    {
                        MessageBox.Show("Não foi possível determinar o tempo de empréstimo para este usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    using (MySqlCommand cmd = new MySqlCommand("inserirEmprestimo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_idUsuario", emprestimo.IdUsuario);
                        cmd.Parameters.AddWithValue("@p_idMaterialImpresso", emprestimo.IdMaterialImpresso);
                        cmd.Parameters.AddWithValue("@p_idInstrumento", emprestimo.IdInstrumento);
                        cmd.Parameters.AddWithValue("@p_idMidia", emprestimo.IdMidia);
                        cmd.Parameters.AddWithValue("@p_idJogo", emprestimo.IdJogo);

                        if (!string.IsNullOrEmpty(emprestimo.IdMaterialImpresso))
                        {
                            cmd.Parameters.AddWithValue("@p_diasEmprestimo", diasEmprestimo);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@p_diasEmprestimo", 1);
                        }
                        cmd.ExecuteNonQuery();

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

        public List<Emprestimo> BuscarEmprestimos()
        {
            List<Emprestimo> lista = new List<Emprestimo>();
            Emprestimo funcao = new Emprestimo();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("lerEmprestimos", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string idMaterialImpresso = reader["idMaterialImpresso"] == DBNull.Value ? null : reader["idMaterialImpresso"].ToString();
                            string idJogo = reader["idJogo"] == DBNull.Value ? null : reader["idJogo"].ToString();
                            string idMidia = reader["idMidia"] == DBNull.Value ? null : reader["idMidia"].ToString();
                            string idInstrumento = reader["idInstrumento"] == DBNull.Value ? null : reader["idInstrumento"].ToString();

                            Emprestimo emprestimo = new Emprestimo()
                            {
                                Id = reader["id"].ToString(),
                                IdUsuario = reader["idUsuario"].ToString(),
                                DataDevolucao = funcao.ConverterDataParaFormatoBR(reader["dataDevolucao"].ToString()),
                                IdAcervo = funcao.ReceberIdAcervo(idMaterialImpresso, idJogo, idMidia, idInstrumento)
                            };

                            lista.Add(emprestimo);
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

        public bool FinalizarEmprestimo(string idEmprestimo)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("finalizarEmprestimo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_idEmprestimo", idEmprestimo);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show($"Empréstimo {idEmprestimo} finalizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        public bool RenovarEmprestimo(string idEmprestimo)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("renovarEmprestimo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_idEmprestimo", idEmprestimo);
                        cmd.Parameters.AddWithValue("@p_dias", 15);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show($"Empréstimo {idEmprestimo} renovado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        public Emprestimo LerEmprestimo(string id)
        {
            Emprestimo emprestimo = new Emprestimo();
            Emprestimo funcao = new Emprestimo();
            UtilDAO utilDAO = new UtilDAO();

            bool redistroExistente = utilDAO.IdEmprestimoExiste(id);

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                if (redistroExistente)
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand("lerEmprestimo", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_idEmprestimo", id);

                        // Obtém a senha armazenada no banco
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string idMaterialImpresso = reader["idMaterialImpresso"] == DBNull.Value ? null : reader["idMaterialImpresso"].ToString();
                                string idJogo = reader["idJogo"] == DBNull.Value ? null : reader["idJogo"].ToString();
                                string idMidia = reader["idMidia"] == DBNull.Value ? null : reader["idMidia"].ToString();
                                string idInstrumento = reader["idInstrumento"] == DBNull.Value ? null : reader["idInstrumento"].ToString();

                                emprestimo.Id = reader["id"].ToString();
                                emprestimo.IdUsuario = reader["idUsuario"].ToString();
                                emprestimo.DataDevolucao = funcao.ConverterDataParaFormatoBR(reader["dataDevolucao"].ToString());
                                emprestimo.DataEmprestimo = funcao.ConverterDataParaFormatoBR(reader["dataEmprestimo"].ToString());
                                emprestimo.IdAcervo = funcao.ReceberIdAcervo(idMaterialImpresso, idJogo, idMidia, idInstrumento);
                                emprestimo.Finalizado = funcao.StringParaBool(reader["finalizado"].ToString());
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"Empréstimo {id} inesistente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            return emprestimo;
        }

        public bool EstaEmprestado(string idAcervo)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("estaEmprestado", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("id_acervo", idAcervo);

                        var outputParam = new MySqlParameter("total_emprestimos", MySqlDbType.Int32);
                        outputParam.Direction = ParameterDirection.Output;

                        cmd.Parameters.Add(outputParam);

                        cmd.ExecuteNonQuery();

                        int count = Convert.ToInt32(outputParam.Value);

                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao verificar empréstimo: " + ex.Message);
                    return false;
                }
            }
        }

        public int ObterDiasEmprestimoPorVinculo(string idUsuario)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("obterVinculoUsuario", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("p_idUsuario", idUsuario);

                        var outputParam = new MySqlParameter("p_vinculo", MySqlDbType.VarChar, 50)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(outputParam);

                        cmd.ExecuteNonQuery();

                        string tipoVinculo = outputParam.Value?.ToString();

                        if (!string.IsNullOrEmpty(tipoVinculo))
                        {
                            switch (tipoVinculo.ToLower())
                            {
                                case "aluno":
                                    return 7;
                                case "professor":
                                    return 15;
                                case "funcionário":
                                    return 10;
                                default:
                                    return 5;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuário não encontrado!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return -1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar tipo de vínculo: " + ex.Message);
                    return -1;
                }
            }
        }
    }
}
