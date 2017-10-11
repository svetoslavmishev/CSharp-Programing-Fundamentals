using System;
using System.Numerics;

namespace _14.Factorial_Trailing_Zeroes
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            BigInteger factorial = GetFactorial(num);
            Console.WriteLine(GetTrailingZeroes(factorial));
        }

        static BigInteger GetFactorial(int num)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        static int GetTrailingZeroes(BigInteger factorial)
        {
            int count = 0;
            while (factorial % 10 == 0)
            {
                count++;
                factorial /= 10;
            }
            return count;
        }
    }
}