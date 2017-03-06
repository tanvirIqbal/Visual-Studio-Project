using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Hello World!! from sb1.");
            string str = sb1.ToString();
            Console.WriteLine(str);

            //or

            StringBuilder sb2 = new StringBuilder("Hello World!!", 50);
            StringBuilder sb3 = new StringBuilder(50);

            //or

            StringBuilder sb4 = new StringBuilder("Hello World!!", 50);

            Console.WriteLine(sb4);

            StringBuilder amountMsg = new StringBuilder("Your total amount is ");
            amountMsg.AppendFormat("{0:C} ", 25);
            Console.WriteLine(amountMsg);

            sb4.Insert(5, " C#");
            Console.WriteLine(sb4);

            sb4.Remove(6, 7);
            Console.WriteLine(sb4);

            sb2.Replace("World", "C#");
            Console.WriteLine(sb2);
            Console.ReadLine();
        }
    }
}

/*
Points to Remember :
StringBuilder is mutable.
StringBuilder performs faster than string when appending multiple string values.
Initialize StringBuilder as class e.g. StringBuilder sb = new StringBuilder()
Use StringBuilder when you need to append more than three or four strings.
Use Append() method to add or append strings with StringBuilder.
Use ToString() method to get the string from StringBuilder.
 string str = sb.ToString();
 * http://www.tutorialsteacher.com/csharp/csharp-stringbuilder
 */
