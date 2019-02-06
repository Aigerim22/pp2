using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static string Reverse(string s)
        {
            char[] ch = s.ToCharArray();
            Array.Reverse(ch);
            return new string(ch);
        }
        static void Main(string[] args)
        {

            FileStream fs = new FileStream(@"C:\Users\123\Desktop\pp2\plndrm.txt", FileMode.Open,FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            string st1 = sr.ReadLine();
            string st2=Reverse(st1);
            
            if (st1 == st2)
            {
                Console.WriteLine("Yes");
            }
            else Console.WriteLine("No");
            Console.ReadKey();
         }
    }
}