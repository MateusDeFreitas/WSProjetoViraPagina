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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Principal form = new Principal();
            form.Show();
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            PrincipalLivro form = new PrincipalLivro();
            form.Show();
            this.Hide();
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
                Name = "Codigo",
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
            colunaImagem.Image = Image.FromFile("ImagemX.png");
            colunaImagem.Width = 45;
            colunaImagem.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvVisualizacaoMaterialImpresso.Columns.Add(colunaImagem);

            // Vincula os dados
            dgvVisualizacaoMaterialImpresso.DataSource = materiais;
        }

        private void VisualizacaoMaterialImpresso_Load(object sender, EventArgs e)
        {
            MaterialImpressoDAO materialImpressoDAO = new MaterialImpressoDAO();

            List<MaterialImpresso> materiais = materialImpressoDAO.BuscarMateriaisImpressos();
            CarregarGrid();
        }

        private void dgvVisualizacaoMaterialImpresso_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvVisualizacaoMaterialImpresso.Columns[e.ColumnIndex].Name == "Excluir")
            {
                // Pega o ID da linha selecionada
                string idMaterial = dgvVisualizacaoMaterialImpresso.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();

                // Confirma exclusão
                DialogResult result = MessageBox.Show("Deseja excluir este material?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MaterialImpressoDAO materialImpressoDAO = new MaterialImpressoDAO();
                    materialImpressoDAO.ExcluirMaterialImpressoNoBanco(idMaterial);

                    CarregarGrid();
                }
            }
        }
    }
}