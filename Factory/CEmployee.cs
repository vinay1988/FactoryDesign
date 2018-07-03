using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class CEmployee : IEmployee
    {
        double IEmployee.GetBonus()
        {
            return 5;
        }
    }
}
