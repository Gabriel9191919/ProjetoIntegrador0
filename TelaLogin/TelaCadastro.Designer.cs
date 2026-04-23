namespace TelaLogin
{
    partial class TelaCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastro));
            linkLabel2 = new LinkLabel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtsenha = new TextBox();
            pictureBox3 = new PictureBox();
            txtUsuario = new TextBox();
            pictureBox4 = new PictureBox();
            txtsenha2 = new TextBox();
            rButton1 = new RButton();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.SteelBlue;
            linkLabel2.Anchor = AnchorStyles.None;
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.ForeColor = SystemColors.ActiveCaptionText;
            linkLabel2.LinkColor = Color.Gold;
            linkLabel2.Location = new Point(945, 660);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(38, 15);
            linkLabel2.TabIndex = 5;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Entrar";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
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
            pictureBox1.TabIndex = 17;
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
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // txtsenha
            // 
            txtsenha.Anchor = AnchorStyles.None;
            txtsenha.Location = new Point(826, 533);
            txtsenha.Name = "txtsenha";
            txtsenha.PasswordChar = '*';
            txtsenha.PlaceholderText = "Senha";
            txtsenha.Size = new Size(297, 23);
            txtsenha.TabIndex = 2;
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
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.None;
            txtUsuario.Location = new Point(826, 494);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(297, 23);
            txtUsuario.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(789, 571);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 23);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 21;
            pictureBox4.TabStop = false;
            // 
            // txtsenha2
            // 
            txtsenha2.Anchor = AnchorStyles.None;
            txtsenha2.Location = new Point(826, 571);
            txtsenha2.Name = "txtsenha2";
            txtsenha2.PasswordChar = '*';
            txtsenha2.PlaceholderText = "Confirme sua senha";
            txtsenha2.Size = new Size(297, 23);
            txtsenha2.TabIndex = 3;
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
            rButton1.Location = new Point(807, 617);
            rButton1.Name = "rButton1";
            rButton1.Size = new Size(316, 40);
            rButton1.TabIndex = 4;
            rButton1.Text = "Cadastrar";
            rButton1.TextColor = SystemColors.ActiveCaptionText;
            rButton1.UseVisualStyleBackColor = false;
            rButton1.Click += rButton1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(1713, 1047);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 23;
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
            pictureBox5.TabIndex = 24;
            pictureBox5.TabStop = false;
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1920, 1080);
            Controls.Add(label1);
            Controls.Add(pictureBox5);
            Controls.Add(rButton1);
            Controls.Add(pictureBox4);
            Controls.Add(txtsenha2);
            Controls.Add(linkLabel2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(txtsenha);
            Controls.Add(pictureBox3);
            Controls.Add(txtUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TelaCadastro";
            Text = "TelaCadastro";
            Load += TelaCadastro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtsenha;
        private PictureBox pictureBox3;
        private TextBox txtUsuario;
        private PictureBox pictureBox4;
        private TextBox txtsenha2;
        private RButton rButton1;
        private Label label1;
        private PictureBox pictureBox5;
    }
}