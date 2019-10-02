using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace timer2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            // устанавливаем метод обратного вызова
            TimerCallback tm = new TimerCallback(Count);
            // создаем таймер
            System.Threading.Timer timer = new System.Threading.Timer(tm, num, 0, 2000);

            Console.ReadLine();
        }
        public static void Count(object obj)
        {
            int x = (int)obj;
            for (int i = 1; i < 9; i++, x++)
            {
                Console.WriteLine("{0}", x * i);
            }
        }
    }
}