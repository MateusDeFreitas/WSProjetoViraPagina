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
    public partial class AtualizacaoMaterialImpresso : Form
    {
        public AtualizacaoMaterialImpresso()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AtualizacaoMaterialImpresso_Load(object sender, EventArgs e)
        {
            MaterialImpresso ultimoItem = MaterialImpresso.ListaMateriaisImpressos.Last();
            MaterialImpressoDAO DAO = new MaterialImpressoDAO();

            LoadInputs(DAO.lerMaterialImpresso(ultimoItem.Id));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PrincipalLivro form = new PrincipalLivro();
            form.Show();
            this.Hide();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            MaterialImpresso ultimoItem = MaterialImpresso.ListaMateriaisImpressos.Last();

            if (textIdLivro.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo código.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textAnoLancamento.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo data de lançamento.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textTitulo.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo título.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textExemplar.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo exemplar.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textAutor.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo autor.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textGenero.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo gênero.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textEditora.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo editora.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textISBN.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo ISBN.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                extractInputs(ultimoItem);

                AtualizacaoMaterialImpressoP2 form = new AtualizacaoMaterialImpressoP2();
                form.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Principal form = new Principal();
            form.Show();
            this.Hide();
        }
        private void LoadInputs(MaterialImpresso mi)
        {
            textIdLivro.Text = mi.Id;
            textAnoLancamento.Text = mi.DataLancamento;
            textTitulo.Text = mi.Titulo;
            textExemplar.Text = mi.Exemplar;
            textAutor.Text = mi.Autor;
            textGenero.Text = mi.Genero;
            textEditora.Text = mi.Editora;
            textISBN.Text = mi.ISBN;
        }

        private void extractInputs(MaterialImpresso mi)
        {
            mi.Id = textIdLivro.Text;
            mi.DataLancamento = textAnoLancamento.Text;
            mi.Titulo = textTitulo.Text;
            mi.Exemplar = textExemplar.Text;
            mi.Autor = textAutor.Text;
            mi.Genero = textGenero.Text;
            mi.Editora = textEditora.Text;
            mi.ISBN = textISBN.Text;
        }
    }
}
