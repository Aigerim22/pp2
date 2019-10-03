using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace многошарабильярд
{
    class ball
    {
        public int radius;      // радиус
        public SolidBrush br;   // кисть для его рисования
        public int x;           // координата x - слева
        public int y;           // координата y - сверху
        int dx;                 // шаг смещения по x
        int dy;                 // шаг смещения по y
                                // задание свойств шара
        public void Sharik(int rch)
        {
            Random r = new Random(rch); // для новой цепочки 
                                        //   случайных чисел через rch
            br = new SolidBrush(RandomColor(rch));
            radius = r.Next(30, 50);
            x = r.Next(1, Form1.ActiveForm.Width - 2 * radius);
            y = r.Next(1, Form1.ActiveForm.Height - 2 * radius);
            dx = r.Next(2, 6);
            dy = r.Next(3, 5);
        }
        // отражение от стенок бильярда
        public void Next()
        {
            if (x >= Form1.ActiveForm.Width - 2 * radius)
                dx = -dx;
            if (x <= 0)
                dx = -dx;
            x += dx;
            if (y >= Form1.ActiveForm.Height - 2 * radius)
                dy = -dy;
            if (y <= 0)
                dy = -dy;
            y += dy;
        }
        // случайный цвет
        public Color RandomColor(int rch)      // rch - случайное число
        {
            int r, g, b;
            byte[] bytes1 = new byte[3];        // массив 3 цветов
            Random rnd1 = new Random(rch);
            rnd1.NextBytes(bytes1);             // генерация в массив 
            r = Convert.ToInt16(bytes1[0]);
            g = Convert.ToInt16(bytes1[1]);
            b = Convert.ToInt16(bytes1[2]);
            return Color.FromArgb(r, g, b);     // возврат цвета 
        }
    }
}