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
    public partial class CadastroMidia : Form
    {
        public CadastroMidia()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PrincipalMidia form = new PrincipalMidia();
            form.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Principal form = new Principal();
            form.Show();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (textTitulo.Text == "")
            {
                MessageBox.Show("Insirá um valor válido no campo título", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textAnoLancamento.Text == "" || textAnoLancamento.Text.Length != 4)
            {
                MessageBox.Show("Insirá um valor válido no campo ano de lançamento", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textDiretor.Text == "")
            {
                MessageBox.Show("Insirá um valor válido no campo diretor", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textProdutora.Text == "")
            {
                MessageBox.Show("Insirá um valor válido no campo produtora", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textGeneroMidia.Text == "")
            {
                MessageBox.Show("Insirá um valor válido no campo gênero", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textTipoMidia.Text == "")
            {
                MessageBox.Show("Insirá um valor válido no campo tipo de mídia", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Midia midia = new Midia();
                MidiaDAO midiaDAO = new MidiaDAO();

                midia.Titulo = textTitulo.Text;
                midia.AnoLancamento = textAnoLancamento.Text;
                midia.Diretor = textDiretor.Text;
                midia.Produtora = textProdutora.Text;
                midia.Genero = textGeneroMidia.Text;
                midia.Tipo = textTipoMidia.Text;

                bool var = midiaDAO.AdicionarMidiaNoBanco(midia);

                if (var)
                {
                    textTitulo.Text = "";
                    textAnoLancamento.Text = "";
                    textDiretor.Text = "";
                    textProdutora.Text = "";
                    textGeneroMidia.Text = "";
                    textTipoMidia.Text = "";
                }
            }
        }
    }
}
