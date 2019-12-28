using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    sealed partial class Emerald : PrecioiusStone
    {
        public string ImportCountry { get; set; }

        public override string good
        {
            get => base.good;
            set => base.good = value;
        }


        public override int PRice { get => base.PRice; set => base.PRice = value; }
   

        public new void Print()
        {
            Console.WriteLine("Import country: " + ImportCountry + ". Shop: " + Shop);
        }
        public override string ToString()
        {
            return "Emerald";
        }
    }

}