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
    public partial class VisualizacaoLivroUnicoP3 : Form
    {
        public VisualizacaoLivroUnicoP3()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            VisualizacaoLivroUnicoP2 form = new VisualizacaoLivroUnicoP2();
            form.Show();
            this.Hide();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            VisualizacaoLivroUnicoP4 form = new VisualizacaoLivroUnicoP4();
            form.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Principal form = new Principal();
            form.Show();
            this.Hide();
        }
    }
}
