using System;
using System.Windows.Forms;
using TelaLogin;

public class AutoLogoff
{
    private System.Windows.Forms.Timer timer;
    private int tempo = 0;
    private int limite;
    private Form formAtual;

    public AutoLogoff(Form form, int segundos)
    {
        formAtual = form;
        limite = segundos;

        timer = new System.Windows.Forms.Timer();
        timer.Interval = 1000;
        timer.Tick += Tick;
        timer.Start();

        // eventos do form
        form.MouseMove += Resetar;
        form.KeyPress += Resetar;
        form.Click += Resetar;
    }

    private void Tick(object sender, EventArgs e)
    {
        tempo++;

        if (tempo >= limite)
        {
            timer.Stop();

            MessageBox.Show("Sessão expirada!");

            Form1 login = new Form1();
            login.Show();

            formAtual.Close();
        }
    }

    private void Resetar(object sender, EventArgs e)
    {
        tempo = 0;
    }
}