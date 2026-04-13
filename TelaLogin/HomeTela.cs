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

        private void HomeTela_Load(object sender, EventArgs e)
        {

        }
    }
}
