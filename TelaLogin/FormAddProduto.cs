using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TelaLogin
{
    public partial class FormAddProduto : Form
    {

        public FormAddProduto()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rButton1_Click(object sender, EventArgs e)
        {
            conectar conectar = new conectar();
            MySqlConnection con = conectar.conectando();

        }
    }
}
