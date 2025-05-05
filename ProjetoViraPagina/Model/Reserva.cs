using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ViraPagina.Model
{
    public class Reserva
    {
        public string? Id { get; set; } // INT UNSIGNED -> uint
        public string? IdUsuario { get; set; } // Não pode ser nulo
        public string? IdMaterialImpresso { get; set; } // Não pode ser nulo
        public string? DataReserva { get; set; }
        public string? DataDisponibilidade { get; set; }
        public bool? Resgatado { get; set; }
        public string? TempoReserva { get; set; } // Pode representar um período
        public string? nomeTomador { get; set; }

        public static List<Reserva> ListaReserva = new List<Reserva>();

        public static void AdicionarReserva(Reserva reserva)
        {
            ListaReserva.Add(reserva);
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

        public bool ConverterStringParaBool(string input)
        {
            if (input == "False")
            {
                return false;
            }
            return true;
        }
    }

}
