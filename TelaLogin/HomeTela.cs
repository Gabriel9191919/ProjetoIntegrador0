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
    public partial class HomeTela : Form
    {

        bool darkMode = false;
        private string nomeUsuario;
        public HomeTela()
        {
            InitializeComponent();

            

            
            lbRelogio.Text = DateTime.Now.ToLongTimeString();

            timer2.Start();

            lbRelogio.Text = "📅 " + DateTime.Now.ToString("dd/MM/yyyy") +
                   "   🕒 " + DateTime.Now.ToString("HH:mm:ss");




        }







        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            EstoqueDetalhado telaEstoque = new EstoqueDetalhado();
            telaEstoque.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PDV TelaDashboard = new PDV();
            TelaDashboard.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void HomeTela_Load(object sender, EventArgs e)
        {
            SessaoTimer.Iniciar(this);

            LbNome.Text = "Bem-vindo, " + Sessao.Usuario;

            //Menor data de vencimento
            conectar conectar = new conectar();
            MySqlConnection con = conectar.conectando();

            // Produto com o vencimento mais próximo
            try
            {
                con.Open();

                // Ordenamos pela data de vencimento (a menor/mais antiga primeiro)
                // Buscamos o nome do produto e a respectiva data
                string sql = @"
            SELECT p.produto, e.datavencimento 
            FROM estoque e
            INNER JOIN produtos p 
            ON e.id_produtodoestoque = p.id_produtos
            ORDER BY e.datavencimento ASC 
            LIMIT 1;";

                MySqlCommand cmdea = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmdea.ExecuteReader();

                if (reader.Read())
                {
                    string nome = reader["produto"].ToString();

                    // Verificamos se a data não é nula antes de converter
                    if (reader["datavencimento"] != DBNull.Value)
                    {
                        DateTime dataVenc = Convert.ToDateTime(reader["datavencimento"]);

                        // Exibe: "Nome do Produto - Vence em: 25/04/2026"
                        label7.Text = $"{nome} - Vence em: {dataVenc.ToString("dd/MM/yyyy")}";
                    }
                }
                else
                {
                    label7.Text = "Estoque vazio ou sem datas.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar validade: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            // Total de produtos no estoque (Soma de todas as quantidades)
            try
            {
                con.Open();
                // Ajustei "quantitade" para "quantidade" (verifique se no seu banco está com 'd' ou 't')
                string sql = "SELECT SUM(quantidade) FROM estoque;";

                MySqlCommand cmdi = new MySqlCommand(sql, con);

                object resultado = cmdi.ExecuteScalar();

                if (resultado != null && resultado != DBNull.Value)
                {
                    // Convertemos para int ou double, já que é uma contagem de itens
                    int totalItens = Convert.ToInt32(resultado);

                    // Exibe o número no label
                    label6.Text = totalItens.ToString() + " itens totais no estoque";
                }
                else
                {
                    label6.Text = "0 itens";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao somar total do estoque: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            //Produto em menor quantidade no estoque
            try
            {
                con.Open();
                string sql = @"
            SELECT p.produto, e.quantidade 
                FROM estoque e
            INNER JOIN produtos p 
            ON e.id_produtodoestoque = p.id_produtos
            ORDER BY e.quantidade ASC 
                    LIMIT 1;";
                MySqlCommand wcmd = new MySqlCommand(sql, con);

                MySqlDataReader reader = wcmd.ExecuteReader();

                string textoFinal = "Menor produto em estoque:\n";

                // O while vai rodar para os 2 produtos retornados
                while (reader.Read())
                {
                    string nome = reader["produto"].ToString();
                    string qtd = reader["quantidade"].ToString();
                    textoFinal += $"{nome}: {qtd} unidade\n";
                }

                // Exibe no label (certifique-se que o label tenha altura suficiente ou AutoSize = true)
                label5.Text = textoFinal;

                if (!reader.HasRows)
                {
                    label5.Text = "Estoque vazio";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            string query = "SELECT SUM(quantidade) FROM itens_venda";
            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                con.Open();
                // ExecuteScalar é ideal para consultas que retornam apenas um valor (um número)
                object resultado = cmd.ExecuteScalar();

                // Verifica se não é nulo e joga na Label
                label13.Text = resultado != DBNull.Value ? resultado.ToString() : "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            // Produto mais vendido da semana
            string queryu = @"
    SELECT p.produto 
    FROM itens_venda iv 
    JOIN produtos p ON iv.id_produto = p.id_produtos 
    JOIN vendas v ON iv.id_venda = v.id_venda 
    WHERE v.status_venda = 'concluida' 
      AND v.data_venda >= DATE_SUB(CURDATE(), INTERVAL 7 DAY)
    GROUP BY p.id_produtos 
    ORDER BY SUM(iv.quantidade) DESC 
    LIMIT 1";

            // Note que aqui o nome é 'cmdau'
            using (MySqlCommand cmdau = new MySqlCommand(queryu, con))
            {
                con.Open();
                // Aqui estava o erro: você deve usar 'cmdau' e não 'cmd'
                var resultado = cmdau.ExecuteScalar();

                if (resultado != null)
                {
                    label12.Text = resultado.ToString();
                }
                else
                {
                    label12.Text = "Sem vendas esta semana";
                }
                con.Close();
            }
        }
        private void LbNome_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {


            lbRelogio.Text = "📅 " + DateTime.Now.ToString("dd/MM/yyyy") +
                  "   🕒 " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void BtnTrocarSessao_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.Show();
            this.Hide();
            SessaoTimer.Parar();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void panel12_Click(object sender, EventArgs e)
        {
            timerToggle.Start();

        }

        
        

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 telarela = new Form5();
            telarela.ShowDialog();
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}


