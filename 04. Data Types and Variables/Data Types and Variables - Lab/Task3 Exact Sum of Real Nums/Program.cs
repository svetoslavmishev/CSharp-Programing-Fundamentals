using System;

namespace Task3_Exact_Sum_of_Real_Nums
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int digits = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < digits; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
