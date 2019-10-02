using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace serializationarray
{
    public class serializationarray
    {
        public class University
        {
            public string Name { get; set; }
            [XmlArray("Staff")]
           // public int numberofstudents;
            public List<University> Universities { get; set; }

            public University()
            {
                Universities = new List<University>();
            }
        }

        public class University
        {
            public string Name { get; set; }

            public University() { }

            public University(string name)
            {
                this.name = name;
            }
        }
        static void Main(string[] args)
        {
            F1();
            Load();
        }

        public static void F1()
        {
            Department dept = new Department();
            dept.Name = "IT";
            dept.Employees.Add(new Employee("Bob"));
            dept.Employees.Add(new Employee("Jim"));
            dept.Employees.Add(new Employee("Mel"));

            //Type t = dept.GetType();
            string filename = "save.xml";
            using (FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.ReadWrite))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Department));
                xs.Serialize(fs, dept);
            }
          

    }
        public static Department Load()
        {
            Department res = null;
            //Type t = GetType();
            string filename =  "save.xml";

            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Department));
                res = xs.Deserialize(fs) as Department;
            }
            Console.WriteLine(res.Name);
            for (int i = 0; i < res.Employees.Count; i++)
            {
                Console.WriteLine(res.Employees[i]);
            }
            return res;
        }
    }
}
