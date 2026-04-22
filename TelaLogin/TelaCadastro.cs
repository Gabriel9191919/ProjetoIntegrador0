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
            this.Hide();
        }

        private void rButton1_Click(object sender, EventArgs e)
        {

            
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtsenha.Text) ||
                string.IsNullOrWhiteSpace(txtsenha2.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            
            if (txtsenha.Text.Length < 4)
            {
                MessageBox.Show("A senha deve ter no mínimo 4 caracteres!");
                return;
            }

            
            if (txtsenha.Text != txtsenha2.Text)
            {
                MessageBox.Show("Senhas não conferem!");
                return;
            }

            
            try
            {
                using (MySqlConnection con = new MySqlConnection(conexao))
                {
                    con.Open();

                    string sql = "INSERT INTO login(usuario, senha) VALUES (@usuario, @senha);";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                    cmd.Parameters.AddWithValue("@senha", txtsenha.Text); 

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Registro feito com sucesso!");

                
                Form1 telaLogin = new Form1();
                telaLogin.Show();
                this.Hide();
            }
            catch (Exception ex) {}
        }





        private void TelaCadastro_Load(object sender, EventArgs e)
        {


            this.FormBorderStyle = FormBorderStyle.None;

            // 2. Define o tamanho máximo como a área útil (sem a Taskbar)
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            // 3. Maximiza o form
            this.WindowState = FormWindowState.Maximized;





        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {

        }
    }

}
