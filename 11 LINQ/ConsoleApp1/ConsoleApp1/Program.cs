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
            string[] WMonthes = { "January", "February", "December" };
            string[] SumMonthes = { "June", "July", "August" };
            string[] monthes = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

             Console.WriteLine("Введите число букв в месяце: ");
             int n = Convert.ToInt32( Console.ReadLine());

           // var MonthesNL = monthes.Where(s => s.Length == n).Select(s => s);
            var MonthesNL2 = monthes.Join(WMonthes, w => w, a => a,(w,a)=>w);
            var MonthesNL3 = monthes.Join(SumMonthes, w => w, a => a, (w, a) => w);
            var MonthesNL5 = monthes.Where(s=>s.Contains('u')).Where(s=>s.Length>=4).Select(s=>s);
            var MonthesNL4 = monthes.OrderBy(s=>s).Select(s=>s);
            var MonthesNL = from s in monthes
                            where s.Length == n
                            select s;
            foreach (var m in MonthesNL)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine();

            foreach (var m in MonthesNL2)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine();

            foreach (var m in MonthesNL3)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine();

            foreach (var m in MonthesNL4)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine();

            foreach (var m in MonthesNL5)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine();
            
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////

            List<Circle> circles = new List<Circle>();

            Circle circle1 = new Circle(-11,13,2);
            circle1.GetInfo();
            Circle circle2 = new Circle(9, 14, 10);
            circle2.GetInfo();
            Circle circle3 = new Circle(12, -10, 13);
            circle3.GetInfo();
            Circle circle4 = new Circle(10, 5, 9);
            circle4.GetInfo();
            Circle circle5 = new Circle(10, -4, 3);
            circle5.GetInfo();
            Circle circle6 = new Circle(11, 11, 11);
            circle6.GetInfo();
            circles.Add(circle1);
            circles.Add(circle2);
            circles.Add(circle3);
            circles.Add(circle4);
            circles.Add(circle5);
            circles.Add(circle6);

            Console.WriteLine("Центры на одной прямой");
                var Tri1 = circles.Where(s => s.Xcen == 10).Select(s => s);

            foreach (var m in Tri1)
            {
                Console.WriteLine(m.Name);
            }
            Console.WriteLine();


            Console.WriteLine("Макс площадь");
            var Tri2 = circles.OrderBy(s => s.Radius).Last();
            Console.WriteLine(Tri2.Name);
            Console.WriteLine();


            Console.WriteLine("Мин площадь");
            var Tri3 = circles.OrderBy(s => s.Radius).First();
            Console.WriteLine(Tri3.Name);
            Console.WriteLine();


            Console.WriteLine("С радиусом 10");
            var Tri4 = circles.Where(s => s.Radius == 10).Select(s => s);
            foreach (var m in Tri4)
            {
                Console.WriteLine(m.Name);
            }
            Console.WriteLine();

            Console.WriteLine("1 Четверть");
            var Tri5 = circles.Where(s => s.Xcen > 0 && s.Ycen > 0).Select(s => s);
            foreach (var m in Tri5)
            {
                Console.WriteLine(m.Name);
            }
            Console.WriteLine();


            Console.WriteLine("Упорядоч по площади");
            var Tri6 = from s in circles
                       orderby s.Square()
                       select s;

            foreach (var m in Tri6)
            {
                Console.WriteLine(m.Name);
            }
            Console.WriteLine();


            Console.WriteLine("Собственный");
            var Cet = circles.OrderBy(s => s.Xcen).ThenBy(s => s.Ycen).Where(s => s.Xcen == 10).Where(s => s.Ycen > 0).Select(s => s);
            foreach (var m in Cet)
            {
                Console.WriteLine(m.Name);
            }
            Console.WriteLine();



            Console.WriteLine("5 Задание");
            List<Circle> circles2 = new List<Circle>();
            Circle cir1 = new Circle(2, 3, 4);
            cir1.GetInfo();
            Circle cir2 = new Circle(7, 11, 12);
            cir2.GetInfo();
            Circle cir3 = new Circle(9, 1, 11);
            cir3.GetInfo();
            circles2.Add(cir1);
            circles2.Add(cir2);
            circles2.Add(cir3);

            var result = from ab in circles
                         join ab2 in circles2 on ab.Name equals ab2.Name
                         select ab;
            foreach (var m in result)
            {
                Console.WriteLine(m.Name);
            }
            Console.WriteLine();



            Console.ReadKey();
        }
    }
}
