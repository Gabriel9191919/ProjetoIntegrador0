namespace TelaLogin
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            Painel_Principal = new Panel();
            button3 = new Button();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            button5 = new Button();
            label2 = new Label();
            button4 = new Button();
            button2 = new Button();
            btnProdutos = new Button();
            gridrt = new DataGridView();
            panel1 = new Panel();
            lbhead = new Label();
            button1 = new Button();
            lbdok = new Label();
            Painel_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridrt).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Painel_Principal
            // 
            Painel_Principal.BackColor = Color.Black;
            Painel_Principal.Controls.Add(button3);
            Painel_Principal.Controls.Add(pictureBox2);
            Painel_Principal.Controls.Add(label3);
            Painel_Principal.Controls.Add(button5);
            Painel_Principal.Controls.Add(label2);
            Painel_Principal.Controls.Add(button4);
            Painel_Principal.Controls.Add(button2);
            Painel_Principal.Controls.Add(btnProdutos);
            Painel_Principal.Dock = DockStyle.Left;
            Painel_Principal.Location = new Point(0, 0);
            Painel_Principal.Name = "Painel_Principal";
            Painel_Principal.Size = new Size(184, 1061);
            Painel_Principal.TabIndex = 15;
            // 
            // button3
            // 
            button3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            button3.ImeMode = ImeMode.NoControl;
            button3.Location = new Point(0, 748);
            button3.Name = "button3";
            button3.Size = new Size(184, 95);
            button3.TabIndex = 37;
            button3.Text = "Relatório";
            button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.ImeMode = ImeMode.NoControl;
            pictureBox2.Location = new Point(0, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(184, 151);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label3.ForeColor = Color.Red;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(69, 224);
            label3.Name = "label3";
            label3.Size = new Size(68, 32);
            label3.TabIndex = 17;
            label3.Text = "J&&M";
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.System;
            button5.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            button5.ImeMode = ImeMode.NoControl;
            button5.Location = new Point(0, 411);
            button5.Name = "button5";
            button5.Size = new Size(184, 95);
            button5.TabIndex = 14;
            button5.Text = "Estoque";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(35, 193);
            label2.Name = "label2";
            label2.Size = new Size(72, 31);
            label2.TabIndex = 16;
            label2.Text = "Adega";
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.System;
            button4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            button4.ImeMode = ImeMode.NoControl;
            button4.Location = new Point(0, 300);
            button4.Name = "button4";
            button4.Size = new Size(184, 95);
            button4.TabIndex = 13;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.ImeMode = ImeMode.NoControl;
            button2.Location = new Point(0, 633);
            button2.Name = "button2";
            button2.Size = new Size(184, 95);
            button2.TabIndex = 15;
            button2.Text = "PDV";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.FlatAppearance.BorderSize = 0;
            btnProdutos.FlatStyle = FlatStyle.System;
            btnProdutos.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnProdutos.ImeMode = ImeMode.NoControl;
            btnProdutos.Location = new Point(0, 523);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(184, 95);
            btnProdutos.TabIndex = 15;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = true;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // gridrt
            // 
            gridrt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridrt.Location = new Point(528, 411);
            gridrt.Name = "gridrt";
            gridrt.ReadOnly = true;
            gridrt.Size = new Size(1089, 537);
            gridrt.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lbhead);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lbdok);
            panel1.Location = new Point(183, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1749, 161);
            panel1.TabIndex = 50;
            // 
            // lbhead
            // 
            lbhead.AutoSize = true;
            lbhead.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold);
            lbhead.ForeColor = SystemColors.ButtonFace;
            lbhead.ImeMode = ImeMode.NoControl;
            lbhead.Location = new Point(173, 56);
            lbhead.Name = "lbhead";
            lbhead.Size = new Size(0, 40);
            lbhead.TabIndex = 53;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.Red;
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(1650, 10);
            button1.Name = "button1";
            button1.Size = new Size(56, 29);
            button1.TabIndex = 52;
            button1.Text = "SAIR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lbdok
            // 
            lbdok.AutoSize = true;
            lbdok.BackColor = Color.Black;
            lbdok.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lbdok.ForeColor = SystemColors.ButtonFace;
            lbdok.ImeMode = ImeMode.NoControl;
            lbdok.Location = new Point(1334, 10);
            lbdok.Name = "lbdok";
            lbdok.Size = new Size(138, 25);
            lbdok.TabIndex = 51;
            lbdok.Text = "Data e Hora";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1920, 1061);
            Controls.Add(panel1);
            Controls.Add(gridrt);
            Controls.Add(Painel_Principal);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form5";
            Text = "Form5";
            WindowState = FormWindowState.Maximized;
            Load += Form5_Load;
            Painel_Principal.ResumeLayout(false);
            Painel_Principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridrt).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Painel_Principal;
        private PictureBox pictureBox2;
        private Label label3;
        private Button button5;
        private Label label2;
        private Button button4;
        private Button button2;
        private Button btnProdutos;
        private DataGridView gridrt;
        private Panel panel1;
        private Label lbdok;
        private Button button1;
        public Label lbhead;
        private Button button3;
    }
}