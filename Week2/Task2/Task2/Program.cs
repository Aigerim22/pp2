using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {

        static bool IsPrime(int x) //creating bool function to check if the array of number is prime or not
        {
            if (x == 1) return false; //if it is 1 and it has just one divider then it is not prime
            if (x == 2) return true;  //if the number equals 2 so it divides to 1 and  divisible by itself then it is a prime number

            bool functionResult = true; //by default it is true

            for (int i = 2; i < x; ++i) //running through the loop starting from 2 because every number divisible by 1
            {
                if (x % i == 0)        //if the given number divides without reminder to i, so the given condition holds that i<x
                {
                    functionResult = false; //then it is not prime
                    break;                
                }
            }
            return functionResult;    //else it is prime
        }

        static bool IsPrimeString(string s)
        {
            return IsPrime(int.Parse(s)); //returns the string and converts to the integer
        }

        static void Main(string[] args)
        {

            List<string> res = new List<string>(); //creates list where will be saved the prime numbers

            FileStream fs = new FileStream(@"C:\Users\123\Desktop\pp2\W1\input.txt", FileMode.Open, FileAccess.Read);//reads the content from FileStream
            StreamReader sr = new StreamReader(fs); //reads the content from byte stream

            string line = sr.ReadLine();  //StreamReader reads the string line
            string[] nums = line.Split(' '); //splited lines will be in the string array

            foreach (var x in nums)   //runs through the each number in array
            {
                if (IsPrimeString(x))  //if the called function is true
                {
                    res.Add(x);        //then add this number to the list
                }
            }

            sr.Close();              //after reading closes
            fs.Close();               



            FileStream fs2 = new FileStream(@"C:\Users\123\Desktop\pp2\W1\output.txt", FileMode.Create, FileAccess.Write); //new FileStream in order to save the res
            StreamWriter sw = new StreamWriter(fs2);

            foreach (var x in res)   //running through the each number in res
            {
                sw.Write(x + " ");   //streamwriter adds space between each number
                Console.Write(x + " "); 
            }

            sw.Close();
            fs2.Close();
        }
    }
}
