using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaLogin
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 telaLogin = new Form1();
            telaLogin.Show();
            this.Hide();
        }

        private void rButton1_Click(object sender, EventArgs e)
        {
            Form1 telaLogin = new Form1();
            telaLogin.Show();
            this.Hide();
        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {


            this.FormBorderStyle = FormBorderStyle.None;

            // 2. Define o tamanho máximo como a área útil (sem a Taskbar)
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            // 3. Maximiza o form
            this.WindowState = FormWindowState.Maximized;
        }
    }
    
}
