using BuilderPattern_CA;
using BuilderPattern_CA.Abstract;

CreateEmployee manager = new ManagerCreation();
AccessTheSystem access = new AccessTheSystem();
access.Access(manager);
Console.WriteLine(manager.Employee.ToString());


CreateEmployee salesPerson = new SalesPersonCreation();
access.Access(salesPerson);
Console.WriteLine(salesPerson.Employee.ToString());


CreateEmployee accountant = new AccountantCreation();
access.Access(accountant);
Console.WriteLine(accountant.Employee.ToString());

Console.Read();