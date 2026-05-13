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
            btnAlterar = new RButton();
            button9 = new Button();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(797, 580);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 23);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 30;
            pictureBox4.TabStop = false;
            // 
            // txtsenha2
            // 
            txtsenha2.Anchor = AnchorStyles.None;
            txtsenha2.Location = new Point(834, 580);
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
            lbVoltar.Location = new Point(968, 689);
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
            pictureBox1.Location = new Point(797, 503);
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
            pictureBox2.Location = new Point(797, 542);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Anchor = AnchorStyles.None;
            txtNovaSenha.Location = new Point(834, 542);
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
            pictureBox3.Location = new Point(807, 301);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(316, 140);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 29;
            pictureBox3.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.None;
            txtUsuario.Location = new Point(834, 503);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(297, 23);
            txtUsuario.TabIndex = 22;
            // 
            // btnAlterar
            // 
            btnAlterar.Anchor = AnchorStyles.None;
            btnAlterar.BackColor = Color.Gold;
            btnAlterar.BackgroundColor = Color.Gold;
            btnAlterar.BorderColor = Color.PaleVioletRed;
            btnAlterar.BorderRadius = 20;
            btnAlterar.BorderSize = 0;
            btnAlterar.Cursor = Cursors.Hand;
            btnAlterar.FlatAppearance.BorderSize = 0;
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.ForeColor = SystemColors.ActiveCaptionText;
            btnAlterar.Location = new Point(834, 627);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(297, 40);
            btnAlterar.TabIndex = 31;
            btnAlterar.Text = "Alterar senha";
            btnAlterar.TextColor = SystemColors.ActiveCaptionText;
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.DimGray;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.Red;
            button9.Location = new Point(1852, 12);
            button9.Name = "button9";
            button9.Size = new Size(56, 29);
            button9.TabIndex = 32;
            button9.Text = "SAIR";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(1713, 1047);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 33;
            label1.Text = "Powered by";
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1724, 985);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(256, 120);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 34;
            pictureBox5.TabStop = false;
            // 
            // EsqueciSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1920, 1080);
            Controls.Add(label1);
            Controls.Add(pictureBox5);
            Controls.Add(button9);
            Controls.Add(btnAlterar);
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EsqueciSenha";
            Load += EsqueciSenha_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
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
        private RButton btnAlterar;
        private Button button9;
        private Label label1;
        private PictureBox pictureBox5;
    }
}