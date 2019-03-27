using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {

        static void Main(string[] args)
        {
            GameState.EnterName();
            Console.CursorVisible = false;
            Console.Clear();

            GameState gameState = new GameState();
                while (true)
                {
                    gameState.Draw();
                gameState.draw_comments();
                    ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                    gameState.PressedKey(consoleKeyInfo);
                } 
        }
        /*public static void EnterName()
        {
            bool saveCursorVisible;
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            saveCursorVisible = Console.CursorVisible;
            Console.Clear();
        }
        */
    }
}
