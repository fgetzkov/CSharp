using System;
namespace _6.Quadratic_Equation
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double discriminant = 0;
            double x = 0;
            double y = 0;
            discriminant = (b * b) + (-4 * (a * c));
            double DiscrSqrt = 0;
            DiscrSqrt = Math.Sqrt(discriminant);
            if (discriminant < 0)
            {
                Console.WriteLine("nqma reshenie");
            }
            if (discriminant == 0)
            {
                x = (-b) / (2 * a);
                Console.WriteLine("Edin dvoen koren" +" "+x);
            }
            if (discriminant > 0)
            {
                x = (-b - DiscrSqrt) / (2 * a);
                y = (-b + DiscrSqrt) / (2 * a);
                Console.WriteLine("Koreni sa " + x + " " + y);
            }
        }
    }
}
