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
    public partial class CadastroInstrumentos : Form
    {
        public CadastroInstrumentos()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;

            ConfigurarComboCategoria(); // Nova configuração do ComboBox Categoria
        }

        private void ConfigurarComboCategoria()
        {
            // Preenche o ComboBox com categorias de instrumentos
            textCategoria.Items.AddRange(new string[]
            {
                "Violão",
                "Guitarra",
                "Pandeiro",
                "Cajón",
                "Baixo",
                "Flauta",
                "Violino",
                "Outro"
            });

            // Impede digitação manual
            textCategoria.DropDownStyle = ComboBoxStyle.DropDown;

            // Estilo visual Flat
            textCategoria.FlatStyle = FlatStyle.Flat;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Principal form = new Principal();
            form.Show();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            UtilDAO utilDAO = new UtilDAO();

            if (textCategoria.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo categoria", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textModelo.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo modelo", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textMarca.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo marca", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textNumeroSerie.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo número de série", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (utilDAO.NumeroDeSerieExiste(textNumeroSerie.Text))
            {
                MessageBox.Show("Esse número de série já foi registrado.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Instrumento instrumento = new Instrumento();
                InstrumentoDAO instrumentoDAO = new InstrumentoDAO();

                instanciarInstrumento(instrumento);

                if (instrumentoDAO.AdicionarInstrumentoNoBanco(instrumento))
                {
                    // Limpa os campos após cadastrar
                    textCategoria.SelectedIndex = -1;
                    textModelo.Text = "";
                    textMarca.Text = "";
                    textNumeroSerie.Text = "";
                }
            }
        }

        private void instanciarInstrumento(Instrumento instrumento)
        {
            instrumento.Categoria = textCategoria.Text;
            instrumento.Modelo = textModelo.Text;
            instrumento.Marca = textMarca.Text;
            instrumento.NumeroSerie = textNumeroSerie.Text;
        }
    }
}