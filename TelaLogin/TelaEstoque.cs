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
            this.FormBorderStyle = FormBorderStyle.None;

            // 2. Define o tamanho máximo como a área útil (sem a Taskbar)
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            // 3. Maximiza o form
            this.WindowState = FormWindowState.Maximized;

            attgrid objeto = new attgrid(this.dataGridView1);
            objeto.updategridProdutos();

            lbRelogio.Text = "📅 " + DateTime.Now.ToString("dd/MM/yyyy") +
                  "🕒 " + DateTime.Now.ToString("HH:mm:ss");

            lbbabel.Text = Sessao.Usuario + " está monitorando o estoque";
        }

        private void TelaEstoque_Load(object sender, EventArgs e)
        {
            SessaoTimer.Iniciar(this);
            dataGridView1.Columns["id_produtos"].ReadOnly = true;

            conectar conectar = new conectar();
            MySqlConnection con = conectar.conectando();

            try
            {
                con.Open();
                string sql = "SELECT * FROM produtos";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter estoque = new MySqlDataAdapter(cmd);
                DataTable qualquercoisa = new DataTable();
                estoque.Fill(qualquercoisa);
                dataGridView1.DataSource = qualquercoisa;
            }
            catch { }
            EstilizarGrid();

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
                " OR Convert(id_produtos, 'System.String') LIKE '%" + txtPesquisa.Text + "%'";
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
            FormAddProduto f = new FormAddProduto();
            f.ShowDialog();
            attgrid objeto = new attgrid(this.dataGridView1);
            objeto.updategridProdutos();
        }

        private void btndeletep_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
            {
                DialogResult resultado = MessageBox.Show(
                    "Deseja remover este item do estoque?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        int idproduto = Convert.ToInt32(
                            dataGridView1.CurrentRow.Cells["id_produtos"].Value
                        );

                        using (MySqlConnection con = new MySqlConnection(conexao))
                        {
                            con.Open();

                            string sql = "DELETE FROM produtos WHERE id_produtos = @id";
                            MySqlCommand cmd = new MySqlCommand(sql, con);
                            cmd.Parameters.AddWithValue("@id", idproduto);

                            int linhas = cmd.ExecuteNonQuery();

                            if (linhas > 0)
                                MessageBox.Show("Item removido do estoque!");
                            else
                                MessageBox.Show("Nada foi removido (id não encontrado).");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir: " + ex.Message);
                    }
                    finally
                    {
                        attgrid at = new attgrid(this.dataGridView1);
                        at.updategridProdutos();
                    }
                }

                else
                {
                    MessageBox.Show("Selecione um produto para excluir.");

                }
            }
        }












        private void txtPesquisa_TextChanged_1(object sender, EventArgs e)
        {

            try
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
                    $"produto LIKE '%{txtPesquisa.Text}%' " +
                    $"OR Convert(id_produtos, 'System.String') LIKE '%{txtPesquisa.Text}%'";
            }
            catch { }
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            TelaEstoque estoque = new TelaEstoque();
            estoque.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EstoqueDetalhado tela = new EstoqueDetalhado();
            tela.ShowDialog();
            this.Close();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            

               
        }
        private void TxtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)8 &&
                e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // impede mais de uma vírgula
            TextBox txt = sender as TextBox;

            if (e.KeyChar == ',' && txt.Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell.OwningColumn.Name == "precoproduto")
            {
                TextBox txt = e.Control as TextBox;

                if (txt != null)
                {
                    txt.KeyPress -= TxtPreco_KeyPress;
                    txt.KeyPress += TxtPreco_KeyPress;
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                using (MySqlConnection con = new MySqlConnection(conexao))
                {
                    con.Open();

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int id = Convert.ToInt32(
                            row.Cells["id_produtos"].Value);

                        string produto =
                            row.Cells["produto"].Value.ToString();

                        decimal preco = Convert.ToDecimal(
                            row.Cells["precoproduto"].Value);

                        string sql = @"
                                UPDATE produtos
                                SET produto = @produto,
                                precoproduto = @preco
                                WHERE id_produtos = @id";

                        MySqlCommand cmd = new MySqlCommand(sql, con);

                        cmd.Parameters.AddWithValue("@produto", produto);
                        cmd.Parameters.AddWithValue("@preco", preco);
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                    }
                    
                    string sql1 = "SELECT * FROM produtos";
                        MySqlCommand cmd1 = new MySqlCommand(sql1, con);
                        MySqlDataAdapter estoque = new MySqlDataAdapter(cmd1);
                        DataTable qualquercoisa = new DataTable();
                        estoque.Fill(qualquercoisa);
                        dataGridView1.DataSource = qualquercoisa;
                }
                        

                MessageBox.Show("Alterações salvas!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            
               
            
        }
        private void EstilizarGrid()
        {
            // ====================================
            // APARÊNCIA GERAL
            // ====================================

            dataGridView1.BorderStyle = BorderStyle.None;

            dataGridView1.BackgroundColor = Color.Black;

            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.RowHeadersVisible = false;

            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.AllowUserToResizeRows = false;

            dataGridView1.MultiSelect = false;

            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            // ====================================
            // CABEÇALHO
            // ====================================

            dataGridView1.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor =
                Color.Black;

            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dataGridView1.ColumnHeadersHeight = 35;

            // ====================================
            // LINHAS
            // ====================================

            dataGridView1.DefaultCellStyle.BackColor =
                Color.Black;

            dataGridView1.DefaultCellStyle.ForeColor =
                Color.White;

            dataGridView1.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            // ====================================
            // SELEÇÃO
            // ====================================

            dataGridView1.DefaultCellStyle.SelectionBackColor =
                Color.White;

            dataGridView1.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            // ====================================
            // GRID
            // ====================================

            dataGridView1.GridColor = Color.DimGray;

            // ====================================
            // LINHAS ALTERNADAS
            // ====================================

            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(20, 20, 20);

            // ====================================
            // AUTO AJUSTE
            // ====================================

            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            // ====================================
            // ALTURA DAS LINHAS
            // ====================================

            dataGridView1.RowTemplate.Height = 30;

            // ====================================
            // TIRAR FOCO AZUL
            // ====================================

            dataGridView1.DefaultCellStyle.SelectionBackColor =
                Color.White;

            dataGridView1.DefaultCellStyle.SelectionForeColor =
                Color.Black;
        }
    }
}








