using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ViraPagina.Model
{
    public class Tomador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int NumeroDeLivrosEmprestados { get; set; }
        public int NumeroDePenalidade { get; set; }
        public DateTime? ValidadeMatricula { get; set; }
        public string NumeroTelefone { get; set; }
        public string Vinculo { get; set; }
    }
}
