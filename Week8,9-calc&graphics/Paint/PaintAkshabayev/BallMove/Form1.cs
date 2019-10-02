using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallMove
{
    enum Painttool
    {
        Pen,
        Rectangle,
        Ellipse,
        Star
    }

    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics graphics;
        Point prevpoint, curpoint;
        bool mouseclicked = false;
        Painttool tool = Painttool.Pen;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Refresh();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseclicked = true;
            prevpoint = e.Location;

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseclicked)
            {
                curpoint = e.Location;
                graphics.DrawLine(new Pen(Color.Red), prevpoint, curpoint);
                prevpoint = curpoint;
            }
            pictureBox1.Refresh();
        }


        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseclicked = false;
            if (tool == Painttool.Rectangle)
            {
                graphics.DrawRectangle(new Pen(Color.Black), GetRectangle(prevpoint, curpoint));
            }

        }
    
        /*
        Rectangle GetRectangle(Point prevpoint, Point curpoint)
        {
            int minX = Math.Min(prevpoint.X, curpoint.X);
            int minY = Math.Min(prevpoint.Y, curpoint.Y);
            int width = Math.Abs(prevpoint.X - curpoint.X);
            int height = Math.Abs(prevpoint.Y - curpoint.Y);

        }
        */

        private void pen(object sender, EventArgs e)
        {
            tool = Painttool.Pen;
        }

        private void Rectangle(object sender, EventArgs e)
        {
            tool = Painttool.Rectangle;
        }

        private void Ellipse(object sender, EventArgs e)
        {
            tool = Painttool.Ellipse;
        }

        private void Star(object sender, EventArgs e)
        {
            tool = Painttool.Star;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
