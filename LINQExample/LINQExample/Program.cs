using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Average(); Returns double value
            int[] numbers = { 2, 4, 8, 9 };
            Console.WriteLine(numbers.Average());

            //Select();
            string[] petName = {"dog","cat","mouse"};
            var petNameUpperCase = petName.Select(x => x.ToUpper());
            foreach (string pName in petNameUpperCase)
            {
                Console.WriteLine(pName);
            }

            //Where();
            string[] petNameWithNull = { "dog", "cat", "mouse", null, null };
            var petNameWithoutNull = petNameWithNull.Where(x => x != null);
            foreach (string pName in petNameWithoutNull)
            {
                Console.WriteLine(pName);
            }

            //First(); Locates first matching object
            Animal anim = GetAnimal("Camel");
            Console.WriteLine(anim);

            //Aggregate();
            var sum = numbers.Aggregate((a, b) => (a + b));
            Console.WriteLine(sum);

            var mul = numbers.Aggregate((a, b) => (a * b));
            Console.WriteLine(mul);

            var chars = new[] { "a", "b", "c", "d" };
            var csv = chars.Aggregate((a, b) => a + ',' + b);
            Console.WriteLine(csv);

            Console.Read();
        }

        #region For First();
        class Animal
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public override string ToString()
            {
                return String.Format("Name = {0}, Age = {1}", Name, Age);
            }
        }

        static List<Animal> animals = new List<Animal>()
        {
            new Animal(){Name = "Camel", Age = 5},
            new Animal(){Name = "Dog", Age = 3},
            new Animal(){Name = "Cat", Age = 2}
        };


        static Animal GetAnimal(string n)
        {
            return animals.First(a => a.Name == n);
        } 
        #endregion
    }
}
