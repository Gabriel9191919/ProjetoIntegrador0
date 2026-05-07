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
            panel12 = new Panel();
            btnModo = new Button();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            BtnTrocarSessao = new Button();
            button5 = new Button();
            label2 = new Label();
            button4 = new Button();
            button2 = new Button();
            btnProdutos = new Button();
            dataGridView1 = new DataGridView();
            Painel_Principal.SuspendLayout();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Painel_Principal
            // 
            Painel_Principal.BackColor = Color.Gold;
            Painel_Principal.Controls.Add(panel12);
            Painel_Principal.Controls.Add(pictureBox2);
            Painel_Principal.Controls.Add(label3);
            Painel_Principal.Controls.Add(BtnTrocarSessao);
            Painel_Principal.Controls.Add(button5);
            Painel_Principal.Controls.Add(label2);
            Painel_Principal.Controls.Add(button4);
            Painel_Principal.Controls.Add(button2);
            Painel_Principal.Controls.Add(btnProdutos);
            Painel_Principal.Dock = DockStyle.Left;
            Painel_Principal.Location = new Point(0, 0);
            Painel_Principal.Name = "Painel_Principal";
            Painel_Principal.Size = new Size(184, 1041);
            Painel_Principal.TabIndex = 15;
            // 
            // panel12
            // 
            panel12.BackColor = Color.Gray;
            panel12.Controls.Add(btnModo);
            panel12.Location = new Point(60, 917);
            panel12.Name = "panel12";
            panel12.Size = new Size(60, 30);
            panel12.TabIndex = 36;
            // 
            // btnModo
            // 
            btnModo.FlatStyle = FlatStyle.Flat;
            btnModo.ImeMode = ImeMode.NoControl;
            btnModo.Location = new Point(2, 2);
            btnModo.Name = "btnModo";
            btnModo.Size = new Size(25, 25);
            btnModo.TabIndex = 0;
            btnModo.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.ImeMode = ImeMode.NoControl;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(184, 151);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
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
            // BtnTrocarSessao
            // 
            BtnTrocarSessao.BackColor = Color.Gold;
            BtnTrocarSessao.FlatAppearance.BorderSize = 0;
            BtnTrocarSessao.FlatStyle = FlatStyle.Flat;
            BtnTrocarSessao.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnTrocarSessao.ForeColor = Color.Red;
            BtnTrocarSessao.ImeMode = ImeMode.NoControl;
            BtnTrocarSessao.Location = new Point(12, 953);
            BtnTrocarSessao.Name = "BtnTrocarSessao";
            BtnTrocarSessao.Size = new Size(155, 57);
            BtnTrocarSessao.TabIndex = 24;
            BtnTrocarSessao.Text = "Trocar de sessão";
            BtnTrocarSessao.UseVisualStyleBackColor = false;
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
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(317, 389);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1089, 537);
            dataGridView1.TabIndex = 16;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1904, 1041);
            Controls.Add(dataGridView1);
            Controls.Add(Painel_Principal);
            ForeColor = Color.Snow;
            Name = "Form5";
            Text = "Form5";
            Painel_Principal.ResumeLayout(false);
            Painel_Principal.PerformLayout();
            panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Painel_Principal;
        private Panel panel12;
        private Button btnModo;
        private PictureBox pictureBox2;
        private Label label3;
        private Button BtnTrocarSessao;
        private Button button5;
        private Label label2;
        private Button button4;
        private Button button2;
        private Button btnProdutos;
        private DataGridView dataGridView1;
    }
}