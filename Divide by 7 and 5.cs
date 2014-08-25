using System;
namespace _3.Divide_by_7_and_5
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            bool numIsNull = num != 0;
            bool sum = num % 35 == 0;
            Console.WriteLine(numIsNull && sum);
        }
    }
}
