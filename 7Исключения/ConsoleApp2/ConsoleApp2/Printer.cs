using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Printer
    {
        static public void iAmPrinting(IGoods objects)
        {
            Console.WriteLine(objects.ToString());
        }
    }
}
