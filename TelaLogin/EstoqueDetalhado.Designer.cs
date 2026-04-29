namespace TelaLogin
{
    partial class EstoqueDetalhado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstoqueDetalhado));
            LbNome = new Label();
            BtnDelete = new RButton();
            btnAdd = new RButton();
            label1 = new Label();
            txtPesquisa = new TextBox();
            dvgEstoque = new DataGridView();
            pictureBox3 = new PictureBox();
            Painel_Principal = new Panel();
            label3 = new Label();
            btnEstoque = new Button();
            label2 = new Label();
            btnHome = new Button();
            pictureBox2 = new PictureBox();
            btnPdv = new Button();
            panel1 = new Panel();
            button9 = new Button();
            lbRelogio = new Label();
            label4 = new Label();
            btnSair = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            btnestoqueSimples = new RButton();
            ((System.ComponentModel.ISupportInitialize)dvgEstoque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            Painel_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LbNome
            // 
            LbNome.AutoSize = true;
            LbNome.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold);
            LbNome.ImeMode = ImeMode.NoControl;
            LbNome.Location = new Point(873, 381);
            LbNome.Name = "LbNome";
            LbNome.Size = new Size(0, 40);
            LbNome.TabIndex = 2;
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
            BtnDelete.Location = new Point(829, 388);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(164, 40);
            BtnDelete.TabIndex = 39;
            BtnDelete.Text = "Delete";
            BtnDelete.TextColor = SystemColors.ActiveCaptionText;
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Click += BtnDelete_Click;
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
            btnAdd.TabIndex = 38;
            btnAdd.Text = "Adicionar";
            btnAdd.TextColor = SystemColors.ActiveCaptionText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
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
            label1.TabIndex = 34;
            label1.Text = "ESTOQUE";
            // 
            // txtPesquisa
            // 
            txtPesquisa.BorderStyle = BorderStyle.None;
            txtPesquisa.Font = new Font("Segoe UI", 12F);
            txtPesquisa.Location = new Point(999, 399);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "Pesquisar";
            txtPesquisa.Size = new Size(213, 22);
            txtPesquisa.TabIndex = 32;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // dvgEstoque
            // 
            dvgEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgEstoque.Location = new Point(646, 434);
            dvgEstoque.Name = "dvgEstoque";
            dvgEstoque.Size = new Size(594, 369);
            dvgEstoque.TabIndex = 31;
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
            pictureBox3.TabIndex = 35;
            pictureBox3.TabStop = false;
            // 
            // Painel_Principal
            // 
            Painel_Principal.BackColor = Color.Gold;
            Painel_Principal.Controls.Add(label3);
            Painel_Principal.Controls.Add(btnEstoque);
            Painel_Principal.Controls.Add(label2);
            Painel_Principal.Controls.Add(btnHome);
            Painel_Principal.Controls.Add(pictureBox2);
            Painel_Principal.Controls.Add(btnPdv);
            Painel_Principal.Dock = DockStyle.Left;
            Painel_Principal.Location = new Point(0, 0);
            Painel_Principal.Name = "Painel_Principal";
            Painel_Principal.Size = new Size(184, 1080);
            Painel_Principal.TabIndex = 51;
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
            btnEstoque.Click += btnEstoque_Click;
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
            // btnHome
            // 
            btnHome.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnHome.Location = new Point(0, 300);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(184, 95);
            btnHome.TabIndex = 13;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
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
            // btnPdv
            // 
            btnPdv.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnPdv.Location = new Point(0, 523);
            btnPdv.Name = "btnPdv";
            btnPdv.Size = new Size(184, 95);
            btnPdv.TabIndex = 15;
            btnPdv.Text = "PDV";
            btnPdv.UseVisualStyleBackColor = true;
            btnPdv.Click += btnPdv_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(button9);
            panel1.Controls.Add(lbRelogio);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnSair);
            panel1.Location = new Point(177, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1925, 151);
            panel1.TabIndex = 52;
            // 
            // button9
            // 
            button9.BackColor = Color.Gold;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.Red;
            button9.Location = new Point(1675, 3);
            button9.Name = "button9";
            button9.Size = new Size(56, 29);
            button9.TabIndex = 55;
            button9.Text = "SAIR";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // lbRelogio
            // 
            lbRelogio.AutoSize = true;
            lbRelogio.BackColor = Color.Gold;
            lbRelogio.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRelogio.Location = new Point(1345, 9);
            lbRelogio.Name = "lbRelogio";
            lbRelogio.Size = new Size(76, 25);
            lbRelogio.TabIndex = 54;
            lbRelogio.Text = "label4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold);
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(321, 45);
            label4.Name = "label4";
            label4.Size = new Size(0, 40);
            label4.TabIndex = 1;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Gold;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.Red;
            btnSair.Location = new Point(1764, 12);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(56, 29);
            btnSair.TabIndex = 53;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // btnestoqueSimples
            // 
            btnestoqueSimples.Anchor = AnchorStyles.None;
            btnestoqueSimples.BackColor = Color.Gold;
            btnestoqueSimples.BackgroundColor = Color.Gold;
            btnestoqueSimples.BorderColor = Color.PaleVioletRed;
            btnestoqueSimples.BorderRadius = 20;
            btnestoqueSimples.BorderSize = 0;
            btnestoqueSimples.Cursor = Cursors.Hand;
            btnestoqueSimples.FlatAppearance.BorderSize = 0;
            btnestoqueSimples.FlatStyle = FlatStyle.Flat;
            btnestoqueSimples.ForeColor = SystemColors.ActiveCaptionText;
            btnestoqueSimples.Location = new Point(847, 822);
            btnestoqueSimples.Name = "btnestoqueSimples";
            btnestoqueSimples.Size = new Size(198, 40);
            btnestoqueSimples.TabIndex = 38;
            btnestoqueSimples.Text = "Estoque Simples";
            btnestoqueSimples.TextColor = SystemColors.ActiveCaptionText;
            btnestoqueSimples.UseVisualStyleBackColor = false;
            btnestoqueSimples.Click += btnestoqueSimples_Click;
            // 
            // EstoqueDetalhado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1920, 1080);
            Controls.Add(Painel_Principal);
            Controls.Add(panel1);
            Controls.Add(BtnDelete);
            Controls.Add(btnestoqueSimples);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(txtPesquisa);
            Controls.Add(dvgEstoque);
            Controls.Add(pictureBox3);
            Controls.Add(LbNome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EstoqueDetalhado";
            Text = "EstoqueDetalhado";
            Load += EstoqueDetalhado_Load;
            ((System.ComponentModel.ISupportInitialize)dvgEstoque).EndInit();
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

        public Label LbNome;
        private RButton BtnDelete;
        private RButton btnAdd;
        private Button btnRemover;
        private Button btnAdicionar;
        private Label label1;
        private TextBox txtPesquisa;
        public DataGridView dvgEstoque;
        private PictureBox pictureBox3;
        private Panel Painel_Principal;
        private Label label3;
        private Button btnEstoque;
        private Label label2;
        private Button btnHome;
        private PictureBox pictureBox2;
        private Button btnPdv;
        private Panel panel1;
        public Label label4;
        private Label lbRelogio;
        private Button btnSair;
        private System.Windows.Forms.Timer timer1;
        private RButton btnestoqueSimples;
        private Button button9;
    }
}