using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Numerics;
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

            DvgPdv.Columns.Clear();
            DvgPdv.Columns.Add("id", "ID");
            DvgPdv.Columns.Add("produto", "Produto");
            DvgPdv.Columns.Add("preco", "Preço");
            DvgPdv.Columns.Add("qtd", "Qtd");
            DvgPdv.Columns.Add("total", "Total");

            comboPagamento.Items.AddRange(new string[] { "Dinheiro", "Pix", "Cartão", "Débito", "Crédito" });
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
            catch (Exception ex) { MessageBox.Show("Erro ao carregar produtos: " + ex.Message); }
        }

        // 💰 PREÇO AUTOMÁTICO
        private void comboBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboProduto.SelectedItem is DataRowView row)
            {
                txtPreco.Text = Convert.ToDecimal(row["precoproduto"]).ToString("F2");
                txtId.Text = row["id_produtos"].ToString();
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
                // 1. MUDANÇA: Iniciamos uma Transação. Se algo der errado nos itens, a Venda também é cancelada.
                MySqlTransaction trans = con.BeginTransaction();

                try
                {
                    // 2. MUDANÇA: Calcular o total da nota percorrendo o Grid
                    decimal totalGeralDaNota = 0;
                    foreach (DataGridViewRow row in DvgPdv.Rows)
                    {
                        if (row.IsNewRow) continue;
                        totalGeralDaNota += Convert.ToDecimal(row.Cells["total"].Value);
                    }

                    // 3. MUDANÇA: Inserir primeiro na tabela MESTRE (vendas)
                    string sqlVenda = "INSERT INTO vendas (total_venda, forma_pagamento) VALUES (@total, @pagamento)";
                    MySqlCommand cmdVenda = new MySqlCommand(sqlVenda, con, trans);
                    cmdVenda.Parameters.AddWithValue("@total", totalGeralDaNota);
                    cmdVenda.Parameters.AddWithValue("@pagamento", comboPagamento.Text);
                    cmdVenda.ExecuteNonQuery();

                    // 4. MUDANÇA CHAVE: Capturar o ID da venda que o MySQL acabou de gerar
                    long idVendaGerada = cmdVenda.LastInsertedId;

                    // 5. MUDANÇA: Agora percorremos o Grid para salvar cada item vinculado a esse ID
                    foreach (DataGridViewRow row in DvgPdv.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int idProd = Convert.ToInt32(row.Cells["id"].Value);
                        decimal precoUnit = Convert.ToDecimal(row.Cells["preco"].Value);
                        int qtd = Convert.ToInt32(row.Cells["qtd"].Value);

                        // Inserir na tabela DETALHE (itens_venda)
                        string sqlItens = @"INSERT INTO itens_venda (id_venda, id_produto, quantidade, preco_unitario_venda) 
                                            VALUES (@idVenda, @idProd, @qtd, @preco)";

                        MySqlCommand cmdItens = new MySqlCommand(sqlItens, con, trans);
                        cmdItens.Parameters.AddWithValue("@idVenda", idVendaGerada); // <-- O vínculo da nota
                        cmdItens.Parameters.AddWithValue("@idProd", idProd);
                        cmdItens.Parameters.AddWithValue("@qtd", qtd);
                        cmdItens.Parameters.AddWithValue("@preco", precoUnit);
                        cmdItens.ExecuteNonQuery();

                        // 6. MUDANÇA: Baixar o estoque aqui dentro do loop
                        string updateEstoque = "UPDATE estoque SET quantidade = quantidade - @qtd WHERE id_produtodoestoque = @idProd";
                        MySqlCommand cmdEstoque = new MySqlCommand(updateEstoque, con, trans);
                        cmdEstoque.Parameters.AddWithValue("@qtd", qtd);
                        cmdEstoque.Parameters.AddWithValue("@idProd", idProd);
                        cmdEstoque.ExecuteNonQuery();
                    }

                    // Se tudo correu bem até aqui, confirma no Banco de Dados
                    trans.Commit();
                    MessageBox.Show($"Venda #{idVendaGerada} (Nota Fiscal) registrada com sucesso!");

                    // Limpar interface
                    DvgPdv.Rows.Clear();
                    txtTotal.Text = "Total: R$ 0,00";
                    txtQtd.Clear();
                }
                catch (Exception ex)
                {
                    // Se der qualquer erro (ex: falta de estoque de um item), desfaz tudo
                    trans.Rollback();
                    MessageBox.Show("Erro ao processar venda: " + ex.Message);
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
            // 1. VALIDAÇÃO INICIAL: Verifica se os campos básicos estão preenchidos
            if (comboProduto.SelectedValue == null || string.IsNullOrWhiteSpace(txtQtd.Text))
            {
                MessageBox.Show("Por favor, selecione um produto e informe a quantidade!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. CAPTURA DE DADOS: Coleta as informações dos controles
                int idProduto = Convert.ToInt32(comboProduto.SelectedValue);
                string nomeProduto = comboProduto.Text;
                decimal precoUnitario = Convert.ToDecimal(txtPreco.Text);
                int quantidadeSolicitada = Convert.ToInt32(txtQtd.Text);
                int estoqueDisponivelNoBanco = 0;

                // 3. CONSULTA AO BANCO: Verifica a quantidade real disponível no estoque agora
                using (MySqlConnection con = new MySqlConnection(conexao))
                {
                    con.Open();
                    string sqlEstoque = "SELECT quantidade FROM estoque WHERE id_produtodoestoque = @id";
                    MySqlCommand cmd = new MySqlCommand(sqlEstoque, con);
                    cmd.Parameters.AddWithValue("@id", idProduto);

                    object resultado = cmd.ExecuteScalar();
                    if (resultado != null)
                    {
                        estoqueDisponivelNoBanco = Convert.ToInt32(resultado);
                    }
                }

                // 4. VERIFICAÇÃO DO CARRINHO (GRID): Soma o que já foi adicionado na tela
                int quantidadeJaNoCarrinho = 0;
                foreach (DataGridViewRow row in DvgPdv.Rows)
                {
                    if (row.Cells["id"].Value != null && Convert.ToInt32(row.Cells["id"].Value) == idProduto)
                    {
                        quantidadeJaNoCarrinho += Convert.ToInt32(row.Cells["qtd"].Value);
                    }
                }

                // 5. VALIDAÇÃO FINAL DE ESTOQUE: Bloqueia se a soma (Carrinho + Novo) for maior que o Banco
                if (quantidadeJaNoCarrinho + quantidadeSolicitada > estoqueDisponivelNoBanco)
                {
                    int saldoReal = estoqueDisponivelNoBanco - quantidadeJaNoCarrinho;
                    MessageBox.Show($"Estoque insuficiente!\n\nDisponível no sistema: {estoqueDisponivelNoBanco}\nJá no carrinho: {quantidadeJaNoCarrinho}\nSaldo para adicionar: {saldoReal}",
                                    "Estoque Baixo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 6. ADIÇÃO AO DATAGRIDVIEW: Calcula o total do item e joga na lista
                decimal totalItem = precoUnitario * quantidadeSolicitada;
                DvgPdv.Rows.Add(idProduto, nomeProduto, precoUnitario, quantidadeSolicitada, totalItem);

                // 7. ATUALIZAÇÃO DA INTERFACE: Limpa campos e atualiza o total da nota
                txtQtd.Clear();
                txtTotal.Clear(); // Limpa o subtotal da caixa de texto se houver
                AtualizarTotalGeral(); // Chama sua função que soma a coluna 'total' do Grid

                comboProduto.Focus(); // Volta o foco para facilitar a próxima venda
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar produto: " + ex.Message, "Erro técnico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AtualizarTotalGeral()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in DvgPdv.Rows)
            {
                if (row.Cells["total"].Value != null)
                    total += Convert.ToDecimal(row.Cells["total"].Value);
            }
            txtTotal.Text = "Total: R$ " + total.ToString("F2");
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboProduto.SelectedItem is DataRowView row)
            {
                txtPreco.Text = Convert.ToDecimal(row["precoproduto"]).ToString("F2");
                txtId.Text = row["id_produtos"].ToString();
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 telarela = new Form5();
            telarela.ShowDialog();
            this.Close();
        }
    }
}

