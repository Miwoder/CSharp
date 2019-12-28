using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ExceptionFull : Exception
    {
        public ExceptionFull(string msg) : base(msg)
        { }
    }
}
