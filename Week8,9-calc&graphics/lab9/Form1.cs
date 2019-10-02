using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex3
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics gfx;
        Pen pen = new Pen(Color.Yellow);
        List<Point> circlepoints = new List<Point>(){
            new Point(180,200),
            new Point(120, 120),
            new Point(230,100),
            new Point(140,15),
            new Point(50, 225),
            new Point(60,310),
            new Point(350, 25),
            new Point(460,310)
        };


        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gfx = Graphics.FromImage(bmp);
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
           
            foreach (Point pt in circlepoints)
            {
                gfx.FillEllipse(Brushes.White, pt.X, pt.Y, 15, 15);
            }
            Point point1 = new Point(252, 199);
            Point point2 = new Point(219, 255);
            Point point3 = new Point(251, 312);
            Point point4 = new Point(316, 312);
            Point point5 = new Point(349, 256);
            Point point6 = new Point(316, 200);
            Point[] polygonPoints =
                     {
                 point1,
                 point2,
                 point3,
                 point4,
                 point5,
                 point6 
             };
            gfx.DrawPolygon(pen, polygonPoints);
            gfx.FillPolygon(pen.Brush, polygonPoints);

            
            Point point7 = new Point(257, 114);
            Point point8 = new Point(250, 130);
            Point point9 = new Point(237, 133);
            Point point10 = new Point(249, 137);
            Point point11 = new Point(256, 151);
            Point point12 = new Point(262, 138);
            Point point13 = new Point(276, 133);
            Point point14 = new Point(262, 129);
            Point[] star1points =
                     {
                 point7,
                 point8,
                 point9,
                 point10,
                 point11,
                 point12,
                 point13,
                 point14
             };
            GraphicsPath graphPath = new GraphicsPath();
            graphPath.AddPolygon(star1points);
            gfx.DrawPath(pen, graphPath);
            gfx.FillPath(Brushes.Green, graphPath);

            Point[] starpoints = new Point[]
            {
                 new Point(180, 300),
                  new Point(165, 323),
                   new Point(195, 323),
            };
            Point[] starpoints1 = new Point[]
            {
                 new Point(180, 330),
                  new Point(165, 310),
                   new Point(195, 310),
            };
            Point[] starpoints2 = new Point[]
                {
                 new Point(100, 220),
                  new Point(85, 243),
                   new Point(115, 243),
                };
            Point[] starpoints3 = new Point[]
                {
                 new Point(100, 250),
                  new Point(85, 230),
                   new Point(115, 230),
                };

            Point[] starpoints4 = new Point[]
                {
                 new Point(355, 235),
                  new Point(340, 182),
                   new Point(370, 242),
                };
            Point[] starpoints5 = new Point[]
                {
                 new Point(355, 205),
                 new Point(340, 195),
                 new Point(370, 195),
                };
            gfx.FillPolygon(Brushes.Red, starpoints);
            gfx.FillPolygon(Brushes.Red, starpoints1);
            gfx.FillPolygon(Brushes.Red, starpoints2);
            gfx.FillPolygon(Brushes.Red, starpoints3);
           // gfx.FillPolygon(Brushes.Red, starpoints4);
          //gfx.FillPolygon(Brushes.Red, starpoints5);
            pictureBox1.Image = bmp;
         }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            var borderColor = Color.Black;
            var borderStyle = ButtonBorderStyle.Solid;
            var borderWidth = 5;
            ControlPaint.DrawBorder(e.Graphics, pictureBox1.ClientRectangle, borderColor,
                    borderWidth,
                    borderStyle,
                    borderColor,
                    borderWidth,
                    borderStyle,
                    borderColor,
                    borderWidth,
                    borderStyle,
                    borderColor,
                    borderWidth,
                    borderStyle);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
