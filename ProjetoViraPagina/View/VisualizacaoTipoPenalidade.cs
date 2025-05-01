using Projeto_ViraPagina.DAO;
using Projeto_ViraPagina.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_ViraPagina.View
{
    public partial class VisualizacaoTipoPenalidade : Form
    {
        public VisualizacaoTipoPenalidade()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            PenalidadeDAO penalidadeDAO = new PenalidadeDAO();
            Penalidade penalidade = Penalidade.ListaPenalidade.Last();
            
            penalidade.CodPenalidade = textTipoPenalidade.Text;


            if (penalidade.CodPenalidade != "")
            {
                penalidadeDAO.AdicionarPenalidadeNoBanco(InstanciarPenalidade(penalidade.IdEmprestimo, penalidade.IdUsuario, penalidade.CodPenalidade));
            }

            this.Hide();
        }

        private Penalidade InstanciarPenalidade(string idEmprestimo, string idTomador, string TipoPenalidade)
        {
            Penalidade penalidade = new Penalidade();
            penalidade.IdEmprestimo = idEmprestimo;
            penalidade.IdUsuario = idTomador;
            penalidade.CodPenalidade = TipoPenalidade;

            return penalidade;
        }
    }
}
