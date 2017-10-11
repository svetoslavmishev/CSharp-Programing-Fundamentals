using System;

namespace _06.Prime_Checker
{
    class Program
    {
        public static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            IsPrimeNumber(n);
        }

        static void IsPrimeNumber(long n)
        {
            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (n < 2)
            {
                Console.WriteLine(false);
            }
            else if (isPrime)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
