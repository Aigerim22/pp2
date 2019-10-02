using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pen
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        Star s1 = new Star(70, 20);  //экземпляр класса стар и объявление 1 звезды
        Star s2 = new Star(70, 500);   //экземпляр класса стар и объявление 2 звезды


        Gun g1 = new Gun(300, 200);  //экземпляр класса стар и объявление 1 звезды

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 800;  //задаем размер формы
            this.Height = 600;
        } 

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = Color.Black; //задаем цвет формы
            SolidBrush blue = new SolidBrush(Color.Blue); 
            e.Graphics.FillRectangle(blue, 10, 10, 760, 540); //рисуем прямоугольник чтобы сделать рамку

            SolidBrush white = new SolidBrush(Color.White);
            e.Graphics.FillEllipse(white, 100, 100, 40, 40); //рисуем шар

            //Координаты для полигона, for hexagon(6points)
            int y = 200, x = 300;
            Point[] spaceship =
            {
                new Point(x,y),
                new Point(x+40,y+20),
                new Point(x+40,y+50),
                new Point(x,y+70),
                new Point(x-40,y+50),
                 new Point(x-40,y+20)
            };
            SolidBrush yellow = new SolidBrush(Color.Yellow);
            e.Graphics.FillPolygon(yellow, spaceship);

            SolidBrush red = new SolidBrush(Color.Red);
            e.Graphics.FillPath(red, s1.gp1);//1 треугольник добавление в GraphicsPath1
            e.Graphics.FillPath(red, s1.gp2);//1 треугольник добавление в GraphicsPath2

            e.Graphics.FillPath(red, s2.gp1);//1 треугольник добавление в GraphicsPath1
            e.Graphics.FillPath(red, s2.gp2);//1 треугольник добавление в GraphicsPath2




            x = 360;
            y = 180;
            Point[] newstar =
            {
                    new Point(x,y),
                    new Point(x+5,y+10),
                    new Point(x+20,y+15),
                    new Point(x+5,y+20),
                    new Point(x,y+30),

                    new Point(x-5,y+20),
                    new Point(x-20,y+15),
                    new Point(x-5,y+10),

            };
            e.Graphics.FillClosedCurve(new SolidBrush(Color.Green), newstar);


            SolidBrush green = new SolidBrush(Color.Green);
            e.Graphics.FillPath(green, g1.gp1);//1 треугольник добавление в GraphicsPath1
            e.Graphics.FillPath(green, g1.gp2);//1 треугольник добавление в GraphicsPath2


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s1.Move();
            s2.Move();
            Refresh();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            g1.Move();
            Refresh();
        }
    }
}
