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
    public partial class VisualizacaoEmprestimos : Form
    {
        public VisualizacaoEmprestimos()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CarregarGrid()
        {
            EmprestimoDAO emprestimoDAO = new EmprestimoDAO();

            List<Emprestimo> emprestimos = emprestimoDAO.BuscarEmprestimos();

            dgvVisualizacaoEmprestimos.Columns.Clear(); // Limpa colunas anteriores
            dgvVisualizacaoEmprestimos.DataSource = null;
            dgvVisualizacaoEmprestimos.AutoGenerateColumns = false;

            dgvVisualizacaoEmprestimos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Codigo",
                HeaderText = "Código",
                DataPropertyName = "Id",
                Width = 90
            });

            dgvVisualizacaoEmprestimos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "CodigoTomador",
                HeaderText = "Cód. Tomador",
                DataPropertyName = "IdUsuario",
                Width = 140,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            dgvVisualizacaoEmprestimos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "CodigoAcervo",
                HeaderText = "Cód. Acervo",
                DataPropertyName = "IdAcervo",
                Width = 165,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            dgvVisualizacaoEmprestimos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Data de Devolução",
                DataPropertyName = "DataDevolucao",
                Width = 190,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            DataGridViewImageColumn colunaImagemPenalizar = new DataGridViewImageColumn();
            colunaImagemPenalizar.Name = "Penalizar";
            colunaImagemPenalizar.HeaderText = "";
            colunaImagemPenalizar.Image = Image.FromFile("Imagens/Penalizado.png");
            colunaImagemPenalizar.Width = 45;
            colunaImagemPenalizar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvVisualizacaoEmprestimos.Columns.Add(colunaImagemPenalizar);

            DataGridViewImageColumn colunaImagemRetornar = new DataGridViewImageColumn();
            colunaImagemRetornar.Name = "Retornar";
            colunaImagemRetornar.HeaderText = "";
            colunaImagemRetornar.Image = Image.FromFile("Imagens/Retornado.png");
            colunaImagemRetornar.Width = 45;
            colunaImagemRetornar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvVisualizacaoEmprestimos.Columns.Add(colunaImagemRetornar);

            DataGridViewImageColumn colunaImagemRenovar = new DataGridViewImageColumn();
            colunaImagemRenovar.Name = "Renovar";
            colunaImagemRenovar.HeaderText = "";
            colunaImagemRenovar.Image = Image.FromFile("Imagens/Renovado.png");
            colunaImagemRenovar.Width = 45;
            colunaImagemRenovar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvVisualizacaoEmprestimos.Columns.Add(colunaImagemRenovar);

            // Vincula os dados
            dgvVisualizacaoEmprestimos.DataSource = emprestimos;
        }

        private void CarregarGridPorBusca(string id)
        {
            EmprestimoDAO emprestimoDAO = new EmprestimoDAO();
            Emprestimo emprestimo = emprestimoDAO.LerEmprestimo(id);

            dgvVisualizacaoEmprestimos.Columns.Clear(); // Limpa colunas anteriores
            dgvVisualizacaoEmprestimos.DataSource = null;
            dgvVisualizacaoEmprestimos.AutoGenerateColumns = false;

            dgvVisualizacaoEmprestimos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Codigo",
                HeaderText = "Código",
                DataPropertyName = "Id",
                Width = 90
            });

            dgvVisualizacaoEmprestimos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "CodigoTomador",
                HeaderText = "Cód. Tomador",
                DataPropertyName = "IdUsuario",
                Width = 140,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            dgvVisualizacaoEmprestimos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "CodigoAcervo",
                HeaderText = "Cód. Acervo",
                DataPropertyName = "IdAcervo",
                Width = 165,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            dgvVisualizacaoEmprestimos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Data de Devolução",
                DataPropertyName = "DataDevolucao",
                Width = 190,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            DataGridViewImageColumn colunaImagemPenalizar = new DataGridViewImageColumn();
            colunaImagemPenalizar.Name = "Penalizar";
            colunaImagemPenalizar.HeaderText = "";
            colunaImagemPenalizar.Image = Image.FromFile("Imagens/Penalizado.png");
            colunaImagemPenalizar.Width = 45;
            colunaImagemPenalizar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvVisualizacaoEmprestimos.Columns.Add(colunaImagemPenalizar);

            DataGridViewImageColumn colunaImagemRetornar = new DataGridViewImageColumn();
            colunaImagemRetornar.Name = "Retornar";
            colunaImagemRetornar.HeaderText = "";
            colunaImagemRetornar.Image = Image.FromFile("Imagens/Retornado.png");
            colunaImagemRetornar.Width = 45;
            colunaImagemRetornar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvVisualizacaoEmprestimos.Columns.Add(colunaImagemRetornar);

            DataGridViewImageColumn colunaImagemRenovar = new DataGridViewImageColumn();
            colunaImagemRenovar.Name = "Renovar";
            colunaImagemRenovar.HeaderText = "";
            colunaImagemRenovar.Image = Image.FromFile("Imagens/Renovado.png");
            colunaImagemRenovar.Width = 45;
            colunaImagemRenovar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvVisualizacaoEmprestimos.Columns.Add(colunaImagemRenovar);

            // Vincula os dados
            dgvVisualizacaoEmprestimos.DataSource = new List<Emprestimo> { emprestimo };
        }

        private void VisualizacaoEmprestimos_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Principal form = new Principal();
            form.Show();
            this.Hide();
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            PrincipalEmprestimo form = new PrincipalEmprestimo();
            form.Show();
            this.Hide();
        }

        private void dgvVisualizacaoEmprestimos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvVisualizacaoEmprestimos.Columns[e.ColumnIndex].Name == "Penalizar")
            {
                PenalidadeDAO penalidadeDAO = new PenalidadeDAO();

                string idEmprestimo = dgvVisualizacaoEmprestimos.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                string idTomador = dgvVisualizacaoEmprestimos.Rows[e.RowIndex].Cells["CodigoTomador"].Value.ToString();
                string TipoPenalidade = Microsoft.VisualBasic.Interaction.InputBox("Digite o tipo da penalidade:", "Tipo de penalidade", "AT");

                if (TipoPenalidade != "")
                {
                    penalidadeDAO.AdicionarPenalidadeNoBanco(InstanciarPenalidade(idEmprestimo, idTomador, TipoPenalidade));
                }
            }
            else if (e.RowIndex >= 0 && dgvVisualizacaoEmprestimos.Columns[e.ColumnIndex].Name == "Retornar")
            {
                EmprestimoDAO emprestimoDAO = new EmprestimoDAO();

                if (emprestimoDAO.FinalizarEmprestimo(dgvVisualizacaoEmprestimos.Rows[e.RowIndex].Cells["Codigo"].Value.ToString()))
                {
                    CarregarGrid();
                }
            }
            else if (e.RowIndex >= 0 && dgvVisualizacaoEmprestimos.Columns[e.ColumnIndex].Name == "Renovar")
            {
                EmprestimoDAO emprestimoDAO = new EmprestimoDAO();

                if (emprestimoDAO.RenovarEmprestimo(dgvVisualizacaoEmprestimos.Rows[e.RowIndex].Cells["Codigo"].Value.ToString()))
                {
                    CarregarGrid();
                }
            }
        }

        private Penalidade InstanciarPenalidade(string idEmprestimo, string idTomador, string TipoPenalidade)
        {
            Penalidade penalidade = new Penalidade();
            penalidade.IdEmprestimo = idEmprestimo;
            penalidade.IdUsuario = idTomador;
            penalidade.CodPenalidade = TipoPenalidade;

            return penalidade;
        }

        private void pictureBoxLupa_Click(object sender, EventArgs e)
        {
            string idEmprestimo = texPesquisarVisualizacaoEmprestimos.Text;
            UtilDAO utilDAO = new UtilDAO();

            if (utilDAO.IdEmprestimoExiste(idEmprestimo))
            {
                CarregarGridPorBusca(idEmprestimo);
            }
            else if (idEmprestimo == "")
            {
                CarregarGrid();
            }
            else
            {
                MessageBox.Show($"Emprestimo {idEmprestimo} não existe.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}