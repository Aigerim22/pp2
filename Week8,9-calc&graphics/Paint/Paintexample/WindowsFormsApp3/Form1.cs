using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    enum Tools
    {
        Pen,
        Rectangle,
        Circle
    }
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics g;
        bool clicked = false;
        Point prev;
        Point cur;
        Tools tools = Tools.Pen;
        int penwidth = 1;
        Color color1;
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            
            g = Graphics.FromImage(bmp);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

            clicked = true;
            prev = e.Location;
            if (e.Button == MouseButtons.Left)
            {
                cur = e.Location;
                color1 = pictureBox2.BackColor;
            }
            else
            {
                color1 = pictureBox3.BackColor;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            cur = e.Location;
            if (clicked)
            {
                if (tools == Tools.Pen)
                {
                    g.DrawLine(new Pen(color1, penwidth), prev, cur);
                    prev = cur;
                }
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            int x = Math.Min(prev.X, e.X);
            int y = Math.Min(prev.Y, e.Y);
            int width = Math.Abs(prev.X - e.X);
            int height = Math.Abs(prev.Y - e.Y);
            if (tools == Tools.Pen)
            {
                g.DrawLine(new Pen(color1, penwidth), x, y, width, height);

            }
            if (tools == Tools.Rectangle)
            {
                g.DrawRectangle(new Pen(color1, penwidth), x, y, width, height);
                
            }
             if(tools == Tools.Circle)
                {
                g.DrawEllipse(new Pen(color1, penwidth), x, y, width, height);

                }
            pictureBox1.Refresh();
            clicked = false;
        }

        private void Tools_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn.Text == "Pen")
            {
                tools = Tools.Pen;
            }
            if(btn.Text == "Rectangle")
            {
                tools = Tools.Rectangle;
            }
            if (btn.Text == "Circle")
            {
                tools = Tools.Circle;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            penwidth = trackBar1.Value;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.BackColor = colorDialog1.Color;
            }   
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.BackColor = colorDialog1.Color;
            }
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int x = Math.Min(prev.X, cur.X);
            int y = Math.Min(prev.Y, cur.Y);
            int width = Math.Abs(prev.X - cur.X);
            int height = Math.Abs(prev.Y - cur.Y);
            if (tools == Tools.Pen)
            {
                e.Graphics.DrawLine(new Pen(color1, penwidth), x, y, width, height);
            }
            if (tools == Tools.Rectangle)
            {
                e.Graphics.DrawRectangle(new Pen(color1, penwidth), x, y, width, height);
            }
            if (tools == Tools.Circle)
            {
                e.Graphics.DrawEllipse(new Pen(color1, penwidth), x, y, width, height);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
