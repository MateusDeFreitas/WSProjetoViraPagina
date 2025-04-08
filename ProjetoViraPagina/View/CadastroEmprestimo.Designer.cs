namespace Projeto_ViraPagina.View
{
    partial class CadastroEmprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroEmprestimo));
            panel5 = new Panel();
            textAcervo = new TextBox();
            labelTituloPrincipal = new Label();
            label5 = new Label();
            panelLivro = new Panel();
            pictureBox1 = new PictureBox();
            panelNome = new Panel();
            textUsuario = new TextBox();
            labelTitulo = new Label();
            btnCadastrar = new Button();
            btnCancelar = new Button();
            pictureBox2 = new PictureBox();
            panelLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkRed;
            panel5.Location = new Point(455, 241);
            panel5.Name = "panel5";
            panel5.Size = new Size(270, 4);
            panel5.TabIndex = 73;
            // 
            // textAcervo
            // 
            textAcervo.BackColor = Color.FromArgb(250, 243, 224);
            textAcervo.BorderStyle = BorderStyle.None;
            textAcervo.Font = new Font("Arial Narrow", 12F);
            textAcervo.ForeColor = Color.FromArgb(130, 119, 106);
            textAcervo.Location = new Point(459, 216);
            textAcervo.Name = "textAcervo";
            textAcervo.Size = new Size(257, 19);
            textAcervo.TabIndex = 72;
            // 
            // labelTituloPrincipal
            // 
            labelTituloPrincipal.AutoSize = true;
            labelTituloPrincipal.Font = new Font("Arial Narrow", 20F);
            labelTituloPrincipal.ForeColor = Color.DarkRed;
            labelTituloPrincipal.Location = new Point(292, 19);
            labelTituloPrincipal.Name = "labelTituloPrincipal";
            labelTituloPrincipal.Size = new Size(239, 31);
            labelTituloPrincipal.TabIndex = 70;
            labelTituloPrincipal.Text = "Cadastrar empréstimos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 14F);
            label5.ForeColor = Color.DarkRed;
            label5.Location = new Point(455, 175);
            label5.Name = "label5";
            label5.Size = new Size(111, 23);
            label5.TabIndex = 71;
            label5.Text = "Código acervo";
            // 
            // panelLivro
            // 
            panelLivro.BackColor = Color.DarkRed;
            panelLivro.Controls.Add(pictureBox1);
            panelLivro.Location = new Point(0, 0);
            panelLivro.Name = "panelLivro";
            panelLivro.Size = new Size(42, 468);
            panelLivro.TabIndex = 69;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 76;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelNome
            // 
            panelNome.BackColor = Color.DarkRed;
            panelNome.Location = new Point(106, 241);
            panelNome.Name = "panelNome";
            panelNome.Size = new Size(270, 4);
            panelNome.TabIndex = 68;
            // 
            // textUsuario
            // 
            textUsuario.BackColor = Color.FromArgb(250, 243, 224);
            textUsuario.BorderStyle = BorderStyle.None;
            textUsuario.Font = new Font("Arial Narrow", 12F);
            textUsuario.ForeColor = Color.FromArgb(130, 119, 106);
            textUsuario.Location = new Point(110, 216);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(257, 19);
            textUsuario.TabIndex = 67;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Arial Narrow", 14F);
            labelTitulo.ForeColor = Color.DarkRed;
            labelTitulo.Location = new Point(106, 175);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(121, 23);
            labelTitulo.TabIndex = 66;
            labelTitulo.Text = "Código tomador";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.DarkRed;
            btnCadastrar.Font = new Font("Segoe UI", 12F);
            btnCadastrar.ForeColor = Color.FromArgb(250, 243, 224);
            btnCadastrar.Location = new Point(411, 391);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(128, 35);
            btnCadastrar.TabIndex = 75;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkRed;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.ForeColor = Color.FromArgb(250, 243, 224);
            btnCancelar.Location = new Point(268, 391);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(128, 35);
            btnCancelar.TabIndex = 74;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(460, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(340, 422);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 77;
            pictureBox2.TabStop = false;
            // 
            // CadastroEmprestimo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrar);
            Controls.Add(btnCancelar);
            Controls.Add(panel5);
            Controls.Add(textAcervo);
            Controls.Add(labelTituloPrincipal);
            Controls.Add(label5);
            Controls.Add(panelLivro);
            Controls.Add(panelNome);
            Controls.Add(textUsuario);
            Controls.Add(labelTitulo);
            Controls.Add(pictureBox2);
            Name = "CadastroEmprestimo";
            Text = "CadastroEmprestimo";
            panelLivro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel5;
        private TextBox textAcervo;
        private Label labelTituloPrincipal;
        private Label label5;
        private Panel panelLivro;
        private Panel panelNome;
        private TextBox textUsuario;
        private Label labelTitulo;
        private Button btnCadastrar;
        private Button btnCancelar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}