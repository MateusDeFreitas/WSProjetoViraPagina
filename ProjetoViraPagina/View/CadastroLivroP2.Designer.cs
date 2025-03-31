namespace Projeto_ViraPagina.View
{
    partial class CadastroLivroP2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroLivroP2));
            pictureBox1 = new PictureBox();
            panelLivro = new Panel();
            btnCadastrar = new Button();
            btnVoltar = new Button();
            panel3 = new Panel();
            textIdioma = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            textCircular = new TextBox();
            labelCircular = new Label();
            panel5 = new Panel();
            textClasse = new TextBox();
            labelClasse = new Label();
            labelTituloPrincipal = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            textResumo = new TextBox();
            label1 = new Label();
            buttonCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelLivro.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelLivro
            // 
            panelLivro.BackColor = Color.DarkRed;
            panelLivro.Controls.Add(pictureBox1);
            panelLivro.Location = new Point(0, 0);
            panelLivro.Name = "panelLivro";
            panelLivro.Size = new Size(42, 468);
            panelLivro.TabIndex = 59;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.DarkRed;
            btnCadastrar.Font = new Font("Segoe UI", 12F);
            btnCadastrar.ForeColor = Color.FromArgb(250, 243, 224);
            btnCadastrar.Location = new Point(607, 393);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(128, 35);
            btnCadastrar.TabIndex = 84;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.DarkRed;
            btnVoltar.Font = new Font("Segoe UI", 12F);
            btnVoltar.ForeColor = Color.FromArgb(250, 243, 224);
            btnVoltar.Location = new Point(464, 393);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(128, 35);
            btnVoltar.TabIndex = 83;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkRed;
            panel3.Location = new Point(464, 331);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 4);
            panel3.TabIndex = 82;
            // 
            // textIdioma
            // 
            textIdioma.BackColor = Color.FromArgb(250, 243, 224);
            textIdioma.BorderStyle = BorderStyle.None;
            textIdioma.Font = new Font("Arial Narrow", 12F);
            textIdioma.ForeColor = Color.FromArgb(130, 119, 106);
            textIdioma.Location = new Point(468, 306);
            textIdioma.Name = "textIdioma";
            textIdioma.Size = new Size(257, 19);
            textIdioma.TabIndex = 81;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 14F);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(464, 265);
            label3.Name = "label3";
            label3.Size = new Size(56, 23);
            label3.TabIndex = 80;
            label3.Text = "Idioma";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkRed;
            panel4.Location = new Point(465, 247);
            panel4.Name = "panel4";
            panel4.Size = new Size(270, 4);
            panel4.TabIndex = 79;
            // 
            // textCircular
            // 
            textCircular.BackColor = Color.FromArgb(250, 243, 224);
            textCircular.BorderStyle = BorderStyle.None;
            textCircular.Font = new Font("Arial Narrow", 12F);
            textCircular.ForeColor = Color.FromArgb(130, 119, 106);
            textCircular.Location = new Point(469, 222);
            textCircular.Name = "textCircular";
            textCircular.Size = new Size(257, 19);
            textCircular.TabIndex = 78;
            // 
            // labelCircular
            // 
            labelCircular.AutoSize = true;
            labelCircular.Font = new Font("Arial Narrow", 14F);
            labelCircular.ForeColor = Color.DarkRed;
            labelCircular.Location = new Point(464, 181);
            labelCircular.Name = "labelCircular";
            labelCircular.Size = new Size(106, 23);
            labelCircular.TabIndex = 77;
            labelCircular.Text = "Livro circular?";
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkRed;
            panel5.Location = new Point(464, 160);
            panel5.Name = "panel5";
            panel5.Size = new Size(270, 4);
            panel5.TabIndex = 76;
            // 
            // textClasse
            // 
            textClasse.BackColor = Color.FromArgb(250, 243, 224);
            textClasse.BorderStyle = BorderStyle.None;
            textClasse.Font = new Font("Arial Narrow", 12F);
            textClasse.ForeColor = Color.FromArgb(130, 119, 106);
            textClasse.Location = new Point(468, 135);
            textClasse.Name = "textClasse";
            textClasse.Size = new Size(257, 19);
            textClasse.TabIndex = 75;
            // 
            // labelClasse
            // 
            labelClasse.AutoSize = true;
            labelClasse.Font = new Font("Arial Narrow", 14F);
            labelClasse.ForeColor = Color.DarkRed;
            labelClasse.Location = new Point(464, 94);
            labelClasse.Name = "labelClasse";
            labelClasse.Size = new Size(58, 23);
            labelClasse.TabIndex = 74;
            labelClasse.Text = "Classe";
            // 
            // labelTituloPrincipal
            // 
            labelTituloPrincipal.AutoSize = true;
            labelTituloPrincipal.Font = new Font("Arial Narrow", 20F);
            labelTituloPrincipal.ForeColor = Color.DarkRed;
            labelTituloPrincipal.Location = new Point(250, 19);
            labelTituloPrincipal.Name = "labelTituloPrincipal";
            labelTituloPrincipal.Size = new Size(309, 31);
            labelTituloPrincipal.TabIndex = 85;
            labelTituloPrincipal.Text = "Cadastro de material impresso";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(73, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 251);
            panel1.TabIndex = 77;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(250, 243, 224);
            panel2.Controls.Add(textResumo);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(314, 245);
            panel2.TabIndex = 78;
            // 
            // textResumo
            // 
            textResumo.BackColor = Color.FromArgb(250, 243, 224);
            textResumo.BorderStyle = BorderStyle.None;
            textResumo.Font = new Font("Arial Narrow", 12F);
            textResumo.ForeColor = Color.FromArgb(130, 119, 106);
            textResumo.Location = new Point(3, 6);
            textResumo.Multiline = true;
            textResumo.Name = "textResumo";
            textResumo.ScrollBars = ScrollBars.Vertical;
            textResumo.Size = new Size(308, 234);
            textResumo.TabIndex = 87;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14F);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(73, 94);
            label1.Name = "label1";
            label1.Size = new Size(69, 23);
            label1.TabIndex = 86;
            label1.Text = "Resumo";
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.DarkRed;
            buttonCancelar.Font = new Font("Segoe UI", 12F);
            buttonCancelar.ForeColor = Color.FromArgb(250, 243, 224);
            buttonCancelar.Location = new Point(321, 393);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(128, 35);
            buttonCancelar.TabIndex = 87;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // CadastroLivroP2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCancelar);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(labelTituloPrincipal);
            Controls.Add(btnCadastrar);
            Controls.Add(btnVoltar);
            Controls.Add(panel3);
            Controls.Add(textIdioma);
            Controls.Add(label3);
            Controls.Add(panel4);
            Controls.Add(textCircular);
            Controls.Add(labelCircular);
            Controls.Add(panel5);
            Controls.Add(textClasse);
            Controls.Add(labelClasse);
            Controls.Add(panelLivro);
            Name = "CadastroLivroP2";
            Text = "CadastroLivroP2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelLivro.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panelLivro;
        private Button btnCadastrar;
        private Button btnVoltar;
        private Panel panel3;
        private TextBox textIdioma;
        private Label label3;
        private Panel panel4;
        private TextBox textCircular;
        private Label labelCircular;
        private Panel panel5;
        private TextBox textClasse;
        private Label labelClasse;
        private Label labelTituloPrincipal;
        private Panel panel1;
        private Panel panel2;
        private TextBox textResumo;
        private Label label1;
        private Button buttonCancelar;
    }
}