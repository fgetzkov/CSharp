using System;
namespace _12.Extract_Bit_from_Integer
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(num, 2).PadLeft(16, '0'));
            int index = int.Parse(Console.ReadLine());
            int bit = (num >> index) & 1;
            Console.WriteLine(bit);
        }
    }
}
