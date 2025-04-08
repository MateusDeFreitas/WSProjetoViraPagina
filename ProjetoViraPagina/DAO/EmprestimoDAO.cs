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
    }
}
