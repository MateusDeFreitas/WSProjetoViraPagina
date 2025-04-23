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
                DataPropertyName = "IdJogo",
                Width = 100
            });

            dgvVisualizacaoReservas.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Nome",
                DataPropertyName = "Nome",
                Width = 145
            });

            dgvVisualizacaoReservas.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Gênero",
                DataPropertyName = "Genero",
                Width = 100
            });

            dgvVisualizacaoReservas.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Marca",
                DataPropertyName = "Marca",
                Width = 145
            });

            dgvVisualizacaoReservas.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "N. Jogadores",
                DataPropertyName = "NumeroJogadores",
                Width = 140,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            DataGridViewImageColumn colunaImagemEditar = new DataGridViewImageColumn();
            colunaImagemEditar.Name = "Editar";
            colunaImagemEditar.HeaderText = "";
            colunaImagemEditar.Image = Image.FromFile("Imagens/ImagemEditr.png");
            colunaImagemEditar.Width = 45;
            colunaImagemEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvVisualizacaoReservas.Columns.Add(colunaImagemEditar);

            DataGridViewImageColumn colunaImagem = new DataGridViewImageColumn();
            colunaImagem.Name = "Excluir";
            colunaImagem.HeaderText = "";
            colunaImagem.Image = Image.FromFile("Imagens/ImagemX.png");
            colunaImagem.Width = 45;
            colunaImagem.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvVisualizacaoReservas.Columns.Add(colunaImagem);

            // Vincula os dados
            dgvVisualizacaoReservas.DataSource = reservas;
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
    }
}
