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

        private void VisualizacaoInstrumentos_Load(object sender, EventArgs e)
        {
            // Fundo da tela
            this.BackColor = ColorTranslator.FromHtml("#FFF4E3");

            // Fundo da tabela
            dgvVisualizacaoInstrumentos.BackgroundColor = ColorTranslator.FromHtml("#FFF4E3");

            // Não permitir adicionar linha manual
            dgvVisualizacaoInstrumentos.AllowUserToAddRows = false;

            // Esconder cabeçalho lateral
            dgvVisualizacaoInstrumentos.RowHeadersVisible = false;

            // Seleção da linha inteira
            dgvVisualizacaoInstrumentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Borda invisível nas células
            dgvVisualizacaoInstrumentos.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Fonte das células
            dgvVisualizacaoInstrumentos.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Cor da linha selecionada
            dgvVisualizacaoInstrumentos.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#5A0000");
            dgvVisualizacaoInstrumentos.DefaultCellStyle.SelectionForeColor = Color.White;

            // Cabeçalho estilizado
            dgvVisualizacaoInstrumentos.EnableHeadersVisualStyles = false;
            dgvVisualizacaoInstrumentos.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#8B0000");
            dgvVisualizacaoInstrumentos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvVisualizacaoInstrumentos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvVisualizacaoInstrumentos.ColumnHeadersHeight = 35;

            // Espaçamento entre as linhas (efeito card)
            dgvVisualizacaoInstrumentos.RowTemplate.Height = 40;
            dgvVisualizacaoInstrumentos.DefaultCellStyle.Padding = new Padding(0, 5, 0, 5);

            // Cores das linhas
            dgvVisualizacaoInstrumentos.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#A67B5B");
            dgvVisualizacaoInstrumentos.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#8B0000");
            dgvVisualizacaoInstrumentos.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;

            // AutoSize manual para controlar os tamanhos
            dgvVisualizacaoInstrumentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Se as colunas já existirem, define os tamanhos
            if (dgvVisualizacaoInstrumentos.Columns.Count >= 5)
            {
                dgvVisualizacaoInstrumentos.Columns[0].Width = 60;   // Código
                dgvVisualizacaoInstrumentos.Columns[1].Width = 200;  // Nome do jogo
                dgvVisualizacaoInstrumentos.Columns[2].Width = 200;  // Tema
                dgvVisualizacaoInstrumentos.Columns[3].Width = 140;  // Número de jogadores
                dgvVisualizacaoInstrumentos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Idioma
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