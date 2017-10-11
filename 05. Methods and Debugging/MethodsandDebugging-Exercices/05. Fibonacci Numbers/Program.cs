using System;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFibonacciNumber(num));
        }

        static int GetFibonacciNumber(int num)
        {
            int leftNumber = 1;
            int rightNumber = 1;

            for (int i = 1; i < num; i++)
            {
                int oldRightNumber = rightNumber;
                rightNumber = leftNumber + rightNumber;
                leftNumber = oldRightNumber;
            }
            return rightNumber;
        }
    }
}
