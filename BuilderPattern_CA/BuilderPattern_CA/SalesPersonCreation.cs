using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern_CA.Abstract;

namespace BuilderPattern_CA
{
    public class SalesPersonCreation : CreateEmployee
    {
        public SalesPersonCreation()
        {
            employee = new Employee();
        }
        public override void CreateEmployeeId()
        {
            employee.EmployeeId = 30;
        }

        public override void CreateName()
        {
            employee.Name = "Marry";
        }
        public override void CreateSurName()
        {
            employee.Surname = "Rose";
        }
        public override void CreateRole()
        {
            employee.Role = "Sales Representative";
        }

      
    }
}
