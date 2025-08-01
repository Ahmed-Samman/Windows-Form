using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Picture_Box.Properties;

namespace Picture_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.aevkt99a;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.hwrxvts4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"D:\C#\Windows Form\Picture Box\bgfvyboc.png");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new PictureBox().Image; // This for delete Picture

        }
    }
}
