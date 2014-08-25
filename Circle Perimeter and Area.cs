using System;
namespace _3.Circle_Perimeter_and_Area
{
    class Program
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double p = 3.14*(r*2);
            double area = 3.14*(r*r);
            Console.WriteLine("{0:F2} {1:F2}", p, area);
        }
    }
}
