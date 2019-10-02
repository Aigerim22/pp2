using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Complex_Class
{
    public class Complex
    {
        public string name;
        public string id;
        public double gpa;
      
        public Complex()
        {

        }
        public string getname(string name)
        {
            return this.name;

        }
        public string getid(string id)
        {
            return this.id;

        }
        public double getgpa(double gpa)
        {
            return this.gpa;

        }
        public override string ToString()
        {
            return getname(name) + " +" + getid(id) + " " + getgpa(gpa);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            F2();
        }

        private static void F1()
        {
            string name = Console.ReadLine();
            string id = Console.ReadLine();
            int gpa = int.Parse(Console.ReadLine());
            Complex ab = new Complex();
            //ab.getname(name);
            //ab.getid(id);
            //ab.getgpa(gpa);


            FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(Complex));
            xs.Serialize(fs, ab.getname(name));
            xs.Serialize(fs, ab.getid(id));
            xs.Serialize(fs, ab.getgpa(gpa));

            fs.Close();
        }

        private static void F2()
        {
            FileStream fs = new FileStream("input.txt", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(Complex));
            Complex ab = xs.Deserialize(fs) as Complex;
           
            Console.WriteLine(ab.ToString());
            fs.Close();
        }
    }
}
