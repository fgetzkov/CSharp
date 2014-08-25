using System;
namespace Num_in_Interval_Dividable_by_Given_Num
{
    class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int p = 0;
            for (  int i = num1; i <= num2; i++)
            {
                if (i%5==0)
                {
                    Console.WriteLine(i);
                    p++;
                }
            }
            Console.WriteLine(p);

        }
    }
}
