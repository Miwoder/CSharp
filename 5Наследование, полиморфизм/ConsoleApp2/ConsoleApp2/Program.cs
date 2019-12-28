using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Diamond diamond1 = new Diamond();
            diamond1.ImportCountry = "Canada";
            diamond1.Shop = "Perfect Brilliant";
            diamond1.FirstName = "Duke";
            diamond1.LastName = "Harmont";
            diamond1.Print();
            ((IWorker)diamond1).Print();

            Emerald emerald1 = new Emerald();
            emerald1.ImportCountry = "Greenland";
            emerald1.Shop = "100%Emeralds";
            emerald1.Print();

            Flint flint1 = new Flint();
            flint1.ImportCountry = "Belarus";
            flint1.Shop = "All for travelling";
            flint1.Print();

            Ruby ruby1 = new Ruby();
            ruby1.ImportCountry = "Kenya";
            ruby1.Shop = "Smart Stones";
            ruby1.Print();

            Thread thread1 = new Thread();
            thread1.ImportCountry = "Belarus";
            thread1.Shop = "House of country";
            thread1.Print();

            bool a = diamond1 is PrecioiusStone;
            Console.WriteLine(a);

            Ruby Ruby2 = ruby1 as Ruby;
            Console.WriteLine(Ruby2);


            IGoods[] objects = new IGoods[3];
            objects[0] = new Diamond();
            objects[1] = new Ruby();
            objects[2] = new Emerald();
            foreach (IGoods obj in objects)
            {
                Printer.iAmPrinting(obj);
            }


            Console.ReadKey();
        }
    }
}
