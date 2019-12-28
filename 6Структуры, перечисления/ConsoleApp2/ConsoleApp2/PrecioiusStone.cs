using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class PrecioiusStone : IGoods
    {
        public string Shop { get; set; }
        public virtual void Print() { }
        //string Good { get; set; }
        public virtual string good { get; set; }

        public virtual int PRice { get; set; }

        string ImportCountry { get; set; }
        

        public override string ToString()
        {
            return "PreciousStone type";
        }
    }
}
