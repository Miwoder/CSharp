using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle();
            circle1.GetInfo();

            Circle circle2 = new Circle();
            circle2.GetInfo();

            Circle circle3 = new Circle();
            circle3.GetInfo();

            Circle[] cirArray = { circle1, circle2, circle3};

            double now = 9999;
            string name = "default";
            foreach (Circle a in cirArray)
            {
                if (a.Square() < now)
                {
                    now = a.Square();
                    name = a.Name;
                }
            }
            Console.WriteLine($"Наименьшая площадь: {name}");

            double now1 = 0;
            string name1 = "default";
            foreach (Circle a in cirArray)
            {
                if (a.Square() > now1)
                {
                    now1 = a.Square();
                    name1 = a.Name;
                }
            }
            Console.WriteLine($"Наибольшая площадь: {name1}");

            if (circle1.xcen == circle2.xcen)
            
                {
                    if (circle2.xcen == circle3.xcen)
                    {
                        Console.WriteLine("ЦЕнтры окружности 1,2 и 3 на одной прямой");
                    }
                    else
                    {
                        Console.WriteLine("Центры окружности 1 и 2 на одной прямой");
                    }
                }
            else if (circle3.xcen == circle1.xcen)
                {
                    Console.Write("Центры окружности 1 и 3 на одной прямой");
                }

                else if (circle1.ycen == circle2.ycen)
                {
                    if (circle2.ycen == circle3.ycen)
                    {
                        Console.WriteLine("Центры окружности 1,2,3 на одной прямой");
                    }
                    else
                    {
                        Console.WriteLine("Центры окружности 1,2 на одной прямой");
                    }
                }
                else if (circle1.ycen == circle3.ycen)
                {
                    Console.WriteLine("Центры окружности 1,3 на одной прямой");
                }
                else
                {
                    Console.Write("Ни одного центра окружности нет на одной прямой");
                }
            

            Console.ReadKey();
        }
    }
}
