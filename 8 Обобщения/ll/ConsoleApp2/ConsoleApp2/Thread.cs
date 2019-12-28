using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    sealed class Thread : PrecioiusStone, IGoods
    {
        public string Shop { get; set; }
        public override string good
        {
            get => base.good;
            set => base.good = value;
        }

        public override int PRice { get => base.PRice; set => base.PRice = value; }
        

        public string ImportCountry { get; set; }
        public void Print()
        {
            Console.WriteLine("Your product is " + good + ". Import country: " + ImportCountry + ". Shop: " + Shop);
        }
        public override string ToString()
        {
            return "Thread";
        }
    }
}
