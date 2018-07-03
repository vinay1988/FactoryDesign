using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
   public class EmployeeFactory
    {
        public IEmployee GetEmployeeBonus(int employeeTypeId)
        {
            IEmployee employee = null;
            if (employeeTypeId == 1)
                employee = new PEmployee();
            else if (employeeTypeId == 2)
                employee = new CEmployee();

            return employee;
        }
    }
}
