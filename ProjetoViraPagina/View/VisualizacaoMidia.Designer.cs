namespace Projeto_ViraPagina.View
{
    partial class VisualizacaoMidia
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
            panelLivro = new Panel();
            pictureBox1 = new PictureBox();
            labelAtualizacaoInstrumentos = new Label();
            panel5 = new Panel();
            textVisualizacaoMidia = new TextBox();
            btnVoltar = new Button();
            dgvVisualizacaoMidia = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Título = new DataGridViewTextBoxColumn();
            Diretor = new DataGridViewTextBoxColumn();
            Genero = new DataGridViewTextBoxColumn();
            AnoLancamento = new DataGridViewTextBoxColumn();
            panelLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVisualizacaoMidia).BeginInit();
            SuspendLayout();
            // 
            // panelLivro
            // 
            panelLivro.BackColor = Color.DarkRed;
            panelLivro.Controls.Add(pictureBox1);
            panelLivro.Location = new Point(-1, -11);
            panelLivro.Name = "panelLivro";
            panelLivro.Size = new Size(42, 472);
            panelLivro.TabIndex = 158;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(2, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 157;
            pictureBox1.TabStop = false;
            // 
            // labelAtualizacaoInstrumentos
            // 
            labelAtualizacaoInstrumentos.AutoSize = true;
            labelAtualizacaoInstrumentos.Font = new Font("Arial Narrow", 20F);
            labelAtualizacaoInstrumentos.ForeColor = Color.DarkRed;
            labelAtualizacaoInstrumentos.Location = new Point(285, 9);
            labelAtualizacaoInstrumentos.Name = "labelAtualizacaoInstrumentos";
            labelAtualizacaoInstrumentos.Size = new Size(226, 31);
            labelAtualizacaoInstrumentos.TabIndex = 159;
            labelAtualizacaoInstrumentos.Text = "Visualização de mídia";
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkRed;
            panel5.Location = new Point(211, 95);
            panel5.Name = "panel5";
            panel5.Size = new Size(382, 4);
            panel5.TabIndex = 164;
            // 
            // textVisualizacaoMidia
            // 
            textVisualizacaoMidia.BackColor = Color.FromArgb(250, 243, 224);
            textVisualizacaoMidia.BorderStyle = BorderStyle.None;
            textVisualizacaoMidia.Font = new Font("Arial Narrow", 12F);
            textVisualizacaoMidia.ForeColor = Color.FromArgb(130, 119, 106);
            textVisualizacaoMidia.Location = new Point(206, 70);
            textVisualizacaoMidia.Name = "textVisualizacaoMidia";
            textVisualizacaoMidia.Size = new Size(386, 19);
            textVisualizacaoMidia.TabIndex = 163;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.DarkRed;
            btnVoltar.Font = new Font("Segoe UI", 12F);
            btnVoltar.ForeColor = Color.FromArgb(250, 243, 224);
            btnVoltar.Location = new Point(351, 394);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(128, 35);
            btnVoltar.TabIndex = 182;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // dgvVisualizacaoMidia
            // 
            dgvVisualizacaoMidia.BackgroundColor = Color.FromArgb(250, 243, 224);
            dgvVisualizacaoMidia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVisualizacaoMidia.Columns.AddRange(new DataGridViewColumn[] { Codigo, Título, Diretor, Genero, AnoLancamento });
            dgvVisualizacaoMidia.Location = new Point(51, 118);
            dgvVisualizacaoMidia.Name = "dgvVisualizacaoMidia";
            dgvVisualizacaoMidia.Size = new Size(739, 239);
            dgvVisualizacaoMidia.TabIndex = 183;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            Codigo.Width = 145;
            // 
            // Título
            // 
            Título.HeaderText = "Título";
            Título.Name = "Título";
            Título.Width = 145;
            // 
            // Diretor
            // 
            Diretor.HeaderText = "Diretor";
            Diretor.Name = "Diretor";
            Diretor.Width = 145;
            // 
            // Genero
            // 
            Genero.HeaderText = "Gênero";
            Genero.Name = "Genero";
            Genero.Width = 145;
            // 
            // AnoLancamento
            // 
            AnoLancamento.HeaderText = "Ano de lançamento";
            AnoLancamento.Name = "AnoLancamento";
            AnoLancamento.Width = 145;

            dgvVisualizacaoMidia.Rows.Add("MD001", "O Senhor dos Anéis", "Peter Jackson", "Fantasia", "2001");
            dgvVisualizacaoMidia.Rows.Add("MD002", "Matrix", "Lana Wachowski", "Ficção Científica", "1999");
            // 
            // VisualizacaoMidia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(dgvVisualizacaoMidia);
            Controls.Add(btnVoltar);
            Controls.Add(panel5);
            Controls.Add(textVisualizacaoMidia);
            Controls.Add(labelAtualizacaoInstrumentos);
            Controls.Add(panelLivro);
            Name = "VisualizacaoMidia";
            Text = "VisualizacaoMidia";
            Load += VisualizacaoMidia_Load;
            panelLivro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVisualizacaoMidia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelLivro;
        private PictureBox pictureBox1;
        private Label labelAtualizacaoInstrumentos;
        private Panel panel5;
        private TextBox textVisualizacaoMidia;
        private Button btnVoltar;
        private DataGridView dgvVisualizacaoMidia;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Título;
        private DataGridViewTextBoxColumn Diretor;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewTextBoxColumn AnoLancamento;
    }
}