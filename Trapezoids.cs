﻿using System;
namespace _9.Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine(((a+b)/2)*h);

        }
    }
}
