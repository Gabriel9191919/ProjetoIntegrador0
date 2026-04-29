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
using System.Windows.Forms.DataVisualization.Charting;

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

            lbRelogio.Text = "📅 " + DateTime.Now.ToString("dd/MM/yyyy") +
                  "🕒 " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void TelaEstoque_Load(object sender, EventArgs e)
        {


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
                dataGridView1.DataSource = qualquercoisa;











            }
            catch { }

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
            EstoqueDetalhado estoque = new EstoqueDetalhado();
            estoque.ShowDialog();
            this.Close();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbRelogio.Text = "📅 " + DateTime.Now.ToString("dd/MM/yyyy") +
                  "🕒 " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {


        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {



            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
                "produto LIKE '%" + txtPesquisa.Text + "%'" +
                " OR Convert(id_estoque, 'System.String') LIKE '%" + txtPesquisa.Text + "%'";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {


            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione um produto!");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_estoque"].Value);
            int quantidade = Convert.ToInt32(dataGridView1.CurrentRow.Cells["quantidade"].Value);

            quantidade++;

            MySqlConnection con = new MySqlConnection(conexao);

            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand(
                    "UPDATE estoque SET quantidade = @qtd WHERE id_estoque = @id", con);

                cmd.Parameters.AddWithValue("@qtd", quantidade);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }


            attgrid objeto = new attgrid(this.dataGridView1);
            objeto.updategrid();
            Aviso aviso = new Aviso(
            "Estoque",
            "Quantidade aumentada!",
            new Point(Screen.PrimaryScreen.WorkingArea.Width - 320,
                  Screen.PrimaryScreen.WorkingArea.Height - 100),
            Color.LightSkyBlue
    );

            aviso.Show();






        }

        private void btnRemover_Click(object sender, EventArgs e)
        {



            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione um produto!");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_estoque"].Value);
            int quantidade = Convert.ToInt32(dataGridView1.CurrentRow.Cells["quantidade"].Value);

            quantidade--;

            MySqlConnection con = new MySqlConnection(conexao);

            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand(
                    "UPDATE estoque SET quantidade = @qtd WHERE id_estoque = @id", con);

                cmd.Parameters.AddWithValue("@qtd", quantidade);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }


            attgrid objeto = new attgrid(this.dataGridView1);
            objeto.updategrid();
            Aviso aviso = new Aviso(
            "Estoque",
            "Quantidade Reduzida!",
            new Point(Screen.PrimaryScreen.WorkingArea.Width - 320,
                  Screen.PrimaryScreen.WorkingArea.Height - 100),
            Color.LightSkyBlue
    );

            aviso.Show();





        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }


}





