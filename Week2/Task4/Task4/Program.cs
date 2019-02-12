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
            CreateFile();   //cals the void function to create the file
            CopyFile();    //calls the function CopyFile to copy the created file 
            DeleteFile();   //calls the third function in order to delete the original one

        }


        static void CreateFile()
        {
            string folderName = @"C:\Folder";   //specify the name for your folder
            string pathString = System.IO.Path.Combine(folderName, "SubFolder");//create the subfolder and add the name 
            System.IO.Directory.CreateDirectory(pathString);//create the directory 
            string fileName = "File.txt"; //specify the name for your file
            pathString = System.IO.Path.Combine(pathString, fileName);//combine again to add the file name to the path.
            Console.WriteLine("Path to my file: {0}\n", pathString); //verify the path that you have constructed.


            //Check that the file doesn't already exist. If it doesn't exist, create
            // the file and write integers 0 - 99 to it.
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
            
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }




        public static void CopyFile()
        {
            string fileName = "File.txt";  //specify the name of your file
            string sourcePath = @"C:\Folder\SubFolder";  //show where the file is located
            string targetPath = @"C:\Users\123\Desktop\pp2"; //show where you want to move it
         // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);
            //To copy a file to another location and overwrite the destination file if it already exists.
            System.IO.File.Copy(sourceFile, destFile, true);
        }

        public static void DeleteFile()
        {

           // Use a try block to catch IOExceptions, to
            // handle the case of the file already being
            // opened by another process.
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




