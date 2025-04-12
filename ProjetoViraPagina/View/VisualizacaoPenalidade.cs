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

        private void Penalidades_Load(object sender, EventArgs e)
        {
            // Fundo da tela
            this.BackColor = ColorTranslator.FromHtml("#FFF4E3");

            // Fundo da tabela
            dgvPenalidades.BackgroundColor = ColorTranslator.FromHtml("#FFF4E3");

            // Não permitir adicionar linha manual
            dgvPenalidades.AllowUserToAddRows = false;

            // Esconder cabeçalho lateral
            dgvPenalidades.RowHeadersVisible = false;

            // Seleção da linha inteira
            dgvPenalidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Borda invisível nas células
            dgvPenalidades.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Fonte das células
            dgvPenalidades.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Cor da linha selecionada
            dgvPenalidades.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#5A0000");
            dgvPenalidades.DefaultCellStyle.SelectionForeColor = Color.White;

            // Cabeçalho estilizado
            dgvPenalidades.EnableHeadersVisualStyles = false;
            dgvPenalidades.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#8B0000");
            dgvPenalidades.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPenalidades.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvPenalidades.ColumnHeadersHeight = 35;

            // Espaçamento entre as linhas (efeito card)
            dgvPenalidades.RowTemplate.Height = 40;
            dgvPenalidades.DefaultCellStyle.Padding = new Padding(0, 5, 0, 5);

            // Cores das linhas
            dgvPenalidades.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#A67B5B");
            dgvPenalidades.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#8B0000");
            dgvPenalidades.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;

            // AutoSize manual para controlar os tamanhos
            dgvPenalidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Se as colunas já existirem, define os tamanhos
            if (dgvPenalidades.Columns.Count >= 5)
            {
                dgvPenalidades.Columns[0].Width = 60;   // Código
                dgvPenalidades.Columns[1].Width = 200;  // Nome do jogo
                dgvPenalidades.Columns[2].Width = 200;  // Tema
                dgvPenalidades.Columns[3].Width = 140;  // Número de jogadores
                dgvPenalidades.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Idioma
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