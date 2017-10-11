using System;

namespace _12.Master_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                bool isPolindrom = PalindromeCheck(i);
                bool isDivisionBySeven = DivisionBySeven(i);
                bool isEvenDigit = EvenDigitCheck(i);

                if (isPolindrom && isDivisionBySeven && isEvenDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool EvenDigitCheck(int i)
        {
            while (i > 0)
            {
                int digit = i % 10;
                if (digit % 2 == 0)
                {
                    return true;
                }
                i /= 10;
            }
            return false;
        }

        static bool DivisionBySeven(int i)
        {
            int sum = 0;
            while (i > 0)
            {
                sum += i % 10;
                i /= 10;
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            return false;
        }

        static bool PalindromeCheck(int i)
        {
            string str = i.ToString();

            for (int j = 0; j < str.Length / 2; j++)
            {
                if (str[j] != str[str.Length - 1 - j])
                {
                    return false;
                }
            }
            return true;
        }
    }
}