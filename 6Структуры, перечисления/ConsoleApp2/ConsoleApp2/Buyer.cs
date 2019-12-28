using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    struct Buyer
    {
       
            public string name;
            public int buydate;

            public void DisplayInfo()
            {
                Console.WriteLine($"Name: {name}  Age: {buydate}");
            }
        
    }
}
