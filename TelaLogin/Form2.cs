using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace TelaLogin
{
    public partial class PDV : Form
    {
        string conexao = "server=localhost;uid=root;pwd=;database=adega_jm;";

        public PDV()
        {
            InitializeComponent();

            label10.Text = "📅 " + DateTime.Now.ToString("dd/MM/yyyy") +
                           "   🕒 " + DateTime.Now.ToString("HH:mm:ss");

            LbNom.Text = Sessao.Usuario + " está realizando uma venda";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;

            CarregarProdutos();

            txtPreco.ReadOnly = true; // 🔥 preço não editável
        }

        // 🔽 CARREGA PRODUTOS NA COMBOBOX
        private void CarregarProdutos()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(conexao))
                {
                    con.Open();

                    string sql = "SELECT id_produtos, produto, precoproduto FROM produtos";

                    MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboProduto.DataSource = dt;
                    comboProduto.DisplayMember = "produto";
                    comboProduto.ValueMember = "id_produtos";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
            }
        }

        // 💰 PREÇO AUTOMÁTICO
        private void comboBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboProduto.SelectedItem != null)
            {
                DataRowView row = comboProduto.SelectedItem as DataRowView;
                txtPreco.Text = row["precoproduto"].ToString();
            }
        }

        // 🔢 CALCULAR TOTAL AUTOMÁTICO
        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtQtd.Text, out int qtd) &&
                decimal.TryParse(txtPreco.Text, out decimal preco))
            {
                txtTotal.Text = (qtd * preco).ToString("F2");
            }
        }

        // 🧾 BOTÃO VENDER
        private void btnVender_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboProduto.SelectedValue == null ||
                    string.IsNullOrWhiteSpace(txtQtd.Text))
                {
                    MessageBox.Show("Preencha os campos corretamente!");
                    return;
                }

                using (MySqlConnection con = new MySqlConnection(conexao))
                {
                    con.Open();

                    // INSERT NA TABELA PDV
                    string sql = @"
                    INSERT INTO pdv
                    (id_produtopdv, precopdv, quantidadepdv, formadepagamento, totalpagarpdv)
                    VALUES
                    (@idproduto, @preco, @qtd, @pagamento, @total)";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("@idproduto", comboProduto.SelectedValue);
                    cmd.Parameters.AddWithValue("@preco", Convert.ToDecimal(txtPreco.Text));
                    cmd.Parameters.AddWithValue("@qtd", Convert.ToInt32(txtQtd.Text));
                    cmd.Parameters.AddWithValue("@pagamento", comboPagamento.Text);
                    cmd.Parameters.AddWithValue("@total", Convert.ToDecimal(txtTotal.Text));

                    cmd.ExecuteNonQuery();

                    // 🔥 BAIXAR ESTOQUE
                    string update = @"
                    UPDATE estoque 
                    SET quantidade = quantidade - @qtd 
                    WHERE id_produtodoestoque = @idproduto";

                    MySqlCommand cmd2 = new MySqlCommand(update, con);

                    cmd2.Parameters.AddWithValue("@qtd", Convert.ToInt32(txtQtd.Text));
                    cmd2.Parameters.AddWithValue("@idproduto", comboProduto.SelectedValue);

                    cmd2.ExecuteNonQuery();
                }

                MessageBox.Show("Venda realizada com sucesso!");

                // limpar campos
                txtQtd.Clear();
                txtTotal.Clear();
                txtPreco.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVender_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (comboProduto.SelectedValue == null ||
                    string.IsNullOrWhiteSpace(txtQtd.Text))
                {
                    MessageBox.Show("Preencha os campos corretamente!");
                    return;
                }

                using (MySqlConnection con = new MySqlConnection(conexao))
                {
                    con.Open();

                    // INSERT NA TABELA PDV
                    string sql = @"
                    INSERT INTO pdv
                    (id_produtopdv, precopdv, quantidadepdv, formadepagamento, totalpagarpdv)
                    VALUES
                    (@idproduto, @preco, @qtd, @pagamento, @total)";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("@idproduto", comboProduto.SelectedValue);
                    cmd.Parameters.AddWithValue("@preco", Convert.ToDecimal(txtPreco.Text));
                    cmd.Parameters.AddWithValue("@qtd", Convert.ToInt32(txtQtd.Text));
                    cmd.Parameters.AddWithValue("@pagamento", comboPagamento.Text);
                    cmd.Parameters.AddWithValue("@total", Convert.ToDecimal(txtTotal.Text));

                    cmd.ExecuteNonQuery();

                    // 🔥 BAIXAR ESTOQUE
                    string update = @"
                    UPDATE estoque 
                    SET quantidade = quantidade - @qtd 
                    WHERE id_produtodoestoque = @idproduto";

                    MySqlCommand cmd2 = new MySqlCommand(update, con);

                    cmd2.Parameters.AddWithValue("@qtd", Convert.ToInt32(txtQtd.Text));
                    cmd2.Parameters.AddWithValue("@idproduto", comboProduto.SelectedValue);

                    cmd2.ExecuteNonQuery();
                }

                MessageBox.Show("Venda realizada com sucesso!");

                // limpar campos
                txtQtd.Clear();
                txtTotal.Clear();
                txtPreco.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
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
    }
}
