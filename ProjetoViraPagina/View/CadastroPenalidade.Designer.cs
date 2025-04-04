namespace Projeto_ViraPagina.View
{
    partial class CadastroPenalidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroPenalidade));
            btnCadastrar = new Button();
            btnCancelar = new Button();
            labelTituloPrincipal = new Label();
            panelLivro = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            textIdioma = new TextBox();
            labelMarca = new Label();
            panel4 = new Panel();
            textNome = new TextBox();
            labelNome = new Label();
            panel5 = new Panel();
            textIdJogo = new TextBox();
            labelIdJogo = new Label();
            pictureBox2 = new PictureBox();
            panelLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.DarkRed;
            btnCadastrar.Font = new Font("Segoe UI", 12F);
            btnCadastrar.ForeColor = Color.FromArgb(250, 243, 224);
            btnCadastrar.Location = new Point(412, 382);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(128, 35);
            btnCadastrar.TabIndex = 160;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkRed;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.ForeColor = Color.FromArgb(250, 243, 224);
            btnCancelar.Location = new Point(269, 382);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(128, 35);
            btnCancelar.TabIndex = 159;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // labelTituloPrincipal
            // 
            labelTituloPrincipal.AutoSize = true;
            labelTituloPrincipal.Font = new Font("Arial Narrow", 20F);
            labelTituloPrincipal.ForeColor = Color.DarkRed;
            labelTituloPrincipal.Location = new Point(293, 10);
            labelTituloPrincipal.Name = "labelTituloPrincipal";
            labelTituloPrincipal.Size = new Size(221, 31);
            labelTituloPrincipal.TabIndex = 155;
            labelTituloPrincipal.Text = "Cadastrar penalidade";
            // 
            // panelLivro
            // 
            panelLivro.BackColor = Color.DarkRed;
            panelLivro.Controls.Add(pictureBox1);
            panelLivro.Location = new Point(0, -9);
            panelLivro.Name = "panelLivro";
            panelLivro.Size = new Size(42, 468);
            panelLivro.TabIndex = 154;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 171;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkRed;
            panel3.Location = new Point(76, 323);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 4);
            panel3.TabIndex = 170;
            // 
            // textIdioma
            // 
            textIdioma.BackColor = Color.FromArgb(250, 243, 224);
            textIdioma.BorderStyle = BorderStyle.None;
            textIdioma.Font = new Font("Arial Narrow", 12F);
            textIdioma.ForeColor = Color.FromArgb(130, 119, 106);
            textIdioma.Location = new Point(80, 298);
            textIdioma.Name = "textIdioma";
            textIdioma.Size = new Size(257, 19);
            textIdioma.TabIndex = 169;
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Font = new Font("Arial Narrow", 14F);
            labelMarca.ForeColor = Color.DarkRed;
            labelMarca.Location = new Point(76, 257);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(135, 23);
            labelMarca.TabIndex = 168;
            labelMarca.Text = "Tipo de pnalidade";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkRed;
            panel4.Location = new Point(77, 239);
            panel4.Name = "panel4";
            panel4.Size = new Size(270, 4);
            panel4.TabIndex = 167;
            // 
            // textNome
            // 
            textNome.BackColor = Color.FromArgb(250, 243, 224);
            textNome.BorderStyle = BorderStyle.None;
            textNome.Font = new Font("Arial Narrow", 12F);
            textNome.ForeColor = Color.FromArgb(130, 119, 106);
            textNome.Location = new Point(81, 214);
            textNome.Name = "textNome";
            textNome.Size = new Size(257, 19);
            textNome.TabIndex = 166;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Arial Narrow", 14F);
            labelNome.ForeColor = Color.DarkRed;
            labelNome.Location = new Point(76, 173);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(111, 23);
            labelNome.TabIndex = 165;
            labelNome.Text = "Código acervo";
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkRed;
            panel5.Location = new Point(76, 152);
            panel5.Name = "panel5";
            panel5.Size = new Size(270, 4);
            panel5.TabIndex = 164;
            // 
            // textIdJogo
            // 
            textIdJogo.BackColor = Color.FromArgb(250, 243, 224);
            textIdJogo.BorderStyle = BorderStyle.None;
            textIdJogo.Font = new Font("Arial Narrow", 12F);
            textIdJogo.ForeColor = Color.FromArgb(130, 119, 106);
            textIdJogo.Location = new Point(80, 127);
            textIdJogo.Name = "textIdJogo";
            textIdJogo.Size = new Size(257, 19);
            textIdJogo.TabIndex = 163;
            // 
            // labelIdJogo
            // 
            labelIdJogo.AutoSize = true;
            labelIdJogo.Font = new Font("Arial Narrow", 14F);
            labelIdJogo.ForeColor = Color.DarkRed;
            labelIdJogo.Location = new Point(76, 86);
            labelIdJogo.Name = "labelIdJogo";
            labelIdJogo.Size = new Size(116, 23);
            labelIdJogo.TabIndex = 162;
            labelIdJogo.Text = "Código usuário";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(444, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(357, 426);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 172;
            pictureBox2.TabStop = false;
            // 
            // CadastroPenalidade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(textIdioma);
            Controls.Add(labelMarca);
            Controls.Add(panel4);
            Controls.Add(textNome);
            Controls.Add(labelNome);
            Controls.Add(panel5);
            Controls.Add(textIdJogo);
            Controls.Add(labelIdJogo);
            Controls.Add(btnCadastrar);
            Controls.Add(btnCancelar);
            Controls.Add(labelTituloPrincipal);
            Controls.Add(panelLivro);
            Controls.Add(pictureBox2);
            Name = "CadastroPenalidade";
            Text = "CadastrarPenalidade";
            panelLivro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private Button btnCancelar;
        private Label labelTituloPrincipal;
        private Panel panelLivro;
        private Panel panel3;
        private TextBox textIdioma;
        private Label labelMarca;
        private Panel panel4;
        private TextBox textNome;
        private Label labelNome;
        private Panel panel5;
        private TextBox textIdJogo;
        private Label labelIdJogo;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}