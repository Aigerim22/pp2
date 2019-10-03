using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task1
{

   public class Program
    {
        public class Student
        {
            public string name, id;

            public Student()
            {
            }

            public Student(string name, string id)
            {
                this.name = name;
                this.id = id;
            }

            public override string ToString()
            {
                return name + " " + id;
            }

            public static void F1()
            {
                string name = Console.ReadLine();
                string id = Console.ReadLine();

                Student s = new Student(name, id);
                FileStream fs = new FileStream("task1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                XmlSerializer xs = new XmlSerializer(typeof(Student));
                xs.Serialize(fs, s); 
                fs.Close();
            }

            public static void F2()
            {
                FileStream fs = new FileStream("task1.txt", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(Student));
                Student s = xs.Deserialize(fs) as Student;
                Console.WriteLine(s.ToString());
                fs.Close();
            }

           public static void Main(string[] args)
            {
               F1();
               F2();
            }
        }
    }
}
