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
    public partial class VisualizacaoMidia : Form
    {
        public VisualizacaoMidia()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CarregarGrid()
        {
            MidiaDAO midiaDAO = new MidiaDAO();

            List<Midia> midias = midiaDAO.BuscarMidias();

            dgvVisualizacaoMidia.Columns.Clear(); // Limpa colunas anteriores
            dgvVisualizacaoMidia.DataSource = null;
            dgvVisualizacaoMidia.AutoGenerateColumns = false;

            dgvVisualizacaoMidia.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Codigo",
                HeaderText = "Código",
                DataPropertyName = "IdMidia",
                Width = 100
            });

            dgvVisualizacaoMidia.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Lancamento",
                DataPropertyName = "AnoLancamento",
                Width = 140,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            dgvVisualizacaoMidia.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Título",
                DataPropertyName = "Titulo",
                Width = 130
            });

            dgvVisualizacaoMidia.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Diretor",
                DataPropertyName = "Diretor",
                Width = 140
            });

            dgvVisualizacaoMidia.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Genero",
                DataPropertyName = "Genero",
                Width = 120
            });

            DataGridViewImageColumn colunaImagemEditar = new DataGridViewImageColumn();
            colunaImagemEditar.Name = "Editar";
            colunaImagemEditar.HeaderText = "";
            colunaImagemEditar.Image = Image.FromFile("Imagens/ImagemEditr.png");
            colunaImagemEditar.Width = 45;
            colunaImagemEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvVisualizacaoMidia.Columns.Add(colunaImagemEditar);

            DataGridViewImageColumn colunaImagem = new DataGridViewImageColumn();
            colunaImagem.Name = "Excluir";
            colunaImagem.HeaderText = "";
            colunaImagem.Image = Image.FromFile("Imagens/ImagemX.png");
            colunaImagem.Width = 45;
            colunaImagem.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvVisualizacaoMidia.Columns.Add(colunaImagem);

            // Vincula os dados
            dgvVisualizacaoMidia.DataSource = midias;
        }

        private void CarregarGridPorBusca(string id)
        {
            MidiaDAO midiaDAO = new MidiaDAO();
            Midia midia = midiaDAO.LerMidia(id);


            dgvVisualizacaoMidia.Columns.Clear(); // Limpa colunas anteriores
            dgvVisualizacaoMidia.DataSource = null;
            dgvVisualizacaoMidia.AutoGenerateColumns = false;

            dgvVisualizacaoMidia.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Codigo",
                HeaderText = "Código",
                DataPropertyName = "IdMidia",
                Width = 100
            });

            dgvVisualizacaoMidia.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Lancamento",
                DataPropertyName = "AnoLancamento",
                Width = 140,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            dgvVisualizacaoMidia.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Título",
                DataPropertyName = "Titulo",
                Width = 130
            });

            dgvVisualizacaoMidia.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Diretor",
                DataPropertyName = "Diretor",
                Width = 140
            });

            dgvVisualizacaoMidia.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Genero",
                DataPropertyName = "Genero",
                Width = 120
            });

            DataGridViewImageColumn colunaImagemEditar = new DataGridViewImageColumn();
            colunaImagemEditar.Name = "Editar";
            colunaImagemEditar.HeaderText = "";
            colunaImagemEditar.Image = Image.FromFile("Imagens/ImagemEditr.png");
            colunaImagemEditar.Width = 45;
            colunaImagemEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvVisualizacaoMidia.Columns.Add(colunaImagemEditar);

            DataGridViewImageColumn colunaImagem = new DataGridViewImageColumn();
            colunaImagem.Name = "Excluir";
            colunaImagem.HeaderText = "";
            colunaImagem.Image = Image.FromFile("Imagens/ImagemX.png");
            colunaImagem.Width = 45;
            colunaImagem.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvVisualizacaoMidia.Columns.Add(colunaImagem);

            // Vincula os dados
            dgvVisualizacaoMidia.DataSource = new List<Midia> { midia };
        }

        private void VisualizacaoMidia_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Principal form = new Principal();
            form.Show();
            this.Hide();
        }

        private void dgvVisualizacaoMidia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvVisualizacaoMidia.Columns[e.ColumnIndex].Name == "Excluir")
            {
                // Pega o ID da linha selecionada
                string idJogo = dgvVisualizacaoMidia.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();

                // Confirma exclusão
                DialogResult result = MessageBox.Show("Deseja excluir esta mídia?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MidiaDAO midiaDAO = new MidiaDAO();
                    midiaDAO.ExcluirMidiaNoBanco(idJogo);

                    CarregarGrid();
                }
            }
            else if (e.RowIndex >= 0 && dgvVisualizacaoMidia.Columns[e.ColumnIndex].Name == "Editar")
            {
                Midia midia = new Midia();
                UtilDAO utilDAO = new UtilDAO();

                midia.IdMidia = dgvVisualizacaoMidia.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();

                Midia.AdicionarMidia(midia);

                if (utilDAO.IdMidiaExiste(midia.IdMidia))
                {
                    AtualizacaoMidia form = new AtualizacaoMidia();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Erro ao buscar registro: Código identificador inexistente.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            PrincipalMidia form = new PrincipalMidia();
            form.Show();
            this.Hide();
        }

        private void pictureBoxLupa_Click(object sender, EventArgs e)
        {
            UtilDAO utilDAO = new UtilDAO();
            string idMidia = texPesquisarVisualizacaoMidia.Text;


            if (utilDAO.IdMidiaExiste(idMidia))
            {
                CarregarGridPorBusca(idMidia);
            }
            else if (idMidia == "")
            {
                CarregarGrid();
            }
            else
            {
                MessageBox.Show($"O mídia {idMidia} não existe.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}