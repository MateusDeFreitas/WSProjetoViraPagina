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
    public partial class AtualizacaoMidia : Form
    {
        public AtualizacaoMidia()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CarregarInputs(Midia midia)
        {
            textIdMidia.Text = midia.IdMidia;
            textAnoLancamento.Text = midia.AnoLancamento;
            textTitulo.Text = midia.Titulo;
            textProdutora.Text = midia.Produtora;
            textDiretor.Text = midia.Diretor;
            textTipoMidia.Text = midia.Tipo;
            textGeneroMidia.Text = midia.Genero;
        }

        private void ExtrairInputs(Midia midia)
        {
            midia.IdMidia = textIdMidia.Text;
            midia.AnoLancamento = textAnoLancamento.Text;
            midia.Titulo = textTitulo.Text;
            midia.Produtora = textProdutora.Text;
            midia.Diretor = textDiretor.Text;
            midia.Tipo = textTipoMidia.Text;
            midia.Genero = textGeneroMidia.Text;
        }

        private void AtualizacaoMidia_Load(object sender, EventArgs e)
        {
            Midia ultimoItem = Midia.ListaMidia.Last();
            MidiaDAO midiaDAO = new MidiaDAO();

            CarregarInputs(midiaDAO.lerMidia(ultimoItem.IdMidia));
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (textIdMidia.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo código.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textAnoLancamento.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo ano de lançamento.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textTitulo.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo título.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textProdutora.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo produtora.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textDiretor.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo diretor.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textTipoMidia.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo tipo de mídia.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textGeneroMidia.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo gênero.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Midia midia = new Midia();
                MidiaDAO midiaDAO = new MidiaDAO();

                ExtrairInputs(midia);

                if (midiaDAO.AtualizarMidiaNoBanco(midia))
                {
                    EditarMidia form = new EditarMidia();
                    form.Show();
                    this.Hide();
                }
            }
        }
    }
}
