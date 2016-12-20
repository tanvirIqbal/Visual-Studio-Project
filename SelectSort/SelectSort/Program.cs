using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int minKey, temp;
            int[] array = { 100, 50, 20, 40, 10, 60, 80, 70, 90, 30 };
            Console.Write("Unsorted Array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }
            for (int j = 0; j < array.Length - 1; j++)
            {
                minKey = j;
                for (int k = j + 1; k < array.Length; k++)
                {
                    if (array[k] < array[minKey])
                    {
                        minKey = k;
                    }
                }

                temp = array[minKey];
                array[minKey] = array[j];
                array[j] = temp;
            }

            Console.Write("\nSelection Sorted Array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
