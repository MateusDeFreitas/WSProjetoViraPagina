namespace Projeto_ViraPagina.View
{
    partial class VisualizacaoEmprestimos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizacaoEmprestimos));
            dgvVisualizacaoEmprestimos = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            DataDevolucao = new DataGridViewTextBoxColumn();
            CodigoLivro = new DataGridViewTextBoxColumn();
            Unidade = new DataGridViewTextBoxColumn();
            btnVoltar = new Button();
            panel5 = new Panel();
            texPesquisarVisualizacaoEmprestimos = new TextBox();
            labelAtualizacaoEmprestimos = new Label();
            panelLivro = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvVisualizacaoEmprestimos).BeginInit();
            panelLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvVisualizacaoEmprestimos
            // 
            dgvVisualizacaoEmprestimos.BackgroundColor = Color.FromArgb(250, 243, 224);
            dgvVisualizacaoEmprestimos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVisualizacaoEmprestimos.Columns.AddRange(new DataGridViewColumn[] { Codigo, DataDevolucao, CodigoLivro, Unidade });
            dgvVisualizacaoEmprestimos.Location = new Point(51, 124);
            dgvVisualizacaoEmprestimos.Name = "dgvVisualizacaoEmprestimos";
            dgvVisualizacaoEmprestimos.Size = new Size(739, 239);
            dgvVisualizacaoEmprestimos.TabIndex = 207;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            Codigo.Width = 175;
            // 
            // DataDevolucao
            // 
            DataDevolucao.HeaderText = "Data de devoluçao";
            DataDevolucao.Name = "DataDevolucao";
            DataDevolucao.Width = 175;
            // 
            // CodigoLivro
            // 
            CodigoLivro.HeaderText = "Código livro";
            CodigoLivro.Name = "CodigoLivro";
            CodigoLivro.Width = 175;
            // 
            // Unidade
            // 
            Unidade.HeaderText = "Unidade";
            Unidade.Name = "Unidade";
            Unidade.Width = 175;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.DarkRed;
            btnVoltar.Font = new Font("Segoe UI", 12F);
            btnVoltar.ForeColor = Color.FromArgb(250, 243, 224);
            btnVoltar.Location = new Point(350, 400);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(128, 35);
            btnVoltar.TabIndex = 206;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkRed;
            panel5.Location = new Point(219, 101);
            panel5.Name = "panel5";
            panel5.Size = new Size(382, 4);
            panel5.TabIndex = 205;
            // 
            // texPesquisarVisualizacaoEmprestimos
            // 
            texPesquisarVisualizacaoEmprestimos.BackColor = Color.FromArgb(250, 243, 224);
            texPesquisarVisualizacaoEmprestimos.BorderStyle = BorderStyle.None;
            texPesquisarVisualizacaoEmprestimos.Font = new Font("Arial Narrow", 12F);
            texPesquisarVisualizacaoEmprestimos.ForeColor = Color.FromArgb(130, 119, 106);
            texPesquisarVisualizacaoEmprestimos.Location = new Point(214, 76);
            texPesquisarVisualizacaoEmprestimos.Name = "texPesquisarVisualizacaoEmprestimos";
            texPesquisarVisualizacaoEmprestimos.Size = new Size(386, 19);
            texPesquisarVisualizacaoEmprestimos.TabIndex = 204;
            // 
            // labelAtualizacaoEmprestimos
            // 
            labelAtualizacaoEmprestimos.AutoSize = true;
            labelAtualizacaoEmprestimos.Font = new Font("Arial Narrow", 20F);
            labelAtualizacaoEmprestimos.ForeColor = Color.DarkRed;
            labelAtualizacaoEmprestimos.Location = new Point(259, 15);
            labelAtualizacaoEmprestimos.Name = "labelAtualizacaoEmprestimos";
            labelAtualizacaoEmprestimos.Size = new Size(297, 31);
            labelAtualizacaoEmprestimos.TabIndex = 203;
            labelAtualizacaoEmprestimos.Text = "Visualização de empréstimos";
            // 
            // panelLivro
            // 
            panelLivro.BackColor = Color.DarkRed;
            panelLivro.Controls.Add(pictureBox1);
            panelLivro.Location = new Point(0, -5);
            panelLivro.Name = "panelLivro";
            panelLivro.Size = new Size(42, 472);
            panelLivro.TabIndex = 202;
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
            // VisualizacaoEmprestimos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(dgvVisualizacaoEmprestimos);
            Controls.Add(btnVoltar);
            Controls.Add(panel5);
            Controls.Add(texPesquisarVisualizacaoEmprestimos);
            Controls.Add(labelAtualizacaoEmprestimos);
            Controls.Add(panelLivro);
            Name = "VisualizacaoEmprestimos";
            Text = "VisualizacaoEmprestimos";
            Load += VisualizacaoEmprestimos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVisualizacaoEmprestimos).EndInit();
            panelLivro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVisualizacaoEmprestimos;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn DataDevolucao;
        private DataGridViewTextBoxColumn CodigoLivro;
        private DataGridViewTextBoxColumn Unidade;
        private Button btnVoltar;
        private Panel panel5;
        private TextBox texPesquisarVisualizacaoEmprestimos;
        private Label labelAtualizacaoEmprestimos;
        private Panel panelLivro;
        private PictureBox pictureBox1;
    }
}