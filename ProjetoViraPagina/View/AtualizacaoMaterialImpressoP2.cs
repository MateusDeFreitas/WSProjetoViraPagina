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
    public partial class AtualizacaoMaterialImpressoP2 : Form
    {
        public AtualizacaoMaterialImpressoP2()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AtualizacaoMaterialImpressoP2_Load(object sender, EventArgs e)
        {
            MaterialImpresso ultimoItem = MaterialImpresso.ListaMateriaisImpressos.Last();
            MaterialImpresso mi = new MaterialImpresso();
            MaterialImpressoDAO DAO = new MaterialImpressoDAO();

            mi = DAO.lerMaterialImpresso(ultimoItem.Id);

            textCircular.Text = mi.FormatarCircular(ultimoItem.Circular);
            textIdioma.Text = mi.Idioma;
            textClasse.Text = mi.Classe;
            textResumo.Text = mi.Resumo;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            PrincipalLivro form = new PrincipalLivro();
            form.Show();
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            AtualizacaoMaterialImpresso form = new AtualizacaoMaterialImpresso();
            form.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Principal form = new Principal();
            form.Show();
            this.Hide();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (textResumo.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo resumo.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textCircular.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo livro circular.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textIdioma.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo idioma.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textClasse.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo classe.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MaterialImpresso ultimoItem = MaterialImpresso.ListaMateriaisImpressos.Last();
                MaterialImpressoDAO DAO = new MaterialImpressoDAO();
                extractInputs(ultimoItem);

                if (DAO.AtualizarMaterialImpressoNoBanco(ultimoItem))
                {
                    VisualizacaoMaterialImpresso form = new VisualizacaoMaterialImpresso();
                    form.Show();
                    this.Hide();
                }
            }
        }

        private void extractInputs(MaterialImpresso mi)
        {
            mi.ExtraiCircular(textCircular.Text);
            mi.Idioma = textIdioma.Text;
            mi.Classe = textClasse.Text;
            mi.Resumo = textResumo.Text;
        }
    }
}
