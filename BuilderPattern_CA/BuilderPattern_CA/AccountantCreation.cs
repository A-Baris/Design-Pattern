using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern_CA.Abstract;

namespace BuilderPattern_CA
{
    public class AccountantCreation : CreateEmployee
    {
        public AccountantCreation()
        {
            employee = new Employee();
        }
        public override void CreateEmployeeId()
        {
            employee.EmployeeId = 60;
        }

        public override void CreateName()
        {
            employee.Name = "Micheal";
        }
        public override void CreateSurName()
        {
            employee.Surname = "Rain";
        }

        public override void CreateRole()
        {
            employee.Role = "Accountant";
        }

       
    }
}
