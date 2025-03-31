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
    class MaterialImpressoDAO
    {

        private string connectionString = "Server=localhost;Database=bd_virapagina;Uid=root;Pwd=";
        public void AdicionarMaterialImpressoNoBanco(MaterialImpresso material)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("InserirMaterialImpresso", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        DateTime dataFormatada = DateTime.ParseExact(material.DataLancamento, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        string dataFormatadaSQL = dataFormatada.ToString("yyyy-MM-dd");

                        cmd.Parameters.AddWithValue("@p_titulo", material.Titulo);
                        cmd.Parameters.AddWithValue("@p_autor", material.Autor);
                        cmd.Parameters.AddWithValue("@p_genero", material.Genero);
                        cmd.Parameters.AddWithValue("@p_dataLancamento", dataFormatadaSQL);
                        cmd.Parameters.AddWithValue("@p_ISBN", material.ISBN);

                        cmd.Parameters.AddWithValue("@p_reservaLivro", material.ReservaLivro);
                        cmd.Parameters.AddWithValue("@p_idioma", material.Idioma);
                        cmd.Parameters.AddWithValue("@p_exemplar", material.Exemplar);
                        cmd.Parameters.AddWithValue("@p_editora", material.Editora);
                        cmd.Parameters.AddWithValue("@p_classe", material.Classe);
                        cmd.Parameters.AddWithValue("@p_circular", material.Circular);
                        cmd.Parameters.AddWithValue("@p_resumo", material.Resumo);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Registro inserido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
