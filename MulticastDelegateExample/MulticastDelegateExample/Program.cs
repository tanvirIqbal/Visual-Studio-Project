using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegateExample
{
    public delegate void SampleDelegate();
    public delegate int SampleDelegate2();
    class Program
    {
        static void Main(string[] args)
        {
            //Approach 1
            SampleDelegate del1, del2, del3, del4;
            del1 = new SampleDelegate(SampleMethod1);
            del2 = new SampleDelegate(SampleMethod2);
            del3 = new SampleDelegate(SampleMethod3);

            del4 = del1 + del2 + del3 - del2;
            del4(); // Multicast delegate

            //Approach 2
            SampleDelegate del = new SampleDelegate(SampleMethod1); //Register
            del += SampleMethod2; // Register
            del += SampleMethod3; // Register
            del -= SampleMethod2; // De register

            del(); // Multicast delegate


            SampleDelegate2 delInt = new SampleDelegate2(SampleMethod4);
            delInt += SampleMethod5;

            Console.WriteLine(delInt()); // Last invoked method's value will be shown

            Console.Read();
        }

        public static void SampleMethod1()
        {
            Console.WriteLine("One");
        }
        public static void SampleMethod2()
        {
            Console.WriteLine("Two");
        }
        public static void SampleMethod3()
        {
            Console.WriteLine("Three\n");
        }

        public static int SampleMethod4()
        {
            return 100;
        }
        public static int SampleMethod5()
        {
            return 200;
        }
    }
}

/*
 * Multicast Delegate: Points to more than one method
 * Two approaches 
 */