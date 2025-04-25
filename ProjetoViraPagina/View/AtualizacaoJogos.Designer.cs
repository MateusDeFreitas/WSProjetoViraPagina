namespace Projeto_ViraPagina.View
{
    partial class AtualizacaoJogos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtualizacaoJogos));
            panelLivro = new Panel();
            pictureBox1 = new PictureBox();
            btnCadastrar = new Button();
            btnCancelar = new Button();
            panel7 = new Panel();
            textMaterial = new TextBox();
            labelMaterial = new Label();
            panel1 = new Panel();
            textNumeroJogadores = new TextBox();
            labelNumeroJogadores = new Label();
            panel2 = new Panel();
            textGenero = new TextBox();
            labelGenero = new Label();
            panel3 = new Panel();
            textMarca = new TextBox();
            labelMarca = new Label();
            panel4 = new Panel();
            textNome = new TextBox();
            labelNome = new Label();
            panel5 = new Panel();
            labelIdJogo = new Label();
            labelAtualizacaoJogos = new Label();
            textIdJogo = new Label();
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
            panelLivro.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 157;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.DarkRed;
            btnCadastrar.Font = new Font("Segoe UI", 12F);
            btnCadastrar.ForeColor = Color.FromArgb(250, 243, 224);
            btnCadastrar.Location = new Point(391, 403);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(128, 35);
            btnCadastrar.TabIndex = 156;
            btnCadastrar.Text = "Atualizar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkRed;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.ForeColor = Color.FromArgb(250, 243, 224);
            btnCancelar.Location = new Point(248, 403);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(128, 35);
            btnCancelar.TabIndex = 155;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.DarkRed;
            panel7.Location = new Point(455, 157);
            panel7.Name = "panel7";
            panel7.Size = new Size(270, 4);
            panel7.TabIndex = 154;
            // 
            // textMaterial
            // 
            textMaterial.BackColor = Color.FromArgb(250, 243, 224);
            textMaterial.BorderStyle = BorderStyle.None;
            textMaterial.Font = new Font("Arial Narrow", 12F);
            textMaterial.ForeColor = Color.FromArgb(130, 119, 106);
            textMaterial.Location = new Point(456, 132);
            textMaterial.Name = "textMaterial";
            textMaterial.Size = new Size(257, 19);
            textMaterial.TabIndex = 153;
            // 
            // labelMaterial
            // 
            labelMaterial.AutoSize = true;
            labelMaterial.Font = new Font("Arial Narrow", 14F);
            labelMaterial.ForeColor = Color.DarkRed;
            labelMaterial.Location = new Point(455, 91);
            labelMaterial.Name = "labelMaterial";
            labelMaterial.Size = new Size(64, 23);
            labelMaterial.TabIndex = 152;
            labelMaterial.Text = "Material";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Location = new Point(454, 328);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 4);
            panel1.TabIndex = 151;
            // 
            // textNumeroJogadores
            // 
            textNumeroJogadores.BackColor = Color.FromArgb(250, 243, 224);
            textNumeroJogadores.BorderStyle = BorderStyle.None;
            textNumeroJogadores.Font = new Font("Arial Narrow", 12F);
            textNumeroJogadores.ForeColor = Color.FromArgb(130, 119, 106);
            textNumeroJogadores.Location = new Point(458, 303);
            textNumeroJogadores.Name = "textNumeroJogadores";
            textNumeroJogadores.Size = new Size(257, 19);
            textNumeroJogadores.TabIndex = 150;
            // 
            // labelNumeroJogadores
            // 
            labelNumeroJogadores.AutoSize = true;
            labelNumeroJogadores.Font = new Font("Arial Narrow", 14F);
            labelNumeroJogadores.ForeColor = Color.DarkRed;
            labelNumeroJogadores.Location = new Point(454, 262);
            labelNumeroJogadores.Name = "labelNumeroJogadores";
            labelNumeroJogadores.Size = new Size(162, 23);
            labelNumeroJogadores.TabIndex = 149;
            labelNumeroJogadores.Text = "Número de jogadores";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkRed;
            panel2.Location = new Point(455, 244);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 4);
            panel2.TabIndex = 148;
            // 
            // textGenero
            // 
            textGenero.BackColor = Color.FromArgb(250, 243, 224);
            textGenero.BorderStyle = BorderStyle.None;
            textGenero.Font = new Font("Arial Narrow", 12F);
            textGenero.ForeColor = Color.FromArgb(130, 119, 106);
            textGenero.Location = new Point(459, 219);
            textGenero.Name = "textGenero";
            textGenero.Size = new Size(257, 19);
            textGenero.TabIndex = 147;
            // 
            // labelGenero
            // 
            labelGenero.AutoSize = true;
            labelGenero.Font = new Font("Arial Narrow", 14F);
            labelGenero.ForeColor = Color.DarkRed;
            labelGenero.Location = new Point(454, 178);
            labelGenero.Name = "labelGenero";
            labelGenero.Size = new Size(63, 23);
            labelGenero.TabIndex = 146;
            labelGenero.Text = "Gênero";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkRed;
            panel3.Location = new Point(71, 328);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 4);
            panel3.TabIndex = 142;
            // 
            // textMarca
            // 
            textMarca.BackColor = Color.FromArgb(250, 243, 224);
            textMarca.BorderStyle = BorderStyle.None;
            textMarca.Font = new Font("Arial Narrow", 12F);
            textMarca.ForeColor = Color.FromArgb(130, 119, 106);
            textMarca.Location = new Point(72, 303);
            textMarca.Name = "textMarca";
            textMarca.Size = new Size(257, 19);
            textMarca.TabIndex = 141;
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Font = new Font("Arial Narrow", 14F);
            labelMarca.ForeColor = Color.DarkRed;
            labelMarca.Location = new Point(72, 262);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(54, 23);
            labelMarca.TabIndex = 140;
            labelMarca.Text = "Marca";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkRed;
            panel4.Location = new Point(71, 244);
            panel4.Name = "panel4";
            panel4.Size = new Size(270, 4);
            panel4.TabIndex = 139;
            // 
            // textNome
            // 
            textNome.BackColor = Color.FromArgb(250, 243, 224);
            textNome.BorderStyle = BorderStyle.None;
            textNome.Font = new Font("Arial Narrow", 12F);
            textNome.ForeColor = Color.FromArgb(130, 119, 106);
            textNome.Location = new Point(72, 219);
            textNome.Name = "textNome";
            textNome.Size = new Size(257, 19);
            textNome.TabIndex = 138;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Arial Narrow", 14F);
            labelNome.ForeColor = Color.DarkRed;
            labelNome.Location = new Point(71, 178);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(52, 23);
            labelNome.TabIndex = 137;
            labelNome.Text = "Nome";
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkRed;
            panel5.Location = new Point(72, 157);
            panel5.Name = "panel5";
            panel5.Size = new Size(270, 4);
            panel5.TabIndex = 136;
            // 
            // labelIdJogo
            // 
            labelIdJogo.AutoSize = true;
            labelIdJogo.Font = new Font("Arial Narrow", 14F);
            labelIdJogo.ForeColor = Color.DarkRed;
            labelIdJogo.Location = new Point(72, 91);
            labelIdJogo.Name = "labelIdJogo";
            labelIdJogo.Size = new Size(60, 23);
            labelIdJogo.TabIndex = 134;
            labelIdJogo.Text = "Código";
            // 
            // labelAtualizacaoJogos
            // 
            labelAtualizacaoJogos.AutoSize = true;
            labelAtualizacaoJogos.Font = new Font("Arial Narrow", 20F);
            labelAtualizacaoJogos.ForeColor = Color.DarkRed;
            labelAtualizacaoJogos.Location = new Point(287, 21);
            labelAtualizacaoJogos.Name = "labelAtualizacaoJogos";
            labelAtualizacaoJogos.Size = new Size(215, 31);
            labelAtualizacaoJogos.TabIndex = 133;
            labelAtualizacaoJogos.Text = "Atualização de jogos";
            // 
            // textIdJogo
            // 
            textIdJogo.AutoSize = true;
            textIdJogo.Font = new Font("Arial Narrow", 12F);
            textIdJogo.ForeColor = Color.FromArgb(130, 119, 106);
            textIdJogo.Location = new Point(73, 131);
            textIdJogo.Name = "textIdJogo";
            textIdJogo.Size = new Size(17, 20);
            textIdJogo.TabIndex = 157;
            textIdJogo.Text = "  ";
            // 
            // AtualizacaoJogos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 224);
            ClientSize = new Size(757, 450);
            Controls.Add(textIdJogo);
            Controls.Add(btnCadastrar);
            Controls.Add(btnCancelar);
            Controls.Add(panel7);
            Controls.Add(textMaterial);
            Controls.Add(labelMaterial);
            Controls.Add(panel1);
            Controls.Add(textNumeroJogadores);
            Controls.Add(labelNumeroJogadores);
            Controls.Add(panel2);
            Controls.Add(textGenero);
            Controls.Add(labelGenero);
            Controls.Add(panel3);
            Controls.Add(textMarca);
            Controls.Add(labelMarca);
            Controls.Add(panel4);
            Controls.Add(textNome);
            Controls.Add(labelNome);
            Controls.Add(panel5);
            Controls.Add(labelIdJogo);
            Controls.Add(labelAtualizacaoJogos);
            Controls.Add(panelLivro);
            Name = "AtualizacaoJogos";
            Text = "AtualizacaoJogos";
            Load += AtualizacaoJogos_Load;
            panelLivro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelLivro;
        private Button btnCadastrar;
        private Button btnCancelar;
        private Panel panel7;
        private TextBox textMaterial;
        private Label labelMaterial;
        private Panel panel1;
        private TextBox textNumeroJogadores;
        private Label labelNumeroJogadores;
        private Panel panel2;
        private TextBox textGenero;
        private Label labelGenero;
        private Panel panel3;
        private TextBox textMarca;
        private Label labelMarca;
        private Panel panel4;
        private TextBox textNome;
        private Label labelNome;
        private Panel panel5;
        private Label labelIdJogo;
        private Label labelAtualizacaoJogos;
        private PictureBox pictureBox1;
        private Label textIdJogo;
    }
}