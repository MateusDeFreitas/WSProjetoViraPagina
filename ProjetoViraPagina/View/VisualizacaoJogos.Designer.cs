namespace Projeto_ViraPagina.View
{
    partial class VisualizacaoJogos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizacaoJogos));
            dgvVisualizacaoJogos = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            NomeJogo = new DataGridViewTextBoxColumn();
            Tema = new DataGridViewTextBoxColumn();
            NumeroJogadores = new DataGridViewTextBoxColumn();
            Idioma = new DataGridViewTextBoxColumn();
            btnVoltar = new Button();
            panel5 = new Panel();
            texPesquisarVisualizacaoJogos = new TextBox();
            labelAtualizacaoJogos = new Label();
            panelLivro = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvVisualizacaoJogos).BeginInit();
            panelLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvVisualizacaoJogos
            // 
            dgvVisualizacaoJogos.BackgroundColor = Color.FromArgb(250, 243, 224);
            dgvVisualizacaoJogos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVisualizacaoJogos.Columns.AddRange(new DataGridViewColumn[] { Codigo, NomeJogo, Tema, NumeroJogadores, Idioma });
            dgvVisualizacaoJogos.Location = new Point(51, 124);
            dgvVisualizacaoJogos.Name = "dgvVisualizacaoJogos";
            dgvVisualizacaoJogos.Size = new Size(739, 239);
            dgvVisualizacaoJogos.TabIndex = 189;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            Codigo.Width = 145;
            // 
            // NomeJogo
            // 
            NomeJogo.HeaderText = "Nome do jogo";
            NomeJogo.Name = "NomeJogo";
            NomeJogo.Width = 145;
            // 
            // Tema
            // 
            Tema.HeaderText = "Tema";
            Tema.Name = "Tema";
            Tema.Width = 145;
            // 
            // NumeroJogadores
            // 
            NumeroJogadores.HeaderText = "Número de jogadores";
            NumeroJogadores.Name = "NumeroJogadores";
            NumeroJogadores.Width = 145;
            // 
            // Idioma
            // 
            Idioma.HeaderText = "Idioma";
            Idioma.Name = "Idioma";
            Idioma.Width = 145;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.DarkRed;
            btnVoltar.Font = new Font("Segoe UI", 12F);
            btnVoltar.ForeColor = Color.FromArgb(250, 243, 224);
            btnVoltar.Location = new Point(348, 400);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(128, 35);
            btnVoltar.TabIndex = 188;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkRed;
            panel5.Location = new Point(217, 101);
            panel5.Name = "panel5";
            panel5.Size = new Size(382, 4);
            panel5.TabIndex = 187;
            // 
            // texPesquisarVisualizacaoJogos
            // 
            texPesquisarVisualizacaoJogos.BackColor = Color.FromArgb(250, 243, 224);
            texPesquisarVisualizacaoJogos.BorderStyle = BorderStyle.None;
            texPesquisarVisualizacaoJogos.Font = new Font("Arial Narrow", 12F);
            texPesquisarVisualizacaoJogos.ForeColor = Color.FromArgb(130, 119, 106);
            texPesquisarVisualizacaoJogos.Location = new Point(212, 76);
            texPesquisarVisualizacaoJogos.Name = "texPesquisarVisualizacaoJogos";
            texPesquisarVisualizacaoJogos.Size = new Size(386, 19);
            texPesquisarVisualizacaoJogos.TabIndex = 186;
            // 
            // labelAtualizacaoJogos
            // 
            labelAtualizacaoJogos.AutoSize = true;
            labelAtualizacaoJogos.Font = new Font("Arial Narrow", 20F);
            labelAtualizacaoJogos.ForeColor = Color.DarkRed;
            labelAtualizacaoJogos.Location = new Point(285, 15);
            labelAtualizacaoJogos.Name = "labelAtualizacaoJogos";
            labelAtualizacaoJogos.Size = new Size(225, 31);
            labelAtualizacaoJogos.TabIndex = 185;
            labelAtualizacaoJogos.Text = "Visualização de jogos";
            // 
            // panelLivro
            // 
            panelLivro.BackColor = Color.DarkRed;
            panelLivro.Controls.Add(pictureBox1);
            panelLivro.Location = new Point(-1, -5);
            panelLivro.Name = "panelLivro";
            panelLivro.Size = new Size(42, 472);
            panelLivro.TabIndex = 184;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // VisualizacaoJogos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(dgvVisualizacaoJogos);
            Controls.Add(btnVoltar);
            Controls.Add(panel5);
            Controls.Add(texPesquisarVisualizacaoJogos);
            Controls.Add(labelAtualizacaoJogos);
            Controls.Add(panelLivro);
            Name = "VisualizacaoJogos";
            Text = "VisualizacaoJogos";
            Load += VisualizacaoJogos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVisualizacaoJogos).EndInit();
            panelLivro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVisualizacaoJogos;
        private Button btnVoltar;
        private Panel panel5;
        private TextBox texPesquisarVisualizacaoJogos;
        private Label labelAtualizacaoJogos;
        private Panel panelLivro;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn NomeJogo;
        private DataGridViewTextBoxColumn Tema;
        private DataGridViewTextBoxColumn NumeroJogadores;
        private DataGridViewTextBoxColumn Idioma;
        private PictureBox pictureBox1;
    }
}