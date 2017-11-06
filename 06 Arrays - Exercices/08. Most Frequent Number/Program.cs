using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int mostFrequent = 0;
            int leftIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int currentNumber = array[i];
                int count = 0;
                for (int j = i; j < array.Length; j++)
                {
                    if (currentNumber == array[j])
                    {
                        count++;
                    }
                }

                if (count > leftIndex)
                {
                    mostFrequent = currentNumber;
                    leftIndex = count;
                }
            }
            Console.WriteLine(mostFrequent);
        }
    }
}
