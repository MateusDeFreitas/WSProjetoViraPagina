using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ViraPagina.Model
{
    public class Instrumento
    {
        public string IdInstrumento { get; set; }
        public string Categoria { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string NumeroSerie { get; set; }

        public static List<Instrumento> ListaInstrumento = new List<Instrumento>();

        public static void AdicionarInstrumento(Instrumento instrumento)
        {
            ListaInstrumento.Add(instrumento);
        }
    }
}
