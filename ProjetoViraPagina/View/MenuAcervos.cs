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
    public partial class MenuAcervos : Form
    {
        public MenuAcervos()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Principal form = new Principal();
            form.Show();
            this.Hide();
        }

        private void btnLivros_Click(object sender, EventArgs e)
        {
            PrincipalLivro form = new PrincipalLivro();
            form.Show();
            this.Hide();
        }

        private void btnInstrumentos_Click(object sender, EventArgs e)
        {
            PrincipalInstrumentos form = new PrincipalInstrumentos();
            form.Show();
            this.Hide();
        }

        private void btnJogos_Click(object sender, EventArgs e)
        {
            PrincipalJogos form = new PrincipalJogos();
            form.Show();
            this.Hide();
        }

        private void btnMidia_Click(object sender, EventArgs e)
        {
            PrincipalMidia form = new PrincipalMidia();
            form.Show();
            this.Hide();
        }
    }
}
