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
    }
}
