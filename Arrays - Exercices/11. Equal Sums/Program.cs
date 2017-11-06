using System;
using System.Linq;

namespace _11.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            bool isEqualSum = false;

            for (int i = 0; i < array.Length; i++)
            {
                int[] leftSide = array.Take(i).ToArray();
                int[] rightSide = array.Skip(i + 1).ToArray();

                if (leftSide.Sum() == rightSide.Sum())
                {
                    isEqualSum = true;
                    Console.WriteLine(i);
                    break;
                }
            }

            if (!isEqualSum)
            {
                Console.WriteLine("no");
            }
        }
    }
}
