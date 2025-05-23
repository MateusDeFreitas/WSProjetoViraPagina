﻿using MySql.Data.MySqlClient;
using Projeto_ViraPagina.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ViraPagina.DAO
{
    class PenalidadeDAO
    {
        private string connectionString = "Server=localhost;Database=bd_virapagina;Uid=root;Pwd=";

        public bool AdicionarPenalidadeNoBanco(Penalidade penalidade)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("inserirPenalidade", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_idTomador", penalidade.IdUsuario);
                        cmd.Parameters.AddWithValue("@p_idEmprestimo", penalidade.IdEmprestimo);
                        cmd.Parameters.AddWithValue("@p_codPenalidade", penalidade.CodPenalidade);

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

        public List<Penalidade> BuscarPenalidades()
        {
            List<Penalidade> lista = new List<Penalidade>();
            TomadorDAO tomadorDAO = new TomadorDAO();
            Penalidade funçao = new Penalidade();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("lerPenalidades", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Penalidade penalidade = new Penalidade()
                            {
                                Id = reader["id"].ToString(),
                                IdUsuario = reader["idTomador"].ToString(),
                                DataPenalidade = funçao.ConverterDataParaFormatoBR(reader["dataPenalidade"].ToString()),
                                IdEmprestimo = reader["idEmprestimo"].ToString(),
                                CodPenalidade = reader["codPenalidade"].ToString(),
                                nomeTomador = tomadorDAO.LerNomeTomador(reader["idTomador"].ToString())
                            };

                            lista.Add(penalidade);
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

        public List<Penalidade> BuscarPenalidadesDeTomador(string idTomador)
        {
            List<Penalidade> lista = new List<Penalidade>();
            Penalidade funçao = new Penalidade();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("lerPenalidadesDeTomador", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_idTomador", idTomador);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Penalidade penalidade = new Penalidade()
                            {
                                Id = reader["id"].ToString(),
                                IdUsuario = reader["idTomador"].ToString(),
                                PenalidadeAtivaStr = funçao.ConverterPenalidadeBoolParaString(reader["penalidadeAtiva"].ToString()),
                                DataPenalidade = funçao.ConverterDataParaFormatoBR(reader["dataPenalidade"].ToString()),
                                IdEmprestimo = reader["idEmprestimo"].ToString(),
                                CodPenalidade = reader["codPenalidade"].ToString(),
                            };

                            lista.Add(penalidade);
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

        public bool RegularizarPenalidade(string id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("desativarPenalidade", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_idPenalidade", id);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Penalidade regularizada", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        public Penalidade LerPenalidade(string id)
        {
            Penalidade penalidade = new Penalidade();
            UtilDAO utilDAO = new UtilDAO();
            Penalidade funcao = new Penalidade();


            bool redistroExistente = utilDAO.IdPenalidadeExiste(id);

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                if (redistroExistente)
                {

                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand("lerPenalidade", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_idPenalidade", id);

                        // Obtém a senha armazenada no banco
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                penalidade.Id = reader["id"].ToString();
                                penalidade.IdUsuario = reader["idTomador"].ToString();
                                penalidade.DataPenalidade = funcao.ConverterDataParaFormatoBR(reader["dataPenalidade"].ToString());
                                penalidade.IdEmprestimo = reader["idEmprestimo"].ToString();
                                penalidade.CodPenalidade = reader["codPenalidade"].ToString();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Penalidade inesistente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            return penalidade;
        }
    }
}
