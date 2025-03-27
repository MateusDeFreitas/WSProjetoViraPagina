namespace Projeto_ViraPagina.View
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            panelLivro = new Panel();
            PictureLivro = new PictureBox();
            panelPesquisa = new Panel();
            labelAcervos = new Label();
            labelEmprestimo = new Label();
            labelReservas = new Label();
            labelPenalidades = new Label();
            textPesquisa = new TextBox();
            labelNomeTomador = new Label();
            textNomeTomador = new TextBox();
            panelNome = new Panel();
            labelLivrosEmprestados = new Label();
            textLivrosEmprestados = new TextBox();
            panelLivros = new Panel();
            labelMatricula = new Label();
            labelVinculo = new Label();
            textMatricula = new TextBox();
            panelMatricula = new Panel();
            textVinculo = new TextBox();
            panelVinculo = new Panel();
            labelEmail = new Label();
            textEmail = new TextBox();
            panelEmail = new Panel();
            label1 = new Label();
            textPenalidades = new TextBox();
            panelPenalidades = new Panel();
            labelTelefone = new Label();
            textTelefone = new TextBox();
            panelTelefone = new Panel();
            labelCodigo = new Label();
            textCodigo = new TextBox();
            panelCodigo = new Panel();
            pictureBoxLupa = new PictureBox();
            pictureBoxMenu = new PictureBox();
            panelLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureLivro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLupa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMenu).BeginInit();
            SuspendLayout();
            // 
            // panelLivro
            // 
            panelLivro.BackColor = Color.DarkRed;
            panelLivro.Controls.Add(PictureLivro);
            panelLivro.Location = new Point(0, 0);
            panelLivro.Name = "panelLivro";
            panelLivro.Size = new Size(262, 451);
            panelLivro.TabIndex = 1;
            // 
            // PictureLivro
            // 
            PictureLivro.Image = (Image)resources.GetObject("PictureLivro.Image");
            PictureLivro.InitialImage = null;
            PictureLivro.Location = new Point(12, 104);
            PictureLivro.Name = "PictureLivro";
            PictureLivro.Size = new Size(230, 234);
            PictureLivro.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureLivro.TabIndex = 0;
            PictureLivro.TabStop = false;
            // 
            // panelPesquisa
            // 
            panelPesquisa.BackColor = Color.DarkRed;
            panelPesquisa.Location = new Point(369, 104);
            panelPesquisa.Name = "panelPesquisa";
            panelPesquisa.Size = new Size(318, 4);
            panelPesquisa.TabIndex = 2;
            // 
            // labelAcervos
            // 
            labelAcervos.AutoSize = true;
            labelAcervos.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAcervos.ForeColor = Color.DarkRed;
            labelAcervos.Location = new Point(473, 9);
            labelAcervos.Name = "labelAcervos";
            labelAcervos.Size = new Size(59, 20);
            labelAcervos.TabIndex = 3;
            labelAcervos.Text = "Acervos";
            labelAcervos.Click += labelAcervos_Click;
            // 
            // labelEmprestimo
            // 
            labelEmprestimo.AutoSize = true;
            labelEmprestimo.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmprestimo.ForeColor = Color.DarkRed;
            labelEmprestimo.Location = new Point(538, 9);
            labelEmprestimo.Name = "labelEmprestimo";
            labelEmprestimo.Size = new Size(88, 20);
            labelEmprestimo.TabIndex = 4;
            labelEmprestimo.Text = "Empréstimos";
            labelEmprestimo.Click += labelEmprestimo_Click;
            // 
            // labelReservas
            // 
            labelReservas.AutoSize = true;
            labelReservas.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelReservas.ForeColor = Color.DarkRed;
            labelReservas.Location = new Point(632, 9);
            labelReservas.Name = "labelReservas";
            labelReservas.Size = new Size(66, 20);
            labelReservas.TabIndex = 5;
            labelReservas.Text = "Reservas";
            labelReservas.Click += labelReservas_Click;
            // 
            // labelPenalidades
            // 
            labelPenalidades.AutoSize = true;
            labelPenalidades.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPenalidades.ForeColor = Color.DarkRed;
            labelPenalidades.Location = new Point(704, 9);
            labelPenalidades.Name = "labelPenalidades";
            labelPenalidades.Size = new Size(84, 20);
            labelPenalidades.TabIndex = 6;
            labelPenalidades.Text = "Penalidades";
            labelPenalidades.Click += labelPenalidades_Click;
            // 
            // textPesquisa
            // 
            textPesquisa.BackColor = Color.FromArgb(250, 243, 224);
            textPesquisa.BorderStyle = BorderStyle.None;
            textPesquisa.Font = new Font("Arial Narrow", 12F);
            textPesquisa.ForeColor = Color.FromArgb(130, 119, 106);
            textPesquisa.Location = new Point(369, 79);
            textPesquisa.Name = "textPesquisa";
            textPesquisa.Size = new Size(275, 19);
            textPesquisa.TabIndex = 7;
            // 
            // labelNomeTomador
            // 
            labelNomeTomador.AutoSize = true;
            labelNomeTomador.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNomeTomador.ForeColor = Color.DarkRed;
            labelNomeTomador.Location = new Point(285, 149);
            labelNomeTomador.Name = "labelNomeTomador";
            labelNomeTomador.Size = new Size(118, 20);
            labelNomeTomador.TabIndex = 8;
            labelNomeTomador.Text = "Nome do tomador";
            // 
            // textNomeTomador
            // 
            textNomeTomador.BackColor = Color.FromArgb(250, 243, 224);
            textNomeTomador.BorderStyle = BorderStyle.None;
            textNomeTomador.Font = new Font("Arial Narrow", 12F);
            textNomeTomador.ForeColor = Color.FromArgb(130, 119, 106);
            textNomeTomador.Location = new Point(289, 172);
            textNomeTomador.Name = "textNomeTomador";
            textNomeTomador.Size = new Size(202, 19);
            textNomeTomador.TabIndex = 9;
            // 
            // panelNome
            // 
            panelNome.BackColor = Color.DarkRed;
            panelNome.Location = new Point(285, 197);
            panelNome.Name = "panelNome";
            panelNome.Size = new Size(203, 4);
            panelNome.TabIndex = 10;
            // 
            // labelLivrosEmprestados
            // 
            labelLivrosEmprestados.AutoSize = true;
            labelLivrosEmprestados.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLivrosEmprestados.ForeColor = Color.DarkRed;
            labelLivrosEmprestados.Location = new Point(285, 217);
            labelLivrosEmprestados.Name = "labelLivrosEmprestados";
            labelLivrosEmprestados.Size = new Size(195, 20);
            labelLivrosEmprestados.TabIndex = 11;
            labelLivrosEmprestados.Text = "Número de livros emprestados";
            // 
            // textLivrosEmprestados
            // 
            textLivrosEmprestados.BackColor = Color.FromArgb(250, 243, 224);
            textLivrosEmprestados.BorderStyle = BorderStyle.None;
            textLivrosEmprestados.Font = new Font("Arial Narrow", 12F);
            textLivrosEmprestados.ForeColor = Color.FromArgb(130, 119, 106);
            textLivrosEmprestados.Location = new Point(290, 240);
            textLivrosEmprestados.Name = "textLivrosEmprestados";
            textLivrosEmprestados.Size = new Size(202, 19);
            textLivrosEmprestados.TabIndex = 12;
            // 
            // panelLivros
            // 
            panelLivros.BackColor = Color.DarkRed;
            panelLivros.Location = new Point(286, 265);
            panelLivros.Name = "panelLivros";
            panelLivros.Size = new Size(203, 4);
            panelLivros.TabIndex = 13;
            // 
            // labelMatricula
            // 
            labelMatricula.AutoSize = true;
            labelMatricula.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMatricula.ForeColor = Color.DarkRed;
            labelMatricula.Location = new Point(286, 289);
            labelMatricula.Name = "labelMatricula";
            labelMatricula.Size = new Size(137, 20);
            labelMatricula.TabIndex = 14;
            labelMatricula.Text = "Validade da matrícula";
            // 
            // labelVinculo
            // 
            labelVinculo.AutoSize = true;
            labelVinculo.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelVinculo.ForeColor = Color.DarkRed;
            labelVinculo.Location = new Point(285, 359);
            labelVinculo.Name = "labelVinculo";
            labelVinculo.Size = new Size(53, 20);
            labelVinculo.TabIndex = 15;
            labelVinculo.Text = "Vínculo";
            // 
            // textMatricula
            // 
            textMatricula.BackColor = Color.FromArgb(250, 243, 224);
            textMatricula.BorderStyle = BorderStyle.None;
            textMatricula.Font = new Font("Arial Narrow", 12F);
            textMatricula.ForeColor = Color.FromArgb(130, 119, 106);
            textMatricula.Location = new Point(290, 312);
            textMatricula.Name = "textMatricula";
            textMatricula.Size = new Size(202, 19);
            textMatricula.TabIndex = 16;
            // 
            // panelMatricula
            // 
            panelMatricula.BackColor = Color.DarkRed;
            panelMatricula.Location = new Point(285, 337);
            panelMatricula.Name = "panelMatricula";
            panelMatricula.Size = new Size(203, 4);
            panelMatricula.TabIndex = 17;
            // 
            // textVinculo
            // 
            textVinculo.BackColor = Color.FromArgb(250, 243, 224);
            textVinculo.BorderStyle = BorderStyle.None;
            textVinculo.Font = new Font("Arial Narrow", 12F);
            textVinculo.ForeColor = Color.FromArgb(130, 119, 106);
            textVinculo.Location = new Point(289, 382);
            textVinculo.Name = "textVinculo";
            textVinculo.Size = new Size(202, 19);
            textVinculo.TabIndex = 18;
            // 
            // panelVinculo
            // 
            panelVinculo.BackColor = Color.DarkRed;
            panelVinculo.Location = new Point(286, 407);
            panelVinculo.Name = "panelVinculo";
            panelVinculo.Size = new Size(203, 4);
            panelVinculo.TabIndex = 19;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.ForeColor = Color.DarkRed;
            labelEmail.Location = new Point(559, 149);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(42, 20);
            labelEmail.TabIndex = 20;
            labelEmail.Text = "Email";
            // 
            // textEmail
            // 
            textEmail.BackColor = Color.FromArgb(250, 243, 224);
            textEmail.BorderStyle = BorderStyle.None;
            textEmail.Font = new Font("Arial Narrow", 12F);
            textEmail.ForeColor = Color.FromArgb(130, 119, 106);
            textEmail.Location = new Point(563, 172);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(202, 19);
            textEmail.TabIndex = 21;
            // 
            // panelEmail
            // 
            panelEmail.BackColor = Color.DarkRed;
            panelEmail.Location = new Point(560, 197);
            panelEmail.Name = "panelEmail";
            panelEmail.Size = new Size(203, 4);
            panelEmail.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(559, 217);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 23;
            label1.Text = "Número de penalidades";
            // 
            // textPenalidades
            // 
            textPenalidades.BackColor = Color.FromArgb(250, 243, 224);
            textPenalidades.BorderStyle = BorderStyle.None;
            textPenalidades.Font = new Font("Arial Narrow", 12F);
            textPenalidades.ForeColor = Color.FromArgb(130, 119, 106);
            textPenalidades.Location = new Point(564, 240);
            textPenalidades.Name = "textPenalidades";
            textPenalidades.Size = new Size(153, 19);
            textPenalidades.TabIndex = 24;
            // 
            // panelPenalidades
            // 
            panelPenalidades.BackColor = Color.DarkRed;
            panelPenalidades.Location = new Point(560, 265);
            panelPenalidades.Name = "panelPenalidades";
            panelPenalidades.Size = new Size(155, 4);
            panelPenalidades.TabIndex = 25;
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTelefone.ForeColor = Color.DarkRed;
            labelTelefone.Location = new Point(559, 289);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(128, 20);
            labelTelefone.TabIndex = 26;
            labelTelefone.Text = "Número de telefone";
            // 
            // textTelefone
            // 
            textTelefone.BackColor = Color.FromArgb(250, 243, 224);
            textTelefone.BorderStyle = BorderStyle.None;
            textTelefone.Font = new Font("Arial Narrow", 12F);
            textTelefone.ForeColor = Color.FromArgb(130, 119, 106);
            textTelefone.Location = new Point(563, 312);
            textTelefone.Name = "textTelefone";
            textTelefone.Size = new Size(202, 19);
            textTelefone.TabIndex = 27;
            // 
            // panelTelefone
            // 
            panelTelefone.BackColor = Color.DarkRed;
            panelTelefone.Location = new Point(560, 337);
            panelTelefone.Name = "panelTelefone";
            panelTelefone.Size = new Size(203, 4);
            panelTelefone.TabIndex = 28;
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCodigo.ForeColor = Color.DarkRed;
            labelCodigo.Location = new Point(559, 359);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(106, 20);
            labelCodigo.TabIndex = 29;
            labelCodigo.Text = "Código tomador";
            // 
            // textCodigo
            // 
            textCodigo.BackColor = Color.FromArgb(250, 243, 224);
            textCodigo.BorderStyle = BorderStyle.None;
            textCodigo.Font = new Font("Arial Narrow", 12F);
            textCodigo.ForeColor = Color.FromArgb(130, 119, 106);
            textCodigo.Location = new Point(563, 382);
            textCodigo.Name = "textCodigo";
            textCodigo.Size = new Size(202, 19);
            textCodigo.TabIndex = 30;
            // 
            // panelCodigo
            // 
            panelCodigo.BackColor = Color.DarkRed;
            panelCodigo.Location = new Point(560, 407);
            panelCodigo.Name = "panelCodigo";
            panelCodigo.Size = new Size(203, 4);
            panelCodigo.TabIndex = 31;
            // 
            // pictureBoxLupa
            // 
            pictureBoxLupa.Image = (Image)resources.GetObject("pictureBoxLupa.Image");
            pictureBoxLupa.Location = new Point(650, 71);
            pictureBoxLupa.Name = "pictureBoxLupa";
            pictureBoxLupa.Size = new Size(27, 27);
            pictureBoxLupa.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxLupa.TabIndex = 32;
            pictureBoxLupa.TabStop = false;
            pictureBoxLupa.Click += pictureBoxLupa_Click;
            // 
            // pictureBoxMenu
            // 
            pictureBoxMenu.Image = (Image)resources.GetObject("pictureBoxMenu.Image");
            pictureBoxMenu.Location = new Point(735, 240);
            pictureBoxMenu.Name = "pictureBoxMenu";
            pictureBoxMenu.Size = new Size(26, 26);
            pictureBoxMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMenu.TabIndex = 33;
            pictureBoxMenu.TabStop = false;
            pictureBoxMenu.Click += pictureBoxMenu_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxMenu);
            Controls.Add(pictureBoxLupa);
            Controls.Add(panelCodigo);
            Controls.Add(textCodigo);
            Controls.Add(labelCodigo);
            Controls.Add(panelTelefone);
            Controls.Add(textTelefone);
            Controls.Add(labelTelefone);
            Controls.Add(panelPenalidades);
            Controls.Add(textPenalidades);
            Controls.Add(label1);
            Controls.Add(panelEmail);
            Controls.Add(textEmail);
            Controls.Add(labelEmail);
            Controls.Add(panelVinculo);
            Controls.Add(textVinculo);
            Controls.Add(panelMatricula);
            Controls.Add(textMatricula);
            Controls.Add(labelVinculo);
            Controls.Add(labelMatricula);
            Controls.Add(panelLivros);
            Controls.Add(textLivrosEmprestados);
            Controls.Add(labelLivrosEmprestados);
            Controls.Add(panelNome);
            Controls.Add(textNomeTomador);
            Controls.Add(labelNomeTomador);
            Controls.Add(textPesquisa);
            Controls.Add(labelPenalidades);
            Controls.Add(labelReservas);
            Controls.Add(labelEmprestimo);
            Controls.Add(labelAcervos);
            Controls.Add(panelPesquisa);
            Controls.Add(panelLivro);
            Name = "Principal";
            Text = "Principal";
            panelLivro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureLivro).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLupa).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelLivro;
        private PictureBox PictureLivro;
        private Panel panelPesquisa;
        private Label labelAcervos;
        private Label labelEmprestimo;
        private Label labelReservas;
        private Label labelPenalidades;
        private TextBox textPesquisa;
        private Label labelNomeTomador;
        private TextBox textNomeTomador;
        private Panel panelNome;
        private Label labelLivrosEmprestados;
        private TextBox textLivrosEmprestados;
        private Panel panelLivros;
        private Label labelMatricula;
        private Label labelVinculo;
        private TextBox textMatricula;
        private Panel panelMatricula;
        private TextBox textVinculo;
        private Panel panelVinculo;
        private Label labelEmail;
        private TextBox textEmail;
        private Panel panelEmail;
        private Label label1;
        private TextBox textPenalidades;
        private Panel panelPenalidades;
        private Label labelTelefone;
        private TextBox textTelefone;
        private Panel panelTelefone;
        private Label labelCodigo;
        private TextBox textCodigo;
        private Panel panelCodigo;
        private PictureBox pictureBoxLupa;
        private PictureBox pictureBoxMenu;
    }
}