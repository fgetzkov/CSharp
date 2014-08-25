using System;
namespace _9.Sum_of_n_Numbers
{
    class Program
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());
            int num = 0;
            int sum = 0;
            for (int i = 0; i < numbers; i++)
            {
                num = int.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
