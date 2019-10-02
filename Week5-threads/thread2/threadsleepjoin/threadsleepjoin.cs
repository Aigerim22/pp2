using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace threadsleepjoin
{
    class threadsleepjoin
    {
        static void Main(string[] args)
        {
            Thread th = new Thread(Run);
            th.Start();
            th.Join();//used to call a thread and Blocks the calling thread until a thread terminates i.e Join method waits for finishing other threads by calling its join method.
            Console.WriteLine("Thread t has terminated !");
            Console.Read();
        }
        static void Run()
        {

            for (int i = 0; i < 50; i++) {

            Console.Write("C#corner");//чтобы по-очереди выводить слово за словом 
                Thread.Sleep(100);
            }   
        }
    }
}
