using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Taimeris
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer laikMatis;
        private int i = 0;

        public Form1()
        {
            Thread myThread;
            InitializeComponent();
            laikMatis = new System.Windows.Forms.Timer();
            laikMatis.Interval = 1000;
            laikMatis.Tick += TimerTickEvent;
            myThread = new Thread(Metodas);
            //myThread.Start();
        }

        private void Metodas()
        {
            while (true)
            {
                for (double i = 0; i < double.MaxValue; i++)
                {
                }
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            laikMatis.Start();
            Thread.Sleep(1000);
        }

        private async void TimerTickEvent(object sender, EventArgs ev)
        {
            Sumavimas.Text = (++i).ToString();
            if (i == 20)
            {
                laikMatis.Stop();
                Action act = MetodasA;
                await Task.Run(act);
                Sumavimas.Text = i.ToString();
                await MetodasBAsync();
            }
        }

        private void MetodasA()
        {
            Sumavimas.Text = "Šimtas";
        }

        private async Task MetodasBAsync()
        {
            Sumavimas.Text = 30000.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}