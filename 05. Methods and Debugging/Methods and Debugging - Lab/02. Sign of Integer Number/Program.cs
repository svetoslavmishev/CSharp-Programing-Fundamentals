using System;

namespace _02.Sign_of_Integer_Number
{
    class Program
    {
        private static object mas;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            IntegerNumber(n);
        }
           
        static void IntegerNumber(int n)
        {
            
            if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {n} is zero.");
            }
        }
    }
}
