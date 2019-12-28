using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface IWorker
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        void Print();

    }
}
