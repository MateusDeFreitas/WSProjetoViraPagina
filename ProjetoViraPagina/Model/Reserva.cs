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

        public static List<Reserva> ListaReserva = new List<Reserva>();

        public static void AdicionarPenalidade(Reserva reserva)
        {
            ListaReserva.Add(reserva);
        }
    }

}
