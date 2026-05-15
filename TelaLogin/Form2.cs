using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Linq.Expressions;
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

            this.FormBorderStyle = FormBorderStyle.None;

           

            

            label10.Text = "📅 " + DateTime.Now.ToString("dd/MM/yyyy") +
                           "   🕒 " + DateTime.Now.ToString("HH:mm:ss");

            LbNom.Text = Sessao.Usuario + " está realizando uma venda";
            EstilizarGrid();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SessaoTimer.Iniciar(this);
            this.FormBorderStyle = FormBorderStyle.None;

            CarregarProdutos();

            txtPreco.ReadOnly = true;

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("produto", "Produto");
            dataGridView1.Columns.Add("preco", "Preço");
            dataGridView1.Columns.Add("qtd", "Qtd");
            dataGridView1.Columns.Add("total", "Total");

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
            Environment.Exit(0);
        }

        private void btnVender_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
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
                    foreach (DataGridViewRow row in dataGridView1.Rows)
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
                    foreach (DataGridViewRow row in dataGridView1.Rows)
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
                    dataGridView1.Rows.Clear();
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
                foreach (DataGridViewRow row in dataGridView1.Rows)
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
                dataGridView1.Rows.Add(idProduto, nomeProduto, precoUnitario, quantidadeSolicitada, totalItem);

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
            foreach (DataGridViewRow row in dataGridView1.Rows)
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

        private void DvgPdv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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


        private void RemoverProduto()
        {
            // Verifica se há uma linha selecionada
            if (dataGridView1.CurrentRow != null && dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show(
                    "Deseja remover este item do carrinho?",
                    "Remover Item",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    // Remove a linha selecionada do DataGridView
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                    // Atualiza o total geral da nota após remover
                    AtualizarTotalGeral();

                    MessageBox.Show("Item removido do carrinho com sucesso!");
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha inteira na lista para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void rButton1_Click(object sender, EventArgs e)
        {
            RemoverProduto();
            CarregarProdutos();
        }

        private void rButton2_Click(object sender, EventArgs e)
        {
            // 1. Verificação básica: Tem algo no grid para cancelar?
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Não há itens lançados para cancelar.");
                return;
            }

            DialogResult confirmar = MessageBox.Show("Deseja realmente cancelar esta operação? Os itens retornarão ao estoque.", "Confirmar Cancelamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                using (MySqlConnection con = new MySqlConnection(conexao))
                {
                    con.Open();
                    MySqlTransaction trans = con.BeginTransaction();

                    try
                    {
                        // 2. Devolver os itens que estão no Grid para o Estoque
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.IsNewRow) continue;

                            int idProd = Convert.ToInt32(row.Cells["id"].Value);
                            int qtd = Convert.ToInt32(row.Cells["qtd"].Value);

                            // Soma de volta ao estoque o que havia sido "reservado" ou baixado no lançamento
                            string updateEstoque = "UPDATE estoque SET quantidade = quantidade + @qtd WHERE id_produtodoestoque = @idProd";
                            MySqlCommand cmdEstoque = new MySqlCommand(updateEstoque, con, trans);
                            cmdEstoque.Parameters.AddWithValue("@qtd", qtd);
                            cmdEstoque.Parameters.AddWithValue("@idProd", idProd);
                            cmdEstoque.ExecuteNonQuery();
                        }

                        // 3. Registrar o cancelamento na tabela de vendas (mesmo sem finalizar)
                        // Isso serve para o seu relatório de "Vendas Abortadas"
                        decimal totalGeral = 0;
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.IsNewRow) continue;
                            totalGeral += Convert.ToDecimal(row.Cells["total"].Value);
                        }

                        string sqlCancelamento = "INSERT INTO vendas (total_venda, status_venda, forma_pagamento) VALUES (@total, 'Abortada', 'Nenhum')";
                        MySqlCommand cmdCancel = new MySqlCommand(sqlCancelamento, con, trans);
                        cmdCancel.Parameters.AddWithValue("@total", totalGeral);
                        cmdCancel.ExecuteNonQuery();

                        // 4. Finaliza a transação no banco
                        trans.Commit();

                        // 5. Limpa a interface para o próximo cliente
                        dataGridView1.Rows.Clear();
                        txtTotal.Text = "Total: R$ 0,00";
                        txtQtd.Clear();

                        MessageBox.Show("Operação cancelada. O estoque foi recomposto e o log registrado.");
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show("Erro ao estornar itens: " + ex.Message);
                    }
                }
            }
        }
    }
}


