using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);
            arrayList.Add(50);
            arrayList.Add(90);
            arrayList.Add(80);
            arrayList.Add(20);
            arrayList.Add(100);
            arrayList.Add(30);
            arrayList.Add(40);
            arrayList.Add(60);

            Console.WriteLine("Items in the arraylist:");
            p.Print(arrayList);
            
            Console.WriteLine("Capacity: "+arrayList.Capacity);

            Console.WriteLine("Count: "+arrayList.Count);

            Console.WriteLine("Add 70 after 60");
            arrayList.Insert(6, 70);
            p.Print(arrayList);

            Console.WriteLine("Sorted: ");
            arrayList.Sort();
            p.Print(arrayList);
            
            Console.WriteLine("Reversed");
            arrayList.Reverse();
            p.Print(arrayList);
            
            Console.Read();
        }

        private void Print(ArrayList arrayList)
        {
            foreach (int i in arrayList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
