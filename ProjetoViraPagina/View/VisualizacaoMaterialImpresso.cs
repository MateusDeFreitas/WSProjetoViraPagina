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
    public partial class VisualizacaoMaterialImpresso : Form
    {
        public VisualizacaoMaterialImpresso()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void VisualizacaoMaterialImpresso_Load(object sender, EventArgs e)
        {
            // Fundo da tela
            this.BackColor = ColorTranslator.FromHtml("#FFF4E3");

            // Fundo da tabela
            dgvVisualizacaoMaterialImpresso.BackgroundColor = ColorTranslator.FromHtml("#FFF4E3");

            // Não permitir adicionar linha manual
            dgvVisualizacaoMaterialImpresso.AllowUserToAddRows = false;

            // Esconder cabeçalho lateral
            dgvVisualizacaoMaterialImpresso.RowHeadersVisible = false;

            // Seleção da linha inteira
            dgvVisualizacaoMaterialImpresso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Borda invisível nas células
            dgvVisualizacaoMaterialImpresso.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Fonte das células
            dgvVisualizacaoMaterialImpresso.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Cor da linha selecionada
            dgvVisualizacaoMaterialImpresso.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#5A0000");
            dgvVisualizacaoMaterialImpresso.DefaultCellStyle.SelectionForeColor = Color.White;

            // Cabeçalho estilizado
            dgvVisualizacaoMaterialImpresso.EnableHeadersVisualStyles = false;
            dgvVisualizacaoMaterialImpresso.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#8B0000");
            dgvVisualizacaoMaterialImpresso.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvVisualizacaoMaterialImpresso.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvVisualizacaoMaterialImpresso.ColumnHeadersHeight = 35;

            // Espaçamento entre as linhas (efeito card)
            dgvVisualizacaoMaterialImpresso.RowTemplate.Height = 40;
            dgvVisualizacaoMaterialImpresso.DefaultCellStyle.Padding = new Padding(0, 5, 0, 5);

            // Cores das linhas
            dgvVisualizacaoMaterialImpresso.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#A67B5B");
            dgvVisualizacaoMaterialImpresso.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#8B0000");
            dgvVisualizacaoMaterialImpresso.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;

            // AutoSize manual para controlar os tamanhos
            dgvVisualizacaoMaterialImpresso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Se as colunas já existirem, define os tamanhos
            if (dgvVisualizacaoMaterialImpresso.Columns.Count >= 5)
            {
                dgvVisualizacaoMaterialImpresso.Columns[0].Width = 60;   // Código
                dgvVisualizacaoMaterialImpresso.Columns[1].Width = 200;  // Nome do jogo
                dgvVisualizacaoMaterialImpresso.Columns[2].Width = 200;  // Tema
                dgvVisualizacaoMaterialImpresso.Columns[3].Width = 140;  // Número de jogadores
                dgvVisualizacaoMaterialImpresso.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Idioma
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