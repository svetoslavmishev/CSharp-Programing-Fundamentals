using System;

namespace _04.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            Console.WriteLine(GetReversedOrder(num));
        }

        static string GetReversedOrder(string num)
        {
            string result = "";

            for (int i = num.Length - 1; i >= 0; i--)
            {
                result += num[i];
            }
            return result;
        }
    }
}

