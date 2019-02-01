using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            String triangle = Console.ReadLine();//computer reads the string star
            int triangle1 = int.Parse(triangle);//converting the star with type string to star1 of type integer
            for(int i=0; i <= triangle1; i++)//runs through the row of the 2d array till the end 
            {
                for(int j=0; j<=i; j++)//running through the column of the 2d array to the row 
                
                    Console.Write("[*]");//put [*] every time as i increases
                
                Console.Write(" \n");//start with new line to show triangle shape 
            }

            Console.ReadKey();//halting after running the program 
        }
    }
}
