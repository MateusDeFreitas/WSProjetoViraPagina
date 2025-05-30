﻿namespace Projeto_ViraPagina.View

{

    partial class PrincipalJogos

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalJogos));
            btnVoltar = new Button();
            labelIntro = new Label();
            labelAcervos = new Label();
            pictureBox2 = new PictureBox();
            panelLivro = new Panel();
            pictureBox1 = new PictureBox();
            btnVerificar = new Button();
            btnDeletar = new Button();
            btnAtualizar = new Button();
            btnCriar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.DarkRed;
            btnVoltar.Font = new Font("Segoe UI", 12F);
            btnVoltar.ForeColor = Color.FromArgb(250, 243, 224);
            btnVoltar.Location = new Point(491, 384);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(149, 41);
            btnVoltar.TabIndex = 23;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // labelIntro
            // 
            labelIntro.AutoSize = true;
            labelIntro.Font = new Font("Arial Narrow", 11F);
            labelIntro.ForeColor = Color.DarkRed;
            labelIntro.Location = new Point(173, 132);
            labelIntro.Name = "labelIntro";
            labelIntro.Size = new Size(86, 20);
            labelIntro.TabIndex = 17;
            labelIntro.Text = "Você deseja...";
            // 
            // labelAcervos
            // 
            labelAcervos.AutoSize = true;
            labelAcervos.Font = new Font("Arial Narrow", 20F);
            labelAcervos.ForeColor = Color.DarkRed;
            labelAcervos.Location = new Point(288, 22);
            labelAcervos.Name = "labelAcervos";
            labelAcervos.Size = new Size(250, 31);
            labelAcervos.TabIndex = 16;
            labelAcervos.Text = "Gerenciamento de jogos";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(476, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(321, 403);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // panelLivro
            // 
            panelLivro.BackColor = Color.DarkRed;
            panelLivro.Controls.Add(pictureBox1);
            panelLivro.Location = new Point(0, -2);
            panelLivro.Name = "panelLivro";
            panelLivro.Size = new Size(42, 472);
            panelLivro.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnVerificar
            // 
            btnVerificar.BackColor = Color.DarkRed;
            btnVerificar.Font = new Font("Segoe UI", 12F);
            btnVerificar.ForeColor = Color.FromArgb(250, 243, 224);
            btnVerificar.Location = new Point(436, 248);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(217, 41);
            btnVerificar.TabIndex = 27;
            btnVerificar.Text = "Verificar um jogo";
            btnVerificar.UseVisualStyleBackColor = false;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.BackColor = Color.DarkRed;
            btnDeletar.Font = new Font("Segoe UI", 12F);
            btnDeletar.ForeColor = Color.FromArgb(250, 243, 224);
            btnDeletar.Location = new Point(175, 248);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(217, 41);
            btnDeletar.TabIndex = 26;
            btnDeletar.Text = "Deletar um jogo";
            btnDeletar.UseVisualStyleBackColor = false;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.DarkRed;
            btnAtualizar.Font = new Font("Segoe UI", 12F);
            btnAtualizar.ForeColor = Color.FromArgb(250, 243, 224);
            btnAtualizar.Location = new Point(436, 192);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(217, 41);
            btnAtualizar.TabIndex = 25;
            btnAtualizar.Text = "Atualizar um jogo";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnCriar
            // 
            btnCriar.BackColor = Color.DarkRed;
            btnCriar.Font = new Font("Segoe UI", 12F);
            btnCriar.ForeColor = Color.FromArgb(250, 243, 224);
            btnCriar.Location = new Point(175, 192);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(217, 41);
            btnCriar.TabIndex = 24;
            btnCriar.Text = "Criar um jogo";
            btnCriar.UseVisualStyleBackColor = false;
            btnCriar.Click += btnCriar_Click;
            // 
            // PrincipalJogos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerificar);
            Controls.Add(btnDeletar);
            Controls.Add(btnAtualizar);
            Controls.Add(btnCriar);
            Controls.Add(btnVoltar);
            Controls.Add(labelIntro);
            Controls.Add(labelAcervos);
            Controls.Add(pictureBox2);
            Controls.Add(panelLivro);
            Name = "PrincipalJogos";
            Text = "PrincipalJogos";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelLivro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Button btnVoltar;

        private Label labelIntro;

        private Label labelAcervos;

        private PictureBox pictureBox2;

        private Panel panelLivro;

        private Button btnVerificar;

        private Button btnDeletar;

        private Button btnAtualizar;

        private Button btnCriar;

        private PictureBox pictureBox1;

    }

}
