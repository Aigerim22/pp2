using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace bazathread
{
    class Program
    {
        static void Thread1()
        {
            for(int i =0; i<20; i++)
            {
                Console.WriteLine("FirstThread" + i);
            }
            Console.WriteLine("End");
        }
        static void Thread2()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("SecondThread" + i);
            }
            Console.WriteLine("End");
        }
        static void Thread3()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("ThirdThread" + i);
            }
            Console.WriteLine("End");
        }

        static void Main(string[] args)
        {
            ThreadStart threadstart1 = new ThreadStart(Thread1);
            ThreadStart threadstart2 = new ThreadStart(Thread2);
            ThreadStart threadstart3 = new ThreadStart(Thread3);
            Thread thread1 = new Thread(Thread1);
            Thread thread2 = new Thread(Thread2);
            Thread thread3 = new Thread(Thread3);
            thread1.Start();
            thread2.Start();
            thread3.Start();

            Console.ReadKey();

        }
    }
}
