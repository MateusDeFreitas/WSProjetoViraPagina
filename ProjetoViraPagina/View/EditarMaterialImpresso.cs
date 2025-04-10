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

        private void brnEditar_Click(object sender, EventArgs e)
        {
            if (textId.Text == "")
            {
                MessageBox.Show("Insira um valor no campo código", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MaterialImpresso mi = new MaterialImpresso();
                UtilDAO utilDAO = new UtilDAO();

                IntanciarId(mi);

                MaterialImpresso.AdicionarMaterialImpresso(mi);

                if (utilDAO.idMaterialImpressoExiste(mi.Id))
                {
                    AtualizacaoMaterialImpresso form = new AtualizacaoMaterialImpresso();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Erro ao buscar registro: Código identificador inexistente.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Principal form = new Principal();
            form.Show();
            this.Hide();
        }

        private void IntanciarId (MaterialImpresso mi)
        {
            mi.Id = textId.Text;
        }
    }
}
