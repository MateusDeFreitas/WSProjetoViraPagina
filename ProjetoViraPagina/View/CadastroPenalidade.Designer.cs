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
            labelPenalidade = new Label();
            panel4 = new Panel();
            textIdEmprestimo = new TextBox();
            labelIdEmprestimo = new Label();
            panel5 = new Panel();
            textIdUsuario = new TextBox();
            labelIdUsuario = new Label();
            pictureBox2 = new PictureBox();
            textTipo = new ComboBox();
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
            btnCadastrar.Location = new Point(430, 385);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(128, 35);
            btnCadastrar.TabIndex = 160;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            //
            // btnCancelar
            //
            btnCancelar.BackColor = Color.DarkRed;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.ForeColor = Color.FromArgb(250, 243, 224);
            btnCancelar.Location = new Point(287, 385);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(128, 35);
            btnCancelar.TabIndex = 159;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            //
            // labelTituloPrincipal
            //
            labelTituloPrincipal.AutoSize = true;
            labelTituloPrincipal.Font = new Font("Arial Narrow", 20F);
            labelTituloPrincipal.ForeColor = Color.DarkRed;
            labelTituloPrincipal.Location = new Point(314, 10);
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
            // labelPenalidade
            //
            labelPenalidade.AutoSize = true;
            labelPenalidade.Font = new Font("Arial Narrow", 14F);
            labelPenalidade.ForeColor = Color.DarkRed;
            labelPenalidade.Location = new Point(76, 257);
            labelPenalidade.Name = "labelPenalidade";
            labelPenalidade.Size = new Size(144, 23);
            labelPenalidade.TabIndex = 168;
            labelPenalidade.Text = "Tipo de penalidade";
            //
            // panel4
            //
            panel4.BackColor = Color.DarkRed;
            panel4.Location = new Point(77, 239);
            panel4.Name = "panel4";
            panel4.Size = new Size(270, 4);
            panel4.TabIndex = 167;
            //
            // textIdEmprestimo
            //
            textIdEmprestimo.BackColor = Color.FromArgb(250, 243, 224);
            textIdEmprestimo.BorderStyle = BorderStyle.None;
            textIdEmprestimo.Font = new Font("Arial Narrow", 12F);
            textIdEmprestimo.ForeColor = Color.FromArgb(130, 119, 106);
            textIdEmprestimo.Location = new Point(81, 214);
            textIdEmprestimo.Name = "textIdEmprestimo";
            textIdEmprestimo.Size = new Size(257, 19);
            textIdEmprestimo.TabIndex = 166;
            //
            // labelIdEmprestimo
            //
            labelIdEmprestimo.AutoSize = true;
            labelIdEmprestimo.Font = new Font("Arial Narrow", 14F);
            labelIdEmprestimo.ForeColor = Color.DarkRed;
            labelIdEmprestimo.Location = new Point(76, 173);
            labelIdEmprestimo.Name = "labelIdEmprestimo";
            labelIdEmprestimo.Size = new Size(145, 23);
            labelIdEmprestimo.TabIndex = 165;
            labelIdEmprestimo.Text = "Código empréstimo";
            //
            // panel5
            //
            panel5.BackColor = Color.DarkRed;
            panel5.Location = new Point(76, 152);
            panel5.Name = "panel5";
            panel5.Size = new Size(270, 4);
            panel5.TabIndex = 164;
            //
            // textIdUsuario
            //
            textIdUsuario.BackColor = Color.FromArgb(250, 243, 224);
            textIdUsuario.BorderStyle = BorderStyle.None;
            textIdUsuario.Font = new Font("Arial Narrow", 12F);
            textIdUsuario.ForeColor = Color.FromArgb(130, 119, 106);
            textIdUsuario.Location = new Point(80, 127);
            textIdUsuario.Name = "textIdUsuario";
            textIdUsuario.Size = new Size(257, 19);
            textIdUsuario.TabIndex = 163;
            //
            // labelIdUsuario
            //
            labelIdUsuario.AutoSize = true;
            labelIdUsuario.Font = new Font("Arial Narrow", 14F);
            labelIdUsuario.ForeColor = Color.DarkRed;
            labelIdUsuario.Location = new Point(76, 86);
            labelIdUsuario.Name = "labelIdUsuario";
            labelIdUsuario.Size = new Size(121, 23);
            labelIdUsuario.TabIndex = 162;
            labelIdUsuario.Text = "Código tomador";
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
            // textTipo
            //
            textTipo.BackColor = Color.FromArgb(250, 243, 224);
            textTipo.FlatStyle = FlatStyle.Flat;
            textTipo.Font = new Font("Arial Narrow", 12F);
            textTipo.ForeColor = Color.FromArgb(130, 119, 106);
            textTipo.FormattingEnabled = true;
            textTipo.Location = new Point(77, 292);
            textTipo.Name = "textTipo";
            textTipo.Size = new Size(269, 28);
            textTipo.TabIndex = 173;
            //
            // CadastroPenalidade
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(textTipo);
            Controls.Add(panel3);
            Controls.Add(labelPenalidade);
            Controls.Add(panel4);
            Controls.Add(textIdEmprestimo);
            Controls.Add(labelIdEmprestimo);
            Controls.Add(panel5);
            Controls.Add(textIdUsuario);
            Controls.Add(labelIdUsuario);
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
        private Label labelPenalidade;
        private Panel panel4;
        private TextBox textIdEmprestimo;
        private Label labelIdEmprestimo;
        private Panel panel5;
        private TextBox textIdUsuario;
        private Label labelIdUsuario;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ComboBox textTipo;
    }
}