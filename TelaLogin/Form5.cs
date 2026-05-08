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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeTela home = new HomeTela();
            home.ShowDialog();
            this.Close();
        }
    }
}
