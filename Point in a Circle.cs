using System;
namespace _7.Point_in_a_Circle
{
    class Program
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double diagonal = 0;
            diagonal = x * x + y * y;
            diagonal = Math.Sqrt(diagonal);
            if (diagonal<=2)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

        }
    }
}
