using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialization
            List<string> list1 = new List<string>()
            {
                "Tanvir", "Tafhim", "Tahsin"
            };

            //Initialization with array
            string[] name = { "Tanvir", "Tafhim", "Tahsin" };
            List<string> list2 = new List<string>(name);

            //Initialization with Add();
            List<string> list3 = new List<string>();
            list3.Add("Tanvir");
            list3.Add("Tafhim");
            list3.Add("Tahsin");

            //Initialization with Object
            List<Name> list4 = new List<Name>() 
            {
                new Name(){A="Tanvir"},
                new Name(){A="Tafhim"},
                new Name(){A="Tahsin"}
            };

            //Initialization with AddRange();
            List<string> list5 = new List<string>();
            list5.AddRange(name);

            //
            Console.WriteLine(list1.Count);
            Console.WriteLine(list2.Count);
            Console.WriteLine(list3.Count);
            Console.WriteLine(list4.Count);
            Console.WriteLine(list5.Count);

            //Display Element with foreach loop
            foreach (string fname in list1)
            {
                Console.Write(fname+" ");
            }
            Console.WriteLine();

            //Display Element with for loop
            for (int i = 0; i < list1.Count; i++)
            {
                Console.Write(list1[i]+" ");
            }
            Console.WriteLine();

            //Clear all element from list
            list5.Clear();
            Console.WriteLine(list5.Count);

            //Contains(); Returns true or false
            Console.WriteLine(list1.Contains("Tanvir")); // True
            Console.WriteLine(list1.Contains("Jamil")); // False

            //Exists(); Returns true or false
            Console.WriteLine(list1.Exists(item => item == "Tanvir")); // True
            Console.WriteLine(list1.Exists(item => item == "Noman"));// False

           //Find(); Return 1st found element or null
            Console.WriteLine(list1.Find(item => item == "Tanvir")); // Tanvir
            var k = list1.Find(item => item == "Fahim"); // Null
            
            Console.Read();

        }
    }

    class Name
    {
        public string A { get; set; }
    }
}
