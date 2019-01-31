using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static bool IsPrime(int n) //the given public function checks whether the given number is prime or not 
        {
            int cnt = 0; //the counting starts at zero 
            for (int i = 1; i <= n; ++i)
            {
                if (n % i == 0)//if the given number divides without reminder
                    cnt++; //then counting starts
            }
            if (cnt == 2)// if the counting equals 2 which means that number has 2 dividers then it is prime number
                return true; //the given number is prime
            else return false; //else it is not prime
        }

        static void Main(string[] args)
        {
            String n = Console.ReadLine(); //the computer reads the string
            int nn = int.Parse(n);  //converting string into integer
            var primes = new List<int>();//creating list for saving prime numbers

            String m = Console.ReadLine();//the another string m which shows theoutput number of primes
            String[] array = m.Split(' ');// splits after in order to read every giving number
            for (int i = 0; i < nn; i++) //runs through starting with 0 index of our list 
            {
                int numbers = int.Parse(array[i]); // convert our string into integer
                if (IsPrime(numbers)) //if the given condition holds or the function is true
                {
                    primes.Add(numbers); // then add these numbers to the prime list
                }
            }
            Console.WriteLine(primes.Count); //count the given primes and show output 
            for(int i=0; i < primes.Count; i++)// runs through the counted prime numbers
            {
                Console.Write(primes[i] + " "); //then show the each prime number as output
            }
            Console.ReadKey();//pausing after execution of the program
        }
    }
}
