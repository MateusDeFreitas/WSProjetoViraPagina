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
    }
}
