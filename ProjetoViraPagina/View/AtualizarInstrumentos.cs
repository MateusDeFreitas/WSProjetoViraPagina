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
    public partial class AtualizarInstrumentos : Form
    {
        public AtualizarInstrumentos()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CarregarInputs(Instrumento instrumento)
        {
            textIdInstrumento.Text = instrumento.IdInstrumento;

            textCategoria.Text = instrumento.Categoria;
            textMarca.Text = instrumento.Marca;
            textModelo.Text = instrumento.Modelo;
            textNumeroSerie.Text = instrumento.NumeroSerie;
        }

        private void ExtrairInputs(Instrumento instrumento)
        {
            instrumento.IdInstrumento = textIdInstrumento.Text;
            instrumento.Categoria = textCategoria.Text;
            instrumento.Marca = textMarca.Text;
            instrumento.Modelo = textModelo.Text;
            instrumento.NumeroSerie = textNumeroSerie.Text;
        }

        private void AtualizarInstrumentos_Load_1(object sender, EventArgs e)
        {
            Instrumento ultimoItem = Instrumento.ListaInstrumento.Last();
            InstrumentoDAO DAO = new InstrumentoDAO();

            CarregarInputs(DAO.LerInstrumento(ultimoItem.IdInstrumento));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Principal form = new Principal();
            form.Show();
            this.Hide();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            VisualizacaoInstrumentos form = new VisualizacaoInstrumentos();
            form.Show();
            this.Hide();
        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            UtilDAO utilDAO = new UtilDAO();
            Instrumento ultimoItem = Instrumento.ListaInstrumento.Last();
            Instrumento instrumento = new Instrumento();
            InstrumentoDAO instrumentoDAO = new InstrumentoDAO();



            if (textIdInstrumento.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo código.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textCategoria.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo categoria.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textMarca.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo marca.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textModelo.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo modelo.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textNumeroSerie.Text == "")
            {
                MessageBox.Show("Insira um valor válido no campo número série.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (utilDAO.NumeroDeSerieExiste(textNumeroSerie.Text) && textIdInstrumento.Text != instrumentoDAO.LerInstrumentoPeloNueroDeSerie(textNumeroSerie.Text).IdInstrumento)
            {
                MessageBox.Show("Esse número de série já existe.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ExtrairInputs(instrumento);

                if (instrumentoDAO.AtualizarInstrumentoNoBanco(instrumento))
                {
                    VisualizacaoInstrumentos form = new VisualizacaoInstrumentos();
                    form.Show();
                    this.Hide();
                }
            }
        }
    }
}