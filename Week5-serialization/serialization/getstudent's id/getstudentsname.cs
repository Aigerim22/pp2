using System;
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
        public class Student
        {
            public string name;
            public string id;

            public Student()
            {
                //this.points = points;
            }


            public string Getname()
            {
                switch (id)
                {
                    case string n when (id == "18BD123"):
                        name = "Aigerim";
                        return name;

                    case string n when (id == "18BD456"):
                        name = "Alina";
                        return name;
                        default:
                        return "Invalid";
                }
            }

            public override string ToString()
            {
                return Getname();
            }
        }

        public static void Main(string[] args)
        {

            F1();
            F2();

        }
        public static void F1()
        {
            List<Student> objects = new List<Student>();
            Student A = new Student();
            A.id = Console.ReadLine();
            objects.Add(A);
            FileStream fs = new FileStream("marks.txt", FileMode.Create, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(List<Student>));
            xs.Serialize(fs, objects);
            fs.Close();
        }

        public static void F2()
        {
            FileStream fs = new FileStream("marks.txt", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(List<Student>));
            List<Student> objects = xs.Deserialize(fs) as List<Student>;
            for (int i = 0; i < objects.Count; i++)
            {
                Console.WriteLine(objects[i]);
            }
            Console.WriteLine(objects.ToString());
            fs.Close();
        }
    }
}
