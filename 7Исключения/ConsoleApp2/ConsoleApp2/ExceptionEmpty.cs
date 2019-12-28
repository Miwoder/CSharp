using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ExceptionEmpty : Exception
    {
        public ExceptionEmpty(string msg) : base(msg)
        { }
    }
}
