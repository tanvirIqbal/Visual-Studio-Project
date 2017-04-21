using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionHandlingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    int fn, sn, result;
                    Console.WriteLine("Enter 1st Number");
                    fn = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter 2nd Number");
                    sn = Convert.ToInt32(Console.ReadLine());
                    result = fn / sn;
                    Console.WriteLine(result);
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    string filePath = "Log1.txt";
                    if (File.Exists(filePath))
                    {
                        StreamWriter sw = new StreamWriter(filePath);
                        sw.WriteLine(ex.GetType().Name);
                        sw.WriteLine(ex.Message);
                        sw.WriteLine(ex.StackTrace);
                        sw.Close();
                        Console.WriteLine("There is a problem. Please try later.");
                        Console.ReadLine();
                    }
                    else
                    {
                        throw new FileNotFoundException(filePath + " is not found.", ex);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Current Exception: {0}",exception.GetType().Name);
                if (exception.InnerException != null)
                {
                    Console.WriteLine("Inner Exception: {0}", exception.InnerException.GetType().Name);
                }
                Console.ReadLine();
            }
        }
    }
}
