using System;
class BiggerNumber
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine(getMax(x, y));
    }

    private static int getMax(int x, int y)
    {
        if (x>=y)
        {
            return x;
        }
        else
        {
            return y;
        }
    }
}
