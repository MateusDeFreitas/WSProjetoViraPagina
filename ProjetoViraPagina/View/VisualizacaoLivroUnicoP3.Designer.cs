namespace Projeto_ViraPagina.View
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
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            labelTitulo = new Label();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelLivro
            // 
            panelLivro.BackColor = Color.DarkRed;
            panelLivro.Controls.Add(pictureBox6);
            panelLivro.Controls.Add(pictureBox5);
            panelLivro.Controls.Add(pictureBox4);
            panelLivro.Controls.Add(pictureBox3);
            panelLivro.Controls.Add(pictureBox1);
            panelLivro.Location = new Point(0, 0);
            panelLivro.Name = "panelLivro";
            panelLivro.Size = new Size(42, 472);
            panelLivro.TabIndex = 19;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(3, 282);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(36, 38);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 132;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(3, 239);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(36, 38);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 131;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 196);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(36, 38);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 130;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 152);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 129;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
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
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Arial Narrow", 20F);
            labelTitulo.ForeColor = Color.DarkRed;
            labelTitulo.Location = new Point(333, 13);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(154, 31);
            labelTitulo.TabIndex = 122;
            labelTitulo.Text = "*Título do livro";
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
            panel3.Location = new Point(66, 339);
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
            textIdioma.Location = new Point(70, 314);
            textIdioma.Name = "textIdioma";
            textIdioma.ReadOnly = true;
            textIdioma.Size = new Size(257, 19);
            textIdioma.TabIndex = 136;
            // 
            // labelIdioma
            // 
            labelIdioma.AutoSize = true;
            labelIdioma.Font = new Font("Arial Narrow", 14F);
            labelIdioma.ForeColor = Color.DarkRed;
            labelIdioma.Location = new Point(66, 273);
            labelIdioma.Name = "labelIdioma";
            labelIdioma.Size = new Size(56, 23);
            labelIdioma.TabIndex = 135;
            labelIdioma.Text = "Idioma";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkRed;
            panel4.Location = new Point(67, 255);
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
            textClasse.Location = new Point(71, 230);
            textClasse.Name = "textClasse";
            textClasse.ReadOnly = true;
            textClasse.Size = new Size(257, 19);
            textClasse.TabIndex = 133;
            // 
            // labelClasse
            // 
            labelClasse.AutoSize = true;
            labelClasse.Font = new Font("Arial Narrow", 14F);
            labelClasse.ForeColor = Color.DarkRed;
            labelClasse.Location = new Point(66, 189);
            labelClasse.Name = "labelClasse";
            labelClasse.Size = new Size(58, 23);
            labelClasse.TabIndex = 132;
            labelClasse.Text = "Classe";
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkRed;
            panel5.Location = new Point(66, 168);
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
            textAnoLancamento.Location = new Point(70, 143);
            textAnoLancamento.Name = "textAnoLancamento";
            textAnoLancamento.ReadOnly = true;
            textAnoLancamento.Size = new Size(257, 19);
            textAnoLancamento.TabIndex = 130;
            // 
            // labelAnoLancamento
            // 
            labelAnoLancamento.AutoSize = true;
            labelAnoLancamento.Font = new Font("Arial Narrow", 14F);
            labelAnoLancamento.ForeColor = Color.DarkRed;
            labelAnoLancamento.Location = new Point(66, 102);
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
            Controls.Add(labelTitulo);
            Controls.Add(panelLivro);
            Controls.Add(pictureBox2);
            Name = "VisualizacaoLivroUnicoP3";
            Text = "VisualizacaoLivroUnicoP3";
            Load += VisualizacaoLivroUnicoP3_Load;
            panelLivro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelLivro;
        private Label labelTitulo;
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
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
    }
}
