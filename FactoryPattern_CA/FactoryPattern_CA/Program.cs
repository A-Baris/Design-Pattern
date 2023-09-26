using FactoryPattern_CA;

MenuClass menu = new MenuClass();
var coffee1 = menu.CoffeeType(AllCoffees.Americano);
var coffee2 = menu.CoffeeType(AllCoffees.Latte);
var coffee3 = menu.CoffeeType(AllCoffees.BlackCoffee);

coffee1.Order();
coffee2.Order();
coffee3.Order();

Console.Read();