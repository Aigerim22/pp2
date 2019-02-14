using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static string path = @"C:\Users\123\Desktop\subjects";
        static FileSystemInfo currentFSI;
        static int selectedindex = 0;
        static Stack<string> hist = new Stack<string>();


        static void Show()
        {
            Console.SetCursorPosition(0, 0);  //the column and row position of the cursor at the beginning
            DirectoryInfo d = new DirectoryInfo(@path);
            List<FileSystemInfo> li = new List<FileSystemInfo>();
            li.AddRange(d.GetDirectories()); //adds elements of this range to the end of the list
            li.AddRange(d.GetFiles());       //adds elements of this range to the end of the ist
            FileSystemInfo[] fsi = li.ToArray(); //copies the elements of the list to the new array
            currentFSI = fsi[selectedindex];

            for (int i = 0; i < fsi.Length; i++)
            {
                FileSystemInfo fs = fsi[i];
                if (selectedindex == i)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                if (fs.GetType() == typeof(DirectoryInfo)) //if it is folder then colour differs from file
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                Console.WriteLine(i + 1 + ". " + fs.Name); //creates numeration
            }
        }

        static void Main(string[] args)
        {

            while (true) //infinite loop
            {
                Show(); //calls function Show
                ConsoleKeyInfo cki = Console.ReadKey();
                switch (cki.Key)
                {
                    case ConsoleKey.UpArrow:
                        UpArrow(); //calls the given function
                        break;
                    case ConsoleKey.DownArrow:
                        DownArrow(); //calls the given function
                        break;
                    case ConsoleKey.Enter:
                        OpenFile(); //calls the given function
                        break;
                    case ConsoleKey.Backspace:
                        Backspace(); ////calls the given function
                        break;
                    case ConsoleKey.Delete:
                        Delete(); //calls the given function
                        break;
                    case ConsoleKey.R:
                        Rename(); ////calls the given function
                        break;
                }

            }
        }

        static void UpArrow()
        {
            selectedindex--;
            if (selectedindex < 0)
            {
                selectedindex = 0;
            }
        }

        static void DownArrow()
        {
            selectedindex++;
        }

        static void OpenFile()
        {
            Console.Clear();

            if (currentFSI.GetType() == typeof(DirectoryInfo))
            {
                selectedindex = 0;
                hist.Push(path);
                path = currentFSI.FullName; Console.Clear();
            }
            else
            {
                FileStream fs = new FileStream(currentFSI.FullName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs); //StreamReader reads content of the file
                Console.WriteLine(sr.ReadToEnd()); //console outputs the content of the file from beginning till the end
                Console.ReadKey();
                sr.Close();
                fs.Close();
            }
            Console.Clear();
        }

        static void Backspace() //function for key Backspace
        {
            path = hist.Peek(); //path of last folder, show запустится из родительской папки
            hist.Pop(); //delete the top element of the Stack
            selectedindex = 0;
            Console.Clear();
        }

        static void Delete() //function for key Delete
        {
            if (currentFSI.GetType() == typeof(FileInfo))
            {
                File.Delete(currentFSI.FullName);
            }
            else //if the selected item is folder then delete all of the path of this folder
            {
                Directory.Delete(currentFSI.FullName, true);
            }
            Console.Clear();
            selectedindex = 0;
        }

        static void Rename()
        {
            Console.SetCursorPosition(5, 15);
            Console.Write("Enter new name:");
            string path = currentFSI.FullName;
            string pr = new DirectoryInfo(path).Parent.FullName;
            string newName = Console.ReadLine();

            if (currentFSI.GetType() == typeof(FileInfo))
            {
                File.Move(path, pr + "\\" + newName); //moves the file to new place and renames
            }
            else
            {
                Directory.Move(path, pr + "\\" + newName);
            }

            Console.Clear();
        }
    }
}
