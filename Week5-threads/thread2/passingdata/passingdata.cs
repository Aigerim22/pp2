using System;
using System.Threading;
public class ThreadWithState
{
    private string boilerplate;
    private int value;
    
    public ThreadWithState(string text, int number)
    {
        boilerplate = text;
        value = number;
    }
    public void ThreadProc()
    {
        Console.WriteLine(boilerplate, value);
    }
}

public class Example
{
    public static void Main()
    {
        ThreadWithState tws = new ThreadWithState(
            "This report displays the number {0}.", 42);
        Thread t = new Thread(new ThreadStart(tws.ThreadProc));
        t.Start();
        Console.WriteLine("Main thread does some work, then waits.");
        t.Join();
        Console.WriteLine(
      "Independent task has completed; main thread ends.");
    }
}