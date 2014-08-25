using System;
namespace _4.Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine(width*2+height*2);
            Console.WriteLine(width*height);
        }
    }
}
