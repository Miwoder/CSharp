using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Circle : Icnt
    {
        public string Name = Convert.ToString(Console.ReadLine());
        public int Xcen { get; set; }
        public int Ycen { get; set; }
        public int Radius { get; set; }
        public string SecCir { get; set; }
        public Circle(int xcen, int ycen, int radius)
        {
            Xcen = xcen;
            Ycen = ycen;
            Radius = radius;
        }

        public double Length()
        {
            double length = Math.PI * 2 * Radius;
            return length;
        }
        public double Square()
        {
            double square = Math.PI * Math.Pow(Radius, 2);
            return square;
        }
        
        public void GetInfo()
        {
            Console.WriteLine($"Имя: {Name}  X: {Xcen}  Y: {Ycen}  Радиус: {Radius}  Площадь: {Square()}  Длина: {Length()}");
        }
    }
}
