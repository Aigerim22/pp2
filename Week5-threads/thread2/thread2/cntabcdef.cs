using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread2
{
    class cntabcdef
    {
        static string cnt= null;
        static object locker = new object();
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Thread thread = new Thread(F1);
                thread.Start();
            }
            Console.ReadLine();
        }
        public static void F1()
        {
            lock (locker)
            {
                cnt = "abc";
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(cnt); 
                    Thread.Sleep(200);
                }
                cnt = "def";
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine(cnt); 
                    Thread.Sleep(500);
                }
            }
        }
    }
}