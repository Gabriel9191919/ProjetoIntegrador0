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

namespace TelaLogin
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;

           




            lbdok.Text = "📅 " + DateTime.Now.ToString("dd/MM/yyyy") +
                           "   🕒 " + DateTime.Now.ToString("HH:mm:ss");

            lbhead.Text = Sessao.Usuario + " está verificando os registros";
            CarregarRelatorio();
            EstilizarGrid();
            gridrt.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView1_CellFormatting);



        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeTela home = new HomeTela();
            home.ShowDialog();
            this.Close();
        }

        private void CarregarRelatorio()
        {
            conectar conectar = new conectar();
            MySqlConnection con = conectar.conectando();

            try
            {
                con.Open();
                string sql = @"
            SELECT 
                v.id_venda AS 'Cód.', 
                DATE_FORMAT(v.data_venda, '%d/%m/%Y %H:%i') AS 'Data/Hora',
                GROUP_CONCAT(CONCAT(iv.quantidade, 'x ', p.produto) SEPARATOR '\n') AS 'Itens do Cupom',
                v.total_venda AS 'Total',
                v.forma_pagamento AS 'Pagamento',
                v.status_venda AS 'Status'
            FROM vendas v
            INNER JOIN itens_venda iv ON v.id_venda = iv.id_venda
            INNER JOIN produtos p ON iv.id_produto = p.id_produtos
            GROUP BY v.id_venda
            ORDER BY v.data_venda DESC";

                MySqlDataAdapter de = new MySqlDataAdapter(sql, con);
                DataTable du = new DataTable();
                de.Fill(du);

                gridrt.DataSource = du;

                // --- CONFIGURAÇÃO VISUAL DO CUPOM ---
                gridrt.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                gridrt.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                gridrt.Columns["Itens do Cupom"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
                // ------------------------------------
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void EstilizarGrid()
        {
            // ====================================
            // APARÊNCIA GERAL
            // ====================================

            gridrt.BorderStyle = BorderStyle.None;

            gridrt.BackgroundColor = Color.Black;

            gridrt.EnableHeadersVisualStyles = false;

            gridrt.RowHeadersVisible = false;

            gridrt.AllowUserToAddRows = false;

            gridrt.AllowUserToResizeRows = false;

            gridrt.MultiSelect = false;

            gridrt.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            // ====================================
            // CABEÇALHO
            // ====================================

            gridrt.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            gridrt.ColumnHeadersDefaultCellStyle.BackColor =
                Color.Black;

            gridrt.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            gridrt.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            gridrt.ColumnHeadersHeight = 35;

            // ====================================
            // LINHAS
            // ====================================

            gridrt.DefaultCellStyle.BackColor =
                Color.Black;

            gridrt.DefaultCellStyle.ForeColor =
                Color.White;

            gridrt.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            // ====================================
            // SELEÇÃO
            // ====================================

            gridrt.DefaultCellStyle.SelectionBackColor =
                Color.White;

            gridrt.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            // ====================================
            // GRID
            // ====================================

            gridrt.GridColor = Color.DimGray;

            // ====================================
            // LINHAS ALTERNADAS
            // ====================================

            gridrt.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(20, 20, 20);

            // ====================================
            // AUTO AJUSTE
            // ====================================

            gridrt.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            // ====================================
            // ALTURA DAS LINHAS
            // ====================================

            gridrt.RowTemplate.Height = 30;

            // ====================================
            // TIRAR FOCO AZUL
            // ====================================

            gridrt.DefaultCellStyle.SelectionBackColor =
                Color.White;

            gridrt.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            // Permite que o texto quebre a linha dentro da célula
            gridrt.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Ajusta a altura das linhas automaticamente para caber os produtos
            gridrt.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Opcional: Ajusta a largura das colunas para preencher a tela
            gridrt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            TelaEstoque produto = new TelaEstoque();
            produto.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EstoqueDetalhado estoque = new EstoqueDetalhado();
            estoque.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PDV pdv = new PDV();
            pdv.ShowDialog();
            this.Close();
        }

        private void BtnTrocarSessao_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica se estamos na coluna correta (ajuste o nome "Status" para o nome da sua coluna)
            if (gridrt.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string status = e.Value.ToString().ToLower();

                if (status == "concluida" || status == "concluída")
                {
                    // Pinta o fundo da célula de verde e o texto de branco para melhor contraste
                    e.CellStyle.BackColor = Color.LightGreen;
                    e.CellStyle.ForeColor = Color.Black;
                }
                else if (status == "cancelado" || status == "cancelada")
                {
                    // Pinta o fundo da célula de vermelho
                    e.CellStyle.BackColor = Color.LightCoral;
                    e.CellStyle.ForeColor = Color.White;
                }
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}

