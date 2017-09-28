namespace Task12_Test_Numbers
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int firstDigit = int.Parse(Console.ReadLine());
            int secondDigit = int.Parse(Console.ReadLine());
            int maxBoundary = int.Parse(Console.ReadLine());
            int count = 0;
            int multiply = 0;
            int totalSum = 0;

            for (int i = firstDigit; i >= 1; i--)
            {
                for (int j = 1; j <= secondDigit; j++)
                {
                    if (totalSum >= maxBoundary)
                    {
                        break;
                    }
                    count++;
                    if (count == 1)
                    {
                        multiply = 3 * (i * j);
                    }
                    totalSum = totalSum + 3 * (i * j);
                }
            }

            if (totalSum >= maxBoundary)
            {
                Console.WriteLine($"{count} combinations" + Environment.NewLine + $"Sum: {totalSum} >= {maxBoundary}");
                return;
            }
            else
            {
                Console.WriteLine($"{count} combinations" + Environment.NewLine + $"Sum: {totalSum}");
            }
        }
    }
}
