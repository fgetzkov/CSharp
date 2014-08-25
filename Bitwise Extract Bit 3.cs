using System;
namespace _11.Bitwise_Extract_Bit_3
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString (num,2).PadLeft(16,'0'));
            int n = 3;
            int bit = (num >> n)&1;
            Console.WriteLine(bit);
        }
    }
}
