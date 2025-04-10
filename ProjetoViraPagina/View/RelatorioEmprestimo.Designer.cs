namespace Projeto_ViraPagina.View
{
    partial class RelatorioEmprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioEmprestimo));
            dgvRelatorioEmprestimo = new DataGridView();
            CodigoLivro = new DataGridViewTextBoxColumn();
            DataDevolucao = new DataGridViewTextBoxColumn();
            CodLivro = new DataGridViewTextBoxColumn();
            Unidade = new DataGridViewTextBoxColumn();
            btnVoltar = new Button();
            panel5 = new Panel();
            texPesquisarRelatorioEmprestimo = new TextBox();
            labelRelatorioEmprestimo = new Label();
            panelLivro = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorioEmprestimo).BeginInit();
            panelLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvRelatorioEmprestimo
            // 
            dgvRelatorioEmprestimo.BackgroundColor = Color.FromArgb(250, 243, 224);
            dgvRelatorioEmprestimo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRelatorioEmprestimo.Columns.AddRange(new DataGridViewColumn[] { CodigoLivro, DataDevolucao, CodLivro, Unidade });
            dgvRelatorioEmprestimo.Location = new Point(51, 124);
            dgvRelatorioEmprestimo.Name = "dgvRelatorioEmprestimo";
            dgvRelatorioEmprestimo.Size = new Size(739, 239);
            dgvRelatorioEmprestimo.TabIndex = 213;
            // 
            // CodigoLivro
            // 
            CodigoLivro.HeaderText = "Código";
            CodigoLivro.Name = "CodigoLivro";
            CodigoLivro.Width = 175;
            // 
            // DataDevolucao
            // 
            DataDevolucao.HeaderText = "Data devolução";
            DataDevolucao.Name = "DataDevolucao";
            DataDevolucao.Width = 175;
            // 
            // CodLivro
            // 
            CodLivro.HeaderText = "Código livro";
            CodLivro.Name = "CodLivro";
            CodLivro.Width = 175;
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
            btnVoltar.Location = new Point(351, 400);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(128, 35);
            btnVoltar.TabIndex = 212;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkRed;
            panel5.Location = new Point(221, 101);
            panel5.Name = "panel5";
            panel5.Size = new Size(382, 4);
            panel5.TabIndex = 211;
            // 
            // texPesquisarRelatorioEmprestimo
            // 
            texPesquisarRelatorioEmprestimo.BackColor = Color.FromArgb(250, 243, 224);
            texPesquisarRelatorioEmprestimo.BorderStyle = BorderStyle.None;
            texPesquisarRelatorioEmprestimo.Font = new Font("Arial Narrow", 12F);
            texPesquisarRelatorioEmprestimo.ForeColor = Color.FromArgb(130, 119, 106);
            texPesquisarRelatorioEmprestimo.Location = new Point(216, 76);
            texPesquisarRelatorioEmprestimo.Name = "texPesquisarRelatorioEmprestimo";
            texPesquisarRelatorioEmprestimo.Size = new Size(386, 19);
            texPesquisarRelatorioEmprestimo.TabIndex = 210;
            // 
            // labelRelatorioEmprestimo
            // 
            labelRelatorioEmprestimo.AutoSize = true;
            labelRelatorioEmprestimo.Font = new Font("Arial Narrow", 20F);
            labelRelatorioEmprestimo.ForeColor = Color.DarkRed;
            labelRelatorioEmprestimo.Location = new Point(273, 15);
            labelRelatorioEmprestimo.Name = "labelRelatorioEmprestimo";
            labelRelatorioEmprestimo.Size = new Size(261, 31);
            labelRelatorioEmprestimo.TabIndex = 209;
            labelRelatorioEmprestimo.Text = "Relatório de empréstimos";
            // 
            // panelLivro
            // 
            panelLivro.BackColor = Color.DarkRed;
            panelLivro.Controls.Add(pictureBox1);
            panelLivro.Location = new Point(0, -5);
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
            // RelatorioEmprestimo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(dgvRelatorioEmprestimo);
            Controls.Add(btnVoltar);
            Controls.Add(panel5);
            Controls.Add(texPesquisarRelatorioEmprestimo);
            Controls.Add(labelRelatorioEmprestimo);
            Controls.Add(panelLivro);
            Name = "RelatorioEmprestimo";
            Text = "RelatorioEmprestimo";
            Load += RelatorioEmprestimo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRelatorioEmprestimo).EndInit();
            panelLivro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRelatorioEmprestimo;
        private DataGridViewTextBoxColumn CodigoLivro;
        private DataGridViewTextBoxColumn DataDevolucao;
        private DataGridViewTextBoxColumn CodLivro;
        private DataGridViewTextBoxColumn Unidade;
        private Button btnVoltar;
        private Panel panel5;
        private TextBox texPesquisarRelatorioEmprestimo;
        private Label labelRelatorioEmprestimo;
        private Panel panelLivro;
        private PictureBox pictureBox1;
    }
}
