using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace bankAkshabayev
{
    class Program
    {
        public class Bank
        {
            public static int balance;
            public static int bal;
            public static int x = 0;
            public static int y = 0;
            public Bank(int balance1, int bals)
            {
                balance = balance1;
                bal = bals; 
            }

            public static void Add()
            {
                x = 50;
               
                while (true)
                {
                    balance = balance + x;
                    Console.WriteLine(balance);
                    Thread.Sleep(3000);
                }
            }

            public static void Delete()
            {
                y = 10;
                while (true)
                {
                    bal -= y;
                    Console.WriteLine(bal);
                    Thread.Sleep(3000);
                }
              
            }

            static void Main(string[] args)
            {
                Bank bank = new Bank(5, 10);
               
                Thread myThread = new Thread(Add);
                
              
                    myThread.Start();
                Thread t2 = new Thread(Delete);
                t2.Start();
                
            }
        }
    }
}

