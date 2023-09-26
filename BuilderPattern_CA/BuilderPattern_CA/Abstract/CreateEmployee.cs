using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_CA.Abstract
{
    public abstract class CreateEmployee
    {
        protected Employee employee;
        public Employee Employee
        {
            get { return employee; }
        }
        public abstract void CreateEmployeeId();
        public abstract void CreateName();
        public abstract void CreateSurName();
        public abstract void CreateRole();


    }
}
