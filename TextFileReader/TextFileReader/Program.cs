using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileReader
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*************************** Read From text ******************************/
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("jamaica.txt"))
                {
                    string lineR;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    while ((lineR = sr.ReadLine()) != null)
                    {
                        //var values = lineR.Split(' ');  
                        Console.WriteLine(lineR);
                    }
                }

                /************************* Write to text ********************************/
                string[] names = new string[] { "Zara Ali", "Nuha Ali", "Noman Ali"};
                using (StreamWriter sw = new StreamWriter("names.txt"))
                {

                    foreach (string s in names)
                    {
                        sw.WriteLine(s);
                    }
                }

                // Read and show each line from the file.
                string lineW = "";
                using (StreamReader sr = new StreamReader("names.txt"))
                {
                    while ((lineW = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(lineW);
                    }
                }
            }
            catch (Exception e)
            {

                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
