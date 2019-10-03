using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace employee50k
{
    public class Program
    {
       public class Employee
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
            private string id;
            public string Id
            {
                get
                {
                    return this.id;
                }
                set
                {
                    this.id = value;
                }
            }
            private int salary;
            public int Salary
            {
                get
                {
                    return this.salary;
                }
                set
                {
                    this.salary = value;
                }
            }
            public void Increase(int salary)
            {
                this.salary = this.salary + 50000;
            }
            public override string ToString()
            {
                return name + " " + id + " " + salary;
            }
            public Employee()
            {

            }

        }
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.Name = "AAAA";
            e1.Id = "18BD110864";
            e1.Salary = 50000;
            e1.Increase(e1.Salary);
            Ser(e1);
            Des();

        }

        static void Ser(Employee e1)
        {
            FileStream fs = new FileStream("e.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            xs.Serialize(fs, e1);
            fs.Close();
        }
         static void Des()
         {
            FileStream fs = new FileStream("e.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            Employee e1des = xs.Deserialize(fs) as Employee;
            fs.Close();
            Console.WriteLine(e1des);
         } 
    }
}