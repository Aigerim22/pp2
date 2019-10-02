using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\123\Desktop\pp2");
            try
            {
                foreach (var x in dir.GetDirectories("*.*", SearchOption.TopDirectoryOnly))
                {
                    int cnt = x.GetFiles("*.txt").Length;
                    Console.WriteLine(x.Name + " " + cnt);
                }
            }
            catch (Exception e)
            {

            }
            //finally
            foreach (var x in dir.GetFiles())
            {
                Console.WriteLine(x.Name);
            }
        }
    }
}
