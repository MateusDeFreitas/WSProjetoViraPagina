namespace Projeto_ViraPagina.View
{
    partial class VisualizacaoLivroUnicoP4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizacaoLivroUnicoP4));
            panelLivro = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            labelLivroCircular = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            textResumo = new TextBox();
            btnVoltar = new Button();
            labelTitulo = new Label();
            pictureBox2 = new PictureBox();
            btnSair = new Button();
            panelLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            panelLivro.TabIndex = 20;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(3, 282);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(36, 38);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 134;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(3, 239);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(36, 38);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 133;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 196);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(36, 38);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 132;
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
            pictureBox3.TabIndex = 131;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 130;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // labelLivroCircular
            // 
            labelLivroCircular.AutoSize = true;
            labelLivroCircular.Font = new Font("Arial Narrow", 14F);
            labelLivroCircular.ForeColor = Color.DarkRed;
            labelLivroCircular.Location = new Point(68, 71);
            labelLivroCircular.Name = "labelLivroCircular";
            labelLivroCircular.Size = new Size(69, 23);
            labelLivroCircular.TabIndex = 90;
            labelLivroCircular.Text = "Resumo";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(68, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 312);
            panel1.TabIndex = 89;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(250, 243, 224);
            panel2.Controls.Add(textResumo);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(323, 306);
            panel2.TabIndex = 78;
            // 
            // textResumo
            // 
            textResumo.BackColor = Color.FromArgb(250, 243, 224);
            textResumo.BorderStyle = BorderStyle.None;
            textResumo.Font = new Font("Arial Narrow", 12F);
            textResumo.ForeColor = Color.FromArgb(130, 119, 106);
            textResumo.Location = new Point(3, 3);
            textResumo.Multiline = true;
            textResumo.Name = "textResumo";
            textResumo.ReadOnly = true;
            textResumo.ScrollBars = ScrollBars.Vertical;
            textResumo.Size = new Size(317, 300);
            textResumo.TabIndex = 87;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.DarkRed;
            btnVoltar.Font = new Font("Segoe UI", 12F);
            btnVoltar.ForeColor = Color.FromArgb(250, 243, 224);
            btnVoltar.Location = new Point(644, 403);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(128, 35);
            btnVoltar.TabIndex = 129;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Arial Narrow", 20F);
            labelTitulo.ForeColor = Color.DarkRed;
            labelTitulo.Location = new Point(351, 12);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(154, 31);
            labelTitulo.TabIndex = 123;
            labelTitulo.Text = "*Título do livro";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(480, 35);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(321, 403);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 130;
            pictureBox2.TabStop = false;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.DarkRed;
            btnSair.Font = new Font("Segoe UI", 12F);
            btnSair.ForeColor = Color.FromArgb(250, 243, 224);
            btnSair.Location = new Point(480, 403);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(128, 35);
            btnSair.TabIndex = 131;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // VisualizacaoLivroUnicoP4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(btnSair);
            Controls.Add(labelTitulo);
            Controls.Add(btnVoltar);
            Controls.Add(labelLivroCircular);
            Controls.Add(panel1);
            Controls.Add(panelLivro);
            Controls.Add(pictureBox2);
            Name = "VisualizacaoLivroUnicoP4";
            Text = "VisualizacaoLivroUnicoP4";
            Load += VisualizacaoLivroUnicoP4_Load;
            panelLivro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelLivro;
        private Label labelLivroCircular;
        private Panel panel1;
        private Panel panel2;
        private TextBox textResumo;
        private Button btnVoltar;
        private Label labelTitulo;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Button btnSair;
    }
}
