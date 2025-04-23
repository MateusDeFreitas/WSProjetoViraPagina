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
            panel5 = new Panel();
            textTipoPenalidade = new TextBox();
            labelTipoPenalidade = new Label();
            btnOk = new Button();
            btnCancelar = new Button();
            pictureBox1 = new PictureBox();
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
            // panel5
            // 
            panel5.BackColor = Color.DarkRed;
            panel5.Location = new Point(100, 105);
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
            textTipoPenalidade.Location = new Point(95, 80);
            textTipoPenalidade.Name = "textTipoPenalidade";
            textTipoPenalidade.Size = new Size(386, 19);
            textTipoPenalidade.TabIndex = 212;
            // 
            // labelTipoPenalidade
            // 
            labelTipoPenalidade.AutoSize = true;
            labelTipoPenalidade.Font = new Font("Arial Narrow", 20F);
            labelTipoPenalidade.ForeColor = Color.DarkRed;
            labelTipoPenalidade.Location = new Point(177, 20);
            labelTipoPenalidade.Name = "labelTipoPenalidade";
            labelTipoPenalidade.Size = new Size(199, 31);
            labelTipoPenalidade.TabIndex = 214;
            labelTipoPenalidade.Text = "Tipo de penalidade";
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.DarkRed;
            btnOk.Font = new Font("Segoe UI", 12F);
            btnOk.ForeColor = Color.FromArgb(250, 243, 224);
            btnOk.Location = new Point(143, 200);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(128, 35);
            btnOk.TabIndex = 215;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkRed;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.ForeColor = Color.FromArgb(250, 243, 224);
            btnCancelar.Location = new Point(283, 200);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(128, 35);
            btnCancelar.TabIndex = 216;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // VisualizacaoTipoPenalidade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 224);
            ClientSize = new Size(546, 250);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
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
        private Button btnOk;
        private Button btnCancelar;
        private PictureBox pictureBox1;
    }
}