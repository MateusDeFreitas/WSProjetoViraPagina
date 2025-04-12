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

        private void VisualizacaoJogos_Load(object sender, EventArgs e)
        {
            // Fundo da tela
            this.BackColor = ColorTranslator.FromHtml("#FFF4E3");

            // Fundo da tabela
            dgvVisualizacaoJogos.BackgroundColor = ColorTranslator.FromHtml("#FFF4E3");

            // Não permitir adicionar linha manual
            dgvVisualizacaoJogos.AllowUserToAddRows = false;

            // Esconder cabeçalho lateral
            dgvVisualizacaoJogos.RowHeadersVisible = false;

            // Seleção da linha inteira
            dgvVisualizacaoJogos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Borda invisível nas células
            dgvVisualizacaoJogos.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Fonte das células
            dgvVisualizacaoJogos.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Cor da linha selecionada
            dgvVisualizacaoJogos.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#5A0000");
            dgvVisualizacaoJogos.DefaultCellStyle.SelectionForeColor = Color.White;

            // Cabeçalho estilizado
            dgvVisualizacaoJogos.EnableHeadersVisualStyles = false;
            dgvVisualizacaoJogos.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#8B0000");
            dgvVisualizacaoJogos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvVisualizacaoJogos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvVisualizacaoJogos.ColumnHeadersHeight = 35;

            // Espaçamento entre as linhas (efeito card)
            dgvVisualizacaoJogos.RowTemplate.Height = 40;
            dgvVisualizacaoJogos.DefaultCellStyle.Padding = new Padding(0, 5, 0, 5);

            // Cores das linhas
            dgvVisualizacaoJogos.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#A67B5B");
            dgvVisualizacaoJogos.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#8B0000");
            dgvVisualizacaoJogos.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;

            // AutoSize manual para controlar os tamanhos
            dgvVisualizacaoJogos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Se as colunas já existirem, define os tamanhos
            if (dgvVisualizacaoJogos.Columns.Count >= 5)
            {
                dgvVisualizacaoJogos.Columns[0].Width = 60;   // Código
                dgvVisualizacaoJogos.Columns[1].Width = 200;  // Nome do jogo
                dgvVisualizacaoJogos.Columns[2].Width = 200;  // Tema
                dgvVisualizacaoJogos.Columns[3].Width = 140;  // Número de jogadores
                dgvVisualizacaoJogos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Idioma
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Principal form = new Principal();
            form.Show();
            this.Hide();
        }
    }
}