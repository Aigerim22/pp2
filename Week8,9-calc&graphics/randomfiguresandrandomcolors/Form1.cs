using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randomfiguresandrandomcolors
{
    public partial class Form1 : Form
    {
        public class circles
        {
            public int x;
            public int y;
            public Color color;

            public circles(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public void RanColors()
            {
                color = Color.FromArgb(new Random().Next());
            }
            public void RanFigures()
            {

            }
            enum Direction
            {
                Left,
                Right,
                Up,
                Down
            }
            private Direction direction;
            private int velocity = 1;

            public void GetDirection()
            {
                if (direction == Direction.Left)
                {
                    x -= velocity;
                }
                if (direction == Direction.Right)
                {
                    x += velocity;
                }
                if (direction == Direction.Down)
                {
                    y += velocity;
                }
                if (direction == Direction.Up)
                {
                    y -= velocity;
                }
            }
            public void GetDirectionRnd()
            {
                Random rnd = new Random();
                Direction[] dir = new Direction[] { Direction.Left, Direction.Down, Direction.Right, Direction.Up };

                direction = dir[rnd.Next(dir.Length)];
            }
        }

            public class rectangle
            {
                public int x;
                public int y;
                public Color color;

                public rectangle(int x, int y)
                {
                    this.x = x;
                    this.y = y;
                }

                public void RanColors()
                {
                    color = Color.FromArgb(new Random().Next());
                }
               public void RanFigures()
                {

                }
                enum Direction
                {
                    Left,
                    Right,
                    Up,
                    Down
                }
                private Direction direction;
                private int velocity = 1;

                public void GetDirection2()
                {
                    if (direction == Direction.Right)
                    {
                        x -= velocity;
                    }
                    if (direction == Direction.Left)
                    {
                        x += velocity;
                    }
                    if (direction == Direction.Up)
                    {
                        y += velocity;
                    }
                    if (direction == Direction.Down)
                    {
                        y -= velocity;
                    }
                }
                public void GetDirectionRnd()
                {
                    Random rnd = new Random();
                    Direction[] dir = new Direction[] { Direction.Down, Direction.Left, Direction.Up, Direction.Right };

                    direction = dir[rnd.Next(dir.Length)];
                }
               
            }
            
        
        List<circles> circle= new List<circles>();
        List<rectangle> rectangles = new List<rectangle>();
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(this.BackColor);
            foreach (var c in circle)
            {
                g.FillEllipse(new SolidBrush(c.color), c.x, c.y, 25, 25);
                c.GetDirection();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            circles c  = new circles(e.X, e.Y);
            circle.Add(c);
            c.RanColors();
            c.GetDirectionRnd();
            rectangle r = new rectangle(e.X, e.Y);
            rectangles.Add(r);
            r.RanColors();
            r.GetDirectionRnd();
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            foreach (var r in rectangles)
            {
                g.FillRectangle(new SolidBrush(r.color), r.x, r.y, 25, 25);
                r.GetDirection2();
            }
            //Refresh();
        }
    }
}
