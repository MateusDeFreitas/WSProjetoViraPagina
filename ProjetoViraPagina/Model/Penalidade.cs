﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ViraPagina.Model
{
    public class Penalidade
    {
        public uint Id { get; set; } 
        public int IdUsuario { get; set; } 
        public string IdEmprestimo { get; set; } 
        public DateTime DataPenalidade { get; set; }
        public string CodPenalidade { get; set; } 
        public bool PenalidadeAtiva { get; set; }

        public static List<Penalidade> ListaPenalidade = new List<Penalidade>();

        public static void AdicionarPenalidade(Penalidade penalidade)
        {
            ListaPenalidade.Add(penalidade);
        }
    }

}
