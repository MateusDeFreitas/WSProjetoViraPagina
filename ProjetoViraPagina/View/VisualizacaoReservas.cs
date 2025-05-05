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
    public partial class VisualizacaoReservas : Form
    {
        public VisualizacaoReservas()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CarregarGrid()
        {
            ReservaDAO reservaDAO = new ReservaDAO();

            List<Reserva> reservas = reservaDAO.BuscarReservas();

            dgvVisualizacaoReservas.Columns.Clear(); // Limpa colunas anteriores
            dgvVisualizacaoReservas.DataSource = null;
            dgvVisualizacaoReservas.AutoGenerateColumns = false;

            dgvVisualizacaoReservas.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Codigo",
                HeaderText = "Código",
                DataPropertyName = "Id",
                Width = 90
            });

            dgvVisualizacaoReservas.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Nome tomador",
                DataPropertyName = "nomeTomador",
                Width = 145,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            dgvVisualizacaoReservas.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Data Solicitação",
                DataPropertyName = "DataReserva",
                Width = 140,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            dgvVisualizacaoReservas.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Cód. Livro",
                DataPropertyName = "IdMaterialImpresso",
                Width = 135,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            dgvVisualizacaoReservas.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Período",
                DataPropertyName = "TempoReserva",
                Width = 120,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            DataGridViewImageColumn colunaImagemResgatar = new DataGridViewImageColumn();
            colunaImagemResgatar.Name = "Resgatar";
            colunaImagemResgatar.HeaderText = "";
            colunaImagemResgatar.Image = Image.FromFile("Imagens/Resgatar.png");
            colunaImagemResgatar.Width = 45;
            colunaImagemResgatar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvVisualizacaoReservas.Columns.Add(colunaImagemResgatar);

            DataGridViewImageColumn colunaImagem = new DataGridViewImageColumn();
            colunaImagem.Name = "Cancelar";
            colunaImagem.HeaderText = "";
            colunaImagem.Image = Image.FromFile("Imagens/ImagemX.png");
            colunaImagem.Width = 45;
            colunaImagem.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvVisualizacaoReservas.Columns.Add(colunaImagem);

            // Vincula os dados
            dgvVisualizacaoReservas.DataSource = reservas;
        }

        private void CarregarGridPorBusca(string id)
        {
            ReservaDAO reservaDAO = new ReservaDAO();
            Reserva reserva = reservaDAO.LerReserva(id);


            dgvVisualizacaoReservas.Columns.Clear(); // Limpa colunas anteriores
            dgvVisualizacaoReservas.DataSource = null;
            dgvVisualizacaoReservas.AutoGenerateColumns = false;

            dgvVisualizacaoReservas.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Codigo",
                HeaderText = "Código",
                DataPropertyName = "Id",
                Width = 90
            });

            dgvVisualizacaoReservas.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Nome tomador",
                DataPropertyName = "nomeTomador",
                Width = 145,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            dgvVisualizacaoReservas.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Data Solicitação",
                DataPropertyName = "DataReserva",
                Width = 140,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            dgvVisualizacaoReservas.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Cód. Livro",
                DataPropertyName = "IdMaterialImpresso",
                Width = 135,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            dgvVisualizacaoReservas.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Período",
                DataPropertyName = "TempoReserva",
                Width = 120,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            DataGridViewImageColumn colunaImagemResgatar = new DataGridViewImageColumn();
            colunaImagemResgatar.Name = "Resgatar";
            colunaImagemResgatar.HeaderText = "";
            colunaImagemResgatar.Image = Image.FromFile("Imagens/Resgatar.png");
            colunaImagemResgatar.Width = 45;
            colunaImagemResgatar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvVisualizacaoReservas.Columns.Add(colunaImagemResgatar);

            DataGridViewImageColumn colunaImagem = new DataGridViewImageColumn();
            colunaImagem.Name = "Cancelar";
            colunaImagem.HeaderText = "";
            colunaImagem.Image = Image.FromFile("Imagens/ImagemX.png");
            colunaImagem.Width = 45;
            colunaImagem.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvVisualizacaoReservas.Columns.Add(colunaImagem);

            // Vincula os dados
            dgvVisualizacaoReservas.DataSource = new List<Reserva> { reserva };
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            PrincipalReserva form = new PrincipalReserva();
            form.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Principal form = new Principal();
            form.Show();
            this.Hide();
        }

        private void VisualizacaoReservas_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void dgvVisualizacaoReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvVisualizacaoReservas.Columns[e.ColumnIndex].Name == "Resgatar")
            {
                // Pega o ID da linha selecionada
                string idReserva = dgvVisualizacaoReservas.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();

                // Confirma exclusão
                DialogResult result = MessageBox.Show($"Deseja resgatar a reserva {idReserva}?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ReservaDAO reservaDAO = new ReservaDAO();
                    reservaDAO.ResgatarReserva(idReserva);

                    CarregarGrid();
                }
            }
            else if (e.RowIndex >= 0 && dgvVisualizacaoReservas.Columns[e.ColumnIndex].Name == "Cancelar")
            {
                // Pega o ID da linha selecionada
                string idReserva = dgvVisualizacaoReservas.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();

                // Confirma exclusão
                DialogResult result = MessageBox.Show($"Deseja excluir a reserva {idReserva}?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ReservaDAO reservaDAO = new ReservaDAO();
                    reservaDAO.ExcluirReservaNoBanco(idReserva);

                    CarregarGrid();
                }
            }
        }

        private void pictureBoxLupa_Click(object sender, EventArgs e)
        {
            UtilDAO utilDAO = new UtilDAO();
            string idReserva = texPesquisarCancelamentoReservas.Text;


            if (utilDAO.IdReservaExiste(idReserva))
            {
                CarregarGridPorBusca(idReserva);
            }
            else if (idReserva == "")
            {
                CarregarGrid();
            }
            else
            {
                MessageBox.Show($"A reserva {idReserva} não existe.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
