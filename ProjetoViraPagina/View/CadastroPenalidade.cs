﻿using Projeto_ViraPagina.DAO;
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
    public partial class CadastroPenalidade : Form
    {
        public CadastroPenalidade()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;

            ConfigurarComboTipoPenalidade(); // Preenche o ComboBox Tipo de Penalidade
        }

        private void ConfigurarComboTipoPenalidade()
        {
            textTipo.Items.AddRange(new string[]
            {
                "LD",
                "ATS",
                "LP",
                "LTD",
            });

            textTipo.DropDownStyle = ComboBoxStyle.DropDown;
            textTipo.FlatStyle = FlatStyle.Flat;
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
            Penalidade penalidade = new Penalidade();
            PenalidadeDAO penalidadeDAO = new PenalidadeDAO();

            if (textIdUsuario.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo código tomador.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textIdEmprestimo.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo código empréstimo.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textTipo.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo tipo de penalidade.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!utilDAO.IdTomadorExiste(textIdUsuario.Text))
            {
                MessageBox.Show("Código de tomador não encontrado.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!utilDAO.IdEmprestimoExiste(textIdEmprestimo.Text))
            {
                MessageBox.Show("Código de empréstimo não encontrado.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                InstanciarPenalidade(penalidade);

                if (penalidadeDAO.AdicionarPenalidadeNoBanco(penalidade))
                {
                    textIdUsuario.Text = "";
                    textIdEmprestimo.Text = "";
                    textTipo.SelectedIndex = -1; // Limpa a seleção do ComboBox
                }
            }
        }

        private void InstanciarPenalidade(Penalidade penalidade)
        {
            penalidade.IdUsuario = textIdUsuario.Text;
            penalidade.IdEmprestimo = textIdEmprestimo.Text;
            penalidade.CodPenalidade = textTipo.Text;
        }
    }
}