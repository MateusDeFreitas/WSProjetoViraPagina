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
                DataPropertyName = "Id",
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

            DataGridViewImageColumn colunaImagem = new DataGridViewImageColumn();
            colunaImagem.Name = "Excluir";
            colunaImagem.HeaderText = "";
            colunaImagem.Image = Image.FromFile("ImagemX.png"); // Ou use Resources se for embedado
            colunaImagem.Width = 45;
            colunaImagem.ImageLayout = DataGridViewImageCellLayout.Zoom; // Deixa a imagem ajustada
            dgvVisualizacaoMaterialImpresso.Columns.Add(colunaImagem);

            // Vincula os dados
            dgvVisualizacaoMaterialImpresso.DataSource = materiais;
        }

        private void VisualizacaoMaterialImpresso_Load(object sender, EventArgs e)
        {
            MaterialImpressoDAO materialImpressoDAO = new MaterialImpressoDAO();

            // Configurações dataGridView
            this.BackColor = ColorTranslator.FromHtml("#FFF4E3");
            dgvVisualizacaoMaterialImpresso.BackgroundColor = ColorTranslator.FromHtml("#FFF4E3");

            List<MaterialImpresso> materiais = materialImpressoDAO.BuscarMateriaisImpressos();
            CarregarGrid();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Principal form = new Principal();
            form.Show();
            this.Hide();
        }

        private void ColorirLinhasAlternadas()
        {
            for (int i = 0; i < dgvVisualizacaoMaterialImpresso.Rows.Count; i++)
            {
                if (i % 2 == 0) // Linhas pares (0, 2, 4...) = Bege amarronzado (#A67B5B)
                {
                    dgvVisualizacaoMaterialImpresso.Rows[i].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#A67B5B");
                }
                else // Linhas ímpares (1, 3, 5...) = Vermelho escuro (#8B0000)
                {
                    dgvVisualizacaoMaterialImpresso.Rows[i].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#8B0000");
                    dgvVisualizacaoMaterialImpresso.Rows[i].DefaultCellStyle.ForeColor = Color.White; // Texto branco para contraste
                }
            }

        }
    }
}