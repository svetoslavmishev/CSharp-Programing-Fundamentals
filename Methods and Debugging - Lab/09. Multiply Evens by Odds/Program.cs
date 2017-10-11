using System;

namespace _09.Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetMultipleOfEvensAndOdds(n));
        }

        static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigits = n % 10;
                if (lastDigits % 2 == 0)
                {
                    sum += lastDigits;
                }
                n /= 10;
            }
            return sum;
        }

        static int GetSumOfOddDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigits = n % 10;
                if (lastDigits % 2 != 0)
                {
                    sum += lastDigits;
                }
                n /= 10;
            }
            return sum;
        }

        static int GetMultipleOfEvensAndOdds(int n)
        {
            return GetSumOfOddDigits(n) * GetSumOfEvenDigits(n);
        }
    }
}
