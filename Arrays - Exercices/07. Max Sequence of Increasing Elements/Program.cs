using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int count = 1;
            int biggestCount = 0;
            int endIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if (count > biggestCount)
                {
                    biggestCount = count;
                    endIndex = i - biggestCount + 1;
                }
            }

            for (int j = endIndex; j < endIndex + biggestCount; j++)
            {
                Console.Write(numbers[j] + " ");
            }
        }
    }
}
