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
    public partial class PDV : Form
    {
        public PDV()
        {
            InitializeComponent();
            label10.Text = "📅 " + DateTime.Now.ToString("dd/MM/yyyy") +
                   "   🕒 " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TelaEstoque TelaEstoque = new TelaEstoque();
            TelaEstoque.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeTela TelaHome = new HomeTela();
            TelaHome.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {


            this.FormBorderStyle = FormBorderStyle.None;

            // 2. Define o tamanho máximo como a área útil (sem a Taskbar)
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            // 3. Maximiza o form
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label10.Text = "📅 " + DateTime.Now.ToString("dd/MM/yyyy") +
                   "   🕒 " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }

}
