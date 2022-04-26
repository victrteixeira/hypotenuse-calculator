using System;
using hypotenuse_calculator;

namespace hypotenuse
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator();

            Console.ReadLine();
        }

        static double Calculator()
        {
            Console.WriteLine("Please, input your first value");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please, input your second value");
            double b = Convert.ToDouble(Console.ReadLine());

            a = Math.Pow(a, 2);
            b = Math.Pow(b, 2);
            double c = Math.Sqrt(a + b);

            Console.WriteLine($"\nO valor da hipotenusa é: {Math.Round(c, 5)}.");
            return c;
        }
    }
}