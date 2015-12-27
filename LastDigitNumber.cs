using System;

class LastDigitNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(GetLastDigit(number));
    }

    private static int GetLastDigit(int number)
    {
        return number%10;
    }
}

