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
    public partial class EditarMaterialImpresso : Form
    {
        public EditarMaterialImpresso()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            PrincipalLivro form = new PrincipalLivro();
            form.Show();
            this.Hide();
        }
    }
}
