﻿namespace Task1_Passed
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var grade = double.Parse(Console.ReadLine());
            if (grade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
