using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern_CA.Abstract;

namespace BuilderPattern_CA
{
    public class AccessTheSystem
    {
        public void Access(CreateEmployee employee)
        {
            employee.CreateEmployeeId();
            employee.CreateName();
            employee.CreateSurName();
            employee.CreateRole();
        }
    }
}
