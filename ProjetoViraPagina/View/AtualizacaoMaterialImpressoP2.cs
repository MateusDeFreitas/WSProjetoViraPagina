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

            ConfigurarCombos(); // Configura os ComboBox
        }

        private void ConfigurarCombos()
        {
            // Preenche os ComboBoxes
            textClasse.Items.AddRange(new string[] { "Literatura", "Quadrinho", "Didático", "Idiomas", "Livro" });
            textCircular.Items.AddRange(new string[] { "Circulável", "Não circulável" });
            textIdioma.Items.AddRange(new string[] { "Português", "Inglês", "Espanhol", "Francês", "Alemão" });

            // Bloqueia digitação
            textClasse.DropDownStyle = ComboBoxStyle.DropDown;
            textCircular.DropDownStyle = ComboBoxStyle.DropDownList;
            textIdioma.DropDownStyle = ComboBoxStyle.DropDown;

            // Estilo Flat (opcional)
            textClasse.FlatStyle = FlatStyle.Flat;
            textCircular.FlatStyle = FlatStyle.Flat;
            textIdioma.FlatStyle = FlatStyle.Flat;
        }

        private void AtualizacaoMaterialImpressoP2_Load(object sender, EventArgs e)
        {
            MaterialImpresso ultimoItem = MaterialImpresso.ListaMateriaisImpressos.Last();
            MaterialImpressoDAO DAO = new MaterialImpressoDAO();
            MaterialImpresso mi = DAO.LerMaterialImpresso(ultimoItem.Id);

            // Seleciona os valores nos ComboBox
            string circular = mi.FormatarCircular(mi.Circular);
            string idioma = mi.Idioma;
            string classe = mi.Classe;

            textCircular.SelectedIndex = ObterIndice(textCircular, circular);
            textIdioma.SelectedIndex = ObterIndice(textIdioma, idioma);
            textClasse.SelectedIndex = ObterIndice(textClasse, classe);
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
            mi.ExtraiCircular(textCircular.Text); // Conversão de "Sim"/"Não" para bool
            mi.Idioma = textIdioma.Text;
            mi.Classe = textClasse.Text;
            mi.Resumo = textResumo.Text;
        }

        private int ObterIndice(ComboBox comboBox, string valor)
        {
            return comboBox.Items.IndexOf(valor);
        }
    }
}