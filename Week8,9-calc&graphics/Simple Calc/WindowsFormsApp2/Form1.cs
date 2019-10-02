 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    enum Op //перечисляем операторы
    {
        Sum,
        Subtract,
        Multiply,
        Division,
        Power, 
        Max
    }
    public partial class Form1 : Form
    {
        //static чтобы все имели доступ, классы и методы и т.д
        static Op opera = Op.Sum;  //по дефолту перечисление равен сумме
        static double temporary = 0; //для временного сохранения числа
        static bool op = false;   //по дефолту фолс 

        public bool text = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (textBox1.Text == "0" || text == false)
            {
                textBox1.Text = btn.Text;
            }
            else
            {
                textBox1.Text += btn.Text;
            }
            text = true;
        }

        private void Operations(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (op == true && text == true)
            {
                if (opera == Op.Sum)
                {
                    textBox1.Text = (temporary + double.Parse(textBox1.Text)).ToString();
                }
                if (opera == Op.Subtract)
                {
                    textBox1.Text = (temporary - double.Parse(textBox1.Text)).ToString();
                }
                if (opera == Op.Multiply)
                {
                    textBox1.Text = (temporary * double.Parse(textBox1.Text)).ToString();
                }
                if (opera == Op.Division)
                {
                    textBox1.Text = (temporary / double.Parse(textBox1.Text)).ToString();
                }
                if (opera == Op.Power)
                {
                    textBox1.Text = Math.Pow(temporary, double.Parse(textBox1.Text)).ToString();
                }
                if(opera == Op.Max)
                {
                    double max = 0;
                    if (double.Parse(textBox1.Text) > temporary)
                    {
                        max = double.Parse(textBox1.Text);
                    }
                    else max = temporary;
                    textBox1.Text = max.ToString();
                }
            }
            temporary = double.Parse(textBox1.Text);
            if (button.Text == "+")
            {
                opera = Op.Sum;
            }
            if (button.Text == "-")
            {
                opera = Op.Subtract;
            }
            if (button.Text == "*")
            {
                opera = Op.Multiply;
            }
            if (button.Text == "/")
            {
                opera = Op.Division;
            }
            if (button.Text == "x^y")
            {
                opera = Op.Power;
            }
            if(button.Text == "max")
            {
                opera = Op.Max;
            }
            op = true;
            text = false;
        }

        private void Result(object sender, EventArgs e) //функция для equals
        {
            if (opera == Op.Sum)
            {
                textBox1.Text = (double.Parse(textBox1.Text) + temporary).ToString();
            }
            if (opera == Op.Subtract)
            {
                textBox1.Text = (temporary - double.Parse(textBox1.Text)).ToString();
            }
            if (opera == Op.Multiply)
            {
                textBox1.Text = (double.Parse(textBox1.Text) * temporary).ToString();
            }
            if (opera == Op.Division)
            {
                textBox1.Text = (double.Parse(textBox1.Text) / temporary).ToString();
            }
            if (opera == Op.Power)
            {
                textBox1.Text = Math.Pow(temporary, double.Parse(textBox1.Text)).ToString();
            }
            if(opera == Op.Max)
            {
                double max = 0;
                if (double.Parse(textBox1.Text) > temporary)
                {
                    max = double.Parse(textBox1.Text);
                }
                else max = temporary;
                textBox1.Text = max.ToString();
            }
            op = false;
            text = false;

        }


        private void sqr(object sender, EventArgs e)
        {
            textBox1.Text = Math.Pow(int.Parse(textBox1.Text), 2).ToString();
        }

        private void sqrt(object sender, EventArgs e)
        {
            textBox1.Text = Math.Sqrt(int.Parse(textBox1.Text)).ToString();
        }

        private void ce(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void c(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            temporary = 0;
            op = false;
            text = false;
        }
        private void sin(object sender, EventArgs e)
        {
            textBox1.Text = Math.Sin(int.Parse(textBox1.Text)).ToString();
        }

        private void cos(object sender, EventArgs e)
        {
            textBox1.Text = Math.Cos(int.Parse(textBox1.Text)).ToString();
        }

        private void log(object sender, EventArgs e)
        {
            textBox1.Text = Math.Log(int.Parse(textBox1.Text)).ToString();
        }

        private void lg(object sender, EventArgs e)
        {
            textBox1.Text = Math.Log10(int.Parse(textBox1.Text)).ToString();
        }

        private void exp(object sender, EventArgs e)
        {
            textBox1.Text = Math.Exp(int.Parse(textBox1.Text)).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sumdiv(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int res = 0;
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                    res += i;

            }
            textBox1.Text = res.ToString();
        }


        private void primecheck(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int m = 0, flag = 0;
            m = a / 2;
            for (int i = 2; i <= m; i++)
            {
                if (a % i == 0)
                {
                    textBox1.Text = "not Prime.";
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                textBox1.Text = "Prime.";
        }

        private void backspace_click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
            {
                textBox1.Text = "0";
            }
            else
            {
                string newtext = "";
                for (int i = 0; i < textBox1.Text.Length - 1; i++)
                {
                    newtext += textBox1.Text[i];
                }
                textBox1.Text = newtext;
            }
        }

        private void plusorminus_click(object sender, EventArgs e)
        {
            double d = double.Parse(textBox1.Text);
            d = d * -1;
            textBox1.Text = d.ToString();
        }

        private void factorial_click(object sender, EventArgs e)
        {
            double result = 1;
            
                for (int i = 2; i <= int.Parse(textBox1.Text); i++)
                {
                    result *= i;
                }
                
            textBox1.Text = result.ToString();
        }

        private void Onedividex(object sender, EventArgs e)
        {
            double  result = 1 / double.Parse(textBox1.Text);
            textBox1.Text = result.ToString();
        }

        private void x3(object sender, EventArgs e)
        {
            textBox1.Text = ((Convert.ToDouble(textBox1.Text)) * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text)).ToString();
        }


        private void ToBin(object sender, EventArgs e)
        {
            int value = (Convert.ToInt32(textBox1.Text));
            textBox1.Clear();
            textBox1.Text = Convert.ToString(value, 2);
        }

        private void ToHex(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBox1.Text);
            textBox1.Text = Convert.ToString(value, 16);
        }

        private void BintoHex(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBox1.Text);
            textBox1.Text = Convert.ToString(value, 16);
        }

        private void xn(object sender, EventArgs e)
        {
           // int power= Convert.ToInt32(textBox1.Text);
           // int ans = Math.Pow(int.Parse(textBox1.Text), power);
            //temporary = (Convert.ToDouble(textBox1.Text));
            //textBox1.Clear();

           // power = Convert.ToDouble(textBox1.Text);
            //ans = Math.Pow(prevNum, power);
        }

        private void howmanydiv(object sender, EventArgs e)
        {
            int sum = 0;
            int number = (Convert.ToInt32(textBox1.Text));

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    sum++;
            }
            textBox1.Text = (sum).ToString();
        }

        private void max(object sender, EventArgs e)
        {

        }

        private void abs(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            textBox1.Text = Math.Abs(Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void factorial_Click(object sender, EventArgs e)
        {
            
           
        }

        double FirstNumber;

        private void Fibonacci(object sender, EventArgs e)
        {
            double fib(double FirstNumber)
            {

                if (FirstNumber == 1) return 0;
                if (FirstNumber == 2) return 1;
                if (FirstNumber == 3) return 1;
                return fib(FirstNumber - 1) + fib(FirstNumber - 2);

            }
            double result;
            FirstNumber = Convert.ToDouble(textBox1.Text);

            result = fib(FirstNumber);

            textBox1.Text = Convert.ToString(result);
        }
    }
}

