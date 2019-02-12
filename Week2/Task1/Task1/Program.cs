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
        public static string Reverse(string s)// creating string function for palindrome
        {
            char[] ch = s.ToCharArray(); //creating an array and converting the string s to char array
            Array.Reverse(ch);           //using reverse reverse the char array 
            return new string(ch);      //return the reversed string
        }
        static void Main(string[] args)
        {

            FileStream fs = new FileStream(@"C:\Users\123\Desktop\pp2\plndrm.txt", FileMode.Open,FileAccess.ReadWrite);//reads the contents from a FileStream 
            StreamReader sr = new StreamReader(fs); //reads chars from the byte stream
            string st1 = sr.ReadLine();             //reads the first string
            string st2=Reverse(st1);                //calls string function Reverse for the string 1 and equates to the second string
            
            if (st1 == st2)                         //compares two given strings, if they are the same or equals each other
            {
                Console.WriteLine("Yes");           //then it is palindrome
            }
            else Console.WriteLine("No");           //else not palindrome
            Console.ReadKey();                      //holds terminal open , until we press any key to do so
        }
    }
}

/*static void IsPalindrome(string s)//this function is created in order to check whether the writtin string is palindrome or not 
            {
                bool p = true;

                for (int i = 0; i < s.Length; i++)//running from 0 till the length of string s 
                {
                    if (s[s.Length - 1 - i] != s[i])//compares elements between each other
                    {
                        p = false;
                        break;
                    }
                }

                if (p)//if the above funciton is true then output will be yes, else will be no
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }

            static void Main(string[] args)
            {
                FileStream fs = new FileStream(@"C:\Users\123\Desktop\pp2\plndrm.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();

                IsPalindrome(line);

                sr.Close();//closes StreamReader
                fs.Close();//closes FileStream
                Console.ReadKey();// holds terminal open , until we press any key to do so
        }
        }
    }
*/
