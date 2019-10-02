using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace abc
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(func);
            Thread thread2 = new Thread(func2);
            Thread thread3 = new Thread(func);
            Thread thread4 = new Thread(func2);

            thread.Start();
            thread2.Start();
            
            thread3.Start();
            thread4.Start();
            

        }
        static void func()
        {
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("abc");
                Thread.Sleep(1000);
            }
        }
        static void func2()
        {
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("def");
                Thread.Sleep(2000);
            }
        }
    }
}
