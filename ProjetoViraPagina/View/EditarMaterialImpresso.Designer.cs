namespace Projeto_ViraPagina.View
{
    partial class EditarMaterialImpresso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarMaterialImpresso));
            labelAcervos = new Label();
            panelLivro = new Panel();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            textId = new TextBox();
            labelIdJogo = new Label();
            brnEditar = new Button();
            btnVoltar = new Button();
            pictureBox2 = new PictureBox();
            panelLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // labelAcervos
            // 
            labelAcervos.AutoSize = true;
            labelAcervos.Font = new Font("Arial Narrow", 20F);
            labelAcervos.ForeColor = Color.DarkRed;
            labelAcervos.Location = new Point(287, 28);
            labelAcervos.Name = "labelAcervos";
            labelAcervos.Size = new Size(248, 31);
            labelAcervos.TabIndex = 16;
            labelAcervos.Text = "Editar material impresso";
            // 
            // panelLivro
            // 
            panelLivro.BackColor = Color.DarkRed;
            panelLivro.Controls.Add(pictureBox1);
            panelLivro.Location = new Point(0, -9);
            panelLivro.Name = "panelLivro";
            panelLivro.Size = new Size(42, 468);
            panelLivro.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 162;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkRed;
            panel5.Location = new Point(274, 221);
            panel5.Name = "panel5";
            panel5.Size = new Size(270, 4);
            panel5.TabIndex = 115;
            // 
            // textId
            // 
            textId.BackColor = Color.FromArgb(250, 243, 224);
            textId.BorderStyle = BorderStyle.None;
            textId.Font = new Font("Arial Narrow", 12F);
            textId.ForeColor = Color.FromArgb(130, 119, 106);
            textId.Location = new Point(278, 196);
            textId.Name = "textId";
            textId.Size = new Size(257, 19);
            textId.TabIndex = 114;
            // 
            // labelIdJogo
            // 
            labelIdJogo.AutoSize = true;
            labelIdJogo.Font = new Font("Arial Narrow", 14F);
            labelIdJogo.ForeColor = Color.DarkRed;
            labelIdJogo.Location = new Point(274, 156);
            labelIdJogo.Name = "labelIdJogo";
            labelIdJogo.Size = new Size(60, 23);
            labelIdJogo.TabIndex = 113;
            labelIdJogo.Text = "Código";
            // 
            // brnEditar
            // 
            brnEditar.BackColor = Color.DarkRed;
            brnEditar.Font = new Font("Segoe UI", 12F);
            brnEditar.ForeColor = Color.FromArgb(250, 243, 224);
            brnEditar.Location = new Point(435, 384);
            brnEditar.Name = "brnEditar";
            brnEditar.Size = new Size(149, 41);
            brnEditar.TabIndex = 161;
            brnEditar.Text = "Editar";
            brnEditar.UseVisualStyleBackColor = false;
            brnEditar.Click += brnEditar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.DarkRed;
            btnVoltar.Font = new Font("Segoe UI", 12F);
            btnVoltar.ForeColor = Color.FromArgb(250, 243, 224);
            btnVoltar.Location = new Point(263, 384);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(149, 41);
            btnVoltar.TabIndex = 160;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(486, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(321, 403);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 163;
            pictureBox2.TabStop = false;
            // 
            // EditarMaterialImpresso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(brnEditar);
            Controls.Add(btnVoltar);
            Controls.Add(panel5);
            Controls.Add(textId);
            Controls.Add(labelIdJogo);
            Controls.Add(labelAcervos);
            Controls.Add(panelLivro);
            Controls.Add(pictureBox2);
            Name = "EditarMaterialImpresso";
            Text = "AtualizacaoMaterialImpressoP0";
            panelLivro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelAcervos;
        private Panel panelLivro;
        private Panel panel5;
        private TextBox textId;
        private Label labelIdJogo;
        private Button brnEditar;
        private Button btnVoltar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}