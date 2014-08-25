using System;
namespace _13.Check_a_Bit_at_Given_Position
{
    class Program
    {
        static void Main()
        {
            
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(num, 2).PadLeft(16, '0'));
            int index = int.Parse(Console.ReadLine());
            int bit = (num >> index) & 1;
            Console.WriteLine(bit == 1);
            
        }
    }
}
