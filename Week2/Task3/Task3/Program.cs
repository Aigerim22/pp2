using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Show();
        }

        private static void PrintInfo(FileSystemInfo fsi, int k)
        {
            string line = new string(' ', k);  //to create k spaces 
            line = line + fsi.Name;            //line shows FileSystemInfo's name in the console
            Console.WriteLine(line);

            if (fsi.GetType() == typeof(DirectoryInfo)) //if it is not file but Directory
            {
                var items = (fsi as DirectoryInfo).GetFileSystemInfos(); //then get the FileSystemInfos in this directory
                foreach (var i in items)   //run through each file in the directory
                {
                    PrintInfo(i, k + 5);  //recursivly recalling the origin funciton
                }
            }
        }

        private static void Show()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\123\Desktop\subjects"); //open your directory
            PrintInfo(dir, 0); //Call the function PrintInfo with dir and 0(the number of spaces at the begining)
        }
    }
}