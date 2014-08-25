using System;
namespace _8.Numbers_from_1_to_n
{
    class Program
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numbers; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
