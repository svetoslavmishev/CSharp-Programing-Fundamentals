using System;

namespace Task11_Odd_Number
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i = 1;

            do
            {
                int n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                }
                else
                {
                    Console.WriteLine($"The number is: {Math.Abs(n)}");
                    break;
                }
            } while (i <= 10);
        }
    }
}


 