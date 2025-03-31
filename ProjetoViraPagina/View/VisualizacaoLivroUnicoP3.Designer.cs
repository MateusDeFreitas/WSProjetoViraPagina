﻿namespace Projeto_ViraPagina.View
{
    partial class VisualizacaoLivroUnicoP3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizacaoLivroUnicoP3));
            panelLivro = new Panel();
            pictureBox1 = new PictureBox();
            labelAcervos = new Label();
            btnVoltar = new Button();
            btnProximo = new Button();
            panel3 = new Panel();
            textIdioma = new TextBox();
            labelIdioma = new Label();
            panel4 = new Panel();
            textClasse = new TextBox();
            labelClasse = new Label();
            panel5 = new Panel();
            textAnoLancamento = new TextBox();
            labelAnoLancamento = new Label();
            pictureBox2 = new PictureBox();
            panelLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelLivro
            // 
            panelLivro.BackColor = Color.DarkRed;
            panelLivro.Controls.Add(pictureBox1);
            panelLivro.Location = new Point(0, 0);
            panelLivro.Name = "panelLivro";
            panelLivro.Size = new Size(42, 472);
            panelLivro.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 126;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // labelAcervos
            // 
            labelAcervos.AutoSize = true;
            labelAcervos.Font = new Font("Arial Narrow", 20F);
            labelAcervos.ForeColor = Color.DarkRed;
            labelAcervos.Location = new Point(290, 17);
            labelAcervos.Name = "labelAcervos";
            labelAcervos.Size = new Size(154, 31);
            labelAcervos.TabIndex = 122;
            labelAcervos.Text = "*Título do livro";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.DarkRed;
            btnVoltar.Font = new Font("Segoe UI", 12F);
            btnVoltar.ForeColor = Color.FromArgb(250, 243, 224);
            btnVoltar.Location = new Point(464, 403);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(128, 35);
            btnVoltar.TabIndex = 127;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnProximo
            // 
            btnProximo.BackColor = Color.DarkRed;
            btnProximo.Font = new Font("Segoe UI", 12F);
            btnProximo.ForeColor = Color.FromArgb(250, 243, 224);
            btnProximo.Location = new Point(607, 403);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(128, 35);
            btnProximo.TabIndex = 126;
            btnProximo.Text = "Próximo";
            btnProximo.UseVisualStyleBackColor = false;
            btnProximo.Click += btnProximo_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkRed;
            panel3.Location = new Point(66, 323);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 4);
            panel3.TabIndex = 137;
            // 
            // textIdioma
            // 
            textIdioma.BackColor = Color.FromArgb(250, 243, 224);
            textIdioma.BorderStyle = BorderStyle.None;
            textIdioma.Font = new Font("Arial Narrow", 12F);
            textIdioma.ForeColor = Color.FromArgb(130, 119, 106);
            textIdioma.Location = new Point(70, 298);
            textIdioma.Name = "textIdioma";
            textIdioma.Size = new Size(257, 19);
            textIdioma.TabIndex = 136;
            // 
            // labelIdioma
            // 
            labelIdioma.AutoSize = true;
            labelIdioma.Font = new Font("Arial Narrow", 14F);
            labelIdioma.ForeColor = Color.DarkRed;
            labelIdioma.Location = new Point(66, 257);
            labelIdioma.Name = "labelIdioma";
            labelIdioma.Size = new Size(56, 23);
            labelIdioma.TabIndex = 135;
            labelIdioma.Text = "Idioma";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkRed;
            panel4.Location = new Point(67, 239);
            panel4.Name = "panel4";
            panel4.Size = new Size(270, 4);
            panel4.TabIndex = 134;
            // 
            // textClasse
            // 
            textClasse.BackColor = Color.FromArgb(250, 243, 224);
            textClasse.BorderStyle = BorderStyle.None;
            textClasse.Font = new Font("Arial Narrow", 12F);
            textClasse.ForeColor = Color.FromArgb(130, 119, 106);
            textClasse.Location = new Point(71, 214);
            textClasse.Name = "textClasse";
            textClasse.Size = new Size(257, 19);
            textClasse.TabIndex = 133;
            // 
            // labelClasse
            // 
            labelClasse.AutoSize = true;
            labelClasse.Font = new Font("Arial Narrow", 14F);
            labelClasse.ForeColor = Color.DarkRed;
            labelClasse.Location = new Point(66, 173);
            labelClasse.Name = "labelClasse";
            labelClasse.Size = new Size(58, 23);
            labelClasse.TabIndex = 132;
            labelClasse.Text = "Classe";
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkRed;
            panel5.Location = new Point(66, 152);
            panel5.Name = "panel5";
            panel5.Size = new Size(270, 4);
            panel5.TabIndex = 131;
            // 
            // textAnoLancamento
            // 
            textAnoLancamento.BackColor = Color.FromArgb(250, 243, 224);
            textAnoLancamento.BorderStyle = BorderStyle.None;
            textAnoLancamento.Font = new Font("Arial Narrow", 12F);
            textAnoLancamento.ForeColor = Color.FromArgb(130, 119, 106);
            textAnoLancamento.Location = new Point(70, 127);
            textAnoLancamento.Name = "textAnoLancamento";
            textAnoLancamento.Size = new Size(257, 19);
            textAnoLancamento.TabIndex = 130;
            // 
            // labelAnoLancamento
            // 
            labelAnoLancamento.AutoSize = true;
            labelAnoLancamento.Font = new Font("Arial Narrow", 14F);
            labelAnoLancamento.ForeColor = Color.DarkRed;
            labelAnoLancamento.Location = new Point(66, 86);
            labelAnoLancamento.Name = "labelAnoLancamento";
            labelAnoLancamento.Size = new Size(145, 23);
            labelAnoLancamento.TabIndex = 129;
            labelAnoLancamento.Text = "Ano de lançamento";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(477, 44);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(321, 403);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 127;
            pictureBox2.TabStop = false;
            // 
            // VisualizacaoLivroUnicoP3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(textIdioma);
            Controls.Add(labelIdioma);
            Controls.Add(panel4);
            Controls.Add(textClasse);
            Controls.Add(labelClasse);
            Controls.Add(panel5);
            Controls.Add(textAnoLancamento);
            Controls.Add(labelAnoLancamento);
            Controls.Add(btnVoltar);
            Controls.Add(btnProximo);
            Controls.Add(labelAcervos);
            Controls.Add(panelLivro);
            Controls.Add(pictureBox2);
            Name = "VisualizacaoLivroUnicoP3";
            Text = "VisualizacaoLivroUnicoP3";
            panelLivro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelLivro;
        private Label labelAcervos;
        private Button btnVoltar;
        private Button btnProximo;
        private Panel panel3;
        private TextBox textIdioma;
        private Label labelIdioma;
        private Panel panel4;
        private TextBox textClasse;
        private Label labelClasse;
        private Panel panel5;
        private TextBox textAnoLancamento;
        private Label labelAnoLancamento;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
