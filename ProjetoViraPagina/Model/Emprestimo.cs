using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ViraPagina.Model
{
    public class Emprestimo
    {
        public uint Id { get; set; } // INT UNSIGNED -> uint
        public int? IdUsuario { get; set; } // Pode ser nulo
        public string IdMaterialImpresso { get; set; } // Pode ser nulo
        public string IdInstrumento { get; set; } // Pode ser nulo
        public string IdMidia { get; set; } // Pode ser nulo
        public string IdJogo { get; set; } // Pode ser nulo
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
        public bool Finalizado { get; set; }

        public static List<Emprestimo> ListaEmprestimo = new List<Emprestimo>();

        public static void AdicionarInstrumento(Emprestimo emprestimo)
        {
            ListaEmprestimo.Add(emprestimo);
        }
    }

}
