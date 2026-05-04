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
        string conexao = "server=localhost;uid=root;pwd=;database=adega_jm;";

        public EsqueciSenha()
        {
            InitializeComponent();
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

        private void lbVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 login = new Form1();
            login.ShowDialog();
            this.Close();
        }
    }
}

