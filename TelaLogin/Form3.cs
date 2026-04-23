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

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(1257, 150);


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtvenc_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e a tecla Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                return;
            }

            TextBox txt = (TextBox)sender;

            // Adiciona a barra automaticamente após o 2º e o 5º caractere
            // Formato: 00/00/0000
            if (char.IsDigit(e.KeyChar))
            {
                if (txt.Text.Length == 2 || txt.Text.Length == 5)
                {
                    txt.Text += "/";
                    txt.SelectionStart = txt.Text.Length;
                }
            }
        }

        private void rButton1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            try
            {
                string produto = (txtproduto.Text);
                double preco = Convert.ToDouble(txtpreco.Text);
                int qtd = Convert.ToInt32(txtqtd.Text);
                DateTime datavenc = Convert.ToDateTime(txtvenc.Text);

                con.Open();
                string sql = ("INSERT INTO estoque(produto,preco,quantidade,datavencimento) VALUES (@produto, @preco, @quantidade, @datavencimento)");
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@produto", produto);
                cmd.Parameters.AddWithValue("@preco", preco);
                cmd.Parameters.AddWithValue("@quantidade", qtd);
                cmd.Parameters.AddWithValue("@datavencimento", datavenc);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Item cadastro com sucesso");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }
            foreach (Form f in Application.OpenForms)
            {
                if (f is TelaEstoque telaReal)
                {
                    attgrid objeto = new attgrid(telaReal.dataGridView1);
                    objeto.updategrid();
                    break;
                }
            }

            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
