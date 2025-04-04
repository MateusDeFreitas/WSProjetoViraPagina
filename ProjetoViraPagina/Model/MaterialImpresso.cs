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

        public string ConverterData(string data)
        {
            if (string.IsNullOrWhiteSpace(data))
                return "Sem dados"; // Retorna "Sem dados" se a string for nula ou vazia

            DateTime dataFormatada;
            if (DateTime.TryParseExact(data, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataFormatada))
            {
                return dataFormatada.ToString("dd/MM/yyyy");
            }

            return "Data inválida"; // Se a conversão falhar, retorna "Data inválida"
        }

        public bool ConverterBool(object valor)
        {
            if (valor == null || valor == DBNull.Value)
                return false; // Retorna falso se for NULL

            return Convert.ToBoolean(valor);
        }

        public void ExtraiCircular(string input)
        {
            if (input.ToLower() == "sim" 
                || input.ToLower() == "circulável" 
                || input.ToLower() == "circulavel")
            {
                this.Circular = true;
            }
            else if (input.ToLower() == "não" 
                || input.ToLower() == "nao" 
                || input.ToLower() == " não circulável" 
                || input.ToLower() == " não circulavel"
                || input.ToLower() == " nao circulável"
                || input.ToLower() == " nao circulavel")
            {
                this.Circular = false;
            }
        }

        public string FormatarCircular(bool input)
        {
            if (input)
            {
                return "Circulável";
            }
            return "Não circulável";
        }
    }
}
