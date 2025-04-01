namespace Projeto_ViraPagina.View
{
    partial class EditarInstrumentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarInstrumentos));
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
            panel5.Location = new Point(270, 215);
            panel5.Name = "panel5";
            panel5.Size = new Size(270, 4);
            panel5.TabIndex = 139;
            // 
            // textIdJogo
            // 
            textIdJogo.BackColor = Color.FromArgb(250, 243, 224);
            textIdJogo.BorderStyle = BorderStyle.None;
            textIdJogo.Font = new Font("Arial Narrow", 12F);
            textIdJogo.ForeColor = Color.FromArgb(130, 119, 106);
            textIdJogo.Location = new Point(274, 190);
            textIdJogo.Name = "textIdJogo";
            textIdJogo.Size = new Size(257, 19);
            textIdJogo.TabIndex = 138;
            // 
            // labelIdJogo
            // 
            labelIdJogo.AutoSize = true;
            labelIdJogo.Font = new Font("Arial Narrow", 14F);
            labelIdJogo.ForeColor = Color.DarkRed;
            labelIdJogo.Location = new Point(270, 150);
            labelIdJogo.Name = "labelIdJogo";
            labelIdJogo.Size = new Size(60, 23);
            labelIdJogo.TabIndex = 137;
            labelIdJogo.Text = "Código";
            // 
            // labelAcervos
            // 
            labelAcervos.AutoSize = true;
            labelAcervos.Font = new Font("Arial Narrow", 20F);
            labelAcervos.ForeColor = Color.DarkRed;
            labelAcervos.Location = new Point(298, 12);
            labelAcervos.Name = "labelAcervos";
            labelAcervos.Size = new Size(190, 31);
            labelAcervos.TabIndex = 135;
            labelAcervos.Text = "Editar instrumento";
            // 
            // panelLivro
            // 
            panelLivro.BackColor = Color.DarkRed;
            panelLivro.Controls.Add(pictureBox1);
            panelLivro.Location = new Point(0, -9);
            panelLivro.Name = "panelLivro";
            panelLivro.Size = new Size(42, 468);
            panelLivro.TabIndex = 134;
            // 
            // brnEditar
            // 
            brnEditar.BackColor = Color.DarkRed;
            brnEditar.Font = new Font("Segoe UI", 12F);
            brnEditar.ForeColor = Color.FromArgb(250, 243, 224);
            brnEditar.Location = new Point(420, 385);
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
            btnVoltar.Location = new Point(248, 385);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(149, 41);
            btnVoltar.TabIndex = 158;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(420, -9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(381, 459);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 160;
            pictureBox2.TabStop = false;
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
            // 
            // EditarInstrumentos
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
            Name = "EditarInstrumentos";
            Text = "AtualizacaoInstrumentosP0";
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
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}