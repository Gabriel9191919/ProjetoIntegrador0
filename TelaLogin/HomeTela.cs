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
        private string nomeUsuario;
        public HomeTela()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;

            // 2. Define o tamanho máximo como a área útil (sem a Taskbar)
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            // 3. Maximiza o form
            this.WindowState = FormWindowState.Maximized;
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
            TelaEstoque telaEstoque = new TelaEstoque();
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
            this.Close();
        }

        private void HomeTela_Load(object sender, EventArgs e)
        {
            //Bem-vindo(Nome)
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
                string sql = "SELECT produto, datavencimento FROM estoque ORDER BY datavencimento ASC LIMIT 1;";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

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

                MySqlCommand cmd = new MySqlCommand(sql, con);

                object resultado = cmd.ExecuteScalar();

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
                string sql = "SELECT produto, quantidade FROM estoque ORDER BY quantidade ASC LIMIT 1;";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                MySqlDataReader reader = cmd.ExecuteReader();

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
    }

}
