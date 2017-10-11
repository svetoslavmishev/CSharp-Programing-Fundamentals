using System;
using System.Collections.Generic;

namespace _07.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            CheckForPrimesInRange(firstNumber, secondNumber);
        }

        static void CheckForPrimesInRange(int firstNumber, int secondNumber)
        {
            List<int> primeNumbers = new List<int>();

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("(emprty list)");
            }

            if (firstNumber < 2)
            {
                firstNumber = 2;
            }
            
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeNumbers.Add(i);                    
                }
            }
            PrintPrimeNumbers(primeNumbers);            
        }

        private static void PrintPrimeNumbers(List<int> primeNumbers)
        {
            Console.WriteLine(String.Join(", ", primeNumbers));
        }
    }
}
