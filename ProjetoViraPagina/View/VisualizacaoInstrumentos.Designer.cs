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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            pictureBox2 = new PictureBox();
            pictureBoxLupa = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvVisualizacaoInstrumentos).BeginInit();
            panelLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLupa).BeginInit();
            SuspendLayout();
            // 
            // dgvVisualizacaoInstrumentos
            // 
            dgvVisualizacaoInstrumentos.AllowUserToAddRows = false;
            dgvVisualizacaoInstrumentos.AllowUserToResizeColumns = false;
            dgvVisualizacaoInstrumentos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(236, 236, 236);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(68, 68, 78);
            dgvVisualizacaoInstrumentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvVisualizacaoInstrumentos.BackgroundColor = Color.FromArgb(255, 244, 227);
            dgvVisualizacaoInstrumentos.BorderStyle = BorderStyle.None;
            dgvVisualizacaoInstrumentos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvVisualizacaoInstrumentos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(222, 162, 117);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(222, 162, 117);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvVisualizacaoInstrumentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvVisualizacaoInstrumentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(211, 220, 227);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 0, 0);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvVisualizacaoInstrumentos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvVisualizacaoInstrumentos.EnableHeadersVisualStyles = false;
            dgvVisualizacaoInstrumentos.Location = new Point(51, 126);
            dgvVisualizacaoInstrumentos.Name = "dgvVisualizacaoInstrumentos";
            dgvVisualizacaoInstrumentos.ReadOnly = true;
            dgvVisualizacaoInstrumentos.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(68, 68, 78);
            dgvVisualizacaoInstrumentos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvVisualizacaoInstrumentos.RowTemplate.Height = 40;
            dgvVisualizacaoInstrumentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVisualizacaoInstrumentos.Size = new Size(739, 239);
            dgvVisualizacaoInstrumentos.TabIndex = 189;
            dgvVisualizacaoInstrumentos.CellContentClick += dgvVisualizacaoInstrumentos_CellContentClick;
            // 
            // Codigo
            // 
            Codigo.Name = "Codigo";
            // 
            // Categoria
            // 
            Categoria.Name = "Categoria";
            // 
            // Marca
            // 
            Marca.Name = "Marca";
            // 
            // Modelo
            // 
            Modelo.Name = "Modelo";
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
            btnVoltar.Click += btnVoltar_Click;
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
            texPesquisarVisualizacaoInstrumentos.Location = new Point(217, 76);
            texPesquisarVisualizacaoInstrumentos.Name = "texPesquisarVisualizacaoInstrumentos";
            texPesquisarVisualizacaoInstrumentos.Size = new Size(331, 19);
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
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(554, 76);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(22, 19);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 196;
            pictureBox2.TabStop = false;
            // 
            // pictureBoxLupa
            // 
            pictureBoxLupa.Image = (Image)resources.GetObject("pictureBoxLupa.Image");
            pictureBoxLupa.Location = new Point(577, 76);
            pictureBoxLupa.Name = "pictureBoxLupa";
            pictureBoxLupa.Size = new Size(22, 19);
            pictureBoxLupa.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLupa.TabIndex = 195;
            pictureBoxLupa.TabStop = false;
            pictureBoxLupa.Click += pictureBoxLupa_Click;
            // 
            // VisualizacaoInstrumentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBoxLupa);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLupa).EndInit();
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
        private PictureBox pictureBox2;
        private PictureBox pictureBoxLupa;
    }
}