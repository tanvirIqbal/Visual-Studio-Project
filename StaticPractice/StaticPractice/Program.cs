using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customer;
using Masters;
using Utility;

namespace StaticPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryMaster obj1 = new CountryMaster();
            obj1.Insert();
            CustomerClass obj2 = new CustomerClass();
            obj2.Insert();
            Console.WriteLine(CommonRoutine.count.ToString());

            Console.ReadLine();
        }
    }
}
