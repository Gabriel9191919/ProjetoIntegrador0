using MySql.Data.MySqlClient;
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
    public partial class Form3 : Form
    {
        string conexao = "server=localhost; uid = root; pwd=; database = adega_jm;";
        
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
                try
            {
                string produto = (txtproduto.Text);
                int preco = Convert.ToInt32(txtpreco.Text);
                int qtd = Convert.ToInt32(txtqtd.Text);
                int datavenc = Convert.ToInt32(txtvenc.Text);

                con.Open();
                string sql = ("INSERT INTO estoque(Produto,Preco,Quantidade,Datadevencimento) VALUES (@produto, @preco, @quantidade, @datadevencimento)");
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@produto", produto);
                cmd.Parameters.AddWithValue("@preco", preco);
                cmd.Parameters.AddWithValue("@quantidade", qtd);
                cmd.Parameters.AddWithValue("@datavencimento", datavenc);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Item cadastro com sucesso");

                con.Close();
            } catch(Exception ex) { } 
            this.Close();
        }
    }
}
