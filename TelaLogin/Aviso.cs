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
    public partial class Aviso : Form
    {


        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public Aviso(string titulo, string mensagem, Point posicao, Color cor)
        {
            InitializeComponent();

            lblTitulo.Text = titulo;
            lblTexto.Text = mensagem;

            panelLado.BackColor = cor;

            this.Location = posicao;
            this.Opacity = 0;

            timer.Interval = 10;
            timer.Tick += FadeIn;
            timer.Start();
        }

        private void FadeIn(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.1;
            }
            else
            {
                timer.Stop();

                var wait = new System.Windows.Forms.Timer();
                wait.Interval = 500;

                wait.Tick += (s, ev) =>
                {
                    wait.Stop();

                    var fadeOut = new System.Windows.Forms.Timer();
                    fadeOut.Interval = 10;

                    fadeOut.Tick += (a, b) =>
                    {
                        if (this.Opacity > 0)
                            this.Opacity -= 0.1;
                        else
                        {
                            fadeOut.Stop();
                            this.Close();
                        }
                    };

                    fadeOut.Start();
                };

                wait.Start();
            }
        }
    }





}

