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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEstoque));
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            Painel_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(468, 217);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(594, 369);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(539, 188);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(620, 188);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(701, 188);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Excluir";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(782, 187);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 22);
            textBox1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(944, 187);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(689, 140);
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
            pictureBox3.Location = new Point(334, -214);
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
            Painel_Principal.Size = new Size(184, 626);
            Painel_Principal.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(90, 170);
            label3.Name = "label3";
            label3.Size = new Size(68, 32);
            label3.TabIndex = 17;
            label3.Text = "J&&M";
            // 
            // button5
            // 
            button5.Location = new Point(0, 341);
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
            label2.Location = new Point(12, 171);
            label2.Name = "label2";
            label2.Size = new Size(72, 31);
            label2.TabIndex = 16;
            label2.Text = "Adega";
            // 
            // button4
            // 
            button4.Location = new Point(0, 231);
            button4.Name = "button4";
            button4.Size = new Size(184, 95);
            button4.TabIndex = 13;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-61, -16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(311, 151);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // button6
            // 
            button6.Location = new Point(0, 454);
            button6.Name = "button6";
            button6.Size = new Size(184, 95);
            button6.TabIndex = 15;
            button6.Text = "DashBoard";
            button6.UseVisualStyleBackColor = true;
            // 
            // TelaEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1284, 626);
            Controls.Add(Painel_Principal);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox3);
            Name = "TelaEstoque";
            Text = "TelaEstoque";
            Load += TelaEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            Painel_Principal.ResumeLayout(false);
            Painel_Principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
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
    }
}