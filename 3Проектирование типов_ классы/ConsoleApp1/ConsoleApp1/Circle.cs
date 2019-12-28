using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Circle
    {
        public string Name = Convert.ToString(Console.ReadLine());
        public double xcen = Convert.ToDouble(Console.ReadLine());

        public double Xcen
        {
            set
            {
                if (value < -50 || value > 50)
                {
                    Console.WriteLine("Координата Х задана неверно");

                }
                else
                {
                    xcen = value;
                }
            }
            get
            {
                return xcen;
            }
        }

        public double ycen = Convert.ToDouble(Console.ReadLine());

        public double Ycen
        {
            set
            {
                if (value < -50 || value > 50)
                {
                    Console.WriteLine("Координата Y должны быть в пределе от -49 до 49");
                }
                else
                {
                    ycen = value;
                }
            }
            get { return ycen; }
        }
        public double radius = Convert.ToDouble(Console.ReadLine());
        public double Radius
        {
            set
            {
                if (value < 0 || value > 11)
                {
                    Console.WriteLine("Радиус должен быть в пределе от 1 до 10");
                }
                else
                {
                    radius = value;
                }
            }
            get { return radius; }
        }

        public double Length()
        {
            double length = Math.PI * 2 * radius;
            return length;
        }
        public double Square()
        {
        double square = Math.PI * Math.Pow(radius, 2);
            return square;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Имя: {Name}  X: {xcen}  Y: {ycen}  Радиус: {radius}  Площадь: {Square()}  Длина: {Length()}");
        }
    }
}
