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
    public partial class VisualizacaoPenalidade : Form
    {
        public VisualizacaoPenalidade()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CarregarGrid()
        {
            PenalidadeDAO penalidadeDAO = new PenalidadeDAO();

            List<Penalidade> penalidades = penalidadeDAO.BuscarPenalidades();

            dgvPenalidades.Columns.Clear(); // Limpa colunas anteriores
            dgvPenalidades.DataSource = null;
            dgvPenalidades.AutoGenerateColumns = false;

            dgvPenalidades.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Codigo",
                HeaderText = "Código",
                DataPropertyName = "Id",
                Width = 90
            });

            dgvPenalidades.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Cód. Tomador",
                DataPropertyName = "IdUsuario",
                Width = 130,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            dgvPenalidades.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Cód. Empréstimo",
                DataPropertyName = "IdEmprestimo",
                Width = 155,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            dgvPenalidades.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Data de Ocorrência",
                DataPropertyName = "DataPenalidade",
                Width = 180,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            dgvPenalidades.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Categoria",
                DataPropertyName = "CodPenalidade",
                Width = 120,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            DataGridViewImageColumn colunaImagemRegularizar = new DataGridViewImageColumn();
            colunaImagemRegularizar.Name = "Regularizar";
            colunaImagemRegularizar.HeaderText = "";
            colunaImagemRegularizar.Image = Image.FromFile("Imagens/Check.png");
            colunaImagemRegularizar.Width = 45;
            colunaImagemRegularizar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvPenalidades.Columns.Add(colunaImagemRegularizar);

            // Vincula os dados
            dgvPenalidades.DataSource = penalidades;
        }

        private void CarregarGridPorBusca(string id)
        {
            PenalidadeDAO penalidadeDAO = new PenalidadeDAO();
            Penalidade penalidade = penalidadeDAO.LerPenalidade(id);


            dgvPenalidades.Columns.Clear(); // Limpa colunas anteriores
            dgvPenalidades.DataSource = null;
            dgvPenalidades.AutoGenerateColumns = false;

            dgvPenalidades.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Codigo",
                HeaderText = "Código",
                DataPropertyName = "Id",
                Width = 90
            });

            dgvPenalidades.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Cód. Tomador",
                DataPropertyName = "IdUsuario",
                Width = 130,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            dgvPenalidades.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Cód. Empréstimo",
                DataPropertyName = "IdEmprestimo",
                Width = 155,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            dgvPenalidades.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Data de Ocorrência",
                DataPropertyName = "DataPenalidade",
                Width = 180,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            dgvPenalidades.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Categoria",
                DataPropertyName = "CodPenalidade",
                Width = 120,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            DataGridViewImageColumn colunaImagemRegularizar = new DataGridViewImageColumn();
            colunaImagemRegularizar.Name = "Regularizar";
            colunaImagemRegularizar.HeaderText = "";
            colunaImagemRegularizar.Image = Image.FromFile("Imagens/Check.png");
            colunaImagemRegularizar.Width = 45;
            colunaImagemRegularizar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvPenalidades.Columns.Add(colunaImagemRegularizar);

            // Vincula os dados
            dgvPenalidades.DataSource = new List<Penalidade> { penalidade };
        }

        private void CarregarGridPorTomador(string idTomador)
        {
            PenalidadeDAO penalidadeDAO = new PenalidadeDAO();

            List<Penalidade> penalidades = penalidadeDAO.BuscarPenalidadesDeTomador(idTomador);

            dgvPenalidades.Columns.Clear(); // Limpa colunas anteriores
            dgvPenalidades.DataSource = null;
            dgvPenalidades.AutoGenerateColumns = false;

            dgvPenalidades.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Codigo",
                HeaderText = "Código",
                DataPropertyName = "Id",
                Width = 90
            });

            dgvPenalidades.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Cód. Tomador",
                DataPropertyName = "IdUsuario",
                Width = 130,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            dgvPenalidades.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Cód. Empréstimo",
                DataPropertyName = "IdEmprestimo",
                Width = 155,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            dgvPenalidades.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Data de Ocorrência",
                DataPropertyName = "DataPenalidade",
                Width = 180,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            dgvPenalidades.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Categoria",
                DataPropertyName = "CodPenalidade",
                Width = 120,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            DataGridViewImageColumn colunaImagemRegularizar = new DataGridViewImageColumn();
            colunaImagemRegularizar.Name = "Regularizar";
            colunaImagemRegularizar.HeaderText = "";
            colunaImagemRegularizar.Image = Image.FromFile("Imagens/Check.png");
            colunaImagemRegularizar.Width = 45;
            colunaImagemRegularizar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvPenalidades.Columns.Add(colunaImagemRegularizar);

            // Vincula os dados
            dgvPenalidades.DataSource = penalidades;
        }

        private void Penalidades_Load(object sender, EventArgs e)
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
            PrincipalPenalidade form = new PrincipalPenalidade();
            form.Show();
            this.Hide();
        }

        private void dgvPenalidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPenalidades.Columns[e.ColumnIndex].Name == "Regularizar")
            {
                // Pega o ID da linha selecionada
                string idPenalidade = dgvPenalidades.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();

                // Confirma exclusão
                DialogResult result = MessageBox.Show("Deseja regularizar esta penalidade?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    PenalidadeDAO penalidadeDAO = new PenalidadeDAO();
                    penalidadeDAO.RegularizarPenalidade(idPenalidade);

                    CarregarGrid();
                }
            }
        }

        private void pictureBoxLupa_Click(object sender, EventArgs e)
        {
            UtilDAO utilDAO = new UtilDAO();
            string idTomador = texPesquisarPenalidades.Text;

            if (utilDAO.IdTomadorExiste(idTomador))
            {
                CarregarGridPorTomador(idTomador);
            }
            else if (idTomador == "")
            {
                CarregarGrid();
            }
            else
            {
                MessageBox.Show($"O Tomador {idTomador} não existe.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //if (utilDAO.IdPenalidadeExiste(idPenalidade))
            //{
            //    CarregarGridPorBusca(idPenalidade);
            //}
            //else if (idPenalidade == "")
            //{
            //    CarregarGrid();
            //}
            //else
            //{
            //    MessageBox.Show($"O penalidade {idPenalidade} não existe.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }
    }
}