using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw_Line__ellipse_and_rectangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Color Black = Color.FromArgb(200, 0, 0, 0);


            Pen Pen = new Pen(Black);
            Pen.Width = 2;


            // Line Descriptions
            //Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;


            // draw Horizental & Vertical lines
            // e.Graphics.DrawLine(Pen, x1, y1, x2, y2);
            e.Graphics.DrawLine(Pen, 100, 100, 50, 100);
            e.Graphics.DrawRectangle(Pen, 150, 300, 200, 100);
            e.Graphics.DrawEllipse(Pen, 150, 50, 200, 200);

        }

    }
}
