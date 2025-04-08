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
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Principal form = new Principal();
            form.Show();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (textCategoria.Text == "")
            {
                MessageBox.Show("Insirá um valor válido no campo categoria", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textModelo.Text == "")
            {
                MessageBox.Show("Insirá um valor válido no campo modelo", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textMarca.Text == "")
            {
                MessageBox.Show("Insirá um valor válido no campo marca", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textNumeroSerie.Text == "")
            {
                MessageBox.Show("Insirá um valor válido no campo número de séire", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Instrumento instrumento = new Instrumento();
                InstrumentoDAO instrumentoDAO = new InstrumentoDAO();

                intanciarInstrumento(instrumento);

                if (instrumentoDAO.AdicionarInstrumentoNoBanco(instrumento))
                {
                    textCategoria.Text = "";
                    textModelo.Text = "";
                    textMarca.Text = "";
                    textNumeroSerie.Text = "";
                }
            }
        }
        private void intanciarInstrumento(Instrumento instrumento)
        {
            instrumento.Categoria = textCategoria.Text;
            instrumento.Modelo = textModelo.Text;
            instrumento.Marca = textMarca.Text;
            instrumento.NumeroSerie = textNumeroSerie.Text;
        }
    }
}
