using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace university
{
   public class Program
    {
        public class University
        {
            private string name;
            public string Name
            {
                get
                {
                    return this.name;
                }
                set
                {
                    this.name = value;
                }
            }
            private int numberofstudents;
            public int NumberofStudents
            {
                get
                {
                    return this.numberofstudents;
                }
                set
                {
                    this.numberofstudents = value;
                }
            }
            private string uniid;
            public string Uniid
            {
                get
                {
                    return uniid;
                }
                set
                {
                    this.uniid = value;
                }
            }
            public void AddStudent(int numberofstudents)
            {
                this.numberofstudents = this.numberofstudents ++;
            }
            public override string ToString()
            {
                return name + " " + " " + numberofstudents + " " + uniid;
            }
            public University()
            {

            }

        }
        static void Main(string[] args)
        {
            University e1 = new University();
            e1.Name = "KBTU";
            e1.Uniid = "1";
            Ser(e1);
            Des();

        }

        static void Ser(University e1)
        {
            List<University> objects = new List<University>();
            objects.Add(e1);
            e1.NumberofStudents = 500;
            e1.AddStudent(e1.NumberofStudents++);
            FileStream fs = new FileStream("students.txt", FileMode.Create, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(List<University>));
            xs.Serialize(fs, objects);
            fs.Close();
        }
        static void Des()
        {
            FileStream fs = new FileStream("students.txt", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(List<University>));
            List<University> objects = xs.Deserialize(fs) as List<University>;
            for (int i = 0; i < objects.Count; i++)
            {
                Console.WriteLine(objects[i]);
            }
            Console.WriteLine(objects.ToString());
            fs.Close();
        }
    }
}
