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
    public partial class CadastroLivro : Form
    {
        public CadastroLivro()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            textAno.PlaceholderText = "dd/mm/aaaa";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            PrincipalLivro form = new PrincipalLivro();
            form.Show();
            this.Hide();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (textTitulo.Text == "")
            {
                MessageBox.Show("Insira um título válido.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textExemplar.Text == "")
            {
                MessageBox.Show("Insira um exemplar válido.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textAutor.Text == "")
            {
                MessageBox.Show("Insira um autor válido.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textGenero.Text == "")
            {
                MessageBox.Show("Insira um gênero válido.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textEditora.Text == "")
            {
                MessageBox.Show("Insira um editora válido.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textIsbn.Text == "")
            {
                MessageBox.Show("Insira um ISBN válido.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textAno.Text == "")
            {
                MessageBox.Show("Insira um ano de lançamento válido.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MaterialImpresso mi = new MaterialImpresso();

                mi.Titulo = textTitulo.Text;
                mi.Exemplar = textExemplar.Text;
                mi.Autor = textAutor.Text;
                mi.Genero = textGenero.Text;
                mi.Editora = textEditora.Text;
                mi.ISBN = textIsbn.Text;
                mi.DataLancamento = textAno.Text;

                MaterialImpresso.AdicionarMaterialImpresso(mi);

                CadastroLivroP2 form = new CadastroLivroP2();
                form.Show();
                this.Hide();
            }
            
        }
    }
}
