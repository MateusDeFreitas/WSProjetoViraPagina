namespace Projeto_ViraPagina.View
{
    partial class CadastroMidia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroMidia));
            panelLivro = new Panel();
            pictureBox1 = new PictureBox();
            labelCadastroMidia = new Label();
            btnCadastrar = new Button();
            btnCancelar = new Button();
            panel7 = new Panel();
            textGeneroMidia = new TextBox();
            labelGeneroMidia = new Label();
            panel1 = new Panel();
            textTipoMidia = new TextBox();
            labelTipo = new Label();
            panel2 = new Panel();
            textProdutora = new TextBox();
            labelProdutora = new Label();
            panel6 = new Panel();
            textAnoLancamento = new TextBox();
            labelAnoLancamento = new Label();
            panel3 = new Panel();
            textDiretor = new TextBox();
            labelDiretor = new Label();
            panel4 = new Panel();
            textTitulo = new TextBox();
            labelTitulo = new Label();
            panelLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelLivro
            // 
            panelLivro.BackColor = Color.DarkRed;
            panelLivro.Controls.Add(pictureBox1);
            panelLivro.Location = new Point(0, 0);
            panelLivro.Name = "panelLivro";
            panelLivro.Size = new Size(42, 472);
            panelLivro.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // labelCadastroMidia
            // 
            labelCadastroMidia.AutoSize = true;
            labelCadastroMidia.Font = new Font("Arial Narrow", 20F);
            labelCadastroMidia.ForeColor = Color.DarkRed;
            labelCadastroMidia.Location = new Point(306, 18);
            labelCadastroMidia.Name = "labelCadastroMidia";
            labelCadastroMidia.Size = new Size(191, 31);
            labelCadastroMidia.TabIndex = 110;
            labelCadastroMidia.Text = "Cadastro de mídia";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.DarkRed;
            btnCadastrar.Font = new Font("Segoe UI", 12F);
            btnCadastrar.ForeColor = Color.FromArgb(250, 243, 224);
            btnCadastrar.Location = new Point(407, 403);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(128, 35);
            btnCadastrar.TabIndex = 179;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkRed;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.ForeColor = Color.FromArgb(250, 243, 224);
            btnCancelar.Location = new Point(264, 403);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(128, 35);
            btnCancelar.TabIndex = 178;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.DarkRed;
            panel7.Location = new Point(84, 324);
            panel7.Name = "panel7";
            panel7.Size = new Size(270, 4);
            panel7.TabIndex = 177;
            // 
            // textGeneroMidia
            // 
            textGeneroMidia.BackColor = Color.FromArgb(250, 243, 224);
            textGeneroMidia.BorderStyle = BorderStyle.None;
            textGeneroMidia.Font = new Font("Arial Narrow", 12F);
            textGeneroMidia.ForeColor = Color.FromArgb(130, 119, 106);
            textGeneroMidia.Location = new Point(85, 299);
            textGeneroMidia.Name = "textGeneroMidia";
            textGeneroMidia.Size = new Size(257, 19);
            textGeneroMidia.TabIndex = 176;
            // 
            // labelGeneroMidia
            // 
            labelGeneroMidia.AutoSize = true;
            labelGeneroMidia.Font = new Font("Arial Narrow", 14F);
            labelGeneroMidia.ForeColor = Color.DarkRed;
            labelGeneroMidia.Location = new Point(84, 258);
            labelGeneroMidia.Name = "labelGeneroMidia";
            labelGeneroMidia.Size = new Size(63, 23);
            labelGeneroMidia.TabIndex = 175;
            labelGeneroMidia.Text = "Gênero";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Location = new Point(456, 324);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 4);
            panel1.TabIndex = 174;
            // 
            // textTipoMidia
            // 
            textTipoMidia.BackColor = Color.FromArgb(250, 243, 224);
            textTipoMidia.BorderStyle = BorderStyle.None;
            textTipoMidia.Font = new Font("Arial Narrow", 12F);
            textTipoMidia.ForeColor = Color.FromArgb(130, 119, 106);
            textTipoMidia.Location = new Point(460, 299);
            textTipoMidia.Name = "textTipoMidia";
            textTipoMidia.Size = new Size(257, 19);
            textTipoMidia.TabIndex = 173;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Font = new Font("Arial Narrow", 14F);
            labelTipo.ForeColor = Color.DarkRed;
            labelTipo.Location = new Point(456, 258);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(103, 23);
            labelTipo.TabIndex = 172;
            labelTipo.Text = "Tipo de mídia";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkRed;
            panel2.Location = new Point(457, 240);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 4);
            panel2.TabIndex = 171;
            // 
            // textProdutora
            // 
            textProdutora.BackColor = Color.FromArgb(250, 243, 224);
            textProdutora.BorderStyle = BorderStyle.None;
            textProdutora.Font = new Font("Arial Narrow", 12F);
            textProdutora.ForeColor = Color.FromArgb(130, 119, 106);
            textProdutora.Location = new Point(461, 215);
            textProdutora.Name = "textProdutora";
            textProdutora.Size = new Size(257, 19);
            textProdutora.TabIndex = 170;
            // 
            // labelProdutora
            // 
            labelProdutora.AutoSize = true;
            labelProdutora.Font = new Font("Arial Narrow", 14F);
            labelProdutora.ForeColor = Color.DarkRed;
            labelProdutora.Location = new Point(456, 174);
            labelProdutora.Name = "labelProdutora";
            labelProdutora.Size = new Size(78, 23);
            labelProdutora.TabIndex = 169;
            labelProdutora.Text = "Produtora";
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkRed;
            panel6.Location = new Point(456, 153);
            panel6.Name = "panel6";
            panel6.Size = new Size(270, 4);
            panel6.TabIndex = 168;
            // 
            // textAnoLancamento
            // 
            textAnoLancamento.BackColor = Color.FromArgb(250, 243, 224);
            textAnoLancamento.BorderStyle = BorderStyle.None;
            textAnoLancamento.Font = new Font("Arial Narrow", 12F);
            textAnoLancamento.ForeColor = Color.FromArgb(130, 119, 106);
            textAnoLancamento.Location = new Point(460, 128);
            textAnoLancamento.Name = "textAnoLancamento";
            textAnoLancamento.Size = new Size(257, 19);
            textAnoLancamento.TabIndex = 167;
            // 
            // labelAnoLancamento
            // 
            labelAnoLancamento.AutoSize = true;
            labelAnoLancamento.Font = new Font("Arial Narrow", 14F);
            labelAnoLancamento.ForeColor = Color.DarkRed;
            labelAnoLancamento.Location = new Point(456, 87);
            labelAnoLancamento.Name = "labelAnoLancamento";
            labelAnoLancamento.Size = new Size(145, 23);
            labelAnoLancamento.TabIndex = 166;
            labelAnoLancamento.Text = "Ano de lançamento";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkRed;
            panel3.Location = new Point(84, 240);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 4);
            panel3.TabIndex = 165;
            // 
            // textDiretor
            // 
            textDiretor.BackColor = Color.FromArgb(250, 243, 224);
            textDiretor.BorderStyle = BorderStyle.None;
            textDiretor.Font = new Font("Arial Narrow", 12F);
            textDiretor.ForeColor = Color.FromArgb(130, 119, 106);
            textDiretor.Location = new Point(85, 215);
            textDiretor.Name = "textDiretor";
            textDiretor.Size = new Size(257, 19);
            textDiretor.TabIndex = 164;
            // 
            // labelDiretor
            // 
            labelDiretor.AutoSize = true;
            labelDiretor.Font = new Font("Arial Narrow", 14F);
            labelDiretor.ForeColor = Color.DarkRed;
            labelDiretor.Location = new Point(85, 174);
            labelDiretor.Name = "labelDiretor";
            labelDiretor.Size = new Size(55, 23);
            labelDiretor.TabIndex = 163;
            labelDiretor.Text = "Diretor";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkRed;
            panel4.Location = new Point(84, 153);
            panel4.Name = "panel4";
            panel4.Size = new Size(270, 4);
            panel4.TabIndex = 162;
            // 
            // textTitulo
            // 
            textTitulo.BackColor = Color.FromArgb(250, 243, 224);
            textTitulo.BorderStyle = BorderStyle.None;
            textTitulo.Font = new Font("Arial Narrow", 12F);
            textTitulo.ForeColor = Color.FromArgb(130, 119, 106);
            textTitulo.Location = new Point(85, 128);
            textTitulo.Name = "textTitulo";
            textTitulo.Size = new Size(257, 19);
            textTitulo.TabIndex = 161;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Arial Narrow", 14F);
            labelTitulo.ForeColor = Color.DarkRed;
            labelTitulo.Location = new Point(84, 87);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(46, 23);
            labelTitulo.TabIndex = 160;
            labelTitulo.Text = "Título";
            // 
            // CadastroMidia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 224);
            ClientSize = new Size(764, 450);
            Controls.Add(btnCadastrar);
            Controls.Add(btnCancelar);
            Controls.Add(panel7);
            Controls.Add(textGeneroMidia);
            Controls.Add(labelGeneroMidia);
            Controls.Add(panel1);
            Controls.Add(textTipoMidia);
            Controls.Add(labelTipo);
            Controls.Add(panel2);
            Controls.Add(textProdutora);
            Controls.Add(labelProdutora);
            Controls.Add(panel6);
            Controls.Add(textAnoLancamento);
            Controls.Add(labelAnoLancamento);
            Controls.Add(panel3);
            Controls.Add(textDiretor);
            Controls.Add(labelDiretor);
            Controls.Add(panel4);
            Controls.Add(textTitulo);
            Controls.Add(labelTitulo);
            Controls.Add(labelCadastroMidia);
            Controls.Add(panelLivro);
            Name = "CadastroMidia";
            Text = "CadastroMidia";
            panelLivro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelLivro;
        private Label labelCadastroMidia;
        private Button btnCadastrar;
        private Button btnCancelar;
        private Panel panel7;
        private TextBox textGeneroMidia;
        private Label labelGeneroMidia;
        private Panel panel1;
        private TextBox textTipoMidia;
        private Label labelTipo;
        private Panel panel2;
        private TextBox textProdutora;
        private Label labelProdutora;
        private Panel panel6;
        private TextBox textAnoLancamento;
        private Label labelAnoLancamento;
        private Panel panel3;
        private TextBox textDiretor;
        private Label labelDiretor;
        private Panel panel4;
        private TextBox textTitulo;
        private Label labelTitulo;
        private PictureBox pictureBox1;
    }
}