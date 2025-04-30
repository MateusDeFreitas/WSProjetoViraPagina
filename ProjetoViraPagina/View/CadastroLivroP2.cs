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

            // Preencher os "text" (agora ComboBox) com as opções:
            PreencherCombos();
        }

        private void PreencherCombos()
        {
            // textClasse agora é ComboBox
            textClasse.Items.AddRange(new string[] { "Literatura", "Quadrinho", "Didático", "Idiomas", "Livro" });

            // textCircular agora é ComboBox
            textCircular.Items.AddRange(new string[] { "Circulável", "Não circulável" });

            // textIdioma agora é ComboBox
            textIdioma.Items.AddRange(new string[] { "Português", "Inglês", "Espanhol", "Francês", "Alemão" });

            // Definir valores padrão (opcional)
            textClasse.SelectedIndex = 0;
            textCircular.SelectedIndex = 1; // "Não"
            textIdioma.SelectedIndex = 0;   // "Português"
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
            if (string.IsNullOrWhiteSpace(textClasse.Text))
            {
                MessageBox.Show("Insira um valor válido no campo classe.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (string.IsNullOrWhiteSpace(textCircular.Text))
            {
                MessageBox.Show("Insira um valor válido no campo circular.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (string.IsNullOrWhiteSpace(textIdioma.Text))
            {
                MessageBox.Show("Insira um valor válido no campo idioma.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MaterialImpresso ultimoItem = MaterialImpresso.ListaMateriaisImpressos.Last();
                MaterialImpressoDAO DAO = new MaterialImpressoDAO();

                ultimoItem.Classe = textClasse.Text;
                ultimoItem.ExtraiCircular(textCircular.Text); // Continua igual
                ultimoItem.Idioma = textIdioma.Text;
                ultimoItem.Resumo = textResumo.Text;

                bool var = DAO.AdicionarMaterialImpressoNoBanco(ultimoItem);
                if (var)
                {
                    CadastroLivro form = new CadastroLivro();
                    form.Show();
                    this.Hide();
                }
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