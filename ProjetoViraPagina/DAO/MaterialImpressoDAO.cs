using MySql.Data.MySqlClient;
using Projeto_ViraPagina.Model;
using Projeto_ViraPagina.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projeto_ViraPagina.DAO
{
    public class MaterialImpressoDAO
    {

        private string connectionString = "Server=localhost;Database=bd_virapagina;Uid=root;Pwd=";

        public bool AdicionarMaterialImpressoNoBanco(MaterialImpresso material)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("inserirMaterialImpresso", conn))
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

        public MaterialImpresso lerMaterialImpresso(string id)
        {
            MaterialImpresso mi = new MaterialImpresso();
            UtilDAO utilDAO = new UtilDAO();
            bool redistroExistente = utilDAO.IdMaterialImpressoExiste(id);

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                if (redistroExistente)
                {
                    string query = "SELECT * FROM materialimpresso WHERE id = @id";

                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        // Obtém a senha armazenada no banco
                        using (MySqlDataReader resultado = cmd.ExecuteReader())
                        {
                            if (resultado.Read())
                            {
                                mi.Id = resultado["id"].ToString();
                                mi.Titulo = resultado["titulo"].ToString();
                                mi.Autor = resultado["autor"].ToString();
                                mi.Genero = resultado["genero"].ToString();
                                mi.DataLancamento = mi.ConverterData(resultado["dataLancamento"].ToString());
                                //mi.DataLancamento = resultado["dataLancamento"].ToString();
                                mi.ISBN = resultado["ISBN"].ToString();
                                mi.ReservaLivro = mi.ConverterBool(resultado["livroReservado"]);
                                mi.Idioma = resultado["idioma"].ToString();
                                mi.Exemplar = resultado["exemplar"].ToString();
                                mi.Editora = resultado["editora"].ToString();
                                mi.Classe = resultado["classe"].ToString();
                                mi.Circular = mi.ConverterBool(resultado["circular"]);
                                mi.Resumo = resultado["resumo"].ToString();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Material impresso inesistente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            return mi;
        }

        public bool AtualizarMaterialImpressoNoBanco(MaterialImpresso mi)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("atualizarMaterialImpresso", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        DateTime dataFormatada = DateTime.ParseExact(mi.DataLancamento, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        string dataFormatadaSQL = dataFormatada.ToString("yyyy-MM-dd");

                        cmd.Parameters.AddWithValue("@p_idMaterial", mi.Id);
                        cmd.Parameters.AddWithValue("@p_titulo", mi.Titulo);
                        cmd.Parameters.AddWithValue("@p_autor", mi.Autor);
                        cmd.Parameters.AddWithValue("@p_genero", mi.Genero);
                        cmd.Parameters.AddWithValue("@p_dataLancamento", dataFormatadaSQL);
                        cmd.Parameters.AddWithValue("@p_ISBN", mi.ISBN);
                        cmd.Parameters.AddWithValue("@p_reservaLivro", mi.ReservaLivro);
                        cmd.Parameters.AddWithValue("@p_idioma", mi.Idioma);
                        cmd.Parameters.AddWithValue("@p_exemplar", mi.Exemplar);
                        cmd.Parameters.AddWithValue("@p_editora", mi.Editora);
                        cmd.Parameters.AddWithValue("@p_classe", mi.Classe);
                        cmd.Parameters.AddWithValue("@p_circular", mi.Circular);
                        cmd.Parameters.AddWithValue("@p_resumo", mi.Resumo);

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
