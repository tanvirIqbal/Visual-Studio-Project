using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    public delegate void HelloFunctionDelegate(string msg);
    class Program
    {
        static void Main(string[] args)
        {
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("Hello, world!");

            List<Employee> employeeList = new List<Employee>();

            employeeList.Add(new Employee() { ID = 101, Name = "Tanvir", Salary = 30000, Experience = 3 });
            employeeList.Add(new Employee() { ID = 102, Name = "Iqbal", Salary = 40000, Experience = 4 });
            employeeList.Add(new Employee() { ID = 103, Name = "Fahim", Salary = 50000, Experience = 5 });
            employeeList.Add(new Employee() { ID = 104, Name = "Jamil", Salary = 60000, Experience = 6 });

            //With delegate function
            Console.WriteLine("With delegate function");
            IsPromotable isPromotable = new IsPromotable(Promote);
            Employee.PromotEmployee(employeeList, isPromotable);

            //With lambda expression, No delegate instance and promote() function needed
            Console.WriteLine("With lambda expression");
            Employee.PromotEmployee(employeeList, emp => emp.Experience >= 5);
            //Now we can change our logic and don't have to change the Employee class as this is our framework class
            Employee.PromotEmployee(employeeList, emp => emp.Salary >= 50000);

            Console.Read();
        }

        public static void Hello(string msg)
        {
            Console.WriteLine(msg);
        }

        public static bool Promote(Employee emp)
        {
            if (emp.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

/*
 * Create Delegate (created in Employee.cs)
 * Use that Delegate (Used in Employee.cs)
 * Create a method to point (created in Program.cs)
 * Create an instance of Delegate that point to the previous method (created in Program.cs)
 * Now use that instance. 
 */
