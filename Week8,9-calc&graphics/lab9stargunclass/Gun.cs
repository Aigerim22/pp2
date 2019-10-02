using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pen
{
    class Gun
    {
        int x, y;
        public GraphicsPath gp1;
        public GraphicsPath gp2;

        public Gun(int x, int y)
        {
            this.x = x;
            this.y = y;
            gp1 = new GraphicsPath();
            gp2 = new GraphicsPath();
        }
        public void Move()
        {
            y -= 10;
            if (y == 10)
                y = 500;
            gp1.Reset(); //очищает GraphicsPath
            gp2.Reset(); //для того чтобы при каждой движении рисовалось новая фигура и очищались предыдущие

            Point[] Triangle =   //пойнты для первого треугольника
           {
                new Point (x,y),    //A
                new Point (x+10,y+15), //B
                new Point(x-10,y+15)   //C
            };
            gp1.AddPolygon(Triangle);   //добавление в GraphicsPath1
                                      //без этого фигура не рисуется
            Point[] Rectangle =         //пойнты для второго треугольника 
          {
                new Point (x+5,y+15), 
                new Point (x+5,y+35),  
                new Point(x-5,y+35),
                new Point(x-5, y+15)
            };
            gp2.AddPolygon(Rectangle);  //добавление в GraphicsPath2
        }

    }
}

