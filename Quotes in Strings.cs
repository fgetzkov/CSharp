using System;
namespace _8.Quotes_in_Strings
{
    class Program
    {
        static void Main()
        {
            string text = "The \"use\" of quotations causes difficulties.";
            string text2= @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(text+'\n'+text2);
        }
    }
}
