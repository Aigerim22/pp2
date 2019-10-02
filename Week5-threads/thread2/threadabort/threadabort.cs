using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

class Test
{
    public static void Main()
    {
        Thread newThread = new Thread(new ThreadStart(TestMethod));
        newThread.Start();
        Thread.Sleep(1000);

        // Abort newThread.
        Console.WriteLine("abc");
        newThread.Abort("def");

        // Wait for the thread to terminate.
        newThread.Join();
        Console.WriteLine("def");
    }

    static void TestMethod()
    {
        try
        {
            while (true)
            {
                Console.WriteLine("New thread running.");
                Thread.Sleep(1000);
            }
        }
        catch (ThreadAbortException abortException)
        {
            Console.WriteLine((string)abortException.ExceptionState);
        }
    }
}
