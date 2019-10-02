using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carmovesback
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitmap;
        }
        public int x = 200;
        public int x1 = 100;
        public int x2 = 200;
        public int x3 = 450;

        int dx = 10;
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), x, 200, 30, 100);
            e.Graphics.FillRectangle(new SolidBrush(Color.Blue), x1, 300, 50, 100);
            e.Graphics.FillEllipse(new SolidBrush(Color.Black), x2, 380, 50, 50);
            e.Graphics.FillEllipse(new SolidBrush(Color.Black), x3, 380, 50, 50);
        }
    }
}
