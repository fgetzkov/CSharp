using System;
namespace _10.Exchange_Variable_Values
{
    class Program
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            int c = 0;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("{0}\n{1}",a,b);
        }
    }
}
