using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    class Program
    {
        enum WeekDays
        {
            Monday = 0,
            Tuesday = 1,
            Wednesday = 2,
            Thursday = 3,
            Friday = 4,
            Saturday = 5,
            Sunday = 6
        }

        enum WeekDays2
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        enum WeekDays3
        {
            Monday = 10,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            Console.WriteLine(WeekDays.Friday);
            Console.WriteLine((int)WeekDays.Friday);

            Console.WriteLine(WeekDays2.Friday);
            Console.WriteLine((int)WeekDays2.Friday);

            Console.WriteLine((int)WeekDays3.Friday);


            Console.WriteLine(Enum.GetName(typeof(WeekDays), 4));

            Console.WriteLine("WeekDays constant names:");
            foreach (string str in Enum.GetNames(typeof(WeekDays)))
                Console.WriteLine(str);

            Console.WriteLine("Enum.TryParse():");
            WeekDays wdEnum;
            Enum.TryParse<WeekDays>("1", out wdEnum);
            Console.WriteLine(wdEnum);

            Console.Read();
        }
    }
}

/*
 Points to Remember :
The enum is a set of named constant.
The value of enum constants starts from 0. Enum can have value of any valid numeric type.
String enum is not supported in C#.
Use of enum makes code more readable and manageable.
 * http://www.tutorialsteacher.com/csharp/csharp-enum
 */
