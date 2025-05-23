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
    public partial class VisualizacaoLivroUnico : Form
    {
        public VisualizacaoLivroUnico()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            VisualizacaoMaterialImpresso form = new VisualizacaoMaterialImpresso();
            form.Show();
            this.Hide();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            VisualizacaoLivroUnicoP2 form = new VisualizacaoLivroUnicoP2();
            form.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Principal form = new Principal();
            form.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            VisualizacaoLivroUnicoP2 form = new VisualizacaoLivroUnicoP2();
            form.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            VisualizacaoLivroUnicoP3 form = new VisualizacaoLivroUnicoP3();
            form.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            VisualizacaoLivroUnicoP4 form = new VisualizacaoLivroUnicoP4();
            form.Show();
            this.Hide();
        }

        private void LoadImputs(MaterialImpresso mi)
        {
            labelTitulo.Text = mi.Titulo;
            labelTitulo.Location = new Point((816 - labelTitulo.Width) / 2, labelTitulo.Location.Y);
            textId.Text = mi.Id;
            textExemplar.Text = mi.Exemplar;
            textISBN.Text = mi.ISBN;
        }

        private void VisualizacaoLivroUnico_Load(object sender, EventArgs e)
        {
            MaterialImpressoDAO materialImpressoDAO = new MaterialImpressoDAO();
            MaterialImpresso ultimoItem = MaterialImpresso.ListaMateriaisImpressos.Last();

            ultimoItem = materialImpressoDAO.LerMaterialImpresso(ultimoItem.Id);

            LoadImputs(ultimoItem);
        }
    }
}
