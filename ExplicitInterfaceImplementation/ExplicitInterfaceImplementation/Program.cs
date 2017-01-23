using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaceImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            I1 iObj1 = new A();
            iObj1.Method1();

            I2 iObj2 = new A();
            iObj2.Method1();

            Console.ReadLine();
        }
    }
    interface I1
    {
        void Method1();
    }
    interface I2
    {
        void Method1();
    }
    class A : I1, I2
    {
        void I1.Method1()
        {
            Console.WriteLine("I1");
        }
        void I2.Method1()
        {
            Console.WriteLine("I2");
        }
    }
}
