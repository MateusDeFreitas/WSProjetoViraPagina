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
    public partial class CadastrarReservas : Form
    {
        public CadastrarReservas()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PrincipalReserva form = new PrincipalReserva();
            form.Show();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Reserva reserva = new Reserva();
            ReservaDAO reservaDAO = new ReservaDAO();
            UtilDAO utilDAO = new UtilDAO();

            if (textCodigoTomador.Text == "")
            {
                MessageBox.Show("Insirá um valor válido no campo código tomador.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textCodigoMaterialImpresso.Text == "")
            {
                MessageBox.Show("Insirá um valor válido no campo código material impresso.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!utilDAO.IdTomadorExiste(textCodigoTomador.Text))
            {
                MessageBox.Show("Código de tomador não encontrado.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!utilDAO.IdMaterialImpressoExiste(textCodigoMaterialImpresso.Text))
            {
                MessageBox.Show("Código do material impresso não encontrado.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                InstanciarReserva(reserva);

                if (reservaDAO.AdicionarReservaNoBanco(reserva))
                {
                    textCodigoTomador.Text = "";
                    textCodigoMaterialImpresso.Text = "";
                }
            }
        }

        private void InstanciarReserva(Reserva reserva)
        {
            reserva.IdUsuario = textCodigoTomador.Text;
            reserva.IdMaterialImpresso = textCodigoMaterialImpresso.Text;
        }
    }
}
