using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaActionFuncPredicateDelegate
{
    class Program
    {
        delegate double CalArea(int r);
        static CalArea calArea = CalculateArea;//1
        static void Main(string[] args)
        {
            double area1 = calArea.Invoke(20);//1

            // Anonymous Method
            CalArea ca = new CalArea(delegate (int r) //2
            {
                return 3.1416 * r * r;
            });
            double area2 = ca(20); //2

            //Lamda Expression
            CalArea cap = r=> 3.1416 * r * r; //3
            double area3 = cap(20); //3

            // Lamda Expression with Generic delegate
            // No need to declare delgate like above

            //Func<input,output>
            Func<double,double> ca3 = r => 3.1416 * r * r; //4
            double area4 = ca3(20); //4

            //Action<output>
            Action<string> hello = y => Console.WriteLine(y); //5
            hello("Hello World!"); //5

            //Extension of Func, Returns true or false
            Predicate<string> checkIfGrreaterThan5 = x => x.Length > 5; //6
            bool checkValue = checkIfGrreaterThan5("Tanvir Iqbal"); //6

            //Application of Predicate
            List<string> oStrings = new List<string>(); //6
            oStrings.Add("Tanvir Iqbal"); //6
            oStrings.Add("Iqbal"); //6
            string str = oStrings.Find(checkIfGrreaterThan5); //6
        }

        static double CalculateArea(int r) //1
        {
            return 3.1416 * r * r;
        }
    }

}
