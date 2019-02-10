using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {

        public static void Main(string[] args)
        {
            CreateFile();
            CopyFile();
            DeleteFile();

        }


        static void CreateFile()
        {
            string folderName = @"C:\Folder";
            string pathString = System.IO.Path.Combine(folderName, "SubFolder");
            System.IO.Directory.CreateDirectory(pathString);
            string fileName = "File.txt";
            pathString = System.IO.Path.Combine(pathString, fileName);
            Console.WriteLine("Path to my file: {0}\n", pathString);

            if (!System.IO.File.Exists(pathString))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(pathString))
                {
                    for (byte i = 0; i < 100; i++)
                    {
                        fs.WriteByte(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("File \"{0}\" already exists.", fileName);
                return;
            }
            try
            {
                byte[] readBuffer = System.IO.File.ReadAllBytes(pathString);
                foreach (byte b in readBuffer)
                {
                    Console.Write(b + " ");
                }
                Console.WriteLine();
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.Message);
            }
            CopyFile();
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }




        public static void CopyFile()
        {
            string fileName = "File.txt";
            string sourcePath = @"C:\Folder\SubFolder";
            string targetPath = @"C:\Users\123\Desktop\pp2";
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);
            System.IO.File.Copy(sourceFile, destFile, true);
        }

        public static void DeleteFile()
        {
            if (System.IO.File.Exists(@"C:\Folder\SubFolder\File.txt"))
            {
                try
                {
                    System.IO.File.Delete(@"C:\Folder\SubFolder\File.txt");
                }
                catch (System.IO.IOException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }
        }
    }
}




