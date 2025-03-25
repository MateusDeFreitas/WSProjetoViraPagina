using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ViraPagina.Model
{
    public class Penalidade
    {
        public uint Id { get; set; } // INT UNSIGNED -> uint
        public int IdUsuario { get; set; } // Não pode ser nulo
        public string IdEmprestimo { get; set; } // Não pode ser nulo
        public DateTime DataPenalidade { get; set; }
        public string CodPenalidade { get; set; } // Corrigindo o nome do campo
        public bool PenalidadeAtiva { get; set; } // Nome mais claro
    }

}
