using System;
namespace _4.Number_Comparer
{
    class Program
    {
        static void Main()
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());            
            Console.WriteLine(Math.Max(a,b));

        }
    }
}
