using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace locks
{
    class Program
    {
        public static Object lockObject = new object();
        static int k = 100;

        static void Main(string[] args)
        {
            Thread[] threads = new Thread[10]; //создание массивов типа threads
            for (int i = 0; i < 10; i++) //пробегаемся до элемeнтов массива
            {
                threads[i] = new Thread(PrintV); //вызываем функцию Printv для каждого элемента массива
                threads[i].Start(); // запускаем поток для каждого массива потока
            }
        }

        static void PrintV()
        {
            lock (lockObject) //oператор lock определяет блок кода, внутри которого весь код 
                              //блокируется и становится недоступным для других потоков до завершения работы текущего потока.
            {
                Console.WriteLine(k); //выводим на консоль к который равен изначально 100
                k -= 10;  //при этом каждый раз отнимаем 10 от к
            }
        }
    }
}



