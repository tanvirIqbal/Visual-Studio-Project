using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethodExample
{
    class Program
    {
        delegate int PointToAdd(int num1, int num2);
        static void Main(string[] args)
        {
            Stopwatch objWatch = new Stopwatch();
            for (int y = 0; y < 10; y++)
            {
                objWatch.Reset();
                objWatch.Start();
                for (int i = 0; i < 1000; i++)
                {
                    /*With Named Method:*/
                    //PointToAdd oPointToAdd = Add;

                    /*With Anonymous Method*/
                    PointToAdd oPointToAdd = delegate (int num1, int num2)
                    {
                        return num1 + num2;
                    };
                    int num = oPointToAdd.Invoke(2, 2);
                    //Console.WriteLine(num); 
                }
                objWatch.Stop();
                Console.WriteLine(objWatch.ElapsedTicks.ToString());
            }
            Console.Read();
        }

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
