using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace корабль
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //если сделать так чтобы при нажатии появился рисунок
            //надо сначала создать графику 
            //Graphics g = pictureBox1.CreateGraphics();
            //и все рисовать с помощью g

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = pictureBox1.CreateGraphics();
            e.Graphics.Clear(Color.Turquoise);

            SolidBrush myCorp = new SolidBrush(Color.DarkMagenta);
            SolidBrush myTrum = new SolidBrush(Color.DarkOrchid);
            SolidBrush myTrub = new SolidBrush(Color.DeepPink);
            SolidBrush mySeа = new SolidBrush(Color.Blue);
            Pen myWind = new Pen(Color.Yellow, 2);
            // Закрашиваем фигуры
            e.Graphics.FillRectangle(myTrub, 300, 125, 75, 75); // 1 труба (прямоугольник)
            e.Graphics.FillRectangle(myTrub, 480, 125, 75, 75); // 2 труба (прямоугольник)
            e.Graphics.FillPolygon(myCorp, new Point[]      // корпус (трапеция)
              {
                 new Point(100,300),new Point(700,300),
                 new Point(700,300),new Point(600,400),
                 new Point(600,400),new Point(200,400),
                 new Point(200,400),new Point(100,300)
              }
            );
            e.Graphics.FillRectangle(myTrum, 250, 200, 350, 100); // палуба (прямоугольник)
            
            // Море - 12 секторов-полуокружностей
            int x = 50;
            int Radius = 50;
            while (x <= pictureBox1.Width - Radius)
            {
                e.Graphics.FillPie(mySeа, 0 + x, 375, 50, 50, 0, -180);
                x += 50;
            }
            // Иллюминаторы 
            for (int y = 300; y <= 550; y += 50)
            {
                e.Graphics.DrawEllipse(myWind, y, 240, 20, 20); // 6 окружностей
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left++;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Turquoise);
        }
    }
}
