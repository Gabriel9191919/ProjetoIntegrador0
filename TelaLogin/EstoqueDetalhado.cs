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
using MySql.Data.MySqlClient;
namespace TelaLogin
{
    public partial class EstoqueDetalhado : Form
    {
        string conexao = "server=localhost; uid = root; pwd=; database = adega_jm;";

        public EstoqueDetalhado()
        {
            InitializeComponent();
        }

        private void EstoqueDetalhado_Load(object sender, EventArgs e)
        {
            lbRelogio.Text = "📅 " + DateTime.Now.ToString("dd/MM/yyyy") +
                  "🕒 " + DateTime.Now.ToString("HH:mm:ss");

            conectar conectar = new conectar();
            MySqlConnection con = conectar.conectando();

            try
            {
                con.Open();
                string sql = "SELECT * FROM estoque";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter estoque = new MySqlDataAdapter(cmd);
                DataTable qualquercoisa = new DataTable();
                estoque.Fill(qualquercoisa);
                dvgEstoque.DataSource = qualquercoisa;

            }
            catch { }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form3 telaadd = new Form3();
            telaadd.ShowDialog();
            telaadd.StartPosition = FormStartPosition.Manual;
            telaadd.Location = new Point(200, 150);


            attgrid objeto = new attgrid(this.dvgEstoque);
            objeto.updategrid();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbRelogio.Text = "📅 " + DateTime.Now.ToString("dd/MM/yyyy") +
                  "🕒 " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dvgEstoque.CurrentRow != null && !dvgEstoque.CurrentRow.IsNewRow)
            {

                DialogResult resultado = MessageBox.Show(
                    "Tem certeza que deseja excluir este produto?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.Yes)
                {
                    int idSelecionado = Convert.ToInt32(
                        dvgEstoque.CurrentRow.Cells["id_estoque"].Value
                    );

                    MySqlConnection con = new MySqlConnection(conexao);

                    try
                    {
                        con.Open();

                        string sqlDelete = "DELETE FROM produtos WHERE id_estoque = @id_estoque";

                        MySqlCommand cmd = new MySqlCommand(sqlDelete, con);

                        cmd.Parameters.AddWithValue("@id_estoque", idSelecionado);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Produto excluído com sucesso!");


                    }

                    catch (Exception ex)
                    {

                    }


                }
            }
            else
            {
                MessageBox.Show("Selecione um produto para excluir.");

            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

            (dvgEstoque.DataSource as DataTable).DefaultView.RowFilter =
                "produto LIKE '%" + txtPesquisa.Text + "%'" +
                " OR Convert(id_estoque, 'System.String') LIKE '%" + txtPesquisa.Text + "%'";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeTela home = new HomeTela();
            home.ShowDialog();
            this.Close();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            TelaEstoque estoque = new TelaEstoque();
            estoque.ShowDialog();
            this.Close();
        }

        private void btnPdv_Click(object sender, EventArgs e)
        {
            PDV pdv = new PDV();
            pdv.ShowDialog();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnestoqueSimples_Click(object sender, EventArgs e)
        {
            TelaEstoque estoque = new TelaEstoque();
            estoque.ShowDialog();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
