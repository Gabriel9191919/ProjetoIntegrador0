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
            label1 = new Label();
            pictureBox3 = new PictureBox();
            Painel_Principal = new Panel();
            button3 = new Button();
            label3 = new Label();
            btnEstoque = new Button();
            label2 = new Label();
            button4 = new Button();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            btnProdutos = new Button();
            button9 = new Button();
            lbRelogio = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            notifyIcon1 = new NotifyIcon(components);
            panel1 = new Panel();
            lbbabel = new Label();
            btnAdd = new RButton();
            txtPesquisa = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            Painel_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(646, 434);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(594, 369);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            dataGridView1.EditingControlShowing += dataGridView1_EditingControlShowing;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(863, 317);
            label1.Name = "label1";
            label1.Size = new Size(150, 35);
            label1.TabIndex = 6;
            label1.Text = "PRODUTOS";
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
            Painel_Principal.Controls.Add(button3);
            Painel_Principal.Controls.Add(label3);
            Painel_Principal.Controls.Add(btnEstoque);
            Painel_Principal.Controls.Add(label2);
            Painel_Principal.Controls.Add(button4);
            Painel_Principal.Controls.Add(pictureBox2);
            Painel_Principal.Controls.Add(button2);
            Painel_Principal.Controls.Add(btnProdutos);
            Painel_Principal.Dock = DockStyle.Left;
            Painel_Principal.Location = new Point(0, 0);
            Painel_Principal.Name = "Painel_Principal";
            Painel_Principal.Size = new Size(184, 1080);
            Painel_Principal.TabIndex = 13;
            // 
            // button3
            // 
            button3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            button3.ImeMode = ImeMode.NoControl;
            button3.Location = new Point(0, 747);
            button3.Name = "button3";
            button3.Size = new Size(184, 95);
            button3.TabIndex = 53;
            button3.Text = "Relatório";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
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
            // btnEstoque
            // 
            btnEstoque.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnEstoque.Location = new Point(0, 411);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(184, 95);
            btnEstoque.TabIndex = 14;
            btnEstoque.Text = "Estoque";
            btnEstoque.UseVisualStyleBackColor = true;
            btnEstoque.Click += button5_Click;
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
            // button2
            // 
            button2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            button2.Location = new Point(0, 634);
            button2.Name = "button2";
            button2.Size = new Size(184, 95);
            button2.TabIndex = 15;
            button2.Text = "PDV";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button6_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnProdutos.Location = new Point(0, 523);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(184, 95);
            btnProdutos.TabIndex = 15;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = true;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Gold;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.Red;
            button9.Location = new Point(1671, 3);
            button9.Name = "button9";
            button9.Size = new Size(56, 29);
            button9.TabIndex = 25;
            button9.Text = "SAIR";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // lbRelogio
            // 
            lbRelogio.AutoSize = true;
            lbRelogio.BackColor = Color.Gold;
            lbRelogio.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRelogio.Location = new Point(1522, 9);
            lbRelogio.Name = "lbRelogio";
            lbRelogio.Size = new Size(76, 25);
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
            panel1.Controls.Add(lbbabel);
            panel1.Controls.Add(button9);
            panel1.Location = new Point(181, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1925, 151);
            panel1.TabIndex = 50;
            // 
            // lbbabel
            // 
            lbbabel.AutoSize = true;
            lbbabel.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold);
            lbbabel.ImeMode = ImeMode.NoControl;
            lbbabel.Location = new Point(229, 49);
            lbbabel.Name = "lbbabel";
            lbbabel.Size = new Size(0, 40);
            lbbabel.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.BackColor = Color.Gold;
            btnAdd.BackgroundColor = Color.Gold;
            btnAdd.BorderColor = Color.PaleVioletRed;
            btnAdd.BorderRadius = 20;
            btnAdd.BorderSize = 0;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = SystemColors.ActiveCaptionText;
            btnAdd.Location = new Point(646, 388);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(164, 40);
            btnAdd.TabIndex = 28;
            btnAdd.Text = "Adicionar";
            btnAdd.TextColor = SystemColors.ActiveCaptionText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.BorderStyle = BorderStyle.None;
            txtPesquisa.Font = new Font("Segoe UI", 12F);
            txtPesquisa.Location = new Point(927, 396);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "Pesquisar";
            txtPesquisa.Size = new Size(243, 22);
            txtPesquisa.TabIndex = 52;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged_1;
            // 
            // TelaEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1920, 1080);
            Controls.Add(txtPesquisa);
            Controls.Add(lbRelogio);
            Controls.Add(btnAdd);
            Controls.Add(Painel_Principal);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TelaEstoque";
            Text = "TelaEstoque";
            Load += TelaEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label label1;
        private PictureBox pictureBox3;
        private Panel Painel_Principal;
        private Button btnProdutos;
        private Button btnEstoque;
        private Button button4;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label2;
        private Button button9;
        public DataGridView dataGridView1;
        private Label lbRelogio;
        private System.Windows.Forms.Timer timer1;
        private NotifyIcon notifyIcon1;
        private Panel panel1;
        public Label lbbabel;
        private RButton btnAdd;
        private TextBox txtPesquisa;
        private Button button2;
        private Button button3;
    }
}