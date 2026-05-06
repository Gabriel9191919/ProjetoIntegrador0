namespace TelaLogin
{
    partial class EsqueciSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EsqueciSenha));
            pictureBox4 = new PictureBox();
            txtsenha2 = new TextBox();
            lbVoltar = new LinkLabel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtNovaSenha = new TextBox();
            pictureBox3 = new PictureBox();
            txtUsuario = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(785, 603);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 23);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 30;
            pictureBox4.TabStop = false;
            // 
            // txtsenha2
            // 
            txtsenha2.Anchor = AnchorStyles.None;
            txtsenha2.Location = new Point(822, 603);
            txtsenha2.Name = "txtsenha2";
            txtsenha2.PasswordChar = '*';
            txtsenha2.PlaceholderText = "Confirme sua senha";
            txtsenha2.Size = new Size(297, 23);
            txtsenha2.TabIndex = 24;
            // 
            // lbVoltar
            // 
            lbVoltar.ActiveLinkColor = Color.SteelBlue;
            lbVoltar.Anchor = AnchorStyles.None;
            lbVoltar.AutoSize = true;
            lbVoltar.BackColor = Color.Transparent;
            lbVoltar.ForeColor = SystemColors.ActiveCaptionText;
            lbVoltar.LinkColor = Color.Gold;
            lbVoltar.Location = new Point(942, 712);
            lbVoltar.Name = "lbVoltar";
            lbVoltar.Size = new Size(37, 15);
            lbVoltar.TabIndex = 26;
            lbVoltar.TabStop = true;
            lbVoltar.Text = "Voltar";
            lbVoltar.LinkClicked += lbVoltar_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(785, 526);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(785, 565);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Anchor = AnchorStyles.None;
            txtNovaSenha.Location = new Point(822, 565);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.PasswordChar = '*';
            txtNovaSenha.PlaceholderText = "Nova Senha";
            txtNovaSenha.Size = new Size(297, 23);
            txtNovaSenha.TabIndex = 23;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(803, 333);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(316, 140);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 29;
            pictureBox3.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.None;
            txtUsuario.Location = new Point(822, 526);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(297, 23);
            txtUsuario.TabIndex = 22;
            // 
            // EsqueciSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1904, 1041);
            Controls.Add(pictureBox4);
            Controls.Add(txtsenha2);
            Controls.Add(lbVoltar);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(txtNovaSenha);
            Controls.Add(pictureBox3);
            Controls.Add(txtUsuario);
            ForeColor = SystemColors.ControlDarkDark;
            FormBorderStyle = FormBorderStyle.None;
            Name = "EsqueciSenha";
            Text = "EsqueciSenha";
            Load += EsqueciSenha_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RButton btnAlterarSenha;
        private PictureBox pictureBox4;
        private TextBox txtsenha2;
        private LinkLabel lbVoltar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtNovaSenha;
        private PictureBox pictureBox3;
        private TextBox txtUsuario;
    }
}