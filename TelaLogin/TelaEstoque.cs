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
            telaadd.ShowDialog();
            telaadd.StartPosition = FormStartPosition.Manual;
            telaadd.Location = new Point(200, 150);


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbRelogio.Text = "📅 " + DateTime.Now.ToString("dd/MM/yyyy") +
                  "🕒 " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
            {
                // 🔥 Caixa de confirmação
                DialogResult resultado = MessageBox.Show(
                    "Tem certeza que deseja excluir este produto?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.Yes)
                {
                    int idSelecionado = Convert.ToInt32(
                        dataGridView1.CurrentRow.Cells["id_estoque"].Value
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
    }


}





