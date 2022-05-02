using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _03AndreRandom72B
{
    
    public partial class FrmSorteioJogos : Form
    {
        int counter;

        //private Timer time = new Timer();
        private void InitializeMyTimer()
        {
            // Set the interval for the timer.
            timer1.Interval = 1500;
            // Connect the Tick event of the timer to its event handler.
            timer1.Tick += new EventHandler(IncreaseProgressBar);
            // Start the timer.
            timer1.Start();
        }
        private void IncreaseProgressBar(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                btnPlay.Enabled = true;
            }
               
           
        }
        private void startTimer()
        {
            counter = 0;
            timer2.Interval = 1000;
            //timer2.Tick += new EventHandler(Timer2_tick);
            timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            //btnMegasena.Text = "parar";
            //btnMegasena.Click += new EventHandler(btnMegasena_Click);
        }
        private void Timer2_Tick(object sender, EventArgs e)
        {
            /* if(btnMegasena.Text == "parar")
             {
                 btnMegasena.Text = "Mega-Sena";
                 timer2.Enabled=false;
             }
             else
             {
                 btnMegasena.Text = "parar";
                 timer2.Enabled = true;
             }*/
            if (counter == 150)
            {
                timer2.Enabled = false;
                counter = 0;
            }
            else
                counter = counter + 1;
            lblTeste.Text = "Timer: " + counter.ToString();
        }
        private Random sorteiomucholoco = new Random();
        public FrmSorteioJogos()
        {
            InitializeComponent();
            timer1.Start();
            
            
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormRandom f2 = new FormRandom();
            f2.ShowDialog();
        }

        private void btnCor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnCorzinha.BackColor = colorDialog1.Color;
                lblCorzinha.Text = colorDialog1.Color.ToString();
            }

        }
    


        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnPlay.Enabled = false;

            int time1 = sorteiomucholoco.Next(1, 11);
            int time2 = sorteiomucholoco.Next(1, 11);

            lblNum1.Text = time1.ToString("00");
            lblNum3.Text = time2.ToString("00");
            
            progressBar1.Value = 0;
            //timer1.Start();
            //timer1.Interval = 100000;
            //for(int i = 0; i < 100; i++)
            //{
            //timer1.Enabled = true;
            //lbl5.Text = i.ToString();
            //progressBar1.Value = i;
            //timer1.Stop();
            //timer1.Enabled = false;

            //progressBar1.Increment(1);
            //lbl6.Text = progressBar1.Value.ToString() + "% Completed";
            //}
            
            //timer1.Stop();
            InitializeMyTimer();
            
            int resultadodoidao;
            resultadodoidao = time1 * time2;
            lblNum4.Text = resultadodoidao.ToString();
        }

        private void btnMegasena_Click(object sender, EventArgs e)
        {
            string card = "";
            string num = "";

            a

            for (int i = 1; i <= 6; i++)
            {
                //Verifica se o número sorteado já existe no cartão
                do
                {
                    num = sorteiomucholoco.Next(1, 61).ToString("00"); //1 a 60 mega sena!!
                } while (card.IndexOf(num) >= 0);

                //Adicionar o novo número ao cartão
                card += num;

                /*if (i == 6)
                    cartao += sorteio.Next(1, 61).ToString("00");
                else*/

                //se não for o último, concatena com o  " - "
                    if (i < 6)
                       card += " - ";
                
                
            }
            lblResultMega.Text = card;
        }
    }
}
