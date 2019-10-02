using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car1
{
    class Program
    {
        class car
        {
            public char sign;

            public List<Point> body = new List<Point>();

            public car(char sign, Point fstpoint)
            {
                this.body = new List<Point>();
                if(fstpoint != null)
                {
                    this.body.Add(fstpoint);
                }
                this.sign = sign;
            }

            public void Move()
            {
                Clear();
                for (int i = body.Count - 1; i > 0; --i)
                {
                    body[i].X = body[i - 1].X;
                    body[i].Y = body[i - 1].Y;
                }

                body[0].X += DX;
                body[0].Y += DY;

             
                else if (body[0].Y == -1)
                {
                    body[0].Y = Game.boardH - 1;
                }
            }
        }
        class Point
        {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                value = x;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                value = y;
            }
        }
    }
}
    public static void Move(int dx, int dy)
            {
                Console.Clear();

            }
      

        }
        static void Main(string[] args)
        {
            
        }
    
