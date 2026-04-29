namespace TelaLogin
{
    partial class TelaEstoque
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEstoque));
            dataGridView1 = new DataGridView();
            button1 = new Button();
            txtPesquisa = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            Painel_Principal = new Panel();
            label3 = new Label();
            button5 = new Button();
            label2 = new Label();
            button4 = new Button();
            pictureBox2 = new PictureBox();
            button6 = new Button();
            btnAdicionar = new Button();
            btnRemover = new Button();
            button9 = new Button();
            rButton2 = new RButton();
            BtnDelete = new RButton();
            lbRelogio = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            notifyIcon1 = new NotifyIcon(components);
            panel1 = new Panel();
            LbNome = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            Painel_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(646, 436);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(594, 369);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 29;
            // 
            // txtPesquisa
            // 
            txtPesquisa.BorderStyle = BorderStyle.None;
            txtPesquisa.Font = new Font("Segoe UI", 12F);
            txtPesquisa.Location = new Point(1051, 408);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(156, 22);
            txtPesquisa.TabIndex = 4;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(1213, 408);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(863, 317);
            label1.Name = "label1";
            label1.Size = new Size(130, 35);
            label1.TabIndex = 6;
            label1.Text = "ESTOQUE";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(815, 161);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(213, 153);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // Painel_Principal
            // 
            Painel_Principal.BackColor = Color.Gold;
            Painel_Principal.Controls.Add(label3);
            Painel_Principal.Controls.Add(button5);
            Painel_Principal.Controls.Add(label2);
            Painel_Principal.Controls.Add(button4);
            Painel_Principal.Controls.Add(pictureBox2);
            Painel_Principal.Controls.Add(button6);
            Painel_Principal.Dock = DockStyle.Left;
            Painel_Principal.Location = new Point(0, 0);
            Painel_Principal.Name = "Painel_Principal";
            Painel_Principal.Size = new Size(184, 1080);
            Painel_Principal.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(69, 224);
            label3.Name = "label3";
            label3.Size = new Size(68, 32);
            label3.TabIndex = 17;
            label3.Text = "J&&M";
            // 
            // button5
            // 
            button5.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            button5.Location = new Point(0, 411);
            button5.Name = "button5";
            button5.Size = new Size(184, 95);
            button5.TabIndex = 14;
            button5.Text = "Estoque";
            button5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(35, 193);
            label2.Name = "label2";
            label2.Size = new Size(72, 31);
            label2.TabIndex = 16;
            label2.Text = "Adega";
            // 
            // button4
            // 
            button4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            button4.Location = new Point(0, 300);
            button4.Name = "button4";
            button4.Size = new Size(184, 95);
            button4.TabIndex = 13;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(184, 151);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // button6
            // 
            button6.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            button6.Location = new Point(0, 523);
            button6.Name = "button6";
            button6.Size = new Size(184, 95);
            button6.TabIndex = 15;
            button6.Text = "PDV";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.Location = new Point(1257, 443);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(32, 30);
            btnAdicionar.TabIndex = 14;
            btnAdicionar.Text = "+";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemover.Location = new Point(1257, 492);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(32, 30);
            btnRemover.TabIndex = 15;
            btnRemover.Text = "-";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Gold;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.Red;
            button9.Location = new Point(1852, 12);
            button9.Name = "button9";
            button9.Size = new Size(56, 29);
            button9.TabIndex = 25;
            button9.Text = "SAIR";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // rButton2
            // 
            rButton2.Anchor = AnchorStyles.None;
            rButton2.BackColor = Color.Gold;
            rButton2.BackgroundColor = Color.Gold;
            rButton2.BorderColor = Color.PaleVioletRed;
            rButton2.BorderRadius = 20;
            rButton2.BorderSize = 0;
            rButton2.Cursor = Cursors.Hand;
            rButton2.FlatAppearance.BorderSize = 0;
            rButton2.FlatStyle = FlatStyle.Flat;
            rButton2.ForeColor = SystemColors.ActiveCaptionText;
            rButton2.Location = new Point(646, 390);
            rButton2.Name = "rButton2";
            rButton2.Size = new Size(164, 40);
            rButton2.TabIndex = 28;
            rButton2.Text = "Adicionar";
            rButton2.TextColor = SystemColors.ActiveCaptionText;
            rButton2.UseVisualStyleBackColor = false;
            rButton2.Click += rButton2_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.None;
            BtnDelete.BackColor = Color.Gold;
            BtnDelete.BackgroundColor = Color.Gold;
            BtnDelete.BorderColor = Color.PaleVioletRed;
            BtnDelete.BorderRadius = 20;
            BtnDelete.BorderSize = 0;
            BtnDelete.Cursor = Cursors.Hand;
            BtnDelete.FlatAppearance.BorderSize = 0;
            BtnDelete.FlatStyle = FlatStyle.Flat;
            BtnDelete.ForeColor = SystemColors.ActiveCaptionText;
            BtnDelete.Location = new Point(863, 390);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(164, 40);
            BtnDelete.TabIndex = 30;
            BtnDelete.Text = "Delete";
            BtnDelete.TextColor = SystemColors.ActiveCaptionText;
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // lbRelogio
            // 
            lbRelogio.AutoSize = true;
            lbRelogio.BackColor = Color.Gold;
            lbRelogio.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbRelogio.Location = new Point(1522, 9);
            lbRelogio.Name = "lbRelogio";
            lbRelogio.Size = new Size(68, 30);
            lbRelogio.TabIndex = 31;
            lbRelogio.Text = "label4";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.Text = "\r\n";
            notifyIcon1.Visible = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(LbNome);
            panel1.Location = new Point(181, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1925, 151);
            panel1.TabIndex = 50;
            // 
            // LbNome
            // 
            LbNome.AutoSize = true;
            LbNome.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold);
            LbNome.ImeMode = ImeMode.NoControl;
            LbNome.Location = new Point(321, 45);
            LbNome.Name = "LbNome";
            LbNome.Size = new Size(0, 40);
            LbNome.TabIndex = 1;
            // 
            // TelaEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1920, 1080);
            Controls.Add(lbRelogio);
            Controls.Add(BtnDelete);
            Controls.Add(rButton2);
            Controls.Add(button9);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(Painel_Principal);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(txtPesquisa);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TelaEstoque";
            Text = "TelaEstoque";
            Load += TelaEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            Painel_Principal.ResumeLayout(false);
            Painel_Principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox txtPesquisa;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox3;
        private Panel Painel_Principal;
        private Button button6;
        private Button button5;
        private Button button4;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label2;
        private Button btnAdicionar;
        private Button btnRemover;
        private Button button9;
        private RButton rButton2;
        public DataGridView dataGridView1;
        private RButton BtnDelete;
        private Label lbRelogio;
        private System.Windows.Forms.Timer timer1;
        private NotifyIcon notifyIcon1;
        private Panel panel1;
        public Label LbNome;
    }
}