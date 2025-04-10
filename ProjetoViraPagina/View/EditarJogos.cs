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
    public partial class EditarJogos : Form
    {
        public EditarJogos()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            PrincipalJogos form = new PrincipalJogos();
            form.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Principal form = new Principal();
            form.Show();
            this.Hide();
        }

        private void brnEditar_Click(object sender, EventArgs e)
        {
            if (textIdJogo.Text == "")
            {
                MessageBox.Show("Insira um valor no campo código", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                UtilDAO utilDAO = new UtilDAO();

                InstanciarId(jogo);

                Jogo.AdicionarJogo(jogo);

                if (utilDAO.IdJogoExiste(jogo.IdJogo))
                {
                    AtualizacaoJogos form = new AtualizacaoJogos();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Erro ao buscar registro: Código identificador inexistente.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void InstanciarId(Jogo jogo)
        {
            jogo.IdJogo = textIdJogo.Text;
        }
    }
}
