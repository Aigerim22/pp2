using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ballfallsdown
{
    public partial class Form1 : Form
    {
        Graphics g;
        SolidBrush brf;
       
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Green;
            brf = new SolidBrush(BackColor);
            this.Width = 1000;              // новая ширина формы
            this.Height = 500;              // новая высота формы

        }
         ball shar = new ball(80, Color.Yellow, 5, 5, 5, -5);


        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            g.FillEllipse(brf, shar.x, shar.y, 2 * shar.r, 2 * shar.r);
            shar.Next();          // вычисление нового положения шара
            g.FillEllipse(shar.br, shar.x, shar.y, 2 * shar.r, 2 * shar.r);         
        }
    }
}
