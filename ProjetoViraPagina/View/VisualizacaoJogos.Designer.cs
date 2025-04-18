using System.Windows.Forms;

namespace Projeto_ViraPagina.View
{
    partial class VisualizacaoJogos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizacaoJogos));
            dgvVisualizacaoJogos = new DataGridView();
            btnVoltar = new Button();
            panel5 = new Panel();
            texPesquisarVisualizacaoJogos = new TextBox();
            labelAtualizacaoJogos = new Label();
            panelLivro = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvVisualizacaoJogos).BeginInit();
            panelLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvVisualizacaoJogos
            // 
            dgvVisualizacaoJogos.AllowUserToAddRows = false;
            dgvVisualizacaoJogos.AllowUserToDeleteRows = false;
            dgvVisualizacaoJogos.AllowUserToResizeColumns = false;
            dgvVisualizacaoJogos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(236, 236, 236);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(68, 68, 78);
            dgvVisualizacaoJogos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvVisualizacaoJogos.BackgroundColor = Color.FromArgb(250, 243, 224);
            dgvVisualizacaoJogos.BorderStyle = BorderStyle.None;
            dgvVisualizacaoJogos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvVisualizacaoJogos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(222, 162, 117);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(222, 162, 117);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvVisualizacaoJogos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvVisualizacaoJogos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(211, 220, 227);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 0, 0);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvVisualizacaoJogos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvVisualizacaoJogos.EnableHeadersVisualStyles = false;
            dgvVisualizacaoJogos.Location = new Point(51, 124);
            dgvVisualizacaoJogos.Name = "dgvVisualizacaoJogos";
            dgvVisualizacaoJogos.ReadOnly = true;
            dgvVisualizacaoJogos.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(68, 68, 78);
            dgvVisualizacaoJogos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvVisualizacaoJogos.RowTemplate.Height = 40;
            dgvVisualizacaoJogos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVisualizacaoJogos.Size = new Size(739, 239);
            dgvVisualizacaoJogos.TabIndex = 189;
            dgvVisualizacaoJogos.CellContentClick += dgvVisualizacaoJogos_CellContentClick;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.DarkRed;
            btnVoltar.Font = new Font("Segoe UI", 12F);
            btnVoltar.ForeColor = Color.FromArgb(250, 243, 224);
            btnVoltar.Location = new Point(348, 400);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(128, 35);
            btnVoltar.TabIndex = 188;
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
            panel5.TabIndex = 187;
            // 
            // texPesquisarVisualizacaoJogos
            // 
            texPesquisarVisualizacaoJogos.BackColor = Color.FromArgb(250, 243, 224);
            texPesquisarVisualizacaoJogos.BorderStyle = BorderStyle.None;
            texPesquisarVisualizacaoJogos.Font = new Font("Arial Narrow", 12F);
            texPesquisarVisualizacaoJogos.ForeColor = Color.FromArgb(130, 119, 106);
            texPesquisarVisualizacaoJogos.Location = new Point(212, 76);
            texPesquisarVisualizacaoJogos.Name = "texPesquisarVisualizacaoJogos";
            texPesquisarVisualizacaoJogos.Size = new Size(386, 19);
            texPesquisarVisualizacaoJogos.TabIndex = 186;
            // 
            // labelAtualizacaoJogos
            // 
            labelAtualizacaoJogos.AutoSize = true;
            labelAtualizacaoJogos.Font = new Font("Arial Narrow", 20F);
            labelAtualizacaoJogos.ForeColor = Color.DarkRed;
            labelAtualizacaoJogos.Location = new Point(285, 15);
            labelAtualizacaoJogos.Name = "labelAtualizacaoJogos";
            labelAtualizacaoJogos.Size = new Size(225, 31);
            labelAtualizacaoJogos.TabIndex = 185;
            labelAtualizacaoJogos.Text = "Visualização de jogos";
            // 
            // panelLivro
            // 
            panelLivro.BackColor = Color.DarkRed;
            panelLivro.Controls.Add(pictureBox1);
            panelLivro.Location = new Point(-1, -5);
            panelLivro.Name = "panelLivro";
            panelLivro.Size = new Size(42, 472);
            panelLivro.TabIndex = 184;
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
            // VisualizacaoJogos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(dgvVisualizacaoJogos);
            Controls.Add(btnVoltar);
            Controls.Add(panel5);
            Controls.Add(texPesquisarVisualizacaoJogos);
            Controls.Add(labelAtualizacaoJogos);
            Controls.Add(panelLivro);
            Name = "VisualizacaoJogos";
            Text = "VisualizacaoJogos";
            Load += VisualizacaoJogos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVisualizacaoJogos).EndInit();
            panelLivro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVisualizacaoJogos;
        private Button btnVoltar;
        private Panel panel5;
        private TextBox texPesquisarVisualizacaoJogos;
        private Label labelAtualizacaoJogos;
        private Panel panelLivro;
        private PictureBox pictureBox1;
    }
}