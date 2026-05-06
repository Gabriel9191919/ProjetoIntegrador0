using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace TelaLogin
{
    public partial class TelaCadastro : Form
    {
        string conexao = "server=localhost; uid = root; pwd=; database = adega_jm;";

        
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 telaLogin = new Form1();
            telaLogin.Show();
            this.Close();
        }

        private void rButton1_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtsenha.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmarSenha.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }


            if (txtsenha.Text.Length < 4)
            {
                MessageBox.Show("A senha deve ter no mínimo 4 caracteres!");
                return;
            }
            if (txtsenha.Text.Length > 8)
            {
                MessageBox.Show("A senha deve ter no maximo 8 caracteres!");
                return;
            }



            if (txtsenha.Text != txtConfirmarSenha.Text)
            {
                MessageBox.Show("Senhas não conferem!");
                return;
            }

            string nome = txtUsuario.Text.Trim();

            if (!NomeValido(nome))
            {
                MessageBox.Show("Digite um nome válido (apenas letras e espaços).");
                txtUsuario.Focus();
                return;
            }



            try
            {
                using (MySqlConnection con = new MySqlConnection(conexao))
                {
                    con.Open();
                    string checkSql = "SELECT COUNT(*) FROM login WHERE usuario = @usuario";
                    MySqlCommand checkCmd = new MySqlCommand(checkSql, con);
                    checkCmd.Parameters.AddWithValue("@usuario", nome);

                    int existe = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (existe > 0)
                    {
                        MessageBox.Show("Usuário já existe!");
                        return;
                    }



                    string sql = "INSERT INTO login(usuario, senha) VALUES (@usuario, @senha);";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@usuario", nome);
                    cmd.Parameters.AddWithValue("@senha", txtsenha.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Registro feito com sucesso!");


                Form1 telaLogin = new Form1();
                telaLogin.Show();
                this.Hide();
            }
            catch (Exception ex) { MessageBox.Show("Erro ao cadastrar: " + ex.Message); }
        }






        private void TelaCadastro_Load(object sender, EventArgs e)
        {
            SessaoTimer.Iniciar(this);

            this.FormBorderStyle = FormBorderStyle.None;

            // 2. Define o tamanho máximo como a área útil (sem a Taskbar)
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            // 3. Maximiza o form
            this.WindowState = FormWindowState.Maximized;





        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {

        }
        private bool NomeValido(string nome)
        {
            // Permite letras (com acento) e espaço

            return Regex.IsMatch(nome, @"^[A-Za-zÀ-ÿ\s]+$");
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;

            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            
            if (!NomeValido(txtUsuario.Text))
            {
                txtUsuario.Text = ""; 
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
    }
}


