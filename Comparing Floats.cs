using System;
using System.Text;
namespace _3.Comparing_Floats
{
    class comparingFloats
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("Add your first number");
            double a = (double.Parse(Console.ReadLine()));
            double b = (double.Parse(Console.ReadLine()));
            bool equalAB = Math.Abs(a - b) < 0.000001;
            Console.WriteLine("Are number {0} and {1} equal? {2}", a, b, equalAB);

        }
    }
}
