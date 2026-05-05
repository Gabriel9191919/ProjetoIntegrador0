using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaLogin
{
    internal class AutoLogoff
    {
        public partial class Form1 : Form
        {
            private Timer timerInatividade;

            public Form1()
            {
                InitializeComponent();
                ConfigurarTimer();
            }

            private void ConfigurarTimer()
            {
                timerInatividade = new Timer();
                timerInatividade.Interval = 60000; // 1 minuto
                timerInatividade.Tick += (s, e) => VoltarTela();
                timerInatividade.Start();
            }

            private void VoltarTela()
            {
                timerInatividade.Stop();

                // Lógica para voltar
                Form1 home = new Form1();
                home.Show();
                this.Close();
            }

            // Sobrescreve o filtro de mensagens para detectar qualquer clique no Form
            protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
            {
                ResetarTimer();
                return base.ProcessCmdKey(ref msg, keyData);
            }

            private void ResetarTimer()
            {
                timerInatividade.Stop();
                timerInatividade.Start();
            }
        }
    }
}
