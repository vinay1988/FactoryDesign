using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();

            obj.Name = "John";
            obj.EmployeeType = 1;

            EmployeeFactory ef = new EmployeeFactory();
            IEmployee e = ef.GetEmployeeBonus(obj.EmployeeType);

            //if(obj.EmployeeType==1)
            //{
            //    obj.Bonus = 5;
            //}
            //else if (obj.EmployeeType == 2)
            //{
            //    obj.Bonus = 10;
            //}
            obj.Bonus = e.GetBonus();

            Console.WriteLine("Employee {0} bonus {1}", obj.Name, obj.Bonus);
            Console.ReadKey();
        }
    }
}
