namespace Projeto_ViraPagina.View
{
    partial class VisualizacaoHistoricoTomador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizacaoHistoricoTomador));
            dgvVisualizacaoHistoricoTomador = new DataGridView();
            btnVoltar = new Button();
            labelHistoricoTomador = new Label();
            panelLivro = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvVisualizacaoHistoricoTomador).BeginInit();
            panelLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvVisualizacaoHistoricoTomador
            // 
            dgvVisualizacaoHistoricoTomador.AllowUserToAddRows = false;
            dgvVisualizacaoHistoricoTomador.AllowUserToDeleteRows = false;
            dgvVisualizacaoHistoricoTomador.AllowUserToResizeColumns = false;
            dgvVisualizacaoHistoricoTomador.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(236, 236, 236);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(68, 68, 78);
            dgvVisualizacaoHistoricoTomador.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvVisualizacaoHistoricoTomador.BackgroundColor = Color.FromArgb(250, 243, 224);
            dgvVisualizacaoHistoricoTomador.BorderStyle = BorderStyle.None;
            dgvVisualizacaoHistoricoTomador.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvVisualizacaoHistoricoTomador.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(222, 162, 117);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(222, 162, 117);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvVisualizacaoHistoricoTomador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvVisualizacaoHistoricoTomador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(211, 220, 227);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 0, 0);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvVisualizacaoHistoricoTomador.DefaultCellStyle = dataGridViewCellStyle3;
            dgvVisualizacaoHistoricoTomador.EnableHeadersVisualStyles = false;
            dgvVisualizacaoHistoricoTomador.Location = new Point(49, 113);
            dgvVisualizacaoHistoricoTomador.Name = "dgvVisualizacaoHistoricoTomador";
            dgvVisualizacaoHistoricoTomador.ReadOnly = true;
            dgvVisualizacaoHistoricoTomador.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(68, 68, 78);
            dgvVisualizacaoHistoricoTomador.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvVisualizacaoHistoricoTomador.RowTemplate.Height = 40;
            dgvVisualizacaoHistoricoTomador.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVisualizacaoHistoricoTomador.Size = new Size(739, 239);
            dgvVisualizacaoHistoricoTomador.TabIndex = 213;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.DarkRed;
            btnVoltar.Font = new Font("Segoe UI", 12F);
            btnVoltar.ForeColor = Color.FromArgb(250, 243, 224);
            btnVoltar.Location = new Point(350, 398);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(128, 35);
            btnVoltar.TabIndex = 212;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // labelHistoricoTomador
            // 
            labelHistoricoTomador.AutoSize = true;
            labelHistoricoTomador.Font = new Font("Arial Narrow", 20F);
            labelHistoricoTomador.ForeColor = Color.DarkRed;
            labelHistoricoTomador.Location = new Point(326, 13);
            labelHistoricoTomador.Name = "labelHistoricoTomador";
            labelHistoricoTomador.Size = new Size(166, 31);
            labelHistoricoTomador.TabIndex = 209;
            labelHistoricoTomador.Text = "*Nome tomador";
            // 
            // panelLivro
            // 
            panelLivro.BackColor = Color.DarkRed;
            panelLivro.Controls.Add(pictureBox1);
            panelLivro.Location = new Point(0, -7);
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
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // VisualizacaoHistoricoTomador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(dgvVisualizacaoHistoricoTomador);
            Controls.Add(btnVoltar);
            Controls.Add(labelHistoricoTomador);
            Controls.Add(panelLivro);
            Name = "VisualizacaoHistoricoTomador";
            Text = "VisualizacaoHistoricoTomador";
            ((System.ComponentModel.ISupportInitialize)dgvVisualizacaoHistoricoTomador).EndInit();
            panelLivro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVisualizacaoHistoricoTomador;
        private Button btnVoltar;
        private Label labelHistoricoTomador;
        private Panel panelLivro;
        private PictureBox pictureBox1;
    }
}