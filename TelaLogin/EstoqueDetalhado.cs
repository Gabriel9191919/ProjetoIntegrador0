using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace TelaLogin
{
    public partial class EstoqueDetalhado : Form
    {
        string conexao = "server=localhost;uid=root;pwd=;database=adega_jm;";

        public EstoqueDetalhado()
        {
            InitializeComponent();
        }

        private void EstoqueDetalhado_Load(object sender, EventArgs e)
        {
            AtualizarRelogio();
            CarregarEstoque();
            SessaoTimer.Iniciar(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AtualizarRelogio();
        }

        private void AtualizarRelogio()
        {
            lbRelogio.Text = "📅 " + DateTime.Now.ToString("dd/MM/yyyy") +
                             " 🕒 " + DateTime.Now.ToString("HH:mm:ss");
        }

        // 🔥 MÉTODO COM INNER JOIN
        private void CarregarEstoque()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(conexao))
                {
                    con.Open();

                    string sql = @"
                    SELECT 
                        e.id_estoque,
                        p.produto,
                        p.precoproduto,
                        e.quantidade,
                        e.datavencimento
                        
                    FROM estoque e
                    INNER JOIN produtos p 
                        ON e.id_produtodoestoque = p.id_produtos";

                    MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dvgEstoque.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar estoque: " + ex.Message);
            }
        }

        // ➕ ADICIONAR PRODUTO
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form3 telaadd = new Form3();
            telaadd.StartPosition = FormStartPosition.Manual;
            telaadd.Location = new Point(200, 150);

            telaadd.ShowDialog();

            CarregarEstoque(); // 🔄 atualiza grid
        }

        // ❌ DELETAR CORRIGIDO
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

                    try
                    {
                        using (MySqlConnection con = new MySqlConnection(conexao))
                        {
                            con.Open();

                            string sqlDelete = "DELETE FROM estoque WHERE id_estoque = @id";

                            MySqlCommand cmd = new MySqlCommand(sqlDelete, con);
                            cmd.Parameters.AddWithValue("@id", idSelecionado);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Produto excluído com sucesso!");
                        CarregarEstoque();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto para excluir.");
            }
        }

        // 🔍 PESQUISA FUNCIONANDO COM JOIN
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (dvgEstoque.DataSource as DataTable).DefaultView.RowFilter =
                    $"produto LIKE '%{txtPesquisa.Text}%' " +
                    $"OR Convert(id_estoque, 'System.String') LIKE '%{txtPesquisa.Text}%'";
            }
            catch { }
        }

        // 🔄 NAVEGAÇÃO
        private void btnHome_Click(object sender, EventArgs e)
        {
            new HomeTela().ShowDialog();
            this.Close();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            new EstoqueDetalhado().ShowDialog();
            this.Close();
        }

        private void btnPdv_Click(object sender, EventArgs e)
        {
            new PDV().ShowDialog();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnestoqueSimples_Click(object sender, EventArgs e)
        {
            new TelaEstoque().ShowDialog();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            SessaoTimer.Resetar();
            base.OnMouseMove(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            SessaoTimer.Resetar();
            base.OnKeyPress(e);
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            TelaEstoque estoque = new TelaEstoque();
            estoque.ShowDialog();
            this.Close();
        }
    }
}