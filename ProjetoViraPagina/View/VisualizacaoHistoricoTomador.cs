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
    public partial class VisualizacaoHistoricoTomador : Form
    {
        public VisualizacaoHistoricoTomador()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Principal form = new Principal();
            form.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Principal form = new Principal();
            form.Show();
            this.Hide();
        }

        private void CarregarTitulo(Tomador tomador)
        {
            labelNomeTomador.Text = tomador.Nome;
            labelNomeTomador.Location = new Point((816 - labelNomeTomador.Width) / 2, labelNomeTomador.Location.Y);
        }

        private void CarregarGrid()
        {
            Tomador tomador = Tomador.ListaTomador.Last();

            PenalidadeDAO penalidadeDAO = new PenalidadeDAO();

            List<Penalidade> penalidades = penalidadeDAO.BuscarPenalidadesDeTomador(tomador.Id);

            dgvVisualizacaoHistoricoTomador.Columns.Clear(); // Limpa colunas anteriores
            dgvVisualizacaoHistoricoTomador.DataSource = null;
            dgvVisualizacaoHistoricoTomador.AutoGenerateColumns = false;

            dgvVisualizacaoHistoricoTomador.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Codigo",
                HeaderText = "Código",
                DataPropertyName = "Id",
                Width = 90
            });

            dgvVisualizacaoHistoricoTomador.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Cód. Empréstimo",
                DataPropertyName = "IdEmprestimo",
                Width = 165,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            dgvVisualizacaoHistoricoTomador.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Data de Ocorrência",
                DataPropertyName = "DataPenalidade",
                Width = 190,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            dgvVisualizacaoHistoricoTomador.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Categoria",
                DataPropertyName = "CodPenalidade",
                Width = 135,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            dgvVisualizacaoHistoricoTomador.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Estado",
                DataPropertyName = "PenalidadeAtivaStr",
                Width = 140,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            // Vincula os dados
            dgvVisualizacaoHistoricoTomador.DataSource = penalidades;
        }

        private void VisualizacaoHistoricoTomador_Load(object sender, EventArgs e)
        {
            TomadorDAO tomadorDAO = new TomadorDAO();
            Tomador tomador = Tomador.ListaTomador.Last();

            tomador = tomadorDAO.LerTomador(tomador.Id);

            CarregarTitulo(tomador);
            CarregarGrid();
        }
    }
}
