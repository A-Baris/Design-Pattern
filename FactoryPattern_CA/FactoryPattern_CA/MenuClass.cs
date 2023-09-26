using FactoryPattern_CA.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_CA
{
    internal class MenuClass
    {
        public Coffee CoffeeType(AllCoffees cof)
        {
            Coffee coffee = null;
            switch(cof)
            {
                case AllCoffees.Americano:
                    coffee = new Americano();
                    break;
                case AllCoffees.Latte:
                    coffee = new Latte();
                    break;
                case AllCoffees.BlackCoffee:
                    coffee = new BlackCoffee();
                    break;
            }
            return coffee;
        }
    }
}
