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
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(1257, 350);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rButton1_Click(object sender, EventArgs e)
        {
            conectar conectar = new conectar();
            MySqlConnection con = conectar.conectando();
            try
            {
                con.Open();
                string produto = (txtproduto.Text);
                decimal preco = Convert.ToDecimal(txtPreco.Text);
                string sql = "INSERT INTO produtos(produto, precoproduto) VALUES (@produto, @precoproduto)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@produto", produto);
                cmd.Parameters.AddWithValue("@precoproduto", preco);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto cadastro com sucesso");
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
                    objeto.updategridProdutos();
                    break;
                }
                this.Close();
            }


        }
    }
}
