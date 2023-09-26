using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_CA
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Role { get; set; }
      
        public override string ToString()
        {
            return $" Access to the system was achieved by [{EmployeeId}] {Name} {Surname} {Role} ";
        }

    }
}
