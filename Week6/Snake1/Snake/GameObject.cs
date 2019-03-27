using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Snake
{
    public class GameObject
    {
        public List<Point> body = new List<Point>();
        protected char sign;

        public GameObject(char sign)
        {
            this.sign = sign;
        }

        public GameObject() { }
        public void Clear()
        {
            for (int i = 0; i < body.Count; i++)
            {
                Console.SetCursorPosition(body[i].X, body[i].Y);
                Console.Write(' ');
            }
        }
        public void Draw()
        {
            for (int i = 0; i < body.Count; ++i)
            {
                Console.SetCursorPosition(body[i].X, body[i].Y);
                Console.Write(sign);
            }
        }
        public void Save()
        {
            Type t = this.GetType();
            string filename = t.Name + ".xml";
            using (FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.ReadWrite))
            {
                XmlSerializer xs = new XmlSerializer(t);
                xs.Serialize(fs, this);
            }


        }
        public GameObject Load()
        {
            GameObject res = null;
            Type t = this.GetType();
            string filename = t.Name + ".xml";

            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                XmlSerializer xs = new XmlSerializer(t);
                res = xs.Deserialize(fs) as GameObject;
            }

            return res;
        }


        public bool CheckCollisionwithItself()
        {
            for (int i = 1; i < body.Count; i++)
            {
                if (body[0].X == body[i].X && body[0].Y == body[i].Y)
                {
                    return true;
                }
            }
            return false;
        }     
    }
}

