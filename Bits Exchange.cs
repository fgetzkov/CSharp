using System;
namespace ExchangeThreeBitsInANumber
{
    class Program
    {
        static void Main()
        {

            uint num = uint.Parse(Console.ReadLine());


            uint mask1 = 7 << 3;
            uint mask2 = 7 << 24;


            uint bits345 = num & mask1;
            uint bits2456 = num & mask2;


            bits345 <<= 21;
            bits2456 >>= 21;


            num = ~mask1 & num;
            num = ~mask2 & num;


            num |= bits345;
            num |= bits2456;

            Console.WriteLine(num);
        }
    }
}
