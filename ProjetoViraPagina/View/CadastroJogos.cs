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
    public partial class CadastroJogos : Form
    {
        public CadastroJogos()
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PrincipalJogos form = new PrincipalJogos();
            form.Show();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            //if (textIdJogo.Text == "")
            //{
            //    MessageBox.Show("Insirá um valor válido no campo código", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            
            if (textNome.Text == "")
            {
                MessageBox.Show("Insirá um valor válido no campo nome", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textGenero.Text == "")
            {
                MessageBox.Show("Insirá um valor válido no campo gênero", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textMarca.Text == "")
            {
                MessageBox.Show("Insirá um valor válido no campo marca", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textNumeroJogadores.Text == "")
            {
                MessageBox.Show("Insirá um valor válido no campo número de jogdores", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textMaterial.Text == "")
            {
                MessageBox.Show("Insirá um valor válido no campo material", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                JogoDAO jogoDAO = new JogoDAO();

                //jogo.IdJogo = textIdJogo.Text;
                jogo.Nome = textNome.Text;
                jogo.Genero = textGenero.Text;
                jogo.Marca = textMarca.Text;
                jogo.NumeroJogadores = textNumeroJogadores.Text;
                jogo.Material = textMaterial.Text;

                bool var = jogoDAO.AdicionarJogoNoBanco(jogo);

                if (var)
                {
                    textNome.Text = "";
                    textGenero.Text = "";
                    textMarca.Text = "";
                    textNumeroJogadores.Text = "";
                    textMaterial.Text = "";
                }
            }
        }
    }
}
