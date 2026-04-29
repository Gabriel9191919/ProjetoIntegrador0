namespace TelaLogin
{
    partial class FormAddProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddProduto));
            btnSair = new Button();
            pictureBox3 = new PictureBox();
            txtproduto = new TextBox();
            txtPreco = new TextBox();
            label1 = new Label();
            label2 = new Label();
            rButton1 = new RButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.Red;
            btnSair.Location = new Point(472, 12);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(125, 29);
            btnSair.TabIndex = 29;
            btnSair.Text = "CANCELAR";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(204, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(213, 153);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            // 
            // txtproduto
            // 
            txtproduto.Font = new Font("Segoe UI", 12F);
            txtproduto.Location = new Point(92, 223);
            txtproduto.Name = "txtproduto";
            txtproduto.Size = new Size(195, 29);
            txtproduto.TabIndex = 27;
            // 
            // txtPreco
            // 
            txtPreco.Font = new Font("Segoe UI", 12F);
            txtPreco.Location = new Point(357, 223);
            txtPreco.Name = "txtPreco";
            txtPreco.PlaceholderText = "R$";
            txtPreco.Size = new Size(79, 29);
            txtPreco.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 196);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 30;
            label1.Text = "Nome do produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(357, 196);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 30;
            label2.Text = "Preco";
            // 
            // rButton1
            // 
            rButton1.Anchor = AnchorStyles.None;
            rButton1.BackColor = Color.Gold;
            rButton1.BackgroundColor = Color.Gold;
            rButton1.BorderColor = Color.PaleVioletRed;
            rButton1.BorderRadius = 20;
            rButton1.BorderSize = 0;
            rButton1.Cursor = Cursors.Hand;
            rButton1.FlatAppearance.BorderSize = 0;
            rButton1.FlatStyle = FlatStyle.Flat;
            rButton1.ForeColor = SystemColors.ActiveCaptionText;
            rButton1.Location = new Point(273, 277);
            rButton1.Name = "rButton1";
            rButton1.Size = new Size(95, 40);
            rButton1.TabIndex = 31;
            rButton1.Text = "Adicionar";
            rButton1.TextColor = SystemColors.ActiveCaptionText;
            rButton1.UseVisualStyleBackColor = false;
            rButton1.Click += rButton1_Click;
            // 
            // FormAddProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(593, 368);
            Controls.Add(rButton1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSair);
            Controls.Add(pictureBox3);
            Controls.Add(txtPreco);
            Controls.Add(txtproduto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAddProduto";
            Text = "FormAddProduto";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSair;
        private PictureBox pictureBox3;
        private TextBox txtproduto;
        private TextBox txtPreco;
        private Label label1;
        private Label label2;
        private RButton rButton1;
    }
}