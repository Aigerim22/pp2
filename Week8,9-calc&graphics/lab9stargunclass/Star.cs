using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pen
{
    class Star
    {
        int x, y;
        public GraphicsPath gp1;
        public GraphicsPath gp2;

        public Star(int x, int y)
        {
            this.x = x;
            this.y = y;
            gp1 = new GraphicsPath();
            gp2 = new GraphicsPath();
        }
        public void Move()
        {
            x += 10;
            if (x == 760)
                x = 0;
            gp1.Reset(); //очищает GraphicsPath
            gp2.Reset(); //для того чтобы при каждой движении рисовалось новая фигура и очищались предыдущие

            Point[] firstT =   //пойнты для первого треугольника
           {
                new Point (x,y),    //A
                new Point (x+20,y+30), //B
                new Point(x-20,y+30)   //C
            };
            gp1.AddPolygon(firstT);   //добавление в GraphicsPath1
                                      //без этого фигура не рисуется
            Point[] secondT =         //пойнты для второго треугольника 
          {
                new Point (x-20,y+10), //A
                new Point (x+20,y+10),  //B
                new Point(x,y+40)       //C
            };
            gp2.AddPolygon(secondT);  //добавление в GraphicsPath2
        }

    }
}
