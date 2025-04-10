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
    public partial class EditarMidia : Form
    {
        public EditarMidia()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
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

        private void brnEditar_Click(object sender, EventArgs e)
        {
            if (textIdMidia.Text == "")
            {
                MessageBox.Show("Insira um valor no campo código.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Midia midia = new Midia();
                UtilDAO utilDAO = new UtilDAO();

                InstanciarId(midia);
                Midia.AdicionarMidia(midia);

                if (utilDAO.IdMidiaExiste(midia.IdMidia))
                {
                    AtualizacaoMidia form = new AtualizacaoMidia();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Erro ao buscar registro: Código identificador inexistente.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void InstanciarId (Midia midia)
        {
            midia.IdMidia = textIdMidia.Text;
        }
    }
}
