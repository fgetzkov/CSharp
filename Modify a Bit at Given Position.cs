using System;
namespace _14.Modify_a_Bit_at_Given_Position
{
    class ModifyABitAtGivenPosition
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(num, 2).PadLeft(16, '0'));
            int p = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());
            if (v==1)
            {
            int mask = 1 << p;      
            int result = num | mask;      
            Console.WriteLine(result);  
            }
            else
            {
                int mask = ~(1 << p);     
                int result = num & mask;     
                Console.WriteLine(result); 

            }

            
            
        }
    }
}
