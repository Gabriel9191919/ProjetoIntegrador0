namespace TelaPrincipal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Produto = new DataGridViewTextBoxColumn();
            Preço = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            Data_Vencimento = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Produto, Preço, Quantidade, Data_Vencimento });
            dataGridView1.Location = new Point(479, 149);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(474, 320);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Produto
            // 
            Produto.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Produto.HeaderText = "Produto";
            Produto.Name = "Produto";
            Produto.Width = 75;
            // 
            // Preço
            // 
            Preço.HeaderText = "Preço";
            Preço.Name = "Preço";
            // 
            // Quantidade
            // 
            Quantidade.HeaderText = "Quantidade";
            Quantidade.Name = "Quantidade";
            // 
            // Data_Vencimento
            // 
            Data_Vencimento.HeaderText = "Data_Vencimento";
            Data_Vencimento.Name = "Data_Vencimento";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 644);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Produto;
        private DataGridViewTextBoxColumn Preço;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Data_Vencimento;
    }
}
