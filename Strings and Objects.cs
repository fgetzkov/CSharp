using System;
namespace _7.Strings_and_Objects
{
    class Program
    {
        static void Main()
        {
            string var1 = "Hello";
            string var2 = "world";
            object var3 = var1+ " " + var2;
            string var4= (string) var3;
            Console.WriteLine(var4);
        }
    }
}
