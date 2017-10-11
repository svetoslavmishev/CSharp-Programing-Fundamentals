﻿using System;

namespace _05.Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = FahrenheitToCelsius(fahrenheit);
            Console.WriteLine("{0:F2}", celsius);
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            double result = (fahrenheit - 32) * 5 / 9;
            return result;
        }
    }
}
