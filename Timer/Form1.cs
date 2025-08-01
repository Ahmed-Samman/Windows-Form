using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int CounterSeconds = 55;
        int CounterMinutes = 57;
        int CounterHours = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        void UpdateHours()
        {
            if (CounterMinutes == 60)
            {
                CounterMinutes = 0;
                lblHours.Text = (++CounterHours).ToString("00");
                lblMinutes.Text = CounterMinutes.ToString("00");
            }
        }
        void UpdateMinutes()
        {
            if (CounterSeconds == 60)
            {
                CounterSeconds = 0;
                lblMinutes.Text = (++CounterMinutes).ToString("00");
                lblSeconds.Text = CounterSeconds.ToString();
            }
        }    
        void UpdateSeconds()
        {
           
            if (CounterSeconds <= 59)
            {
               
                lblSeconds.Text = (++CounterSeconds).ToString("00");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateSeconds();
            UpdateMinutes();
            UpdateHours();
        }
    }
}
