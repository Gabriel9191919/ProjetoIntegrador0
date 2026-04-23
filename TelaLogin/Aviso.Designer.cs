namespace TelaLogin
{
    partial class Aviso
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
            lblTitulo = new Label();
            panelLado = new Panel();
            lblTexto = new Label();
            panelLado.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(0, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelLado
            // 
            panelLado.BackColor = SystemColors.ActiveCaption;
            panelLado.Controls.Add(lblTexto);
            panelLado.Controls.Add(lblTitulo);
            panelLado.Dock = DockStyle.Fill;
            panelLado.Location = new Point(0, 0);
            panelLado.Name = "panelLado";
            panelLado.Size = new Size(300, 80);
            panelLado.TabIndex = 1;
            // 
            // lblTexto
            // 
            lblTexto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTexto.AutoEllipsis = true;
            lblTexto.AutoSize = true;
            lblTexto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTexto.Location = new Point(75, 31);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(0, 17);
            lblTexto.TabIndex = 1;
            lblTexto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Aviso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 80);
            Controls.Add(panelLado);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Aviso";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Aviso";
            TopMost = true;
            panelLado.ResumeLayout(false);
            panelLado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Panel panelLado;
        private Label lblTexto;
    }
}