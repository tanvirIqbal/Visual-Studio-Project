using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    delegate bool IsPromotable(Employee emp);
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromotEmployee(List<Employee> empList, IsPromotable IsEligibleToPromot)
        {
            foreach (Employee emp in empList)
            {
                if (IsEligibleToPromot(emp))
                {
                    Console.WriteLine(emp.Name +" is promoted");
                }
            }
        }
    }
}
