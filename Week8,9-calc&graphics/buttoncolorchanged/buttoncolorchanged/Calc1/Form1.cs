using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc1
{
    public partial class Form1 : Form
    {
        List<Button> buttons;
        int r, g, k;

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            buttons = new List<Button>();

            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; ++j)
                {
                    Button b = new Button();
                    b.Location = new Point(i * 100, j * 100);
                    b.Click += click;
                    b.Text = "" + (i * 3 + j - 1);
                    b.Size = new Size(100, 100);
                    buttons.Add(b);
                    Controls.Add(b);
                }
            }
            InitializeComponent();
        }

        private void click(object sender, EventArgs e)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            r = random.Next(0, 254);
            g = random.Next(0, 254);
            k = random.Next(0, 254);

            Button b = sender as Button;

            if (b.Text == "3")
            {
                foreach (Button button in buttons)
                {
                    if (button.Text != "3")
                    {
                        button.BackColor = Color.FromArgb(r, g, k);
                    }
                    else
                    {
                        button.BackColor = Color.White;
                    }
                }
                textBox1.BackColor = Color.FromArgb(r, g, k);
                textBox1.Refresh();
            }


            if (b.Text == "6")
            {
                foreach (Button button in buttons)
                {
                    if (button.Text != "6")
                    {
                        button.BackColor = Color.FromArgb(r, g, k);
                    }
                    else
                    {
                        button.BackColor = Color.White;
                    }
                    textBox1.BackColor = Color.FromArgb(r, g, k);
                    textBox1.ForeColor = Color.FromArgb(r, g, k);
                }
                textBox1.BackColor = Color.FromArgb(r, g, k);
                textBox1.Refresh();
            }

            if (b.Text == "9")
            {
                foreach (Button button in buttons)
                {
                    if (button.Text != "9")
                    {
                        button.BackColor = Color.FromArgb(r, g, k);
                    }
                    else
                    {
                        button.BackColor = Color.White;
                    }
                }
                textBox1.BackColor = Color.FromArgb(r, g, k);
                textBox1.Refresh();
            }

            if (b.Text == "4")
            {
                foreach (Button button in buttons)
                {
                    if (button.Text != "4")
                    {
                        button.BackColor = Color.FromArgb(r, g, k);
                    }
                    else
                    {
                        button.BackColor = Color.White;
                    }
                }
                textBox1.BackColor = Color.FromArgb(r, g, k);
                textBox1.Refresh();
            }

            if (b.Text == "5")
            {
                foreach (Button button in buttons)
                {
                    if (button.Text != "5")
                    {
                        button.BackColor = Color.FromArgb(r, g, k);
                    }
                    else
                    {
                        button.BackColor = Color.White;
                    }

                }
                textBox1.BackColor = Color.FromArgb(r, g, k);                
                textBox1.Refresh();

            }
            if (b.Text == "7")
            {
                foreach (Button button in buttons)
                {
                    if (button.Text != "7")
                    {
                        button.BackColor = Color.FromArgb(r, g, k);
                    }
                    else
                    {
                        button.BackColor = Color.White;
                    }
                }
                textBox1.BackColor = Color.FromArgb(r, g, k);
                textBox1.Refresh();

            }
            if (b.Text == "10")
            {
                foreach (Button button in buttons)
                {
                    if (button.Text != "10")
                    {
                        button.BackColor = Color.FromArgb(r, g, k);
                    }
                    else
                    {
                        button.BackColor = Color.White;
                    }

                }
                textBox1.BackColor = Color.FromArgb(r, g, k);  
                textBox1.Refresh();
            }
            if (b.Text == "8")
            {
                foreach (Button button in buttons)
                {
                    if (button.Text != "8")
                    {
                        button.BackColor = Color.FromArgb(r, g, k);
                    }
                    else
                    {
                        button.BackColor = Color.White;
                    }

                }
                textBox1.BackColor = Color.FromArgb(r, g, k);
                textBox1.Refresh();

            }
            if (b.Text == "11")
            {
                foreach (Button button in buttons)
                {
                    if (button.Text != "11")
                    {
                        button.BackColor = Color.FromArgb(r, g, k);
                    }
                    else
                    {
                        button.BackColor = Color.White;
                    }
                }
                textBox1.BackColor = Color.FromArgb(r, g, k);
                textBox1.Refresh();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
