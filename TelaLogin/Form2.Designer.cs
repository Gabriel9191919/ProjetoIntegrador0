namespace TelaLogin
{
    partial class PDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDV));
            Painel_Principal = new Panel();
            button3 = new Button();
            label3 = new Label();
            btnEstoque = new Button();
            label2 = new Label();
            btnHome = new Button();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            btnProdutos = new Button();
            button1 = new Button();
            txtPreco = new TextBox();
            txtQtd = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtId = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtTotal = new TextBox();
            btnVender = new RButton();
            dataGridView1 = new DataGridView();
            bntAdd = new RButton();
            comboProduto = new ComboBox();
            label9 = new Label();
            comboPagamento = new ComboBox();
            label6 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label10 = new Label();
            LbNom = new Label();
            panel1 = new Panel();
            rButton1 = new RButton();
            Painel_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Painel_Principal
            // 
            resources.ApplyResources(Painel_Principal, "Painel_Principal");
            Painel_Principal.BackColor = Color.Gold;
            Painel_Principal.Controls.Add(button3);
            Painel_Principal.Controls.Add(label3);
            Painel_Principal.Controls.Add(btnEstoque);
            Painel_Principal.Controls.Add(label2);
            Painel_Principal.Controls.Add(btnHome);
            Painel_Principal.Controls.Add(pictureBox2);
            Painel_Principal.Controls.Add(button2);
            Painel_Principal.Controls.Add(btnProdutos);
            Painel_Principal.Name = "Painel_Principal";
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.Red;
            label3.Name = "label3";
            // 
            // btnEstoque
            // 
            resources.ApplyResources(btnEstoque, "btnEstoque");
            btnEstoque.Name = "btnEstoque";
            btnEstoque.UseVisualStyleBackColor = true;
            btnEstoque.Click += btnEstoque_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Name = "label2";
            // 
            // btnHome
            // 
            resources.ApplyResources(btnHome, "btnHome");
            btnHome.Name = "btnHome";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnProdutos
            // 
            resources.ApplyResources(btnProdutos, "btnProdutos");
            btnProdutos.Name = "btnProdutos";
            btnProdutos.UseVisualStyleBackColor = true;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.BackColor = Color.Gold;
            button1.FlatAppearance.BorderSize = 0;
            button1.ForeColor = Color.Red;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtPreco
            // 
            resources.ApplyResources(txtPreco, "txtPreco");
            txtPreco.Name = "txtPreco";
            // 
            // txtQtd
            // 
            resources.ApplyResources(txtQtd, "txtQtd");
            txtQtd.Name = "txtQtd";
            txtQtd.TextChanged += txtQtd_TextChanged;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // txtId
            // 
            resources.ApplyResources(txtId, "txtId");
            txtId.Name = "txtId";
            txtId.TextChanged += txtId_TextChanged;
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // txtTotal
            // 
            resources.ApplyResources(txtTotal, "txtTotal");
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            // 
            // btnVender
            // 
            resources.ApplyResources(btnVender, "btnVender");
            btnVender.BackColor = Color.Gold;
            btnVender.BackgroundColor = Color.Gold;
            btnVender.BorderColor = Color.PaleVioletRed;
            btnVender.BorderRadius = 20;
            btnVender.BorderSize = 0;
            btnVender.Cursor = Cursors.Hand;
            btnVender.FlatAppearance.BorderSize = 0;
            btnVender.ForeColor = SystemColors.ActiveCaptionText;
            btnVender.Name = "btnVender";
            btnVender.TextColor = SystemColors.ActiveCaptionText;
            btnVender.UseVisualStyleBackColor = false;
            btnVender.Click += btnVender_Click_1;
            // 
            // dataGridView1
            // 
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.CellContentClick += DvgPdv_CellContentClick;
            // 
            // bntAdd
            // 
            resources.ApplyResources(bntAdd, "bntAdd");
            bntAdd.BackColor = Color.Gold;
            bntAdd.BackgroundColor = Color.Gold;
            bntAdd.BorderColor = Color.PaleVioletRed;
            bntAdd.BorderRadius = 20;
            bntAdd.BorderSize = 0;
            bntAdd.Cursor = Cursors.Hand;
            bntAdd.FlatAppearance.BorderSize = 0;
            bntAdd.ForeColor = SystemColors.ActiveCaptionText;
            bntAdd.Name = "bntAdd";
            bntAdd.TextColor = SystemColors.ActiveCaptionText;
            bntAdd.UseVisualStyleBackColor = false;
            bntAdd.Click += bntAdd_Click;
            // 
            // comboProduto
            // 
            resources.ApplyResources(comboProduto, "comboProduto");
            comboProduto.FormattingEnabled = true;
            comboProduto.Name = "comboProduto";
            comboProduto.SelectedIndexChanged += comboProduto_SelectedIndexChanged;
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // comboPagamento
            // 
            resources.ApplyResources(comboPagamento, "comboPagamento");
            comboPagamento.FormattingEnabled = true;
            comboPagamento.Name = "comboPagamento";
            comboPagamento.SelectedIndexChanged += comboPagamento_SelectedIndexChanged;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.BackColor = Color.Gold;
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Name = "label10";
            // 
            // LbNom
            // 
            resources.ApplyResources(LbNom, "LbNom");
            LbNom.Name = "LbNom";
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(LbNom);
            panel1.Name = "panel1";
            // 
            // rButton1
            // 
            resources.ApplyResources(rButton1, "rButton1");
            rButton1.BackColor = Color.Gold;
            rButton1.BackgroundColor = Color.Gold;
            rButton1.BorderColor = Color.PaleVioletRed;
            rButton1.BorderRadius = 20;
            rButton1.BorderSize = 0;
            rButton1.Cursor = Cursors.Hand;
            rButton1.FlatAppearance.BorderSize = 0;
            rButton1.ForeColor = SystemColors.ActiveCaptionText;
            rButton1.Name = "rButton1";
            rButton1.TextColor = SystemColors.ActiveCaptionText;
            rButton1.UseVisualStyleBackColor = false;
            rButton1.Click += rButton1_Click;
            // 
            // PDV
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(rButton1);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(comboPagamento);
            Controls.Add(label9);
            Controls.Add(comboProduto);
            Controls.Add(bntAdd);
            Controls.Add(dataGridView1);
            Controls.Add(btnVender);
            Controls.Add(txtTotal);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtQtd);
            Controls.Add(txtPreco);
            Controls.Add(button1);
            Controls.Add(Painel_Principal);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PDV";
            WindowState = FormWindowState.Maximized;
            Load += Form2_Load;
            Painel_Principal.ResumeLayout(false);
            Painel_Principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Panel Painel_Principal;
        private Label label3;
        private Button btnEstoque;
        private Label label2;
        private Button btnHome;
        private PictureBox pictureBox2;
        private Button btnProdutos;
        private Button button1;
        private TextBox txtPreco;
        private TextBox txtQtd;
        private Label label4;
        private Label label5;
        private TextBox txtId;
        private Label label7;
        private Label label8;
        private TextBox txtTotal;
        private RButton btnVender;
        private DataGridView dataGridView1;
        private RButton bntAdd;
        private ComboBox comboProduto;
        private Label label9;
        private ComboBox comboPagamento;
        private Label label6;
        private System.Windows.Forms.Timer timer1;
        private Label label10;
        private Label lbRelogio;
        public Label LbNom;
        private Panel panel1;
        private Button button2;
        private Button button3;
        private RButton rButton1;
    }
}