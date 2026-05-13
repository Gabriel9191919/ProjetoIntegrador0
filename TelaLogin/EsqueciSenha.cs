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

    public partial class EsqueciSenha : Form
    {
        string conexao = "server=localhost; uid = root; pwd=; database = adega_jm;";

        public EsqueciSenha()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            // 2. Define o tamanho máximo como a área útil (sem a Taskbar)
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            // 3. Maximiza o form
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtNovaSenha.Text) ||
                string.IsNullOrWhiteSpace(txtsenha2.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            if (txtNovaSenha.Text != txtsenha2.Text)
            {
                MessageBox.Show("As senhas não coincidem!");
                return;
            }


            if (txtNovaSenha.Text.Length < 4)
            {
                MessageBox.Show("A senha deve ter no mínimo 4 caracteres!");
                return;
            }
            if (txtNovaSenha.Text.Length > 8)
            {
                MessageBox.Show("A senha deve ter no maximo 8 caracteres!");
                return;
            }

            //Bloqueia senhas iguais
            // 1. A query procura se existe um registro com o MESMO usuário E a MESMA senha
            conectar conectar = new conectar();
            MySqlConnection con = conectar.conectando();
            string verify = "SELECT COUNT(*) FROM Login WHERE usuario = @usuario AND senha = @senha";

            using (MySqlCommand cmdverify = new MySqlCommand(verify, con))
            {
                // 2. Parâmetros (Substitua pelos nomes das suas variáveis/controles)
                cmdverify.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                cmdverify.Parameters.AddWithValue("@senha", txtNovaSenha.Text);

                try
                {

                    if (con.State == ConnectionState.Closed) con.Open();

                    // 3. Executa a contagem
                    int count = Convert.ToInt32(cmdverify.ExecuteScalar());

                    if (count > 0)
                    {
                        // Se encontrou 1 registro, significa que a "nova" senha é igual à atual
                        MessageBox.Show("A nova senha não pode ser igual à senha atual!", " Atenção");
                    }
                    con.Close();
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro de conexão: " + ex.Message);
                }

            }

            {
                try
                {
                    con.Open();

                    // 🔎 Verifica se usuário existe
                    string check = "SELECT COUNT(*) FROM Login WHERE usuario = @usuario";
                    MySqlCommand cmdCheck = new MySqlCommand(check, con);
                    cmdCheck.Parameters.AddWithValue("@usuario", txtUsuario.Text);

                    int existe = Convert.ToInt32(cmdCheck.ExecuteScalar());

                    if (existe == 0)
                    {
                        MessageBox.Show("Usuário não encontrado!");
                        return;
                    }

                    // 🔄 Atualiza senha
                    string update = "UPDATE Login SET senha = @senha WHERE usuario = @usuario";
                    MySqlCommand cmdUpdate = new MySqlCommand(update, con);

                    cmdUpdate.Parameters.AddWithValue("@senha", txtNovaSenha.Text);
                    cmdUpdate.Parameters.AddWithValue("@usuario", txtUsuario.Text);

                    cmdUpdate.ExecuteNonQuery();

                    MessageBox.Show("Senha alterada com sucesso!");

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void lbVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void EsqueciSenha_Load(object sender, EventArgs e)
        {
            SessaoTimer.Iniciar(this);

        }

        private void btnAlterarSenha_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtNovaSenha.Text) ||
                string.IsNullOrWhiteSpace(txtsenha2.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            if (txtNovaSenha.Text != txtsenha2.Text)
            {
                MessageBox.Show("As senhas não coincidem!");
                return;
            }

            using (MySqlConnection con = new MySqlConnection(conexao))
            {
                try
                {
                    con.Open();

                    // 🔎 Verifica se usuário existe
                    string check = "SELECT COUNT(*) FROM Login WHERE usuario = @usuario";
                    MySqlCommand cmdCheck = new MySqlCommand(check, con);
                    cmdCheck.Parameters.AddWithValue("@usuario", txtUsuario.Text);

                    int existe = Convert.ToInt32(cmdCheck.ExecuteScalar());

                    if (existe == 0)
                    {
                        MessageBox.Show("Usuário não encontrado!");
                        return;
                    }

                    // 🔄 Atualiza senha
                    string update = "UPDATE Login SET senha = @senha WHERE usuario = @usuario";
                    MySqlCommand cmdUpdate = new MySqlCommand(update, con);

                    cmdUpdate.Parameters.AddWithValue("@senha", txtNovaSenha.Text);
                    cmdUpdate.Parameters.AddWithValue("@usuario", txtUsuario.Text);

                    cmdUpdate.ExecuteNonQuery();

                    MessageBox.Show("Senha alterada com sucesso!");

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
               string.IsNullOrWhiteSpace(txtNovaSenha.Text) ||
               string.IsNullOrWhiteSpace(txtsenha2.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            if (txtNovaSenha.Text != txtsenha2.Text)
            {
                MessageBox.Show("As senhas não coincidem!");
                return;
            }

            using (MySqlConnection con = new MySqlConnection(conexao))
            {
                try
                {
                    con.Open();

                    // 🔎 Verifica se usuário existe
                    string check = "SELECT COUNT(*) FROM Login WHERE usuario = @usuario";
                    MySqlCommand cmdCheck = new MySqlCommand(check, con);
                    cmdCheck.Parameters.AddWithValue("@usuario", txtUsuario.Text);

                    int existe = Convert.ToInt32(cmdCheck.ExecuteScalar());

                    if (existe == 0)
                    {
                        MessageBox.Show("Usuário não encontrado!");
                        return;
                    }

                    // 🔄 Atualiza senha
                    string update = "UPDATE Login SET senha = @senha WHERE usuario = @usuario";
                    MySqlCommand cmdUpdate = new MySqlCommand(update, con);

                    cmdUpdate.Parameters.AddWithValue("@senha", txtNovaSenha.Text);
                    cmdUpdate.Parameters.AddWithValue("@usuario", txtUsuario.Text);

                    cmdUpdate.ExecuteNonQuery();

                    MessageBox.Show("Senha alterada com sucesso!");

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}


