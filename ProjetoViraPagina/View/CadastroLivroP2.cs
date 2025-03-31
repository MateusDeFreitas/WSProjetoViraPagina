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
    public partial class CadastroLivroP2 : Form
    {
        public CadastroLivroP2()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            PrincipalLivro form = new PrincipalLivro();
            form.Show();
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            CadastroLivro form = new CadastroLivro();
            form.Show();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (textClasse.Text == "")
            {
                MessageBox.Show("Insirá um valor válido no campo classe.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textCircular.Text == "")
            {
                MessageBox.Show("Insirá um sim ou não no campo circular.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textIdioma.Text == "")
            {
                MessageBox.Show("Insirá um valor valido no campo idioma.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MaterialImpresso ultimoItem = MaterialImpresso.ListaMateriaisImpressos.Last();
                MaterialImpressoDAO DAO = new MaterialImpressoDAO();

                ultimoItem.Classe = textClasse.Text;
                ultimoItem.ExtraiCircular(textCircular.Text);
                ultimoItem.Idioma = textIdioma.Text;
                ultimoItem.Resumo = textResumo.Text;

                DAO.AdicionarMaterialImpressoNoBanco(ultimoItem);
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
