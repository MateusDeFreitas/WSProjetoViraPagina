using Projeto_ViraPagina.DAO;
using Projeto_ViraPagina.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_ViraPagina.View
{
    public partial class VisualizacaoJogos : Form
    {
        public VisualizacaoJogos()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CarregarGrid()
        {
            JogoDAO jogoDAO = new JogoDAO();

            List<Jogo> jogos = jogoDAO.BuscarJogos();

            dgvVisualizacaoJogos.Columns.Clear(); // Limpa colunas anteriores
            dgvVisualizacaoJogos.DataSource = null;
            dgvVisualizacaoJogos.AutoGenerateColumns = false;

            dgvVisualizacaoJogos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Codigo",
                HeaderText = "Código",
                DataPropertyName = "IdJogo",
                Width = 100
            });

            dgvVisualizacaoJogos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Nome",
                DataPropertyName = "Nome",
                Width = 145
            });

            dgvVisualizacaoJogos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Gênero",
                DataPropertyName = "Genero",
                Width = 100
            });

            dgvVisualizacaoJogos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Marca",
                DataPropertyName = "Marca",
                Width = 145
            });

            dgvVisualizacaoJogos.Columns.Add(new DataGridViewTextBoxColumn()
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
            dgvVisualizacaoJogos.Columns.Add(colunaImagemEditar);

            DataGridViewImageColumn colunaImagem = new DataGridViewImageColumn();
            colunaImagem.Name = "Excluir";
            colunaImagem.HeaderText = "";
            colunaImagem.Image = Image.FromFile("Imagens/ImagemX.png");
            colunaImagem.Width = 45;
            colunaImagem.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvVisualizacaoJogos.Columns.Add(colunaImagem);

            // Vincula os dados
            dgvVisualizacaoJogos.DataSource = jogos;
        }

        private void CarregarGridPorBusca(string id)
        {
            JogoDAO jogoDAO = new JogoDAO();
            Jogo jogo = jogoDAO.lerJogo(id);


            dgvVisualizacaoJogos.Columns.Clear(); // Limpa colunas anteriores
            dgvVisualizacaoJogos.DataSource = null;
            dgvVisualizacaoJogos.AutoGenerateColumns = false;

            dgvVisualizacaoJogos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Codigo",
                HeaderText = "Código",
                DataPropertyName = "IdJogo",
                Width = 100
            });

            dgvVisualizacaoJogos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Nome",
                DataPropertyName = "Nome",
                Width = 145
            });

            dgvVisualizacaoJogos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Gênero",
                DataPropertyName = "Genero",
                Width = 100
            });

            dgvVisualizacaoJogos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Marca",
                DataPropertyName = "Marca",
                Width = 145
            });

            dgvVisualizacaoJogos.Columns.Add(new DataGridViewTextBoxColumn()
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
            dgvVisualizacaoJogos.Columns.Add(colunaImagemEditar);

            DataGridViewImageColumn colunaImagem = new DataGridViewImageColumn();
            colunaImagem.Name = "Excluir";
            colunaImagem.HeaderText = "";
            colunaImagem.Image = Image.FromFile("Imagens/ImagemX.png");
            colunaImagem.Width = 45;
            colunaImagem.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvVisualizacaoJogos.Columns.Add(colunaImagem);

            // Vincula os dados
            dgvVisualizacaoJogos.DataSource = new List<Jogo> { jogo };
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Principal form = new Principal();
            form.Show();
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            PrincipalJogos form = new PrincipalJogos();
            form.Show();
            this.Hide();
        }

        private void VisualizacaoJogos_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void dgvVisualizacaoJogos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvVisualizacaoJogos.Columns[e.ColumnIndex].Name == "Excluir")
            {
                // Pega o ID da linha selecionada
                string idJogo = dgvVisualizacaoJogos.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();

                // Confirma exclusão
                DialogResult result = MessageBox.Show("Deseja excluir este jogo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    JogoDAO jogoDAO = new JogoDAO();
                    jogoDAO.ExcluirJogoNoBanco(idJogo);

                    CarregarGrid();
                }
            }
            else if (e.RowIndex >= 0 && dgvVisualizacaoJogos.Columns[e.ColumnIndex].Name == "Editar")
            {
                Jogo jogo = new Jogo();
                UtilDAO utilDAO = new UtilDAO();

                jogo.IdJogo = dgvVisualizacaoJogos.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();

                Jogo.AdicionarJogo(jogo);

                if (utilDAO.IdJogoExiste(jogo.IdJogo))
                {
                    AtualizacaoJogos form = new AtualizacaoJogos();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Erro ao buscar registro: Código identificador inexistente.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void pictureBoxLupa_Click(object sender, EventArgs e)
        {
            UtilDAO utilDAO = new UtilDAO();
            string idJogo = texPesquisarVisualizacaoJogos.Text;


            if (utilDAO.IdJogoExiste(idJogo))
            {
                CarregarGridPorBusca(idJogo);
            }
            else if (idJogo == "")
            {
                CarregarGrid();
            }
            else
            {
                MessageBox.Show($"O jogo {idJogo} não existe.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}