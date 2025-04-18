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
    public partial class AtualizacaoJogos : Form
    {
        public AtualizacaoJogos()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CarregarInputs(Jogo jogo)
        {
            textIdJogo.Text = jogo.IdJogo;
   
            textNome.Text = jogo.Nome;
            textGenero.Text = jogo.Genero;
            textMarca.Text = jogo.Marca;
            textNumeroJogadores.Text = jogo.NumeroJogadores;
            textMaterial.Text = jogo.Material;
        }

        private void ExtrairInputs(Jogo jogo)
        {
            jogo.IdJogo = textIdJogo.Text;
            jogo.Nome = textNome.Text;
            jogo.Genero = textGenero.Text;
            jogo.Marca = textMarca.Text;
            jogo.NumeroJogadores = textNumeroJogadores.Text;
            jogo.Material = textMaterial.Text;
        }

        private void AtualizacaoJogos_Load(object sender, EventArgs e)
        {
            Jogo ultimoItem = Jogo.ListaJogo.Last();
            JogoDAO DAO = new JogoDAO();

            CarregarInputs(DAO.lerJogo(ultimoItem.IdJogo));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Principal form = new Principal();
            form.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PrincipalJogos form = new PrincipalJogos();
            form.Show();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (textIdJogo.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo código.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textNome.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo nome.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textGenero.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo gênero.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textMarca.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo marca.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textNumeroJogadores.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo número de jogadores.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textMaterial.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo material.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                JogoDAO jogoDAO = new JogoDAO();

                ExtrairInputs(jogo);

                if (jogoDAO.AtualizarJogoNoBanco(jogo))
                {
                    VisualizacaoJogos form = new VisualizacaoJogos();
                    form.Show();
                    this.Hide();
                }
            }
        }
    }
}
