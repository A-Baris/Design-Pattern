using FactoryPattern_CA.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_CA
{
    internal class BlackCoffee : Coffee
    {
        public override void Order()
        {
            Console.WriteLine("Black Coffee: brewing coffee with hot water");
        }
    }
}
