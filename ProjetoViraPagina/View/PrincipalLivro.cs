﻿using System;
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
    public partial class PrincipalLivro : Form
    {
        public PrincipalLivro()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MenuAcervos form = new MenuAcervos();
            form.Show();
            this.Hide();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            CadastroLivro form = new CadastroLivro();
            form.Show();
            this.Hide();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            EditarMaterialImpresso form = new EditarMaterialImpresso();
            form.Show();
            this.Hide();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            VisualizacaoLivroUnico form = new VisualizacaoLivroUnico();
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
