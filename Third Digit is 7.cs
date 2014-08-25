using System;
namespace _5.Third_Digit_is_7
{
    class Program
    {
        static void Main()
        {

            int num = int.Parse(Console.ReadLine());
            num = num / 100;
            bool isSeven = num % 10 == 7;
            Console.WriteLine(isSeven);
        }
    }
}
