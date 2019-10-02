using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveCircle
{
    public partial class Form1 : Form
    {
        Random rn = new Random();
        int r = 30;
        List<Point> cPoint = new List<Point>();
        List<SolidBrush> brush = new List<SolidBrush>();
        List<int> dx = new List<int>();
        List<int> dy = new List<int>();
        int x, y;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < cPoint.Count(); ++i)
            {
                cPoint[i] = new Point(cPoint[i].X + dx[i], cPoint[i].Y + dy[i]);
                e.Graphics.FillEllipse(brush[i], new Rectangle(cPoint[i].X - r, cPoint[i].Y - r, 2 * r, 2 * r));
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            /*if (e.Button == MouseButtons.Left)
            {
                cPoint.Add(e.Location);
                brush.Add(new SolidBrush(Color.FromArgb(255, rn.Next(0, 255), rn.Next(0, 255), rn.Next(0, 255))));
                dx.Add(rn.Next(-1, 1));
                if (dx.Last() == 0)
                    dy.Add(rn.Next(-1, 2));
                else
                    dy.Add(0);
                if (dx.Last() == 0 && dy.Last() == 0)
                    dx[dx.Count() - 1] = 1;
            }*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    Random random = new Random();
                    x = random.Next(0, 500);
                    y = random.Next(0, 400);
                    
                    cPoint.Add(new Point(x,y));
                    brush.Add(new SolidBrush(Color.FromArgb(255, rn.Next(0, 255), rn.Next(0, 255), rn.Next(0, 255))));
                    dx.Add(rn.Next(-1, 1));
                    if (dx.Last() == 0)
                        dy.Add(rn.Next(-1, 2));
                    else
                        dy.Add(0);
                    if (dx.Last() == 0 && dy.Last() == 0)
                        dx[dx.Count() - 1] = 1;
                    break;
            }
        }
    }
}
