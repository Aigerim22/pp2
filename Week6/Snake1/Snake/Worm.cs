using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Worm : GameObject
    {
        

        public Worm(char sign) : base(sign)
        {
            body.Add(new Point(20, 20));
        }
        public Worm() { }

        public void Move(int dx, int dy)//0 -1
        {
            Clear();

            for (int i = body.Count - 1; i > 0; --i)
            {
                body[i].X = body[i - 1].X;
                body[i].Y = body[i - 1].Y;
            }

            body[0].X = body[0].X + dx;
            body[0].Y = body[0].Y + dy;
        }

        public bool CheckCollision(List<Point> points)
        {
            bool res = false;

            foreach (Point p in points)
            {

                if (p.X == body[0].X && p.Y == body[0].Y)
                {
                    res = true;
                    break;
                }
            }
            return res;
        }
        public void Eat(Point p)
        {

            body.Add(new Point(p.X, p.Y));
        }
    }
}