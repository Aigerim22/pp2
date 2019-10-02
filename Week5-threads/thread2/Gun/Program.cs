using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Gun
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                ConsoleKeyInfo cki = Console.ReadKey();
                Console.SetCursorPosition(0, 10);
                Console.WriteLine('O');

                switch (cki.Key)
                {
                    case ConsoleKey.Spacebar:
                        new Thread(DrawBullet).Start();
                        break;
                }

                
            }
        }

        static void DrawBullet()
        {
            int x = 5, y = 10;
            while (x < 40)
            {

                Console.SetCursorPosition(x, y);
                Console.Write('*');
                x++;
                Thread.Sleep(500);

                Console.SetCursorPosition(x-1, y);
                Console.Write(' ');
            }
        }
    }
}
