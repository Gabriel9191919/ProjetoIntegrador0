namespace TelaLogin
{
    partial class HomeTela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeTela));
            Painel_Principal = new Panel();
            label3 = new Label();
            button5 = new Button();
            label2 = new Label();
            button4 = new Button();
            pictureBox2 = new PictureBox();
            button6 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            Painel_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
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
            Painel_Principal.Size = new Size(184, 1041);
            Painel_Principal.TabIndex = 14;
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
            button5.Click += button5_Click;
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
            pictureBox2.Location = new Point(0, -10);
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
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDarkDark;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(222, 50);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 15;
            label1.Text = "NomeDoUsuario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlDarkDark;
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(706, 101);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 16;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlDarkDark;
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(222, 241);
            label5.Name = "label5";
            label5.Size = new Size(174, 15);
            label5.TabIndex = 17;
            label5.Text = "Produto em menor quantidade:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ControlDarkDark;
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(222, 101);
            label7.Name = "label7";
            label7.Size = new Size(184, 15);
            label7.TabIndex = 19;
            label7.Text = "Produto mais proximo a validade:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlDarkDark;
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(222, 166);
            label6.Name = "label6";
            label6.Size = new Size(184, 15);
            label6.TabIndex = 20;
            label6.Text = "Produto mais vendido na semana";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(794, 321);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(458, 185);
            textBox1.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ControlDarkDark;
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(794, 300);
            label8.Name = "label8";
            label8.Size = new Size(74, 15);
            label8.TabIndex = 22;
            label8.Text = "Observações";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1624, 970);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 23;
            label9.Text = "label9";
            label9.Click += label9_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(1852, 12);
            button1.Name = "button1";
            button1.Size = new Size(56, 29);
            button1.TabIndex = 24;
            button1.Text = "SAIR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // HomeTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1904, 1041);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Painel_Principal);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "HomeTela";
            Text = "HomeTela";
            Load += HomeTela_Load;
            Painel_Principal.ResumeLayout(false);
            Painel_Principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Painel_Principal;
        private Label label3;
        private Button button5;
        private Label label2;
        private Button button4;
        private PictureBox pictureBox2;
        private Button button6;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label6;
        private TextBox textBox1;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private Label label9;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}