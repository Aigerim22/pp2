using System;
using System.Collections.Generic;
using System.IO;
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
            string folderName = @"C:\Folder1";   //specify the name for your folder
            string pathString = Path.Combine(folderName);//create the folder 
            Directory.CreateDirectory(pathString);//create the directory 
            string fileName = "File.txt"; //specify the name for your file
            pathString = Path.Combine(pathString, fileName);//combine again to add the file name to the path.
            Console.WriteLine("Path to my file: {0}\n", pathString); //verify the path that you have constructed.
             //Check that the file doesn't already exist. If it doesn't exist, create
            // the file and write integers 0 - 99 to it.
            if (!File.Exists(pathString))
            {
                using (FileStream fs = File.Create(pathString))
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
        }
          public static void CopyFile()
        {
            string fileName = "File.txt";  //specify the name of your file
            string sourcePath = @"C:\Folder1";  //show where the file is located
            string targetPath = @"C:\Users\123\Desktop\pp2\Week2\Task4"; //show where you want to move it
         // Use Path class to manipulate file and directory paths.
            string sourceFile = Path.Combine(sourcePath, fileName);
            string destFile = Path.Combine(targetPath, fileName);
            //To copy a file to another location and overwrite the destination file if it already exists.
            File.Copy(sourceFile, destFile, true);
        }
           public static void DeleteFile()
        {
             File.Delete(@"C:\Folder1\File.txt");
        }
    }
}




