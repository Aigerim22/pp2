using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class GameState
    {
        public static int score = 0;
        public static int level = 2;
        public static int MaxScore = 1;
        public static int height = 40;
        public bool gameOver = false;
        Worm w = new Worm('0');
        Food f = new Food('@');
        Wall b = new Wall('#');

        public GameState()
        {
            Console.SetWindowSize(40, 40);
            Console.SetBufferSize(40, 40);
            Console.CursorVisible = false;
        }
        static string name;
        public static void EnterName()
        {
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
        }
        public void Draw()
        {
            if (!gameOver)
            {
                w.Draw();
                f.Draw();
                b.Draw();
        }
        }
        public void draw_comments()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, height - 5);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Player:" + name);
            Console.WriteLine("Your score:" + score);
            Console.WriteLine("Your level:" + level);
            Console.ForegroundColor = ConsoleColor.White;
        }
        void CheckFood()
        {
            if (w.CheckCollision(b.body))
            {
                gameOver = true;
                Console.Clear();
                Console.SetCursorPosition(10, 20);
                Console.WriteLine("Game over!");
            }
             else if (w.CheckCollision(f.body))
            {
                w.Eat(f.body[0]);
                score++;
                f.Generate();
                }
            else if (w.CheckCollisionwithItself())
            {
                gameOver = true;
                Console.Clear();
                Console.SetCursorPosition(10, 20);
                Console.WriteLine("Game over!");
            }

            if (score > MaxScore)
            {
                b.Clear();
                b.body.Clear();
                level = 3;
                b.LoadLevel(3);
            }
        }
        
       /* void CheckFood()
        {
            if (w.CheckCollision(f.body))
            {
                w.Eat(f.body[0]);
                score++;
                do
                {
                    f.Generate();
                }
                while (!CheckFoodSnake());
                Console.SetCursorPosition(5, 32);
                Console.Write("Score:" + score);
            }
           else  if (w.CheckCollisionwithItself())
            {
                gameOver = true;
                Console.Clear();
                Console.SetCursorPosition(10, 20);

                Console.WriteLine("Game over!");
            }
        }
    
        bool CheckFoodSnake()
        {
            for (int i = 0; i < w.body.Count; i++)
            {
                if (w.body[i].X == f.body[0].X && w.body[i].Y == f.body[0].Y)
                {
                    return false;
                }
            }
            return true;
        }
        void CheckWall()
        {

            if (w.CheckCollision(b.body))
            {
                gameOver = true;
                Console.Clear();
                Console.SetCursorPosition(5, 33);

                Console.WriteLine("Game over!");
            }

            if (score > MaxScore)
            { 
               // b.LoadLevel(3);
            }
        }
        */

    public void PressedKey(ConsoleKeyInfo consoleKeyInfo)
        {
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    w.Move(0, -1);
                    break;
                case ConsoleKey.DownArrow:
                    w.Move(0, 1);
                    break;
                case ConsoleKey.LeftArrow:
                    w.Move(-1, 0);
                    break;
                case ConsoleKey.RightArrow:
                    w.Move(1, 0);
                    break;
                case ConsoleKey.F2:
                    w.Save();
                    f.Save();
                    break;
                case ConsoleKey.F3:
                 w = w.Load() as Worm;
                    f = f.Load() as Food;
                    break;

            }
            CheckFood();
        }
        public void Save()
        {

        }

    }
}

   

            