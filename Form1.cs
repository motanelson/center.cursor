using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace center
{
    public partial class Form1 : Form
    {
        private Image i; Bitmap b; int value = 0; int value2 = 0; int xx = 0; int yy = 0; Graphics ee;

        public Form1()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == 0)
            {

                int v = value & 1;

                ee = Graphics.FromImage(b);
                Pen a = new Pen(Color.FromArgb(0, 0, 0));
                Pen c = new Pen(Color.FromArgb(255, 255, 255));
                Rectangle f = new Rectangle(e.X-25 , e.Y-25, 50, 50);
                Rectangle f1 = new Rectangle( pictureBox1.Width / 2-25, pictureBox1.Height / 2-25, 50, 50);
                ee.Clear(Color.FromArgb(255, 255, 255));
                ee.DrawLine(a, pictureBox1.Width/2, pictureBox1.Height/2, e.X, e.Y );
                ee.DrawEllipse(a,f);
                ee.DrawEllipse(a, f1);
                a.Dispose();
                c.Dispose();
                ee.Dispose();
                pictureBox1.Refresh();





            }



        }



        private void Form1_Load(object sender, EventArgs e)
        {
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = b;
        }
    }


}
