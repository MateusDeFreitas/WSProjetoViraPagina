﻿using MySql.Data.MySqlClient;
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
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("inserirEmprestimo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_idUsuario", emprestimo.IdUsuario);
                        cmd.Parameters.AddWithValue("@p_idMaterialImpresso", emprestimo.IdMaterialImpresso);
                        cmd.Parameters.AddWithValue("@p_idInstrumento", emprestimo.IdInstrumento);
                        cmd.Parameters.AddWithValue("@p_idMidia", emprestimo.IdMidia);
                        cmd.Parameters.AddWithValue("@p_idJogo", emprestimo.IdJogo);
                        cmd.Parameters.AddWithValue("@p_diasEmprestimo", 15);

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

        public List<Emprestimo> BuscarEmprestimos()
        {
            List<Emprestimo> lista = new List<Emprestimo>();
            Emprestimo Funcao = new Emprestimo();

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
                                IdUsuario = reader["idUsuario"].ToString(),
                                DataDevolucao = reader["categoria"].ToString(),
                                IdAcervo = Funcao.ReceberIdAcervo(idMaterialImpresso, idJogo, idMidia, idInstrumento),
                                Finalizado = Funcao.StringParaBool(reader["finalizado"].ToString())
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
    }
}
