using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            Thread[] t = {
                new Thread(array),
                new Thread(array),
                new Thread(array) };
                    
            for(int i = 0; i<n; i++)
            {
                t[i].Name = "T" + i;
                t[i].Start();
              
            }
            Console.ReadKey();

        }
        public static void array()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name);
                Thread.Sleep(3000);
            }
            
        }
    }
}
