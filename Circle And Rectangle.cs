using System;
namespace _10.Circle_And_Rectangle
{
    class Program
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double rez = 0;
            double x0 = 1;
            double y0 = 1;
            double r  = 1.5;

            if ((x >= -0.5) && (x <= 2.5) && (y >= 1) && (y <= 2.5))
            {
                if ((x - x0) * (x - x0) + (y - y0) * (y - y0) <= (r * r))
                {
                    Console.WriteLine("yes");
                    
                }
                else
                {
                    Console.WriteLine("no");
                    
                }
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
