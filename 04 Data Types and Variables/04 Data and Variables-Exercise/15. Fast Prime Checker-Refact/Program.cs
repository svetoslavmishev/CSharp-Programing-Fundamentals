using System;

namespace _15.Fast_Prime_Checker_Refact
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int value = int.Parse(Console.ReadLine());
            for (int i = 2; i <= value; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isPrime}");
            }
        }
    }
}
