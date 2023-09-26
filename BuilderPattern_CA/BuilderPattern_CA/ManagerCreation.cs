using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern_CA.Abstract;

namespace BuilderPattern_CA
{
    public class ManagerCreation : CreateEmployee
    {
        public ManagerCreation()
        {
            employee = new Employee();
        }
        public override void CreateEmployeeId()
        {
            employee.EmployeeId = 10;
        }

        public override void CreateName()
        {
            employee.Name = "James";
        }
        public override void CreateSurName()
        {
            employee.Surname = "Sky";
        }
        public override void CreateRole()
        {
            employee.Role = "Manager of Sales Departmant";
        }

       


    }
}
