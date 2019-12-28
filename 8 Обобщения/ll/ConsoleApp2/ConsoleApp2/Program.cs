using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Diamond diamond1 = new Diamond();
                diamond1.ImportCountry = "Canada";
                diamond1.Shop = "Perfect Brilliant";
                diamond1.FirstName = "Duke";
                diamond1.LastName = "Harmont";
                diamond1.good = "Diamond";
                diamond1.PRice = 1000;
                diamond1.Print();
                ((IWorker)diamond1).Print();

                Emerald emerald1 = new Emerald();
                emerald1.ImportCountry = "Greenland";
                emerald1.Shop = "100%Emeralds";
                emerald1.good = "Emerald";
                emerald1.PRice = 500;
                emerald1.Print1();
                emerald1.Print();

                Flint flint1 = new Flint();
                flint1.ImportCountry = "Belarus";
                flint1.good = "Flint";
                flint1.PRice = 300;
                flint1.Shop = "All for travelling";
                flint1.Print();

                Ruby ruby1 = new Ruby();
                ruby1.ImportCountry = "Kenya";
                ruby1.good = "Ruby";
                ruby1.PRice = 800;
                ruby1.Shop = "Smart Stones";
                ruby1.Print();

                Thread thread1 = new Thread();
                thread1.ImportCountry = "Belarus";
                thread1.good = "Thread";
                thread1.PRice = 50;
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

                Console.WriteLine();

                Weight op;
                op = Weight.Diamond;
                Console.WriteLine(op);

                Console.WriteLine();

                string k = diamond1.good;

                Console.WriteLine("The Necklace consists of: ");
                Necklace necklake = new Necklace();
                necklake.Add(flint1);
                necklake.Add(diamond1);
                necklake.Add(thread1);
                necklake.Add(ruby1);
                necklake.Add(emerald1);
                //исключение 1
                //necklake.Add(emerald1);

                //3 исключение
                //necklake.Del(flint1);
                //necklake.Del(diamond1);
                //necklake.Del(thread1);
                //necklake.Del(ruby1);
                //necklake.Del(emerald1);
                necklake.show();

                // 2 исключение
                //Necklace necklake2 = new Necklace();
                //necklake2.Del(flint1);

                

                int abc = 23456;
                Debug.Assert(abc == 1, " Условие не выполнено ");


                controller control = new controller();
                control.Weight(necklake);

                controller sort = new controller();
                sort.Sort(necklake);
                necklake.show();
            }
            catch (ExceptionFull ex) { Console.WriteLine(ex.Message); Console.WriteLine(ex.StackTrace); }
            catch (ExceptionEmpty ex) { Console.WriteLine(ex.Message); Console.WriteLine(ex.StackTrace); }
            catch (Exception ex) { Console.WriteLine(ex.Message); Console.WriteLine(ex.StackTrace); }
            Console.ReadKey();
        }
    }
}
