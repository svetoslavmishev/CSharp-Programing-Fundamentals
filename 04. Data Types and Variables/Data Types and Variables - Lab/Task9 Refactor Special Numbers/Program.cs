using System;

namespace Task9_Refactor_Special_Numbers
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int digits = i;
                int totalSum = 0;
                while (digits > 0)
                {
                    totalSum += digits % 10;
                    digits = digits / 10;
                }
                bool toe = (totalSum == 5) || (totalSum == 7) || (totalSum == 11);
                Console.WriteLine($"{i} -> {toe}");
            }
        }
    }
}
