using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShadowing
{
    class Program
    {
        static void Main(string[] args)
        {
            Sales obj1 = new Sales();
            obj1.InvoiceNumber = 123;

            Sales2 obj2 = new Sales2();
            obj2.InvoiceNumber = "123";
        }
    }

    public class Sales
    {
        public int InvoiceNumber { get; set; }
    }

    public class Sales2 : Sales
    {
        public object InvoiceNumber { get; set; }
    }
}
