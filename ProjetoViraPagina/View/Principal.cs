using MySql.Data.MySqlClient;
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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.StartPosition = FormStartPosition.CenterScreen;

            textPesquisa.PlaceholderText = "Pesquisar";
        }

        private void labelEmprestimo_Click(object sender, EventArgs e)
        {
            PrincipalEmprestimo form = new PrincipalEmprestimo();
            form.Show();
            this.Hide();
        }

        private void labelAcervos_Click(object sender, EventArgs e)
        {
            MenuAcervos form = new MenuAcervos();
            form.Show();
            this.Hide();
        }

        private void labelReservas_Click(object sender, EventArgs e)
        {
            PrincipalReserva form = new PrincipalReserva();
            form.Show();
            this.Hide();
        }

        private void labelPenalidades_Click(object sender, EventArgs e)
        {
            PrincipalPenalidade form = new PrincipalPenalidade();
            form.Show();
            this.Hide();
        }

        private void pictureBoxLupa_Click(object sender, EventArgs e)
        {
            string id = textPesquisa.Text;

            TomadorDAO tomadorDAO = new TomadorDAO();
            UtilDAO utilDAO = new UtilDAO();

            if (utilDAO.IdTomadorExiste(id))
            {
                Tomador tomador = tomadorDAO.LerTomador(id);
                ApagarCampos();
                CarregarCampos(tomador);
            }
            else
            {
                MessageBox.Show("Tomador não encontrado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ApagarCampos()
        {
            textNomeTomador.Text = "";
            textEmail.Text = "";
            textPenalidades.Text = "";
            textPenalidades.Text = "";
            textMatricula.Text = "";
            textTelefone.Text = "";
            textVinculo.Text = "";
            textCodigo.Text = "";
        }

        private void CarregarCampos(Tomador tomador)
        {
            textNomeTomador.Text = tomador.Nome;
            textEmail.Text = tomador.Email;
            textLivrosEmprestados.Text = tomador.NumeroDeLivrosEmprestados.ToString();
            textPenalidades.Text = tomador.NumeroDePenalidade.ToString();
            textMatricula.Text = tomador.exibirValidadeMatricula(tomador.ValidadeMatricula);
            textTelefone.Text = tomador.NumeroTelefone;
            textVinculo.Text = tomador.Vinculo;
            textCodigo.Text = tomador.Id;
        }
    }
}
