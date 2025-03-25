namespace Projeto_ViraPagina.View
{
    partial class LoginProjeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginProjeto));
            panelLivro = new Panel();
            PictureLivro = new PictureBox();
            labelLgin = new Label();
            labelEmail = new Label();
            labelSenha = new Label();
            btnCadastrar = new Button();
            textEmail = new TextBox();
            textSenha = new TextBox();
            panelEmail = new Panel();
            panelSenha = new Panel();
            linkSenha = new LinkLabel();
            panelLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureLivro).BeginInit();
            SuspendLayout();
            // 
            // panelLivro
            // 
            panelLivro.BackColor = Color.DarkRed;
            panelLivro.Controls.Add(PictureLivro);
            panelLivro.Location = new Point(0, 0);
            panelLivro.Name = "panelLivro";
            panelLivro.Size = new Size(349, 451);
            panelLivro.TabIndex = 0;
            // 
            // PictureLivro
            // 
            PictureLivro.Image = (Image)resources.GetObject("PictureLivro.Image");
            PictureLivro.InitialImage = null;
            PictureLivro.Location = new Point(12, 84);
            PictureLivro.Name = "PictureLivro";
            PictureLivro.Size = new Size(316, 297);
            PictureLivro.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureLivro.TabIndex = 0;
            PictureLivro.TabStop = false;
            // 
            // labelLgin
            // 
            labelLgin.AutoSize = true;
            labelLgin.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLgin.ForeColor = Color.DarkRed;
            labelLgin.Location = new Point(539, 20);
            labelLgin.Name = "labelLgin";
            labelLgin.Size = new Size(56, 25);
            labelLgin.TabIndex = 1;
            labelLgin.Text = "Login";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.ForeColor = Color.DarkRed;
            labelEmail.Location = new Point(438, 84);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(55, 25);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Email";
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSenha.ForeColor = Color.DarkRed;
            labelSenha.Location = new Point(438, 192);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(63, 25);
            labelSenha.TabIndex = 3;
            labelSenha.Text = "Senha";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.DarkRed;
            btnCadastrar.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.FromArgb(250, 243, 224);
            btnCadastrar.Location = new Point(471, 360);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(260, 39);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // textEmail
            // 
            textEmail.BackColor = Color.FromArgb(250, 243, 224);
            textEmail.BorderStyle = BorderStyle.None;
            textEmail.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textEmail.ForeColor = Color.FromArgb(130, 119, 106);
            textEmail.Location = new Point(438, 123);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(293, 19);
            textEmail.TabIndex = 5;
            // 
            // textSenha
            // 
            textSenha.BackColor = Color.FromArgb(250, 243, 224);
            textSenha.BorderStyle = BorderStyle.None;
            textSenha.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textSenha.ForeColor = Color.FromArgb(130, 119, 106);
            textSenha.Location = new Point(438, 230);
            textSenha.Name = "textSenha";
            textSenha.Size = new Size(293, 19);
            textSenha.TabIndex = 6;
            // 
            // panelEmail
            // 
            panelEmail.BackColor = Color.DarkRed;
            panelEmail.Location = new Point(438, 148);
            panelEmail.Name = "panelEmail";
            panelEmail.Size = new Size(293, 4);
            panelEmail.TabIndex = 7;
            // 
            // panelSenha
            // 
            panelSenha.BackColor = Color.DarkRed;
            panelSenha.Location = new Point(438, 255);
            panelSenha.Name = "panelSenha";
            panelSenha.Size = new Size(293, 4);
            panelSenha.TabIndex = 8;
            // 
            // linkSenha
            // 
            linkSenha.AutoSize = true;
            linkSenha.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkSenha.LinkColor = Color.DarkRed;
            linkSenha.Location = new Point(441, 281);
            linkSenha.Name = "linkSenha";
            linkSenha.Size = new Size(107, 16);
            linkSenha.TabIndex = 9;
            linkSenha.TabStop = true;
            linkSenha.Text = "Esqueci minha senha";
            linkSenha.LinkClicked += linkSenha_LinkClicked;
            // 
            // LoginProjeto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(linkSenha);
            Controls.Add(panelSenha);
            Controls.Add(panelEmail);
            Controls.Add(textSenha);
            Controls.Add(textEmail);
            Controls.Add(btnCadastrar);
            Controls.Add(labelSenha);
            Controls.Add(labelEmail);
            Controls.Add(labelLgin);
            Controls.Add(panelLivro);
            Name = "LoginProjeto";
            Text = "Login";
            panelLivro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureLivro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelLivro;
        private PictureBox PictureLivro;
        private Label labelLgin;
        private Label labelEmail;
        private Label labelSenha;
        private Button btnCadastrar;
        private TextBox textEmail;
        private TextBox textSenha;
        private Panel panelEmail;
        private Panel panelSenha;
        private LinkLabel linkSenha;
    }
}