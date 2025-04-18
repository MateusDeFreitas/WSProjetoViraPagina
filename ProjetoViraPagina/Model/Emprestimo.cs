using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ViraPagina.Model
{
    public class Emprestimo
    {
        public string? Id { get; set; } // INT UNSIGNED -> uint
        public string? IdUsuario { get; set; } // Pode ser nulo
        public string? IdMaterialImpresso { get; set; } // Pode ser nulo
        public string? IdInstrumento { get; set; } // Pode ser nulo
        public string? IdMidia { get; set; } // Pode ser nulo
        public string? IdJogo { get; set; } // Pode ser nulo
        public string? DataEmprestimo { get; set; }
        public string? DataDevolucao { get; set; }
        public bool? Finalizado { get; set; }

        public string IdAcervo { get; set; }



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

        public static void AdicionarInstrumento(Emprestimo emprestimo)
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
    }
}
