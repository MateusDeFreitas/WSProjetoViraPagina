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

        private void CarregarGrid()
        {
            MaterialImpressoDAO materialImpressoDAO = new MaterialImpressoDAO();

            List<MaterialImpresso> materiais = materialImpressoDAO.BuscarMateriaisImpressos();

            dgvVisualizacaoMaterialImpresso.Columns.Clear(); // Limpa colunas anteriores
            dgvVisualizacaoMaterialImpresso.DataSource = null;
            dgvVisualizacaoMaterialImpresso.AutoGenerateColumns = false;

            dgvVisualizacaoMaterialImpresso.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Código",
                DataPropertyName = "Codigo",
                Width = 100
            });

            dgvVisualizacaoMaterialImpresso.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Título",
                DataPropertyName = "Titulo",
                Width = 145
            });

            dgvVisualizacaoMaterialImpresso.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Autor",
                DataPropertyName = "Autor",
                Width = 145
            });

            dgvVisualizacaoMaterialImpresso.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Classe",
                DataPropertyName = "Classe",
                Width = 145
            });

            dgvVisualizacaoMaterialImpresso.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Idioma",
                DataPropertyName = "Idioma",
                Width = 145
            });

            // Botão de deletar
            DataGridViewButtonColumn botaoExcluir = new DataGridViewButtonColumn();
            botaoExcluir.Name = "Excluir";
            botaoExcluir.HeaderText = "";
            botaoExcluir.Text = "❌";
            botaoExcluir.UseColumnTextForButtonValue = true;
            botaoExcluir.Width = 50;
            dgvVisualizacaoMaterialImpresso.Columns.Add(botaoExcluir);

            // Vincula os dados
            dgvVisualizacaoMaterialImpresso.DataSource = materiais;
        }

        private void VisualizacaoMaterialImpresso_Load(object sender, EventArgs e)
        {
            MaterialImpressoDAO materialImpressoDAO = new MaterialImpressoDAO(); 
            // Configurações dataGridView
            this.BackColor = ColorTranslator.FromHtml("#FFF4E3");
            dgvVisualizacaoMaterialImpresso.BackgroundColor = ColorTranslator.FromHtml("#FFF4E3");
            dgvVisualizacaoMaterialImpresso.AllowUserToAddRows = false;
            dgvVisualizacaoMaterialImpresso.RowHeadersVisible = false;
            dgvVisualizacaoMaterialImpresso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVisualizacaoMaterialImpresso.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvVisualizacaoMaterialImpresso.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvVisualizacaoMaterialImpresso.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#5A0000");
            dgvVisualizacaoMaterialImpresso.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvVisualizacaoMaterialImpresso.EnableHeadersVisualStyles = false;
            dgvVisualizacaoMaterialImpresso.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#8B0000");
            dgvVisualizacaoMaterialImpresso.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvVisualizacaoMaterialImpresso.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvVisualizacaoMaterialImpresso.ColumnHeadersHeight = 35;
            dgvVisualizacaoMaterialImpresso.RowTemplate.Height = 40;
            dgvVisualizacaoMaterialImpresso.DefaultCellStyle.Padding = new Padding(0, 5, 0, 5);
            dgvVisualizacaoMaterialImpresso.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#A67B5B");
            dgvVisualizacaoMaterialImpresso.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#8B0000");
            dgvVisualizacaoMaterialImpresso.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            dgvVisualizacaoMaterialImpresso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Estilo do cabeçalho selecionado (para manter a cor bege também)
            dgvVisualizacaoMaterialImpresso.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(139, 0, 0);
            dgvVisualizacaoMaterialImpresso.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Maroon;

            //if (dgvVisualizacaoMaterialImpresso.Columns.Count >= 5)
            //{
            //    dgvVisualizacaoMaterialImpresso.Columns[0].Width = 60;   // Código
            //    dgvVisualizacaoMaterialImpresso.Columns[1].Width = 200;  // Nome do jogo
            //    dgvVisualizacaoMaterialImpresso.Columns[2].Width = 200;  // Tema
            //    dgvVisualizacaoMaterialImpresso.Columns[3].Width = 140;  // Número de jogadores
            //    dgvVisualizacaoMaterialImpresso.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Idioma
            //}

            List<MaterialImpresso> materiais = materialImpressoDAO.BuscarMateriaisImpressos();
            CarregarGrid();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Principal form = new Principal();
            form.Show();
            this.Hide();
        }
    }
}