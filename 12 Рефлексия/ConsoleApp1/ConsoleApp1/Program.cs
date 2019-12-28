using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(6,11,12);
            Reflector refl = new Reflector();
            refl.ClassInfoInText("ConsoleApp1.Circle");
            refl.ClassMethods("ConsoleApp1.Circle");
            refl.InfoPol("ConsoleApp1.Circle");
            refl.ClassInter("ConsoleApp1.Circle");
            refl.ClassName("ConsoleApp1.Circle", "String");
            refl.ParamFile();

            Console.ReadKey();
        }
    }
}
