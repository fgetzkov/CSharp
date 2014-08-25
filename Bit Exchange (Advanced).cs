using System;
namespace _16.Bit_Exchange__Advanced_
{
    class BitExchange
    {
        static void Main()
        {

            while (true)
            {

                Console.Write("Number: ");
                uint number = 0;
                bool isNumberValid = uint.TryParse(Console.ReadLine(), out number);
                if (!isNumberValid)
                {
                    number = 0;
                }
                Console.Write("p: ");
                int p = int.Parse(Console.ReadLine());
                Console.Write("q: ");
                int q = int.Parse(Console.ReadLine());
                Console.Write("k: ");
                int k = int.Parse(Console.ReadLine());
                k--;

                bool isOutOfRange = (p + k) > 31 || (q + k) > 31;
                bool isOverlapping = (p + q) <= k;

                for (int i = 0; i <= k; i++)
                {
                    
                    int tempP = p + i;
                    int tempQ = q + i;

                   
                    uint tempBit = number >> tempP;
                    tempBit = tempBit & 1;

                   
                    uint secondTempBit = number >> tempQ;
                    secondTempBit = secondTempBit & 1;

                   
                    if (tempBit == 0)
                    {
                        int mask = ~(1 << tempQ);
                        number = number & (uint)mask;
                    }
                    else if (tempBit == 1)
                    {
                        int mask = 1 << tempQ;
                        number = number | (uint)mask;

                    }

                    
                    if (secondTempBit == 0)
                    {
                        int mask = ~(1 << tempP);
                        number = number & (uint)mask;
                    }
                    else if (secondTempBit == 1)
                    {
                        int mask = 1 << tempP;
                        number = number | (uint)mask;

                    }

                }
                if (isOverlapping && !isOutOfRange)
                {
                    Console.Write("Result: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Overlapping!");
                    Console.ResetColor();
                }
                else if (isOutOfRange)
                {
                    Console.Write("Result: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Out of range!");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write("Result: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(number);
                    Console.ResetColor();
                }
                Console.WriteLine();

            }
        }
    }
}
