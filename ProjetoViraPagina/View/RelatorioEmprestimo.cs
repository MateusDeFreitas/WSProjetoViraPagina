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
    public partial class RelatorioEmprestimo : Form
    {
        public RelatorioEmprestimo()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void RelatorioEmprestimo_Load(object sender, EventArgs e)
        {
            // Fundo da tela
            this.BackColor = ColorTranslator.FromHtml("#FFF4E3");

            // Fundo da tabela
            dgvRelatorioEmprestimo.BackgroundColor = ColorTranslator.FromHtml("#FFF4E3");

            // Não permitir adicionar linha manual
            dgvRelatorioEmprestimo.AllowUserToAddRows = false;

            // Esconder cabeçalho lateral
            dgvRelatorioEmprestimo.RowHeadersVisible = false;

            // Seleção da linha inteira
            dgvRelatorioEmprestimo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Borda invisível nas células
            dgvRelatorioEmprestimo.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Fonte das células
            dgvRelatorioEmprestimo.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Cor da linha selecionada
            dgvRelatorioEmprestimo.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#5A0000");
            dgvRelatorioEmprestimo.DefaultCellStyle.SelectionForeColor = Color.White;

            // Cabeçalho estilizado
            dgvRelatorioEmprestimo.EnableHeadersVisualStyles = false;
            dgvRelatorioEmprestimo.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#8B0000");
            dgvRelatorioEmprestimo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRelatorioEmprestimo.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvRelatorioEmprestimo.ColumnHeadersHeight = 35;

            // Espaçamento entre as linhas (efeito card)
            dgvRelatorioEmprestimo.RowTemplate.Height = 40;
            dgvRelatorioEmprestimo.DefaultCellStyle.Padding = new Padding(0, 5, 0, 5);

            // Cores das linhas
            dgvRelatorioEmprestimo.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#A67B5B");
            dgvRelatorioEmprestimo.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#8B0000");
            dgvRelatorioEmprestimo.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;

            // AutoSize manual para controlar os tamanhos
            dgvRelatorioEmprestimo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Se as colunas já existirem, define os tamanhos
            if (dgvRelatorioEmprestimo.Columns.Count >= 5)
            {
                dgvRelatorioEmprestimo.Columns[0].Width = 60;   // Código
                dgvRelatorioEmprestimo.Columns[1].Width = 200;  // Data devolução
                dgvRelatorioEmprestimo.Columns[2].Width = 200;  // Código livro
                dgvRelatorioEmprestimo.Columns[3].Width = 140;  // Unidade
                dgvRelatorioEmprestimo.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Idioma
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