namespace Projeto_ViraPagina.View
{
    partial class EditarMidia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarMidia));
            panel5 = new Panel();
            textIdJogo = new TextBox();
            labelIdJogo = new Label();
            labelAcervos = new Label();
            panelLivro = new Panel();
            brnEditar = new Button();
            btnVoltar = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panelLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkRed;
            panel5.Location = new Point(273, 216);
            panel5.Name = "panel5";
            panel5.Size = new Size(270, 4);
            panel5.TabIndex = 131;
            // 
            // textIdJogo
            // 
            textIdJogo.BackColor = Color.FromArgb(250, 243, 224);
            textIdJogo.BorderStyle = BorderStyle.None;
            textIdJogo.Font = new Font("Arial Narrow", 12F);
            textIdJogo.ForeColor = Color.FromArgb(130, 119, 106);
            textIdJogo.Location = new Point(277, 191);
            textIdJogo.Name = "textIdJogo";
            textIdJogo.Size = new Size(257, 19);
            textIdJogo.TabIndex = 130;
            // 
            // labelIdJogo
            // 
            labelIdJogo.AutoSize = true;
            labelIdJogo.Font = new Font("Arial Narrow", 14F);
            labelIdJogo.ForeColor = Color.DarkRed;
            labelIdJogo.Location = new Point(273, 151);
            labelIdJogo.Name = "labelIdJogo";
            labelIdJogo.Size = new Size(60, 23);
            labelIdJogo.TabIndex = 129;
            labelIdJogo.Text = "Código";
            // 
            // labelAcervos
            // 
            labelAcervos.AutoSize = true;
            labelAcervos.Font = new Font("Arial Narrow", 20F);
            labelAcervos.ForeColor = Color.DarkRed;
            labelAcervos.Location = new Point(335, 20);
            labelAcervos.Name = "labelAcervos";
            labelAcervos.Size = new Size(130, 31);
            labelAcervos.TabIndex = 127;
            labelAcervos.Text = "Editar mídia";
            // 
            // panelLivro
            // 
            panelLivro.BackColor = Color.DarkRed;
            panelLivro.Controls.Add(pictureBox1);
            panelLivro.Location = new Point(0, -9);
            panelLivro.Name = "panelLivro";
            panelLivro.Size = new Size(42, 468);
            panelLivro.TabIndex = 126;
            // 
            // brnEditar
            // 
            brnEditar.BackColor = Color.DarkRed;
            brnEditar.Font = new Font("Segoe UI", 12F);
            brnEditar.ForeColor = Color.FromArgb(250, 243, 224);
            brnEditar.Location = new Point(413, 371);
            brnEditar.Name = "brnEditar";
            brnEditar.Size = new Size(149, 41);
            brnEditar.TabIndex = 159;
            brnEditar.Text = "Editar";
            brnEditar.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.DarkRed;
            btnVoltar.Font = new Font("Segoe UI", 12F);
            btnVoltar.ForeColor = Color.FromArgb(250, 243, 224);
            btnVoltar.Location = new Point(241, 371);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(149, 41);
            btnVoltar.TabIndex = 158;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(391, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(425, 427);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 161;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 160;
            pictureBox1.TabStop = false;
            // 
            // EditarMidia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(brnEditar);
            Controls.Add(btnVoltar);
            Controls.Add(panel5);
            Controls.Add(textIdJogo);
            Controls.Add(labelIdJogo);
            Controls.Add(labelAcervos);
            Controls.Add(panelLivro);
            Controls.Add(pictureBox2);
            Name = "EditarMidia";
            Text = "AtualizacaoMidiaP0";
            panelLivro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel5;
        private TextBox textIdJogo;
        private Label labelIdJogo;
        private Label labelAcervos;
        private Panel panelLivro;
        private Button brnEditar;
        private Button btnVoltar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}