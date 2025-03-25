using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ViraPagina.Model
{
    public class Reserva
    {
        public uint Id { get; set; } // INT UNSIGNED -> uint
        public int IdUsuario { get; set; } // Não pode ser nulo
        public string IdMaterialImpresso { get; set; } // Não pode ser nulo
        public DateTime DataReserva { get; set; }
        public DateTime DataDisponibilidade { get; set; }
        public bool Resgatado { get; set; }
        public TimeSpan TempoReserva { get; set; } // Pode representar um período
    }

}
