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
            SessaoTimer.Iniciar(this);
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;

            CarregarProdutos();

            txtPreco.ReadOnly = true;

            DvgPdv.Columns.Add("id", "ID");
            DvgPdv.Columns.Add("produto", "Produto");
            DvgPdv.Columns.Add("preco", "Preço");
            DvgPdv.Columns.Add("qtd", "Qtd");
            DvgPdv.Columns.Add("total", "Total");

            comboPagamento.Items.AddRange(new string[]
{
                "Dinheiro",
                "Pix",
                "Cartão",
                "Débito",
                "Crédito"
                        });


        }

        //  CARREGA PRODUTOS NA COMBOBOX
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

            if (DvgPdv.Rows.Count == 0)
            {
                MessageBox.Show("Adicione produtos na venda!");
                return;
            }

            if (string.IsNullOrWhiteSpace(comboPagamento.Text))
            {
                MessageBox.Show("Selecione a forma de pagamento!");
                return;
            }

            using (MySqlConnection con = new MySqlConnection(conexao))
            {
                con.Open();
                MySqlTransaction trans = con.BeginTransaction();

                try
                {
                    foreach (DataGridViewRow row in DvgPdv.Rows)
                    {
                        //  ignora linha vazia
                        if (row.IsNewRow) continue;

                        int id = Convert.ToInt32(row.Cells["id"].Value);
                        decimal preco = Convert.ToDecimal(row.Cells["preco"].Value);
                        int qtd = Convert.ToInt32(row.Cells["qtd"].Value);
                        decimal total = Convert.ToDecimal(row.Cells["total"].Value);

                        //  VERIFICAR ESTOQUE
                        string check = "SELECT quantidade FROM estoque WHERE id_produtodoestoque = @id";
                        MySqlCommand cmdCheck = new MySqlCommand(check, con, trans);
                        cmdCheck.Parameters.AddWithValue("@id", id);

                        object resultado = cmdCheck.ExecuteScalar();

                        if (resultado == null)
                            throw new Exception("Produto não encontrado no estoque!");

                        int estoqueAtual = Convert.ToInt32(resultado);

                        if (qtd > estoqueAtual)
                            throw new Exception($"Estoque insuficiente para o produto ID {id}");

                        // 🧾 INSERT NA TABELA PDV
                        string sql = @"
                INSERT INTO pdv
                (id_produtopdv, precopdv, quantidadepdv, formadepagamento, totalpagarpdv)
                VALUES
                (@id, @preco, @qtd, @pagamento, @total)";

                        MySqlCommand cmd = new MySqlCommand(sql, con, trans);

                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@preco", preco);
                        cmd.Parameters.AddWithValue("@qtd", qtd);
                        cmd.Parameters.AddWithValue("@pagamento", comboPagamento.Text);
                        cmd.Parameters.AddWithValue("@total", total);

                        cmd.ExecuteNonQuery();

                        // 📦 ATUALIZAR ESTOQUE
                        string update = @"
                            UPDATE estoque 
                            SET quantidade = quantidade - @qtd 
                            WHERE id_produtodoestoque = @id";

                        MySqlCommand cmd2 = new MySqlCommand(update, con, trans);

                        cmd2.Parameters.AddWithValue("@qtd", qtd);
                        cmd2.Parameters.AddWithValue("@id", id);

                        int linhasAfetadas = cmd2.ExecuteNonQuery();

                        if (linhasAfetadas == 0)
                            throw new Exception("Erro ao atualizar o estoque!");
                    }

                    //  CONFIRMA TUDO
                    trans.Commit();

                    MessageBox.Show("Venda finalizada com sucesso!");

                    //  limpar tela
                    DvgPdv.Rows.Clear();
                    txtTotal.Clear();
                    txtQtd.Clear();
                    txtPreco.Clear();
                }
                catch (Exception ex)
                {

                    trans.Rollback();
                    MessageBox.Show("Erro na venda: " + ex.Message);
                }
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

        private void txtQtd_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtQtd.Text, out int qtd) &&
        decimal.TryParse(txtPreco.Text, out decimal preco))
            {
                txtTotal.Text = (qtd * preco).ToString("F2");
            }
        }

        private void comboProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboProduto.SelectedItem is DataRowView row)
            {

                txtPreco.Text = Convert.ToDecimal(row["precoproduto"]).ToString("F2");


                txtId.Text = row["id_produtos"].ToString();
            }
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {

            if (comboProduto.SelectedValue == null ||
                string.IsNullOrWhiteSpace(txtQtd.Text))
            {
                MessageBox.Show("Preencha os campos!");
                return;
            }

            int id = Convert.ToInt32(comboProduto.SelectedValue);
            string produto = comboProduto.Text;
            decimal preco = Convert.ToDecimal(txtPreco.Text);
            int qtd = Convert.ToInt32(txtQtd.Text);

            using (MySqlConnection con = new MySqlConnection(conexao))
            {
                try
                {
                    con.Open();

                    // 🔎 BUSCAR ESTOQUE
                    string sql = "SELECT quantidade FROM estoque WHERE id_produtodoestoque = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id", id);

                    object resultado = cmd.ExecuteScalar();

                    if (resultado == null)
                    {
                        MessageBox.Show("Produto não encontrado no estoque!");
                        return;
                    }

                    int estoqueAtual = Convert.ToInt32(resultado);

                    // 🔥 VALIDAÇÃO
                    if (qtd > estoqueAtual)
                    {
                        MessageBox.Show($"Estoque insuficiente! Disponível: {estoqueAtual}");
                        return;
                    }

                    // ✅ SE PASSAR, ADICIONA
                    decimal total = preco * qtd;
                    DvgPdv.Rows.Add(id, produto, preco, qtd, total);

                    // limpar campos
                    txtQtd.Clear();
                    txtTotal.Clear();

                    AtualizarTotalGeral();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }


        private void AtualizarTotalGeral()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in DvgPdv.Rows)
            {
                if (row.Cells["total"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["total"].Value);
                }
            }

            txtTotal.Text = "Total: R$ " + total.ToString("F2");
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            TelaEstoque estoque = new();
            estoque.ShowDialog();
            this.Close();

        }
    }
}

