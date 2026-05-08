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

            // 2. Define o tamanho máximo como a área útil (sem a Taskbar)
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            // 3. Maximiza o form
            this.WindowState = FormWindowState.Maximized;

            lbdok.Text = "📅 " + DateTime.Now.ToString("dd/MM/yyyy") +
                           "   🕒 " + DateTime.Now.ToString("HH:mm:ss");

            lbhead.Text = Sessao.Usuario + " está verificando os registros";
            CarregarRelatorio();
            EstilizarGrid();


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

    }
}

