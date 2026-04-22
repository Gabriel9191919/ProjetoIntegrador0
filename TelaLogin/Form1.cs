using MySql.Data.MySqlClient;

namespace TelaLogin
{
    public partial class Form1 : Form
    {
        string conexao = "server=localhost; uid = root; pwd=; database = adega_jm;";

        public Form1()
        {
            InitializeComponent();

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.None;

            // 2. Define o tamanho máximo como a área útil (sem a Taskbar)
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            // 3. Maximiza o form
            this.WindowState = FormWindowState.Maximized;


            if (Properties.Settings.Default.Nome)
            {
                txtUsuario.Text = Properties.Settings.Default.Usuariosalvo;
                checkBox1.Checked = true;
            }






        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Properties.Settings.Default.Usuariosalvo = txtUsuario.Text;
                Properties.Settings.Default.Nome = true;
            }
            else
            {
                Properties.Settings.Default.Usuariosalvo = "";
                Properties.Settings.Default.Nome = false;
            }

            Properties.Settings.Default.Save();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaCadastro telacadastro = new TelaCadastro();
            telacadastro.Show();
            this.Hide();
        }

        private void rButton1_Click(object sender, EventArgs e)
        {



            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(conexao))
                {
                    con.Open();

                    string sql = "SELECT COUNT(*) FROM login WHERE usuario = @usuario AND senha = @senha";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                    cmd.Parameters.AddWithValue("@senha", txtSenha.Text);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Login realizado com sucesso!");
                        
                        
                        this.Hide();
                        Sessao.Usuario = txtUsuario.Text;

                        HomeTela telahome = new HomeTela();

                        telahome.Show();



                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválidos!");
                    }
                }
            }
            catch (Exception) { }
        }




        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            TelaCadastro telacadastro = new TelaCadastro();
            telacadastro.Show();
            this.Hide();

        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                rButton1.PerformClick();
            }
        }

        bool senhaVisivel = false;

        private void btnOlho_Click(object sender, EventArgs e)
        {
            senhaVisivel = !senhaVisivel;

            if (senhaVisivel)
            {
                // mostra senha
                txtSenha.PasswordChar = '\0';


                btnOlho.BackgroundImage = Image.FromFile("imagens/olho_aberto.png");
            }
            else
            {
                // esconde senha
                txtSenha.PasswordChar = '*';

                // troca imagem
                btnOlho.BackgroundImage = Image.FromFile("imagens/olho_fechado.png");
            }
        }

        private void rButton2_Click(object sender, EventArgs e)
        {
            HomeTela gambiarra = new HomeTela();
            gambiarra.Show();
            this.Hide();

        }
    }



}
