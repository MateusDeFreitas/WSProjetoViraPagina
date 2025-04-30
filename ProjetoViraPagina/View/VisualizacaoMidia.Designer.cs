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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizacaoMidia));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelLivro = new Panel();
            pictureBox1 = new PictureBox();
            labelVisualizacaoMidia = new Label();
            panel5 = new Panel();
            texPesquisarVisualizacaoMidia = new TextBox();
            btnVoltar = new Button();
            dgvVisualizacaoMidia = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Título = new DataGridViewTextBoxColumn();
            Diretor = new DataGridViewTextBoxColumn();
            Genero = new DataGridViewTextBoxColumn();
            AnoLancamento = new DataGridViewTextBoxColumn();
            pictureBox2 = new PictureBox();
            pictureBoxLupa = new PictureBox();
            panelLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVisualizacaoMidia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLupa).BeginInit();
            SuspendLayout();
            // 
            // panelLivro
            // 
            panelLivro.BackColor = Color.DarkRed;
            panelLivro.Controls.Add(pictureBox1);
            panelLivro.Location = new Point(-1, -4);
            panelLivro.Name = "panelLivro";
            panelLivro.Size = new Size(42, 472);
            panelLivro.TabIndex = 158;
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
            // labelVisualizacaoMidia
            // 
            labelVisualizacaoMidia.AutoSize = true;
            labelVisualizacaoMidia.Font = new Font("Arial Narrow", 20F);
            labelVisualizacaoMidia.ForeColor = Color.DarkRed;
            labelVisualizacaoMidia.Location = new Point(283, 16);
            labelVisualizacaoMidia.Name = "labelVisualizacaoMidia";
            labelVisualizacaoMidia.Size = new Size(237, 31);
            labelVisualizacaoMidia.TabIndex = 159;
            labelVisualizacaoMidia.Text = "Visualização de mídias";
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkRed;
            panel5.Location = new Point(211, 102);
            panel5.Name = "panel5";
            panel5.Size = new Size(382, 4);
            panel5.TabIndex = 164;
            // 
            // texPesquisarVisualizacaoMidia
            // 
            texPesquisarVisualizacaoMidia.BackColor = Color.FromArgb(250, 243, 224);
            texPesquisarVisualizacaoMidia.BorderStyle = BorderStyle.None;
            texPesquisarVisualizacaoMidia.Font = new Font("Arial Narrow", 12F);
            texPesquisarVisualizacaoMidia.ForeColor = Color.FromArgb(130, 119, 106);
            texPesquisarVisualizacaoMidia.Location = new Point(211, 77);
            texPesquisarVisualizacaoMidia.Name = "texPesquisarVisualizacaoMidia";
            texPesquisarVisualizacaoMidia.Size = new Size(331, 19);
            texPesquisarVisualizacaoMidia.TabIndex = 163;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.DarkRed;
            btnVoltar.Font = new Font("Segoe UI", 12F);
            btnVoltar.ForeColor = Color.FromArgb(250, 243, 224);
            btnVoltar.Location = new Point(351, 401);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(128, 35);
            btnVoltar.TabIndex = 182;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // dgvVisualizacaoMidia
            // 
            dgvVisualizacaoMidia.AllowUserToAddRows = false;
            dgvVisualizacaoMidia.AllowUserToResizeColumns = false;
            dgvVisualizacaoMidia.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(236, 236, 236);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(68, 68, 78);
            dgvVisualizacaoMidia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvVisualizacaoMidia.BackgroundColor = Color.FromArgb(255, 244, 227);
            dgvVisualizacaoMidia.BorderStyle = BorderStyle.None;
            dgvVisualizacaoMidia.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvVisualizacaoMidia.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(222, 162, 117);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(222, 162, 117);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvVisualizacaoMidia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvVisualizacaoMidia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(211, 220, 227);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 0, 0);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvVisualizacaoMidia.DefaultCellStyle = dataGridViewCellStyle3;
            dgvVisualizacaoMidia.EnableHeadersVisualStyles = false;
            dgvVisualizacaoMidia.Location = new Point(51, 126);
            dgvVisualizacaoMidia.Name = "dgvVisualizacaoMidia";
            dgvVisualizacaoMidia.ReadOnly = true;
            dgvVisualizacaoMidia.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(68, 68, 78);
            dgvVisualizacaoMidia.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvVisualizacaoMidia.RowTemplate.Height = 40;
            dgvVisualizacaoMidia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVisualizacaoMidia.Size = new Size(739, 239);
            dgvVisualizacaoMidia.TabIndex = 189;
            dgvVisualizacaoMidia.CellContentClick += dgvVisualizacaoMidia_CellContentClick;
            // 
            // Codigo
            // 
            Codigo.Name = "Codigo";
            // 
            // Título
            // 
            Título.Name = "Título";
            // 
            // Diretor
            // 
            Diretor.Name = "Diretor";
            // 
            // Genero
            // 
            Genero.Name = "Genero";
            // 
            // AnoLancamento
            // 
            AnoLancamento.Name = "AnoLancamento";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(548, 77);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(22, 19);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 193;
            pictureBox2.TabStop = false;
            // 
            // pictureBoxLupa
            // 
            pictureBoxLupa.Image = (Image)resources.GetObject("pictureBoxLupa.Image");
            pictureBoxLupa.Location = new Point(571, 77);
            pictureBoxLupa.Name = "pictureBoxLupa";
            pictureBoxLupa.Size = new Size(22, 19);
            pictureBoxLupa.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLupa.TabIndex = 192;
            pictureBoxLupa.TabStop = false;
            pictureBoxLupa.Click += pictureBoxLupa_Click;
            // 
            // VisualizacaoMidia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBoxLupa);
            Controls.Add(dgvVisualizacaoMidia);
            Controls.Add(btnVoltar);
            Controls.Add(panel5);
            Controls.Add(texPesquisarVisualizacaoMidia);
            Controls.Add(labelVisualizacaoMidia);
            Controls.Add(panelLivro);
            Name = "VisualizacaoMidia";
            Text = "VisualizacaoMidia";
            Load += VisualizacaoMidia_Load;
            panelLivro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVisualizacaoMidia).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLupa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelLivro;
        private Label labelVisualizacaoMidia;
        private Panel panel5;
        private TextBox texPesquisarVisualizacaoMidia;
        private Button btnVoltar;
        private DataGridView dgvVisualizacaoMidia;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Título;
        private DataGridViewTextBoxColumn Diretor;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewTextBoxColumn AnoLancamento;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBoxLupa;
    }
}