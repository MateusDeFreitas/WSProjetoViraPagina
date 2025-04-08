﻿using Projeto_ViraPagina.DAO;
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
    public partial class CadastroPenalidade : Form
    {
        public CadastroPenalidade()
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
            PrincipalPenalidade form = new PrincipalPenalidade();
            form.Show();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            UtilDAO utilDAO = new UtilDAO();


            if (textIdUsuario.Text == "")
            {
                MessageBox.Show("Insirá um valor válido no campo código usuário", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textIdEmprestimo.Text == "")
            {
                MessageBox.Show("Insirá um valor válido no campo código empréstimo", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textTipo.Text == "")
            {
                MessageBox.Show("Insirá um valor válido no campo tipo de penalidade", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!utilDAO.IdTomadorExixte(textIdUsuario.Text))
            {
                MessageBox.Show("Código de tomador não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!utilDAO.IdEmprestimoExixte(textIdEmprestimo.Text))
            {
                MessageBox.Show("Código de tomador não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

            }
        }
    }
}
