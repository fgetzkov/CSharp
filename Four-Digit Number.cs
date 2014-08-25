using System;
namespace _6.Four_Digit_Number
{
    class Program
    {
        static void Main()
        {
            int abcd = int.Parse(Console.ReadLine());
            int a = abcd / 1000;
            int b = (abcd / 100) % 10;
            int c = (abcd % 100) / 10;
            int d = abcd % 10;
            int sum = a + c + b + d;
            Console.WriteLine(sum);
            Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
        }
    }
}
