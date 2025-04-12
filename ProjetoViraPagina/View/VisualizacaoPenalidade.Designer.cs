namespace Projeto_ViraPagina.View
{
    partial class VisualizacaoPenalidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizacaoPenalidade));
            dgvPenalidades = new DataGridView();
            CodigoAluno = new DataGridViewTextBoxColumn();
            DataOcorrencia = new DataGridViewTextBoxColumn();
            CodigoLivro = new DataGridViewTextBoxColumn();
            CodigoPenalidade = new DataGridViewTextBoxColumn();
            btnVoltar = new Button();
            panel5 = new Panel();
            texPesquisarPenalidades = new TextBox();
            labelPenalidades = new Label();
            panelLivro = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvPenalidades).BeginInit();
            panelLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvPenalidades
            // 
            dgvPenalidades.BackgroundColor = Color.FromArgb(250, 243, 224);
            dgvPenalidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPenalidades.Columns.AddRange(new DataGridViewColumn[] { CodigoAluno, DataOcorrencia, CodigoLivro, CodigoPenalidade });
            dgvPenalidades.Location = new Point(51, 125);
            dgvPenalidades.Name = "dgvPenalidades";
            dgvPenalidades.Size = new Size(739, 239);
            dgvPenalidades.TabIndex = 213;
            // 
            // CodigoAluno
            // 
            CodigoAluno.HeaderText = "Código aluno";
            CodigoAluno.Name = "CodigoAluno";
            CodigoAluno.Width = 175;
            // 
            // DataOcorrencia
            // 
            DataOcorrencia.HeaderText = "Data de ocorrência";
            DataOcorrencia.Name = "DataOcorrencia";
            DataOcorrencia.Width = 175;
            // 
            // CodigoLivro
            // 
            CodigoLivro.HeaderText = "Código livro";
            CodigoLivro.Name = "CodigoLivro";
            CodigoLivro.Width = 175;
            // 
            // CodigoPenalidade
            // 
            CodigoPenalidade.HeaderText = "Código penalidade";
            CodigoPenalidade.Name = "CodigoPenalidade";
            CodigoPenalidade.Width = 175;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.DarkRed;
            btnVoltar.Font = new Font("Segoe UI", 12F);
            btnVoltar.ForeColor = Color.FromArgb(250, 243, 224);
            btnVoltar.Location = new Point(350, 401);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(128, 35);
            btnVoltar.TabIndex = 212;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkRed;
            panel5.Location = new Point(232, 102);
            panel5.Name = "panel5";
            panel5.Size = new Size(382, 4);
            panel5.TabIndex = 211;
            // 
            // texPesquisarPenalidades
            // 
            texPesquisarPenalidades.BackColor = Color.FromArgb(250, 243, 224);
            texPesquisarPenalidades.BorderStyle = BorderStyle.None;
            texPesquisarPenalidades.Font = new Font("Arial Narrow", 12F);
            texPesquisarPenalidades.ForeColor = Color.FromArgb(130, 119, 106);
            texPesquisarPenalidades.Location = new Point(227, 77);
            texPesquisarPenalidades.Name = "texPesquisarPenalidades";
            texPesquisarPenalidades.Size = new Size(386, 19);
            texPesquisarPenalidades.TabIndex = 210;
            // 
            // labelPenalidades
            // 
            labelPenalidades.AutoSize = true;
            labelPenalidades.Font = new Font("Arial Narrow", 20F);
            labelPenalidades.ForeColor = Color.DarkRed;
            labelPenalidades.Location = new Point(342, 16);
            labelPenalidades.Name = "labelPenalidades";
            labelPenalidades.Size = new Size(134, 31);
            labelPenalidades.TabIndex = 209;
            labelPenalidades.Text = "Penalidades";
            // 
            // panelLivro
            // 
            panelLivro.BackColor = Color.DarkRed;
            panelLivro.Controls.Add(pictureBox1);
            panelLivro.Location = new Point(-1, -4);
            panelLivro.Name = "panelLivro";
            panelLivro.Size = new Size(42, 472);
            panelLivro.TabIndex = 208;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // VisualizacaoPenalidade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPenalidades);
            Controls.Add(btnVoltar);
            Controls.Add(panel5);
            Controls.Add(texPesquisarPenalidades);
            Controls.Add(labelPenalidades);
            Controls.Add(panelLivro);
            Name = "VisualizacaoPenalidade";
            Text = "Penalidades";
            Load += Penalidades_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPenalidades).EndInit();
            panelLivro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPenalidades;
        private Button btnVoltar;
        private Panel panel5;
        private TextBox texPesquisarPenalidades;
        private Label labelPenalidades;
        private Panel panelLivro;
        private DataGridViewTextBoxColumn CodigoAluno;
        private DataGridViewTextBoxColumn DataOcorrencia;
        private DataGridViewTextBoxColumn CodigoLivro;
        private DataGridViewTextBoxColumn CodigoPenalidade;
        private PictureBox pictureBox1;
    }
}