using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ViraPagina.Model
{
    public class Emprestimo
    {
        public string? Id { get; set; } 
        public string? IdUsuario { get; set; } 
        public string? IdMaterialImpresso { get; set; }
        public string? IdInstrumento { get; set; }
        public string? IdMidia { get; set; } 
        public string? IdJogo { get; set; } 
        public string? DataEmprestimo { get; set; }
        public string? DataDevolucao { get; set; }
        public bool? Finalizado { get; set; }
        public string? nomeTomador { get; set; }
        public string? IdAcervo { get; set; }


        public static List<Emprestimo> ListaEmprestimo = new List<Emprestimo>();

        public string ConverterFinalizado(string input)
        {
            if (input == "1")
            {
                return "Devolvido";
            }
            else if (input == "2")
            {
                return "Pendente";
            }
            else
            {
                return "ERRO";
            }
        }

        public bool StringParaBool(string input)
        {
            if (input == "1")
            {
                return true;
            }
            return false;
        }

        public static void AdicionarEmprestimo(Emprestimo emprestimo)
        {
            ListaEmprestimo.Add(emprestimo);
        }

        public string ReceberIdAcervo(string idMaterialImpresso, string idJogo, string idMidia, string idInstrumento)
        {
            if (idMaterialImpresso != null)
            {
                return idMaterialImpresso;
            }
            if (idJogo != null)
            {
                return idJogo;
            }
            if (idMidia != null)
            {
                return idMidia;
            }
            if (idInstrumento != null)
            {
                return idInstrumento;
            }
            return "ERRO";
        }

        public string ConverterDataParaFormatoBR(string dataOriginal)
        {
            if (DateTime.TryParse(dataOriginal, out DateTime dataConvertida))
            {
                return dataConvertida.ToString("dd/MM/yyyy");
            }
            else
            {
                return "Data inválida";
            }
        }
    }
}
