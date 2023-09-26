using FactoryPattern_CA.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_CA
{
    internal class Americano : Coffee
    {
        public override void Order()
        {
            Console.WriteLine("Americano coffee: hot water and espresso");
        }
    }
}
