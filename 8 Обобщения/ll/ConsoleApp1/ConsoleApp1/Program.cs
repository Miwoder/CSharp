using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class Program
    {
        class Date
        {
            public string date = DateTime.Now.ToString();
        }

        static void Main(string[] args)
        {
            try
            {
                Program.Date Date = new Program.Date();
                Console.WriteLine("Дата создания: {0}", Date.date);

                string str = "Hello world";
                Console.WriteLine(str);
                Console.WriteLine(str.WordMinus(6));
                Vektor one = new Vektor(1, 2);
                Vektor two = new Vektor(3, 4);
                Vektor four = new Vektor(2, 2);
                Vektor three = one + two;
                Console.WriteLine(one > two);
                Console.WriteLine(one < two);
                Console.WriteLine(one == two);
                four.DeletePlus();
                Console.WriteLine("Значения x и y:{0} и {1} ", four.x, four.y);
                Console.WriteLine("Значения x и y:{0} и {1}", two.x, two.y);
                Console.WriteLine("Значение x и y:{0} и {1} ", three.x, three.y);
                Vektor vektor = new Vektor();
                vektor.user.GetInfo();
                ////////
                //////////
                ///////////

                List<Vektor> list4 = new List<Vektor>();
                Vektor vektor1 = new Vektor();
                vektor1.x = 11;
                vektor1.y = 18;
                list4.Add(vektor1);
                Console.ReadKey();




                Console.ReadKey();
            }
            finally { Console.WriteLine(""); }
        }
    }

    public static class StringExtension
    {
        public static string WordMinus(this string str, int c)
        {
            return str.Remove(0, c);

        }
        public static Vektor DeletePlus(this Vektor vektor)
        {
            if (vektor.x > 0)
            {
                vektor.x = 0;
            }
            if (vektor.y > 0)
            {
                vektor.y = 0;
            }
            return vektor;
        }
    }
    public class Vektor
    {

        public Ownew user = new Ownew(15, "Вадим", "БГТУ");

        public int x, y;
        public Vektor()
        {
            x = 0;
            y = 0;
        }
        public Vektor(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public static Vektor operator +(Vektor vektor, Vektor vektor1)
        {

            return new Vektor(vektor.x + vektor1.x, vektor.y + vektor1.y);
        }
        public static bool operator >(Vektor vektor, Vektor vektor1)
        {
            if (vektor.x * vektor.y > vektor1.x * vektor.y) return true;
            else return false;
        }
        public static bool operator <(Vektor vektor, Vektor vektor1)
        {
            if (vektor.x * vektor.y < vektor1.x * vektor.y) return true;
            else return false;
        }
        public static Vektor operator ==(Vektor vektor, Vektor vektor1)
        {
            vektor1.x = vektor.x;
            vektor1.y = vektor.y;
            return vektor1;
        }
        public static Vektor operator !=(Vektor vektor, Vektor vektor1)
        {
            vektor1.x = vektor.x;
            vektor1.y = vektor.y;
            return vektor1;

        }
        public static bool operator true(Vektor vektor)
        {
            if (vektor.x == 0 && vektor.y == 0) return true;
            else return false;
        }
        public static bool operator false(Vektor vektor)
        {
            if (vektor.x != 0 && vektor.y != 0) return true;
            else return false;
        }
        public class Ownew
        {
            int Id = 25676;
            string Name = "UUU";
            string UO = "GGGGG";

            public Ownew(int Id, string Name, string UO)
            {
                this.Id = Id;
                this.Name = Name;
                this.UO = UO;
            }
            public void GetInfo()
            {
                Console.WriteLine($"{Id},{Name},{UO}");
            }
            
        }

        

    }
}
