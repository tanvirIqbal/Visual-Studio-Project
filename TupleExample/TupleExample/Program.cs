using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Tanvir Iqbal Dhaka 123456789";
            var myInfo = ParseData(str);
            Console.WriteLine("First Name: "+myInfo.Item1);
            Console.WriteLine("Last Name: "+myInfo.Item2);
            Console.WriteLine("Address: "+myInfo.Item3);
            Console.WriteLine("Mobile: "+myInfo.Item4.ToString());

            Console.Read();
        }

        static Tuple<string,string,string,int> ParseData(string str)
        {
            string[] arrayData = new string[3];
            arrayData = str.Split(' ');
            return Tuple.Create<string, string, string, int>(arrayData[0], arrayData[1], arrayData[2], Convert.ToInt32(arrayData[3]));
        }
    }
}
