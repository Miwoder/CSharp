using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    sealed class Diamond : PrecioiusStone, IWorker
    {
        public string ImportCountry { get; set; }
        public string good = "Diamond";
        public string Good { get { return good; } set { good = value; } }
        
        public override void Print()
        {
            Console.WriteLine("Your product is " + good + ". Import country: " + ImportCountry + ". Shop: " + Shop);
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        void IWorker.Print()
        {
            Console.WriteLine("Worker name and surname: " + FirstName + " " + LastName);
        }


        public override string ToString()
        {
            return "This is a diamond";
        }


    }

}