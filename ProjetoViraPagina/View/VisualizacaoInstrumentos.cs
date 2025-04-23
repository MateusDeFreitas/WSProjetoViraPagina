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
    public partial class VisualizacaoInstrumentos : Form
    {
        public VisualizacaoInstrumentos()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CarregarGrid()
        {
            InstrumentoDAO instrumentoDAO = new InstrumentoDAO();

            List<Instrumento> instrumentos = instrumentoDAO.BuscarInstrumentos();

            dgvVisualizacaoInstrumentos.Columns.Clear(); // Limpa colunas anteriores
            dgvVisualizacaoInstrumentos.DataSource = null;
            dgvVisualizacaoInstrumentos.AutoGenerateColumns = false;

            dgvVisualizacaoInstrumentos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Codigo",
                HeaderText = "Código",
                DataPropertyName = "IdInstrumento",
                Width = 100
            });

            dgvVisualizacaoInstrumentos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Categoria",
                DataPropertyName = "Categoria",
                Width = 120
            });

            dgvVisualizacaoInstrumentos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Marca",
                DataPropertyName = "Marca",
                Width = 125
            });

            dgvVisualizacaoInstrumentos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Modelo",
                DataPropertyName = "Modelo",
                Width = 145
            });

            dgvVisualizacaoInstrumentos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "NumeroSerie",
                DataPropertyName = "NumeroSerie",
                Width = 140
            });

            DataGridViewImageColumn colunaImagemEditar = new DataGridViewImageColumn();
            colunaImagemEditar.Name = "Editar";
            colunaImagemEditar.HeaderText = "";
            colunaImagemEditar.Image = Image.FromFile("Imagens/ImagemEditr.png");
            colunaImagemEditar.Width = 45;
            colunaImagemEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvVisualizacaoInstrumentos.Columns.Add(colunaImagemEditar);

            DataGridViewImageColumn colunaImagem = new DataGridViewImageColumn();
            colunaImagem.Name = "Excluir";
            colunaImagem.HeaderText = "";
            colunaImagem.Image = Image.FromFile("Imagens/ImagemX.png");
            colunaImagem.Width = 45;
            colunaImagem.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvVisualizacaoInstrumentos.Columns.Add(colunaImagem);

            // Vincula os dados
            dgvVisualizacaoInstrumentos.DataSource = instrumentos;
        }

        private void VisualizacaoInstrumentos_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Principal form = new Principal();
            form.Show();
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            PrincipalInstrumentos form = new PrincipalInstrumentos();
            form.Show();
            this.Hide();
        }

        private void dgvVisualizacaoInstrumentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvVisualizacaoInstrumentos.Columns[e.ColumnIndex].Name == "Excluir")
            {
                // Pega o ID da linha selecionada
                string idJogo = dgvVisualizacaoInstrumentos.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();

                // Confirma exclusão
                DialogResult result = MessageBox.Show("Deseja excluir este instrumento?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    InstrumentoDAO instrumentoDAO = new InstrumentoDAO();
                    instrumentoDAO.ExcluirInstrumentoNoBanco(idJogo);

                    CarregarGrid();
                }
            }
            else if (e.RowIndex >= 0 && dgvVisualizacaoInstrumentos.Columns[e.ColumnIndex].Name == "Editar")
            {
                Instrumento instrumento = new Instrumento();
                UtilDAO utilDAO = new UtilDAO();

                instrumento.IdInstrumento = dgvVisualizacaoInstrumentos.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();

                Instrumento.AdicionarInstrumento(instrumento);

                if (utilDAO.IdInstrumentoExiste(instrumento.IdInstrumento))
                {
                    AtualizarInstrumentos form = new AtualizarInstrumentos();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Erro ao buscar registro: Código identificador inexistente.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}