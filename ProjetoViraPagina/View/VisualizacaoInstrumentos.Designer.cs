namespace Projeto_ViraPagina.View
{
    partial class VisualizacaoInstrumentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizacaoInstrumentos));
            dgvVisualizacaoInstrumentos = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Modelo = new DataGridViewTextBoxColumn();
            NumeroSerie = new DataGridViewTextBoxColumn();
            btnVoltar = new Button();
            panel5 = new Panel();
            texPesquisarVisualizacaoInstrumentos = new TextBox();
            labelAtualizacaoInstrumentos = new Label();
            panelLivro = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvVisualizacaoInstrumentos).BeginInit();
            panelLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvVisualizacaoInstrumentos
            // 
            dgvVisualizacaoInstrumentos.BackgroundColor = Color.FromArgb(250, 243, 224);
            dgvVisualizacaoInstrumentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVisualizacaoInstrumentos.Columns.AddRange(new DataGridViewColumn[] { Codigo, Categoria, Marca, Modelo, NumeroSerie });
            dgvVisualizacaoInstrumentos.Location = new Point(51, 124);
            dgvVisualizacaoInstrumentos.Name = "dgvVisualizacaoInstrumentos";
            dgvVisualizacaoInstrumentos.Size = new Size(739, 239);
            dgvVisualizacaoInstrumentos.TabIndex = 195;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            Codigo.Width = 145;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.Width = 145;
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.Name = "Marca";
            Marca.Width = 145;
            // 
            // Modelo
            // 
            Modelo.HeaderText = "Modelo";
            Modelo.Name = "Modelo";
            Modelo.Width = 145;
            // 
            // NumeroSerie
            // 
            NumeroSerie.HeaderText = "Numero de série";
            NumeroSerie.Name = "NumeroSerie";
            NumeroSerie.Width = 145;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.DarkRed;
            btnVoltar.Font = new Font("Segoe UI", 12F);
            btnVoltar.ForeColor = Color.FromArgb(250, 243, 224);
            btnVoltar.Location = new Point(348, 400);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(128, 35);
            btnVoltar.TabIndex = 194;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkRed;
            panel5.Location = new Point(217, 101);
            panel5.Name = "panel5";
            panel5.Size = new Size(382, 4);
            panel5.TabIndex = 193;
            // 
            // texPesquisarVisualizacaoInstrumentos
            // 
            texPesquisarVisualizacaoInstrumentos.BackColor = Color.FromArgb(250, 243, 224);
            texPesquisarVisualizacaoInstrumentos.BorderStyle = BorderStyle.None;
            texPesquisarVisualizacaoInstrumentos.Font = new Font("Arial Narrow", 12F);
            texPesquisarVisualizacaoInstrumentos.ForeColor = Color.FromArgb(130, 119, 106);
            texPesquisarVisualizacaoInstrumentos.Location = new Point(212, 76);
            texPesquisarVisualizacaoInstrumentos.Name = "texPesquisarVisualizacaoInstrumentos";
            texPesquisarVisualizacaoInstrumentos.Size = new Size(386, 19);
            texPesquisarVisualizacaoInstrumentos.TabIndex = 192;
            // 
            // labelAtualizacaoInstrumentos
            // 
            labelAtualizacaoInstrumentos.AutoSize = true;
            labelAtualizacaoInstrumentos.Font = new Font("Arial Narrow", 20F);
            labelAtualizacaoInstrumentos.ForeColor = Color.DarkRed;
            labelAtualizacaoInstrumentos.Location = new Point(257, 15);
            labelAtualizacaoInstrumentos.Name = "labelAtualizacaoInstrumentos";
            labelAtualizacaoInstrumentos.Size = new Size(297, 31);
            labelAtualizacaoInstrumentos.TabIndex = 191;
            labelAtualizacaoInstrumentos.Text = "Visualização de instrumentos";
            // 
            // panelLivro
            // 
            panelLivro.BackColor = Color.DarkRed;
            panelLivro.Controls.Add(pictureBox1);
            panelLivro.Location = new Point(-1, -5);
            panelLivro.Name = "panelLivro";
            panelLivro.Size = new Size(42, 472);
            panelLivro.TabIndex = 190;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // VisualizacaoInstrumentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(dgvVisualizacaoInstrumentos);
            Controls.Add(btnVoltar);
            Controls.Add(panel5);
            Controls.Add(texPesquisarVisualizacaoInstrumentos);
            Controls.Add(labelAtualizacaoInstrumentos);
            Controls.Add(panelLivro);
            Name = "VisualizacaoInstrumentos";
            Text = "VisualizacaoInstrumentos";
            Load += VisualizacaoInstrumentos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVisualizacaoInstrumentos).EndInit();
            panelLivro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVisualizacaoInstrumentos;
        private Button btnVoltar;
        private Panel panel5;
        private TextBox texPesquisarVisualizacaoInstrumentos;
        private Label labelAtualizacaoInstrumentos;
        private Panel panelLivro;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn NumeroSerie;
        private PictureBox pictureBox1;
    }
}