using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ballfallsdown
{
    public class ball
    {
        public int x; //координата x -левая граница шара
        public int y; //координата у - граница шара сверху
        public int r; //радиус
        int dx;      //смещение по x
        int dy;      //смещение по у
        public SolidBrush br; // кисть для рисования шара

        public ball(int r, Color c, int x, int y, int dx, int dy) //конструктор
        {
            this.r = r;
            br = new SolidBrush(c);
            this.x = x;
            this.y = y;
            this.dx = dx;
            this.dy = dy;
        }

        // отражение от стенок бильярда
        public void Next()
        {
            if (x >= Form1.ActiveForm.Width - 2 * r)
                dx = -dx;
            if (x < 0)
                dx = -dx;
            x += dx;
            if (y >= Form1.ActiveForm.Height - 2 * r)
                dy = -dy;
            if (y < 0)
                dy = -dy;
            y += dy;
        }
    }
}
