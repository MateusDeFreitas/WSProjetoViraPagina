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
    public partial class VisualizacaoEmprestimos : Form
    {
        public VisualizacaoEmprestimos()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void VisualizacaoEmprestimos_Load(object sender, EventArgs e)
        {
            // Fundo da tela
            this.BackColor = ColorTranslator.FromHtml("#FFF4E3");

            // Fundo da tabela
            dgvVisualizacaoEmprestimos.BackgroundColor = ColorTranslator.FromHtml("#FFF4E3");

            // Não permitir adicionar linha manual
            dgvVisualizacaoEmprestimos.AllowUserToAddRows = false;

            // Esconder cabeçalho lateral
            dgvVisualizacaoEmprestimos.RowHeadersVisible = false;

            // Seleção da linha inteira
            dgvVisualizacaoEmprestimos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Borda invisível nas células
            dgvVisualizacaoEmprestimos.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Fonte das células
            dgvVisualizacaoEmprestimos.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Cor da linha selecionada
            dgvVisualizacaoEmprestimos.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#5A0000");
            dgvVisualizacaoEmprestimos.DefaultCellStyle.SelectionForeColor = Color.White;

            // Cabeçalho estilizado
            dgvVisualizacaoEmprestimos.EnableHeadersVisualStyles = false;
            dgvVisualizacaoEmprestimos.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#8B0000");
            dgvVisualizacaoEmprestimos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvVisualizacaoEmprestimos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvVisualizacaoEmprestimos.ColumnHeadersHeight = 35;

            // Espaçamento entre as linhas (efeito card)
            dgvVisualizacaoEmprestimos.RowTemplate.Height = 40;
            dgvVisualizacaoEmprestimos.DefaultCellStyle.Padding = new Padding(0, 5, 0, 5);

            // Cores das linhas
            dgvVisualizacaoEmprestimos.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#A67B5B");
            dgvVisualizacaoEmprestimos.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#8B0000");
            dgvVisualizacaoEmprestimos.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;

            // AutoSize manual para controlar os tamanhos
            dgvVisualizacaoEmprestimos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Se as colunas já existirem, define os tamanhos
            if (dgvVisualizacaoEmprestimos.Columns.Count >= 5)
            {
                dgvVisualizacaoEmprestimos.Columns[0].Width = 60;   // Código
                dgvVisualizacaoEmprestimos.Columns[1].Width = 200;  // Data devolução
                dgvVisualizacaoEmprestimos.Columns[2].Width = 200;  // Código livro
                dgvVisualizacaoEmprestimos.Columns[3].Width = 140;  // Unidade
                dgvVisualizacaoEmprestimos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Idioma
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