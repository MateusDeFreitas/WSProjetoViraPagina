namespace Projeto_ViraPagina.View
{
    partial class VisualizacaoTipoPenalidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizacaoTipoPenalidade));
            panelLivro = new Panel();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            textTipoPenalidade = new TextBox();
            labelTipoPenalidade = new Label();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            panelLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelLivro
            // 
            panelLivro.BackColor = Color.DarkRed;
            panelLivro.Controls.Add(pictureBox1);
            panelLivro.Location = new Point(-1, -8);
            panelLivro.Name = "panelLivro";
            panelLivro.Size = new Size(42, 262);
            panelLivro.TabIndex = 209;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkRed;
            panel5.Location = new Point(102, 136);
            panel5.Name = "panel5";
            panel5.Size = new Size(382, 4);
            panel5.TabIndex = 213;
            // 
            // textTipoPenalidade
            // 
            textTipoPenalidade.BackColor = Color.FromArgb(250, 243, 224);
            textTipoPenalidade.BorderStyle = BorderStyle.None;
            textTipoPenalidade.Font = new Font("Arial Narrow", 12F);
            textTipoPenalidade.ForeColor = Color.FromArgb(130, 119, 106);
            textTipoPenalidade.Location = new Point(102, 111);
            textTipoPenalidade.Name = "textTipoPenalidade";
            textTipoPenalidade.Size = new Size(381, 19);
            textTipoPenalidade.TabIndex = 212;
            // 
            // labelTipoPenalidade
            // 
            labelTipoPenalidade.AutoSize = true;
            labelTipoPenalidade.Font = new Font("Arial Narrow", 20F);
            labelTipoPenalidade.ForeColor = Color.DarkRed;
            labelTipoPenalidade.Location = new Point(192, 20);
            labelTipoPenalidade.Name = "labelTipoPenalidade";
            labelTipoPenalidade.Size = new Size(199, 31);
            labelTipoPenalidade.TabIndex = 214;
            labelTipoPenalidade.Text = "Tipo de penalidade";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.DarkRed;
            btnConfirmar.Font = new Font("Segoe UI", 12F);
            btnConfirmar.ForeColor = Color.FromArgb(250, 243, 224);
            btnConfirmar.Location = new Point(287, 203);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(128, 35);
            btnConfirmar.TabIndex = 215;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkRed;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.ForeColor = Color.FromArgb(250, 243, 224);
            btnCancelar.Location = new Point(153, 203);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(128, 35);
            btnCancelar.TabIndex = 216;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // VisualizacaoTipoPenalidade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 224);
            ClientSize = new Size(546, 250);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(labelTipoPenalidade);
            Controls.Add(panel5);
            Controls.Add(textTipoPenalidade);
            Controls.Add(panelLivro);
            Name = "VisualizacaoTipoPenalidade";
            Text = "VisualizacaoTipoPenalidade";
            panelLivro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelLivro;
        private Panel panel5;
        private TextBox textTipoPenalidade;
        private Label labelTipoPenalidade;
        private Button btnConfirmar;
        private Button btnCancelar;
        private PictureBox pictureBox1;
    }
}