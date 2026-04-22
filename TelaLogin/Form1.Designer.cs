namespace TelaLogin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtUsuario = new TextBox();
            linkLabel1 = new LinkLabel();
            checkBox1 = new CheckBox();
            txtSenha = new TextBox();
            rButton1 = new RButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            button1 = new Button();
            btnCadastrar = new RButton();
            btnOlho = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.None;
            txtUsuario.Location = new Point(826, 494);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(297, 23);
            txtUsuario.TabIndex = 1;
            txtUsuario.KeyDown += txtUsuario_KeyDown;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.SteelBlue;
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.ForeColor = Color.Gold;
            linkLabel1.LinkColor = Color.Gold;
            linkLabel1.Location = new Point(1015, 579);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(90, 15);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Esqueci a senha";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.None;
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.ForeColor = Color.Gold;
            checkBox1.Location = new Point(807, 579);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(92, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Lembrar-me";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.None;
            txtSenha.Location = new Point(826, 533);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(297, 23);
            txtSenha.TabIndex = 4;
            txtSenha.KeyDown += txtSenha_KeyDown;
            // 
            // rButton1
            // 
            rButton1.Anchor = AnchorStyles.None;
            rButton1.BackColor = Color.Gold;
            rButton1.BackgroundColor = Color.Gold;
            rButton1.BorderColor = Color.PaleVioletRed;
            rButton1.BorderRadius = 20;
            rButton1.BorderSize = 0;
            rButton1.Cursor = Cursors.Hand;
            rButton1.FlatAppearance.BorderSize = 0;
            rButton1.FlatStyle = FlatStyle.Flat;
            rButton1.ForeColor = SystemColors.ActiveCaptionText;
            rButton1.Location = new Point(807, 608);
            rButton1.Name = "rButton1";
            rButton1.Size = new Size(316, 40);
            rButton1.TabIndex = 8;
            rButton1.Text = "Entrar";
            rButton1.TextColor = SystemColors.ActiveCaptionText;
            rButton1.UseVisualStyleBackColor = false;
            rButton1.Click += rButton1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(789, 494);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(789, 533);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
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
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(1713, 1047);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 12;
            label1.Text = "Powered by";
            label1.Click += label1_Click_1;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1724, 985);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(256, 120);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(936, 730);
            button1.Name = "button1";
            button1.Size = new Size(56, 29);
            button1.TabIndex = 25;
            button1.Text = "SAIR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.None;
            btnCadastrar.BackColor = Color.Gold;
            btnCadastrar.BackgroundColor = Color.Gold;
            btnCadastrar.BorderColor = Color.PaleVioletRed;
            btnCadastrar.BorderRadius = 20;
            btnCadastrar.BorderSize = 0;
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.ForeColor = SystemColors.ActiveCaptionText;
            btnCadastrar.Location = new Point(807, 666);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(316, 40);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastro";
            btnCadastrar.TextColor = SystemColors.ActiveCaptionText;
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnOlho
            // 
            btnOlho.Anchor = AnchorStyles.None;
            btnOlho.BackColor = Color.Transparent;
            btnOlho.BackgroundImage = (Image)resources.GetObject("btnOlho.BackgroundImage");
            btnOlho.BackgroundImageLayout = ImageLayout.Stretch;
            btnOlho.FlatAppearance.BorderSize = 0;
            btnOlho.FlatStyle = FlatStyle.Flat;
            btnOlho.ForeColor = Color.Transparent;
            btnOlho.Location = new Point(1129, 532);
            btnOlho.Name = "btnOlho";
            btnOlho.Size = new Size(24, 24);
            btnOlho.TabIndex = 26;
            btnOlho.UseVisualStyleBackColor = false;
            btnOlho.Click += btnOlho_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1920, 1080);
            Controls.Add(btnOlho);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnCadastrar);
            Controls.Add(rButton1);
            Controls.Add(pictureBox2);
            Controls.Add(txtSenha);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox3);
            Controls.Add(linkLabel1);
            Controls.Add(txtUsuario);
            Controls.Add(pictureBox4);
            ForeColor = Color.Yellow;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUsuario;
        private LinkLabel linkLabel1;
        private CheckBox checkBox1;
        private TextBox txtSenha;
        private RButton rButton1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox pictureBox4;
        private Button button1;
        private RButton btnCadastrar;
        private Button button2;
        private Button btnOlho;
    }
}
