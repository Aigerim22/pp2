using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace многошарабильярд
{
    public partial class Form1 : Form
    {
        public Graphics g;     // холст
        const int N_max = 50;  // максимальное число шаров
         ball[] balls = new ball[N_max];
        // объявление объектов - массив шаров
        public int N = 10;   // фактическое число шаров
        Random r = new Random();    // случайное число
        SolidBrush brf;

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Green; // цвет сукна
            this.Width = 1350; // новая ширина стола
            this.Height = 700; // новая длина стола

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ball s;  // ссылка на объект класса Sharik
            for (int i = 0; i < N; i++)
            {
                s = balls[i];
                // очистка холста от ранее нарисованного шара
                g.FillEllipse(brf, s.x, s.y, 2 * s.radius, 2 * s.radius);
                s.Next();  // его новое расположение через сдвиг
                           // изображение i-го шара после сдвига
                g.FillEllipse(s.br, s.x + 2, s.y + 2, 2 * s.radius - 4, 2 * s.radius - 4);
            }
        }
            private void Form1_Click(object sender, EventArgs e)
            {
                
            }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            N = Convert.ToInt32(comboBox1.Text);
            comboBox1.Visible = false;
            label1.Visible = false;
            Form1_Click(sender, e);
        }
    }
    }

