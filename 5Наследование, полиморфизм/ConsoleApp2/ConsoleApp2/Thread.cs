using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    sealed class Thread : IGoods
    {
        public string Shop { get; set; }
        public string good = "Thread";
        public string Good { get { return good; } set { good = value; } }
        public string ImportCountry { get; set; }
        public void Print()
        {
            Console.WriteLine("Your product is " + good + ". Import country: " + ImportCountry + ". Shop: " + Shop);
        }
        public override string ToString()
        {
            return "This is a thread";
        }
    }
}
