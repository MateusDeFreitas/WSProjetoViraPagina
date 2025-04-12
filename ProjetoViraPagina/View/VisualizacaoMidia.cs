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

        private void VisualizacaoMidia_Load(object sender, EventArgs e)
        {
            // Fundo da tela
            this.BackColor = ColorTranslator.FromHtml("#FFF4E3");

            // Fundo da tabela
            dgvVisualizacaoMidia.BackgroundColor = ColorTranslator.FromHtml("#FFF4E3");

            // Não permitir adicionar linha manual
            dgvVisualizacaoMidia.AllowUserToAddRows = false;

            // Esconder cabeçalho lateral
            dgvVisualizacaoMidia.RowHeadersVisible = false;

            // Seleção da linha inteira
            dgvVisualizacaoMidia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Borda invisível nas células
            dgvVisualizacaoMidia.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Fonte das células
            dgvVisualizacaoMidia.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Cor da linha selecionada
            dgvVisualizacaoMidia.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#5A0000");
            dgvVisualizacaoMidia.DefaultCellStyle.SelectionForeColor = Color.White;

            // Cabeçalho estilizado
            dgvVisualizacaoMidia.EnableHeadersVisualStyles = false;
            dgvVisualizacaoMidia.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#8B0000");
            dgvVisualizacaoMidia.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvVisualizacaoMidia.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvVisualizacaoMidia.ColumnHeadersHeight = 35;

            // Espaçamento entre as linhas (efeito card)
            dgvVisualizacaoMidia.RowTemplate.Height = 40;
            dgvVisualizacaoMidia.DefaultCellStyle.Padding = new Padding(0, 5, 0, 5);

            // Cores das linhas
            dgvVisualizacaoMidia.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#A67B5B");
            dgvVisualizacaoMidia.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#8B0000");
            dgvVisualizacaoMidia.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;

            // AutoSize manual para controlar os tamanhos
            dgvVisualizacaoMidia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Se as colunas já existirem, define os tamanhos
            if (dgvVisualizacaoMidia.Columns.Count >= 5)
            {
                dgvVisualizacaoMidia.Columns[0].Width = 60;   // Código
                dgvVisualizacaoMidia.Columns[1].Width = 200;  // Nome do jogo
                dgvVisualizacaoMidia.Columns[2].Width = 200;  // Tema
                dgvVisualizacaoMidia.Columns[3].Width = 140;  // Número de jogadores
                dgvVisualizacaoMidia.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Idioma
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