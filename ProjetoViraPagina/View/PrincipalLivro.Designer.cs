namespace Projeto_ViraPagina.View
{
    partial class PrincipalLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalLivro));
            panelLivro = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            labelAcervos = new Label();
            labelIntro = new Label();
            btnCriar = new Button();
            btnAtualizar = new Button();
            btnVerificar = new Button();
            btnDeletar = new Button();
            btnRelatorios = new Button();
            btnVoltar = new Button();
            panelLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelLivro
            // 
            panelLivro.BackColor = Color.DarkRed;
            panelLivro.Controls.Add(pictureBox1);
            panelLivro.Location = new Point(0, -8);
            panelLivro.Name = "panelLivro";
            panelLivro.Size = new Size(42, 468);
            panelLivro.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(494, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(321, 403);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // labelAcervos
            // 
            labelAcervos.AutoSize = true;
            labelAcervos.Font = new Font("Arial Narrow", 20F);
            labelAcervos.ForeColor = Color.DarkRed;
            labelAcervos.Location = new Point(208, 23);
            labelAcervos.Name = "labelAcervos";
            labelAcervos.Size = new Size(413, 31);
            labelAcervos.TabIndex = 6;
            labelAcervos.Text = "Gerenciamento de material impresso (MI)";
            // 
            // labelIntro
            // 
            labelIntro.AutoSize = true;
            labelIntro.Font = new Font("Arial Narrow", 11F);
            labelIntro.ForeColor = Color.DarkRed;
            labelIntro.Location = new Point(180, 133);
            labelIntro.Name = "labelIntro";
            labelIntro.Size = new Size(86, 20);
            labelIntro.TabIndex = 7;
            labelIntro.Text = "Você deseja...";
            // 
            // btnCriar
            // 
            btnCriar.BackColor = Color.DarkRed;
            btnCriar.Font = new Font("Segoe UI", 12F);
            btnCriar.ForeColor = Color.FromArgb(250, 243, 224);
            btnCriar.Location = new Point(180, 181);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(217, 41);
            btnCriar.TabIndex = 8;
            btnCriar.Text = "Criar um MI";
            btnCriar.UseVisualStyleBackColor = false;
            btnCriar.Click += btnCriar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.DarkRed;
            btnAtualizar.Font = new Font("Segoe UI", 12F);
            btnAtualizar.ForeColor = Color.FromArgb(250, 243, 224);
            btnAtualizar.Location = new Point(441, 181);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(217, 41);
            btnAtualizar.TabIndex = 9;
            btnAtualizar.Text = "Atualizar um MI";
            btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // btnVerificar
            // 
            btnVerificar.BackColor = Color.DarkRed;
            btnVerificar.Font = new Font("Segoe UI", 12F);
            btnVerificar.ForeColor = Color.FromArgb(250, 243, 224);
            btnVerificar.Location = new Point(441, 237);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(217, 41);
            btnVerificar.TabIndex = 11;
            btnVerificar.Text = "Verificar um MI";
            btnVerificar.UseVisualStyleBackColor = false;
            // 
            // btnDeletar
            // 
            btnDeletar.BackColor = Color.DarkRed;
            btnDeletar.Font = new Font("Segoe UI", 12F);
            btnDeletar.ForeColor = Color.FromArgb(250, 243, 224);
            btnDeletar.Location = new Point(180, 237);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(217, 41);
            btnDeletar.TabIndex = 10;
            btnDeletar.Text = "Deletar um MI";
            btnDeletar.UseVisualStyleBackColor = false;
            // 
            // btnRelatorios
            // 
            btnRelatorios.BackColor = Color.DarkRed;
            btnRelatorios.Font = new Font("Segoe UI", 12F);
            btnRelatorios.ForeColor = Color.FromArgb(250, 243, 224);
            btnRelatorios.Location = new Point(180, 294);
            btnRelatorios.Name = "btnRelatorios";
            btnRelatorios.Size = new Size(217, 41);
            btnRelatorios.TabIndex = 12;
            btnRelatorios.Text = "Relatórios dos MI";
            btnRelatorios.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.DarkRed;
            btnVoltar.Font = new Font("Segoe UI", 12F);
            btnVoltar.ForeColor = Color.FromArgb(250, 243, 224);
            btnVoltar.Location = new Point(498, 385);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(149, 41);
            btnVoltar.TabIndex = 13;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // PrincipalLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(btnRelatorios);
            Controls.Add(btnVerificar);
            Controls.Add(btnDeletar);
            Controls.Add(btnAtualizar);
            Controls.Add(btnCriar);
            Controls.Add(labelIntro);
            Controls.Add(labelAcervos);
            Controls.Add(pictureBox2);
            Controls.Add(panelLivro);
            Name = "PrincipalLivro";
            Text = "PrincipalLivro";
            panelLivro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelLivro;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label labelAcervos;
        private Label labelIntro;
        private Button btnCriar;
        private Button btnAtualizar;
        private Button btnVerificar;
        private Button btnDeletar;
        private Button btnRelatorios;
        private Button btnVoltar;
    }
}