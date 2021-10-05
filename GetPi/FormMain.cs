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
        bool isStarted = false;
        bool firstStart = true;
        private void timer_Tick(object sender, EventArgs e)
        {

            if (!isStarted) return;

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

        private void buttonStart(object sender, EventArgs e)
        {
            if (firstStart)
            {
                firstStart = false;
                gr.FillEllipse(Brushes.Bisque, 0, 0, 600, 600);
            }
            if (!isStarted)
            {
                buttonStartStop.Text = "Stop";
                isStarted = true;
            }
            else
            {
                buttonStartStop.Text = "Start";
                isStarted = false;
            }
        }

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
    }
}
