using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ViraPagina.Model
{
    public class Midia
    {
        public string IdMidia { get; set; }
        public string Titulo { get; set; }
        public string Diretor { get; set; }
        public string Genero { get; set; }
        public string AnoLancamento { get; set; }
        public string Produtora { get; set; }
        public string Tipo { get; set; }

        public static List<Midia> ListaMidia = new List<Midia>();

        public static void AdicionarMidia(Midia midia)
        {
            ListaMidia.Add(midia);
        }
    }
}
