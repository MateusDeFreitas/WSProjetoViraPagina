using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ViraPagina.Model
{
    public class Tomador
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int NumeroDeLivrosEmprestados { get; set; }
        public int NumeroDePenalidade { get; set; }
        public string ValidadeMatricula { get; set; }
        public string NumeroTelefone { get; set; }
        public string Vinculo { get; set; }

        public string exibirValidadeMatricula(string data)
        {
            string dataStr = "";
            try
            {
                dataStr = Convert.ToDateTime(data).ToString("dd 'de' MMMM 'de' yyyy");
            }
            catch
            {
                Console.WriteLine("anomalia na exibição da data");
            }

            if (dataStr == "")
            {
                dataStr = "Indefinida";
            }
            return dataStr;
        }
    }
}
