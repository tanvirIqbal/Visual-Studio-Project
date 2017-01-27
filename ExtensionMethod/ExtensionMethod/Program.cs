using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class ExtensionMethods
    {
        public static string UppercaseFirstLetter(this string value)
        {
            // Uppercase the first letter in the string.
            if (value.Length > 0)
            {
                char[] array = value.ToCharArray();
                array[0] = char.ToUpper(array[0]);
                value = new String(array);
            }
            return value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string value = "hello world!";
           value = value.UppercaseFirstLetter();
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
