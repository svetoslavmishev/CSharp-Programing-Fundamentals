﻿using System;

namespace Task1_Centuries_to_Minutes
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Console.Write("Centuries = ");
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = 24 * days;
            int minutes = 60 * hours;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes",
                centuries, years, days, hours, minutes);
        }
    }
}
