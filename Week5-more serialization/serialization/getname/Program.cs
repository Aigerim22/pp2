using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace list
{
    public class Program
    {
        public class Orders
        {
            public List<int> nums; //лист типа инт который хранит числа
            public Orders(List<int> nums) //конструктор принимает этот лист с числами
            {
                this.nums = nums;
            }
            public Orders() { }  //создание пустого конструктора для сериализации
        }
        static void Main(string[] args)
        {
            List<int> nums = new List<int>(); //экземпляр листа

            int n = int.Parse(Console.ReadLine()); //вводим число 

            for (int i = 0; i < n; i++) //пробегаемся до этого числа
            {
                int a = Convert.ToInt32(Console.Read()); //вводим какое то число до n 
                nums.Add(a);  //и эти числа добавляем в лист
            }

            Orders order = new Orders(nums); //создаем экземпляр класса который принимает числа
            FileStream fs = new FileStream("order.xml", FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(Orders)); //сериализация этого класса
            xs.Serialize(fs, order);
            fs.Close();
        }
    }
}