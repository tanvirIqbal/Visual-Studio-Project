using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParameterExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Tanvir Iqbal Dhaka 123456789";
            string firstName = "";
            string lastName = "";
            string address = "";
            int mobileNo = 0;
            ParseData(str, out firstName, out lastName, out address, out mobileNo);
            Console.WriteLine("First Name: "+ firstName);
            Console.WriteLine("Last Name: "+ lastName);
            Console.WriteLine("Address: "+ address);
            Console.WriteLine("Mobile Number: "+ mobileNo.ToString());

            Console.Read();

        }

        static void ParseData(string str, out string firstName, out string lastName, out string address, out int mobileNo )
        {
            string[] arrayData = new string[3];
            arrayData = str.Split(' ');
            firstName = arrayData[0];
            lastName = arrayData[1];
            address = arrayData[2];
            mobileNo = Convert.ToInt32(arrayData[3]);
        }
    }
}
