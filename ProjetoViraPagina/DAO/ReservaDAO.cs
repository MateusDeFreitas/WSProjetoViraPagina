using MySql.Data.MySqlClient;
using Projeto_ViraPagina.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ViraPagina.DAO
{
    class ReservaDAO
    {
        private string connectionString = "Server=localhost;Database=bd_virapagina;Uid=root;Pwd=";

        public bool AdicionarReservaNoBanco(Reserva reserva)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("inserirReserva", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_idUsuario", reserva.IdUsuario);
                        cmd.Parameters.AddWithValue("@p_idMaterialImpresso", reserva.IdMaterialImpresso);
                        cmd.Parameters.AddWithValue("@p_tempoReserva", 15);

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

        public List<Reserva> BuscarReservas()
        {
            List<Reserva> lista = new List<Reserva>();
            Reserva funcao = new Reserva();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("lerReservas", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Reserva reserva = new Reserva()
                            {
                                Id = reader["id"].ToString(),
                                IdUsuario = reader["idUsuario"].ToString(),
                                IdMaterialImpresso = reader["idMaterialImpresso"].ToString(),
                                DataReserva = funcao.ConverterDataParaFormatoBR(reader["dataReserva"].ToString()),
                                TempoReserva = reader["tempoReserva"].ToString()
                            };

                            lista.Add(reserva);
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

        public bool ExcluirReservaNoBanco(string id)
        {
            UtilDAO utilDAO = new UtilDAO();
            bool redistroExistente = utilDAO.IdReservaExiste(id);

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                if (redistroExistente)
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand("deletarReserva", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("p_idReserva", id);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show($"Reserva {id} deletado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Reserva inesistente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            return false;
        }

        public bool ResgatarReserva(string id)
        {
            UtilDAO utilDAO = new UtilDAO();
            bool redistroExistente = utilDAO.IdReservaExiste(id);

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                if (redistroExistente)
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand("resgatarReserva", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("p_idReserva", id);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Reserva resgatada!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Reserva inesistente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            return false;
        }

        public bool EstaReservado(string idMaterialImpresso)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("estaReservado", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Parâmetro de entrada
                        cmd.Parameters.AddWithValue("id_material", idMaterialImpresso);

                        // Parâmetro de saída
                        var outputParam = new MySqlParameter("total_reservas", MySqlDbType.Int32);
                        outputParam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(outputParam);

                        // Executa a procedure
                        cmd.ExecuteNonQuery();

                        // Recupera o valor de saída
                        int count = Convert.ToInt32(outputParam.Value);
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao verificar reserva: " + ex.Message);
                    return false;
                }
            }
        }

        public Reserva LerReserva(string id)
        {
            Reserva reserva = new Reserva();
            UtilDAO utilDAO = new UtilDAO();
            Reserva funcao = new Reserva();


            bool redistroExistente = utilDAO.IdReservaExiste(id);

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                if (redistroExistente)
                {

                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand("lerReserva", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_idReserva", id);

                        // Obtém a senha armazenada no banco
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                reserva.Id = reader["id"].ToString();
                                reserva.IdUsuario = reader["idUsuario"].ToString();
                                reserva.IdMaterialImpresso = reader["idMaterialImpresso"].ToString();
                                reserva.DataReserva = funcao.ConverterDataParaFormatoBR(reader["dataReserva"].ToString());
                                reserva.DataDisponibilidade = funcao.ConverterDataParaFormatoBR(reader["dataDisponibilidade"].ToString());
                                reserva.TempoReserva = reader["tempoReserva"].ToString();
                                reserva.Resgatado = funcao.ConverterStringParaBool(reader["resgatado"].ToString());
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Reserva inesistente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            return reserva;
        }
    }
}
