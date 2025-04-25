using MySql.Data.MySqlClient;
using Projeto_ViraPagina.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ViraPagina.DAO
{
    class TomadorDAO
    {
        string connectionString = "Server=localhost;Database=bd_virapagina;Uid=root;Pwd=";

        public Tomador LerTomador(string idTomador)
        {
            Tomador tomador = new Tomador();
            Tomador funcao = new Tomador();
            UtilDAO utilDAO = new UtilDAO();

            bool redistroExistente = utilDAO.IdTomadorExiste(idTomador);

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                if (redistroExistente)
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand("lerTomador", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_idTomador", idTomador); 

                        using (MySqlDataReader resultado = cmd.ExecuteReader())
                        {
                            if (resultado.Read())
                            {
                                tomador.Id = resultado["id"].ToString();
                                tomador.Nome = resultado["nome"].ToString();
                                tomador.Email = resultado["email"].ToString();
                                tomador.NumeroDeLivrosEmprestados = Convert.ToInt32(resultado["numeroDeLivrosEmprestados"]);
                                tomador.NumeroDePenalidade = Convert.ToInt32(resultado["numeroDePenalidade"].ToString());
                                tomador.ValidadeMatricula = funcao.exibirValidadeMatricula(resultado["validadeMatricula"].ToString());
                                tomador.NumeroTelefone = resultado["numeroTelefone"].ToString();
                                tomador.Vinculo = resultado["vinculo"].ToString();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Tomador inexistente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            return tomador;
        }
    }
}
