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
    public partial class CadastroEmprestimo : Form
    {
        public CadastroEmprestimo()
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
            PrincipalEmprestimo form = new PrincipalEmprestimo();
            form.Show();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Emprestimo emprestimo = new Emprestimo();
            EmprestimoDAO emprestimoDAO = new EmprestimoDAO();
            ReservaDAO reservaDAO = new ReservaDAO();
            UtilDAO utilDAO = new UtilDAO();

            if (textUsuario.Text == "" )
            {
                MessageBox.Show("Insirá um valor válido no campo código do usuário", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textAcervo.Text == "")
            {
                MessageBox.Show("Insirá um valor válido no campo código do acervo", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if ((utilDAO.IdMidiaExiste(textAcervo.Text)           ||
                     utilDAO.IdJogoExiste(textAcervo.Text)             ||
                     utilDAO.IdMaterialImpressoExiste(textAcervo.Text) ||
                     utilDAO.IdInstrumentoExiste(textAcervo.Text))     &&
                     utilDAO.IdTomadorExiste(textUsuario.Text)
                     )
            {
                if (utilDAO.IdMaterialImpressoExiste(textAcervo.Text))
                {
                    if (!reservaDAO.EstaReservado(textAcervo.Text))
                    {
                        InstanciarEmprestimo(emprestimo, utilDAO);

                        if (emprestimoDAO.AdicionarEmprestimoNoBanco(emprestimo))
                        {
                            textUsuario.Text = "";
                            textAcervo.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Este acervo está reservado.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    InstanciarEmprestimo(emprestimo, utilDAO);

                    if (emprestimoDAO.AdicionarEmprestimoNoBanco(emprestimo))
                    {
                        textUsuario.Text = "";
                        textAcervo.Text = "";
                    }
                }
            }
            else if (!utilDAO.IdTomadorExiste(textUsuario.Text))
            {
                MessageBox.Show("Código de tomdor não encontrado.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Código de acervo não encontrado.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void InstanciarEmprestimo(Emprestimo emprestimo, UtilDAO utilDAO)
        {
            emprestimo.IdUsuario = textUsuario.Text;

            if (utilDAO.IdMidiaExiste(textAcervo.Text))
            {
                emprestimo.IdMidia = textAcervo.Text;
            }
            else if (utilDAO.IdMaterialImpressoExiste(textAcervo.Text))
            {
                emprestimo.IdMaterialImpresso = textAcervo.Text;
            }
            else if (utilDAO.IdInstrumentoExiste(textAcervo.Text))
            {
                emprestimo.IdInstrumento = textAcervo.Text;
            }
            else if (utilDAO.IdJogoExiste(textAcervo.Text))
            {
                emprestimo.IdJogo = textAcervo.Text;
            }
        }
    }
}
