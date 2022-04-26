using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hypotenuse_calculator
{
    class Calc
    {
        static double FirstCalc(double a, double b)
        {
            Console.WriteLine("Please, input your first value");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please, input your second value");
            b = Convert.ToDouble(Console.ReadLine());

            a = Math.Pow(a, 2);
            b = Math.Pow(b, 2);
            double c = Math.Sqrt(a + b);

            return c;
        }
    }
}
