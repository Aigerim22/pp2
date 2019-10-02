using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace example
{
    class examplelocker
    {
        static int x = 0;
        static object locker = new object();//что такое object?
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)//пробегаемся до 5ти потоков
            {
                Thread myThread = new Thread(Count); //создаем поток и присваиваем функцию Count
                myThread.Name = "Поток " + i.ToString(); //преобразовывает числовое значение в строку поток+число в виде строки
                myThread.Start(); //запускаем потоки
            }

            Console.ReadLine();
        }
        public static void Count()
        {
            lock (locker) //блокируем объект locker то есть доступ к блоку кода имеет только один поток
            {
                x = 1;  //для каждого запускаемого потока начинаем с 1
                for (int i = 1; i < 9; i++) //пробегаемся до 9ти
                {
                    Console.WriteLine("{0}: {1}",Thread.CurrentThread.Name, x); //
                    x++;//x increases for each thread
                    Thread.Sleep(100);
                }
            }
        }
    }
}
      