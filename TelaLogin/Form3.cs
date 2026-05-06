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
using System.Xml.Linq;

namespace TelaLogin
{

    public partial class Form3 : Form
    {
        
        string conexao = "server=localhost; uid = root; pwd=; database = adega_jm;";

        public Form3()
        {
            InitializeComponent();



        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SessaoTimer.Iniciar(this);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(1257, 150);
            CarregarProdutos();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtvenc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                return;
            }

            TextBox txt = (TextBox)sender;

            if (char.IsDigit(e.KeyChar))
            {
                if (txt.Text.Length == 2 || txt.Text.Length == 5)
                {
                    txt.Text += "/";
                    txt.SelectionStart = txt.Text.Length;
                }
            }
        }

        private void rButton1_Click(object sender, EventArgs e)
        {

            try
            {
                if (comboBox1.SelectedValue == null ||
                    string.IsNullOrWhiteSpace(txtqtd.Text) ||
                    string.IsNullOrWhiteSpace(txtvenc.Text))
                {
                    MessageBox.Show("Preencha todos os campos!");
                    return;
                }

                int qtd = Convert.ToInt32(txtqtd.Text);
                DateTime datavenc = Convert.ToDateTime(txtvenc.Text);

                using (MySqlConnection con = new MySqlConnection(conexao))
                {
                    con.Open();

                    string sql = @"
                    INSERT INTO estoque 
                    (quantidade, datavencimento,  id_produtodoestoque)
                    VALUES 
                    (@qtd, @data,  @idproduto)";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("@qtd", qtd);
                    cmd.Parameters.AddWithValue("@data", datavenc);





                    cmd.Parameters.AddWithValue("@idproduto", comboBox1.SelectedValue);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Produto adicionado ao estoque!");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CarregarProdutos()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(conexao))
                {
                    con.Open();

                    string sql = "SELECT id_produtos, produto FROM produtos";

                    MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboBox1.DataSource = dt;
                    comboBox1.DisplayMember = "produto";      // Nome
                    comboBox1.ValueMember = "id_produtos";    // ID
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
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

        private void txtqtd_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Permite apenas números, controle (backspace) e a vírgula decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true; // Ignora o caractere digitado
            }

            // Impede que o usuário digite mais de uma vírgula
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtpreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números, controle (backspace) e a vírgula decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true; // Ignora o caractere digitado
            }

            // Impede que o usuário digite mais de uma vírgula
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtvenc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtvenc_Leave(object sender, EventArgs e)
        {
            // 1. Tenta converter o texto para uma data válida
            if (DateTime.TryParse(txtvenc.Text, out DateTime dataDigitada))
            {
                int ano = dataDigitada.Year;

                // 2. Valida se o ANO está entre 1500 e 3000
                if (ano < 2000 || ano > 3000)
                {
                    MessageBox.Show("O ano da data deve estar entre 2000 e 3000.", "Ano Inválido");
                    txtvenc.Focus();
                    return;
                }

                // 3. Se quiser formatar visualmente para o usuário
                txtvenc.Text = dataDigitada.ToString("dd/MM/yyyy");
            }
            else if (!string.IsNullOrWhiteSpace(txtvenc.Text))
            {
                MessageBox.Show("Por favor, digite uma data válida (DD/MM/AAAA).");
                txtvenc.Focus();
            }
        }
    }
}
