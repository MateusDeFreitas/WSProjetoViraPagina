using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ViraPagina.Model
{
    public class Penalidade
    {
        public string? Id { get; set; } 
        public string? IdUsuario { get; set; } 
        public string? IdEmprestimo { get; set; } 
        public string? DataPenalidade { get; set; }
        public string? CodPenalidade { get; set; } 
        public bool PenalidadeAtiva { get; set; }

        public static List<Penalidade> ListaPenalidade = new List<Penalidade>();

        public static void AdicionarPenalidade(Penalidade penalidade)
        {
            ListaPenalidade.Add(penalidade);
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
