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
    public partial class HomeTela : Form
    {
        public HomeTela()
        {
            InitializeComponent();
            
            
        }

        private void HomeTela_Load(object sender, EventArgs e)
        {


            this.FormBorderStyle = FormBorderStyle.None;

            
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            
            this.WindowState = FormWindowState.Maximized;
            EstiloRelogio();
            label9.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'às' HH:mm:ss");


        }



        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            TelaEstoque telaEstoque = new TelaEstoque();
            telaEstoque.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PDV TelaDashboard = new PDV();
            TelaDashboard.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'às' HH:mm:ss");
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }
        private void EstiloRelogio()
        {
            label9.Text = DateTime.Now.ToString("HH:mm:ss");

            label9.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label9.ForeColor = Color.FloralWhite;
            

            label9.AutoSize = true;
            label9.TextAlign = ContentAlignment.MiddleCenter;

            
        }
    }
}
