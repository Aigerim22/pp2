using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace файлыпапкипалиндром
{
    
        class Program
        {
            public static void F1()
            {
                DirectoryInfo dir = new DirectoryInfo(@"C:\Users\123\Downloads\15647NeonBand.RarZipExtractorPro_g3b9h1p9bdemw!App");
                FileSystemInfo[] fs = dir.GetFileSystemInfos();
                foreach (FileSystemInfo f in fs)
                {
                    if (f.GetType() == typeof(FileInfo))
                        Console.WriteLine(f.Name);
                    else
                    {
                        DirectoryInfo d1 = new DirectoryInfo(f.FullName);
                        Console.WriteLine(f.Name + "(" + d1.GetFileSystemInfos().Length + ")");
                    }
                }
            }

            public static void F2()
            {
                DirectoryInfo dir = new DirectoryInfo(@"C:\Users\123\Downloads\15647NeonBand.RarZipExtractorPro_g3b9h1p9bdemw!App");
                FileInfo[] files = dir.GetFiles("*.txt");
                Console.WriteLine(files.Length);
            }

            public static bool IsPalin(string s)
            {
                int n = s.Length;

                for (int i = 0; i < n / 2; i++)
                    if (s[i] != s[n - i - 1])
                        return false;
                return true;
            }

            public static void F3()
            {
                DirectoryInfo dir = new DirectoryInfo(@"C:\Users\123\Downloads\15647NeonBand.RarZipExtractorPro_g3b9h1p9bdemw!App");
                foreach (FileSystemInfo fs in dir.GetFileSystemInfos())
                {
                    if (IsPalin(fs.Name))
                    {
                        Console.WriteLine(fs.Name);
                    }
                }
            }

            static void Main(string[] args)
            {
                F1();
                F2();
                F3();

            }
        }
    }
