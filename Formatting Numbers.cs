using System;
namespace _5.Formatting_Numbers
{
    class FormattingNumbers
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            Console.Write("|{0,-10:X}", a);
            Console.Write("|"+ Convert.ToString(a, 2).PadLeft(10, '0')+"|");
            Console.Write("{0,10:F2}|{1,-10:F3}", b, c +"          |");

        }
    }
}
