using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace class_counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(F1);

            t.Start();
            t.Join();
            while (true)
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("def");
                    Thread.Sleep(500);
                }
                F1();
            }
        }

        static void F1()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("abc");
                Thread.Sleep(200);
            }
        }
    }
}

