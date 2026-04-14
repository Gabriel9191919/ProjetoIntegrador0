namespace TelaLogin
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            txtvenc = new TextBox();
            label1 = new Label();
            button1 = new Button();
            txtqtd = new TextBox();
            txtpreco = new TextBox();
            txtproduto = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            rButton1 = new RButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // txtvenc
            // 
            txtvenc.Font = new Font("Segoe UI", 12F);
            txtvenc.Location = new Point(363, 239);
            txtvenc.Name = "txtvenc";
            txtvenc.Size = new Size(193, 29);
            txtvenc.TabIndex = 0;
            txtvenc.KeyPress += txtvenc_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 64);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(117, 64);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtqtd
            // 
            txtqtd.Font = new Font("Segoe UI", 12F);
            txtqtd.Location = new Point(502, 197);
            txtqtd.Name = "txtqtd";
            txtqtd.Size = new Size(41, 29);
            txtqtd.TabIndex = 3;
            txtqtd.TextChanged += textBox2_TextChanged;
            // 
            // txtpreco
            // 
            txtpreco.Font = new Font("Segoe UI", 12F);
            txtpreco.Location = new Point(117, 242);
            txtpreco.Name = "txtpreco";
            txtpreco.Size = new Size(54, 29);
            txtpreco.TabIndex = 4;
            // 
            // txtproduto
            // 
            txtproduto.Font = new Font("Segoe UI", 12F);
            txtproduto.Location = new Point(134, 194);
            txtproduto.Name = "txtproduto";
            txtproduto.Size = new Size(243, 29);
            txtproduto.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(62, 197);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 6;
            label2.Text = "Produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(405, 197);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 7;
            label3.Text = "Quantidade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(209, 245);
            label4.Name = "label4";
            label4.Size = new Size(148, 21);
            label4.TabIndex = 8;
            label4.Text = "Data de vencimento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(62, 242);
            label5.Name = "label5";
            label5.Size = new Size(49, 21);
            label5.TabIndex = 9;
            label5.Text = "Preco";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(209, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(213, 153);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
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
            rButton1.Location = new Point(159, 320);
            rButton1.Name = "rButton1";
            rButton1.Size = new Size(316, 40);
            rButton1.TabIndex = 14;
            rButton1.Text = "Adicionar";
            rButton1.TextColor = SystemColors.ActiveCaptionText;
            rButton1.UseVisualStyleBackColor = false;
            rButton1.Click += rButton1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(618, 407);
            Controls.Add(rButton1);
            Controls.Add(pictureBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtproduto);
            Controls.Add(txtpreco);
            Controls.Add(txtqtd);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtvenc);
            ForeColor = SystemColors.ControlLight;
            Name = "Form3";
            Text = "Adicionar";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtvenc;
        private Label label1;
        private Button button1;
        private TextBox txtqtd;
        private TextBox txtpreco;
        private TextBox txtproduto;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox3;
        private RButton rButton1;
    }
}