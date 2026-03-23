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
            ID = new DataGridViewTextBoxColumn();
            Produto = new DataGridViewTextBoxColumn();
            Preço = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            Vencimento = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Produto, Preço, Quantidade, Vencimento });
            dataGridView1.Location = new Point(266, 265);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(432, 211);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(266, 236);
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
            button2.Location = new Point(347, 236);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(428, 236);
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
            textBox1.Location = new Point(509, 235);
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
            pictureBox1.Location = new Point(671, 235);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Produto
            // 
            Produto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Produto.HeaderText = "Produto";
            Produto.Name = "Produto";
            // 
            // Preço
            // 
            Preço.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Preço.HeaderText = "Preço";
            Preço.Name = "Preço";
            // 
            // Quantidade
            // 
            Quantidade.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Quantidade.HeaderText = "Quantidade";
            Quantidade.Name = "Quantidade";
            // 
            // Vencimento
            // 
            Vencimento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Vencimento.HeaderText = "Data de Vencimento";
            Vencimento.Name = "Vencimento";
            // 
            // TelaEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "TelaEstoque";
            Text = "TelaEstoque";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Produto;
        private DataGridViewTextBoxColumn Preço;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Vencimento;
    }
}