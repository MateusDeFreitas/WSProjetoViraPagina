using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ViraPagina.Model
{
    public class MaterialImpresso
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public string DataLancamento { get; set; }
        public string ISBN { get; set; }
        public bool ReservaLivro { get; set; }
        public string Idioma { get; set; }
        public string Exemplar { get; set; }
        public string Editora { get; set; }
        public string Classe { get; set; }
        public bool Circular { get; set; }
        public string Resumo { get; set; }

        public static List<MaterialImpresso> ListaMateriaisImpressos = new List<MaterialImpresso>();

        public static void AdicionarMaterialImpresso(MaterialImpresso MI)
        {
            ListaMateriaisImpressos.Add(MI);
        }

        public void ExtraiCircular(string input)
        {
            if (input.ToLower() == "sim")
            {
                this.Circular = true;
            }
            else if (input.ToLower() == "não" || input.ToLower() == "nao")
            {
                this.Circular = false;
            }
        }

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

                        // Conversão de data de "dd/MM/yyyy" para "yyyy-MM-dd"
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
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao adicionar material impresso: " + ex.Message);
                }
            }
        }
    }
}
