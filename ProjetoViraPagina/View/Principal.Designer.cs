namespace Projeto_ViraPagina.View
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            panelLivro = new Panel();
            PictureLivro = new PictureBox();
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
            panelLivro.Size = new Size(262, 451);
            panelLivro.TabIndex = 1;
            // 
            // PictureLivro
            // 
            PictureLivro.Image = (Image)resources.GetObject("PictureLivro.Image");
            PictureLivro.InitialImage = null;
            PictureLivro.Location = new Point(12, 104);
            PictureLivro.Name = "PictureLivro";
            PictureLivro.Size = new Size(230, 234);
            PictureLivro.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureLivro.TabIndex = 0;
            PictureLivro.TabStop = false;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(panelLivro);
            Name = "Principal";
            Text = "Principal";
            panelLivro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureLivro).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLivro;
        private PictureBox PictureLivro;
    }
}