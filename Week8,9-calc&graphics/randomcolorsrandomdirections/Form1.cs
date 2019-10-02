using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randomcolorsrandomdirections
{
    public partial class Form1 : Form
    {
 
        class Ball
        {
            public int x = 100;
            public int y = 100;
            public int r = 20;
            public Color color;
            Random random = new Random();
            public Ball(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public void RanColor()
            {
                 color = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            }
        }
    List<Ball> Balls = new List<Ball>();
    Graphics graphics;

        public Form1()
        {
            InitializeComponent();
            graphics = CreateGraphics();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Ball b = new Ball(e.X, e.Y);
            Balls.Add(b);
            b.RanColor();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int dy = 2;
            graphics.Clear(this.BackColor);
            foreach (var ball in Balls)
            {
                graphics.FillEllipse(new SolidBrush(ball.color), ball.x, ball.y, ball.r, ball.r);
                ball.y += dy;
                if(ball.y >= ClientSize.Height)
                {
                    ball.y = 0;
                    //ball.y = 100;
                }
            }          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
