using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomFigures
{
    enum Clear
    {
        Clear,
        Picture
    }
    public partial class Form1 : Form
    {
        Clear clear = Clear.Clear;
        int x, y, index, r=30;
        Random color = new Random();
        SolidBrush brush;
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            x = e.Location.X;
            y = e.Location.Y;
            Random random = new Random();
            index = random.Next(1, 4);
            brush = new SolidBrush(Color.FromArgb(color.Next(0, 250), color.Next(0, 250), color.Next(0, 250)));
            clear = Clear.Picture;
           
            Refresh();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            switch (clear)
            {
                case Clear.Clear:
                    break;
                case Clear.Picture:
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    if (index == 1)
                    {
                        e.Graphics.FillEllipse(brush, x - r, y - r, 2 * r, 2 * r);
                    }
                    else if (index == 2)
                    {
                        e.Graphics.FillRectangle(brush, x - 30, y - 20, 60, 40);
                    }
                    else if(index == 3)
                    {
                        Point[] point = { new Point(x, y-25), new Point(x - 40, y + +25), new Point(x + 40, y + +25) };
                        e.Graphics.FillPolygon(brush, point);
                    }
                    break;
            }
        }

       
        public Form1()
        {
            InitializeComponent();
            brush = new SolidBrush(Color.FromArgb(color.Next(0, 250),color.Next(0,250),color.Next(0,250)));
        }
    }
}
