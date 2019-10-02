using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread4
{
    class classmythreadtask2
    {
       static void Main(string[] args)
        {
            MyThread t1 = new MyThread("Thread 1");
            MyThread t2 = new MyThread("Thread 2");
            MyThread t3 = new MyThread("Thread 3");

            t1.startThread();
            t2.startThread();
            t3.startThread();
            Console.Read();

        }
    }
    class MyThread
    {
        Thread threadfield;

        public MyThread(string name)
        {
            threadfield = new Thread(this.func);
            threadfield.Name = name;
        }

        public void startThread()
        {
            threadfield.Start();

        }
        void func()
        {

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " выводит " + i);
                Thread.Sleep(300);
            }
            Console.WriteLine(Thread.CurrentThread.Name + " завершился");
        }
    }

}

