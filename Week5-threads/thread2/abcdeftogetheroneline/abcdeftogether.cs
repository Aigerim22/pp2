using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace abcdeftogetheroneline
{
    class abcdeftogether
    {
        static void Main(string[] args)
        { 
            Thread thread = new Thread(F1);
            Thread thread1 = new Thread(F2);
            thread.Start();
            thread1.Start();
        }
        public static void F1()
        {
            int x = 0;
            while (true)
            {
                Console.SetCursorPosition(0, x++);
                Console.Write("def");
                Thread.Sleep(240);

            }
        }
        public static void F2()
        {
            int x = 0;
            while (true)
            {
                Console.SetCursorPosition(10, x++);
                Console.Write("abc");
                Thread.Sleep(200);

            }
        }
    }
}

