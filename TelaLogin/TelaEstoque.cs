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
    public partial class TelaEstoque : Form
    {
        string conexao = "server=localhost; uid = root; pwd=; database = adega_jm;";

        public TelaEstoque()
        {
            InitializeComponent();
            attgrid objeto = new attgrid(this.dataGridView1);
            objeto.updategrid();
        }

        private void TelaEstoque_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD




            MySqlConnection con = new MySqlConnection(conexao);
=======
            conectar conectar = new conectar();
            MySqlConnection con = conectar.conectando();
>>>>>>> e417a725a160dfb3b42665b0e02e21cc5616f0e1
            try
            {
                con.Open();
                string sql = "SELECT * FROM estoque";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter estoque = new MySqlDataAdapter(cmd);
                DataTable qualquercoisa = new DataTable();
                estoque.Fill(qualquercoisa);
                dataGridView1.DataSource = qualquercoisa;
            }
            catch { }

            this.FormBorderStyle = FormBorderStyle.None;

            // 2. Define o tamanho máximo como a área útil (sem a Taskbar)
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            // 3. Maximiza o form
            this.WindowState = FormWindowState.Maximized;


        }

        private void button6_Click(object sender, EventArgs e)
        {
            PDV TelaDashboard = new PDV();
            TelaDashboard.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeTela TelaHome = new HomeTela();
            TelaHome.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            attgrid objeto = new attgrid(this.dataGridView1);
            objeto.updategrid();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rButton2_Click(object sender, EventArgs e)
        {
            Form3 telaadd = new Form3();
            telaadd.Show();
        }
    }
}
