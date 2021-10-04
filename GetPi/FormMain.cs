using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GetPi
{
    public partial class FormMain : Form
    {
        Graphics gr;
        int nInSquare, nInCircle, radius, centerX, centerY;
        Random rnd = new Random();
        //private void countRect_Click(object sender, EventArgs e)
        //{
        //    countRect.Text = 
        //}

        

        public FormMain()
        {
            InitializeComponent();
            this.ClientSize = new Size(600, 600);
            gr = this.CreateGraphics();
            nInSquare = 0;
            nInCircle = 0;
            radius = 300;
            centerX = 300;
            centerY = 300;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gr.FillEllipse(Brushes.Bisque, 0, 0, 600, 600);
            for (int i = 0; i < 10000; i++)
            {
                int x = rnd.Next(0, 600);
                int y = rnd.Next(0, 600);
                gr.FillEllipse(Brushes.Red, x, y, 5, 5);
                nInSquare++;
                countRect.Text = nInSquare.ToString();
                if (Math.Sqrt((centerX - x) * (centerX - x) + (centerY - y) * (centerY - y)) <= radius)
                {
                    nInCircle++;
                    countCircle.Text = nInCircle.ToString();
                }
                double tempPi = (double)4 * nInCircle / nInSquare;
                pi.Text = tempPi.ToString();

            }
        }

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
        //    gr.FillEllipse(Brushes.Red, e.X, e.Y, 5, 5);
        //    if (Math.Sqrt((centerX - e.X) * (centerX - e.X) + (centerY - e.Y) * (centerY - e.Y)) <= radius)
        //    {
        //        nInCircle++;
        //        countCircle.Text = nInCircle.ToString();
        //    }

        //    nInSquare++;
            
            
        //    double tempPi = (double)4 * nInCircle / nInSquare;
        //    pi.Text = tempPi.ToString();
        }
    }
}
