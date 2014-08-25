using System;
namespace _15.Age_after_10_Years
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Add your age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age after 10 years is " + (age+10));
        }
    }
}
