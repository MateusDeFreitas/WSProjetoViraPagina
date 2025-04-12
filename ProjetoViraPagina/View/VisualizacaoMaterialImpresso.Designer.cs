namespace Projeto_ViraPagina.View
{
    partial class VisualizacaoMaterialImpresso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizacaoMaterialImpresso));
            dgvVisualizacaoMaterialImpresso = new DataGridView();
            CodigoLivro = new DataGridViewTextBoxColumn();
            Título = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            Classe = new DataGridViewTextBoxColumn();
            Idioma = new DataGridViewTextBoxColumn();
            btnVoltar = new Button();
            panel5 = new Panel();
            texPesquisarVisualizacaoMaterialImpresso = new TextBox();
            labelAtualizacaoInstrumentos = new Label();
            panelLivro = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvVisualizacaoMaterialImpresso).BeginInit();
            panelLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvVisualizacaoMaterialImpresso
            // 
            dgvVisualizacaoMaterialImpresso.BackgroundColor = Color.FromArgb(250, 243, 224);
            dgvVisualizacaoMaterialImpresso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVisualizacaoMaterialImpresso.Columns.AddRange(new DataGridViewColumn[] { CodigoLivro, Título, Autor, Classe, Idioma });
            dgvVisualizacaoMaterialImpresso.Location = new Point(51, 126);
            dgvVisualizacaoMaterialImpresso.Name = "dgvVisualizacaoMaterialImpresso";
            dgvVisualizacaoMaterialImpresso.Size = new Size(739, 239);
            dgvVisualizacaoMaterialImpresso.TabIndex = 189;
            // 
            // CodigoLivro
            // 
            CodigoLivro.HeaderText = "Código";
            CodigoLivro.Name = "CodigoLivro";
            CodigoLivro.Width = 145;
            // 
            // Título
            // 
            Título.HeaderText = "Título";
            Título.Name = "Título";
            Título.Width = 145;
            // 
            // Autor
            // 
            Autor.HeaderText = "Autor";
            Autor.Name = "Autor";
            Autor.Width = 145;
            // 
            // Classe
            // 
            Classe.HeaderText = "Classe";
            Classe.Name = "Classe";
            Classe.Width = 145;
            // 
            // Idioma
            // 
            Idioma.HeaderText = "Idioma";
            Idioma.Name = "Idioma";
            Idioma.Width = 145;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.DarkRed;
            btnVoltar.Font = new Font("Segoe UI", 12F);
            btnVoltar.ForeColor = Color.FromArgb(250, 243, 224);
            btnVoltar.Location = new Point(351, 402);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(128, 35);
            btnVoltar.TabIndex = 188;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkRed;
            panel5.Location = new Point(219, 103);
            panel5.Name = "panel5";
            panel5.Size = new Size(382, 4);
            panel5.TabIndex = 187;
            // 
            // texPesquisarVisualizacaoMaterialImpresso
            // 
            texPesquisarVisualizacaoMaterialImpresso.BackColor = Color.FromArgb(250, 243, 224);
            texPesquisarVisualizacaoMaterialImpresso.BorderStyle = BorderStyle.None;
            texPesquisarVisualizacaoMaterialImpresso.Font = new Font("Arial Narrow", 12F);
            texPesquisarVisualizacaoMaterialImpresso.ForeColor = Color.FromArgb(130, 119, 106);
            texPesquisarVisualizacaoMaterialImpresso.Location = new Point(214, 78);
            texPesquisarVisualizacaoMaterialImpresso.Name = "texPesquisarVisualizacaoMaterialImpresso";
            texPesquisarVisualizacaoMaterialImpresso.Size = new Size(386, 19);
            texPesquisarVisualizacaoMaterialImpresso.TabIndex = 186;
            // 
            // labelAtualizacaoInstrumentos
            // 
            labelAtualizacaoInstrumentos.AutoSize = true;
            labelAtualizacaoInstrumentos.Font = new Font("Arial Narrow", 20F);
            labelAtualizacaoInstrumentos.ForeColor = Color.DarkRed;
            labelAtualizacaoInstrumentos.Location = new Point(237, 17);
            labelAtualizacaoInstrumentos.Name = "labelAtualizacaoInstrumentos";
            labelAtualizacaoInstrumentos.Size = new Size(344, 31);
            labelAtualizacaoInstrumentos.TabIndex = 185;
            labelAtualizacaoInstrumentos.Text = "Visualização do material impresso";
            // 
            // panelLivro
            // 
            panelLivro.BackColor = Color.DarkRed;
            panelLivro.Controls.Add(pictureBox1);
            panelLivro.Location = new Point(-1, -3);
            panelLivro.Name = "panelLivro";
            panelLivro.Size = new Size(42, 472);
            panelLivro.TabIndex = 184;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // VisualizacaoMaterialImpresso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(dgvVisualizacaoMaterialImpresso);
            Controls.Add(btnVoltar);
            Controls.Add(panel5);
            Controls.Add(texPesquisarVisualizacaoMaterialImpresso);
            Controls.Add(labelAtualizacaoInstrumentos);
            Controls.Add(panelLivro);
            Name = "VisualizacaoMaterialImpresso";
            Text = "VisualizacaoMaterialImpresso";
            Load += VisualizacaoMaterialImpresso_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVisualizacaoMaterialImpresso).EndInit();
            panelLivro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVisualizacaoMaterialImpresso;
        private Button btnVoltar;
        private Panel panel5;
        private TextBox texPesquisarVisualizacaoMaterialImpresso;
        private Label labelAtualizacaoInstrumentos;
        private Panel panelLivro;
        private DataGridViewTextBoxColumn CodigoLivro;
        private DataGridViewTextBoxColumn Título;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn Classe;
        private DataGridViewTextBoxColumn Idioma;
        private PictureBox pictureBox1;
    }
}