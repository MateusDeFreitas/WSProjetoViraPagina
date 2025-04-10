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
    public partial class EditarInstrumentos : Form
    {
        public EditarInstrumentos()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            PrincipalInstrumentos form = new PrincipalInstrumentos();
            form.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Principal form = new Principal();
            form.Show();
            this.Hide();
        }

        private void InstanciarId(Instrumento instrumento)
        {
            instrumento.IdInstrumento = textIdInstrumento.Text;
        }

        private void brnEditar_Click(object sender, EventArgs e)
        {
            if (textIdInstrumento.Text == "")
            {
                MessageBox.Show("Insira um valor no campo código", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Instrumento instrumento = new Instrumento();
                UtilDAO utilDAO = new UtilDAO();

                InstanciarId(instrumento);

                Instrumento.AdicionarInstrumento(instrumento);

                if (utilDAO.IdInstrumentoExiste(instrumento.IdInstrumento))
                {
                    AtualizarInstrumentos form = new AtualizarInstrumentos();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Erro ao buscar registro: Código identificador inexistente.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}