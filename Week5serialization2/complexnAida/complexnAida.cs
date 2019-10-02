using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace complexnAida
{
    [Serializable]//serializable attribute 
    public class ComplexNumbers//class to serialize 
    {
        [XmlElement]
        public int x, y;

        public ComplexNumbers()
        {
        }

        public ComplexNumbers(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void PrintInfo()
        {
            Console.WriteLine(x + "+" + y + "i");
        }

        public void Save()
        {
            FileStream fs = new FileStream(@"C: \Users\Aida\Desktop\pp2\PP2\week5\task1.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);//The file stream object is used to open or create the file task1.xml for writing or reading purposes 
            XmlSerializer xs = new XmlSerializer(typeof(ComplexNumbers));//creating the filestream 
            xs.Serialize(fs, this);//serialization 
            fs.Close();
        }


        public static ComplexNumbers Load()
        {
            FileStream fs = new FileStream(@"C: \Users\Aida\Desktop\pp2\PP2\week5\task1.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(ComplexNumbers));//creating the file stream 
            ComplexNumbers num = xs.Deserialize(fs) as ComplexNumbers;//deseralize the object 
            fs.Close();
            return num;
        }
    }

    class complexnAida
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            ComplexNumbers n = new ComplexNumbers(x, y);

            n.Save();

            ComplexNumbers n2 = ComplexNumbers.Load();
            n2.PrintInfo();

            Console.ReadKey();
        }
    }
}