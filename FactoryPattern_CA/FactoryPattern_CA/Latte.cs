using FactoryPattern_CA.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_CA
{
    internal class Latte : Coffee
    {
        public override void Order()
        {
            Console.WriteLine("Latte: milk,milk cream and espresso");
        }
    }
}
