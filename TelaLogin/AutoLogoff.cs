using System;
using System.Windows.Forms;

namespace TelaLogin
{
    public static class SessaoTimer
    {
        private static System.Windows.Forms.Timer timer;
        private static int tempo = 0;

        public static int TempoLimite = 60; 

        private static Form formAtual;

        
        public static void Iniciar(Form form)
        {
            formAtual = form;

            if (timer == null)
            {
                timer = new System.Windows.Forms.Timer();
                timer.Interval = 1000; 
                timer.Tick += Tick;
            }

            timer.Start();
        }

        // 🔄 Atualiza qual tela está ativa
        public static void AtualizarForm(Form form)
        {
            formAtual = form;
        }

        // ⏲️ Contador
        private static void Tick(object sender, EventArgs e)
        {
            tempo++;

            if (tempo >= TempoLimite)
            {
                timer.Stop();

                MessageBox.Show("Sessão expirada por inatividade!");


                foreach (Form f in Application.OpenForms.Cast<Form>().ToList())
                {
                    if (!(f is Form1))
                        f.Close();
                }


                Form1 login = new Form1();
                login.Show();
            }
        }

     
        public static void Resetar()
        {
            tempo = 0;
        }


        public static void Parar()
        {
            timer.Stop();
        }
    }
}