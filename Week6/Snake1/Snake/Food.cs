using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
   public class Food : GameObject
    {
       
        public Food(char sign) : base(sign)
        {
            Generate();
        }

        public Food() { }
        public void Generate()
        {
            body.Clear();
            Random random = new Random(DateTime.Now.Second);

            Point p = new Point(random.Next(1, 26), random.Next(1, 26));

            while (!IsGoodPoint(p))
            {
                p = new Point(random.Next(1, 26), random.Next(1, 26));
            }
            body.Add(p);
        }

        bool IsGoodPoint(Point p)
        {
            return true;
        }
        /*public void SetRandomPosition(int shirina, int visota)
        {
            bool nevzmee = true;
            bool nevstene = true;
            while (true)
            {
                int x = new Random().Next(2, shirina);
                int y = new Random().Next(2, visota);
                for (int i = 0; i < Game.snake.body.Count; i++)
                {
                    if (x == Game.snake.body[i].x && y == Game.snake.body[i].y)
                    {
                        nevzmee = false;
                        break;
                    }
                }
                for (int i = 0; i < Game.wall.coord_wall.Count; i++)
                {
                    if (x == Game.wall.coord_wall[i].x && y == Game.wall.coord_wall[i].y)
                    {
                        nevstene = false;
                        break;
                    }
                }
                if (nevzmee == true && nevstene == true)
                {
                    location = new Point(x, y);
                    break;
                }
            }
            */
    }
}