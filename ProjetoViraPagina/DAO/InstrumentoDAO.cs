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
    }
}
