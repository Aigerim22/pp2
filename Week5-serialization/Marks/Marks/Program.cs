﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task2
{
    public class Program
    {
        public class Marks
        {
            public string letter;
            public int points;

            public Marks()
            {
               //this.points = points;
            }
            

            public string GetLetter()
            {
                switch (points)
                {
                    case int n when (points <= 100 && points >= 95):
                            letter = "A";
                            return letter;


                    case int n when (n <= 94 && n >= 90):
                            letter = "A-";
                            return letter;

                    case int n when (n <= 89 && n >= 85):
                        letter = "B+";
                        return letter;


                    case int n when (n <= 84 && n >= 80):
                        letter = "B";
                        return letter;


                    case int n when (n <= 79 && n >= 75):
                        letter = "B-";
                        return letter;


                    case int n when (n <= 74 && n >= 70):
                        letter = "C+";
                        return letter;


                    case int n when (n <= 69 && n >= 65):
                        letter = "C";
                        return letter;

                    case int n when (n <= 64 && n >= 60):
                        letter = "C-";
                        return letter;


                    case int n when (n <= 59 && n >= 55):
                        letter = "D+";
                        return letter;


                    case int n when (n <= 54 && n >= 50):
                        this.letter = "D";
                        return letter;


                    case int n when (n <= 49 && n >= 0):
                        letter = "F";
                        return letter;
                       

                    default:
                        return "Invalid";
                }
            }

            public override string ToString()
            {
                return GetLetter();
            }
        }

        public static void Main(string[] args)
        {

            F1();
            F2();

        }
        public static void F1()
        {
            List<Marks> objects = new List<Marks>();
            Marks A = new Marks();
            A.points = int.Parse(Console.ReadLine());
            objects.Add(A);
            FileStream fs = new FileStream("marks.txt", FileMode.Create, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(List<Marks>));
            xs.Serialize(fs, objects);
           fs.Close();
        }

         public static void F2()
        {
            FileStream fs = new FileStream("marks.txt", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(List<Marks>));
            List<Marks> objects= xs.Deserialize(fs) as List<Marks>;
            for(int i=0; i<objects.Count; i++)
            {
                Console.WriteLine(objects[i]);
            }
            Console.WriteLine(objects.ToString());
            fs.Close();
        }
    }
}
