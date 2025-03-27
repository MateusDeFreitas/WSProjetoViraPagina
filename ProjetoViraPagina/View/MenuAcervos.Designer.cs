namespace Projeto_ViraPagina.View
{
    partial class MenuAcervos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAcervos));
            PictureLivro = new PictureBox();
            panelLivro = new Panel();
            pictureBox1 = new PictureBox();
            labelAcervos = new Label();
            labelIntro = new Label();
            btnLivros = new Button();
            btnInstrumentos = new Button();
            btnMidia = new Button();
            btnJogos = new Button();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureLivro).BeginInit();
            panelLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PictureLivro
            // 
            PictureLivro.Image = (Image)resources.GetObject("PictureLivro.Image");
            PictureLivro.InitialImage = null;
            PictureLivro.Location = new Point(9, 104);
            PictureLivro.Name = "PictureLivro";
            PictureLivro.Size = new Size(236, 234);
            PictureLivro.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureLivro.TabIndex = 0;
            PictureLivro.TabStop = false;
            // 
            // panelLivro
            // 
            panelLivro.BackColor = Color.DarkRed;
            panelLivro.Controls.Add(PictureLivro);
            panelLivro.Location = new Point(0, -6);
            panelLivro.Name = "panelLivro";
            panelLivro.Size = new Size(262, 459);
            panelLivro.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(498, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 441);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // labelAcervos
            // 
            labelAcervos.AutoSize = true;
            labelAcervos.Font = new Font("Arial Narrow", 20F);
            labelAcervos.ForeColor = Color.DarkRed;
            labelAcervos.Location = new Point(480, 22);
            labelAcervos.Name = "labelAcervos";
            labelAcervos.Size = new Size(93, 31);
            labelAcervos.TabIndex = 4;
            labelAcervos.Text = "Acervos";
            // 
            // labelIntro
            // 
            labelIntro.AutoSize = true;
            labelIntro.Font = new Font("Arial Narrow", 11F);
            labelIntro.ForeColor = Color.DarkRed;
            labelIntro.Location = new Point(418, 123);
            labelIntro.Name = "labelIntro";
            labelIntro.Size = new Size(188, 20);
            labelIntro.TabIndex = 5;
            labelIntro.Text = "Qual acervo você quer explorar?";
            // 
            // btnLivros
            // 
            btnLivros.BackColor = Color.DarkRed;
            btnLivros.Font = new Font("Segoe UI", 12F);
            btnLivros.ForeColor = Color.FromArgb(250, 243, 224);
            btnLivros.Location = new Point(344, 211);
            btnLivros.Name = "btnLivros";
            btnLivros.Size = new Size(149, 41);
            btnLivros.TabIndex = 6;
            btnLivros.Text = "Livros";
            btnLivros.UseVisualStyleBackColor = false;
            btnLivros.Click += btnLivros_Click;
            // 
            // btnInstrumentos
            // 
            btnInstrumentos.BackColor = Color.DarkRed;
            btnInstrumentos.Font = new Font("Segoe UI", 12F);
            btnInstrumentos.ForeColor = Color.FromArgb(250, 243, 224);
            btnInstrumentos.Location = new Point(547, 211);
            btnInstrumentos.Name = "btnInstrumentos";
            btnInstrumentos.Size = new Size(149, 41);
            btnInstrumentos.TabIndex = 7;
            btnInstrumentos.Text = "Instrumentos";
            btnInstrumentos.UseVisualStyleBackColor = false;
            btnInstrumentos.Click += btnInstrumentos_Click;
            // 
            // btnMidia
            // 
            btnMidia.BackColor = Color.DarkRed;
            btnMidia.Font = new Font("Segoe UI", 12F);
            btnMidia.ForeColor = Color.FromArgb(250, 243, 224);
            btnMidia.Location = new Point(547, 273);
            btnMidia.Name = "btnMidia";
            btnMidia.Size = new Size(149, 41);
            btnMidia.TabIndex = 9;
            btnMidia.Text = "Mídias";
            btnMidia.UseVisualStyleBackColor = false;
            btnMidia.Click += btnMidia_Click;
            // 
            // btnJogos
            // 
            btnJogos.BackColor = Color.DarkRed;
            btnJogos.Font = new Font("Segoe UI", 12F);
            btnJogos.ForeColor = Color.FromArgb(250, 243, 224);
            btnJogos.Location = new Point(344, 273);
            btnJogos.Name = "btnJogos";
            btnJogos.Size = new Size(149, 41);
            btnJogos.TabIndex = 8;
            btnJogos.Text = "Jogos";
            btnJogos.UseVisualStyleBackColor = false;
            btnJogos.Click += btnJogos_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.DarkRed;
            btnVoltar.Font = new Font("Segoe UI", 12F);
            btnVoltar.ForeColor = Color.FromArgb(250, 243, 224);
            btnVoltar.Location = new Point(444, 386);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(149, 41);
            btnVoltar.TabIndex = 10;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // MenuAcervos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(btnMidia);
            Controls.Add(btnJogos);
            Controls.Add(btnInstrumentos);
            Controls.Add(btnLivros);
            Controls.Add(labelIntro);
            Controls.Add(labelAcervos);
            Controls.Add(pictureBox1);
            Controls.Add(panelLivro);
            Name = "MenuAcervos";
            Text = "MenuAcervos";
            ((System.ComponentModel.ISupportInitialize)PictureLivro).EndInit();
            panelLivro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PictureLivro;
        private Panel panelLivro;
        private PictureBox pictureBox1;
        private Label labelAcervos;
        private Label labelIntro;
        private Button btnLivros;
        private Button btnInstrumentos;
        private Button btnMidia;
        private Button btnJogos;
        private Button btnVoltar;
    }
}