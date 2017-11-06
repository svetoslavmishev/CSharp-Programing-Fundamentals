using System;
using System.Linq;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = Console.ReadLine().Split(' ').ToArray();
            var array2 = Console.ReadLine().Split(' ').ToArray();
            PrintLargesCommonEnd(array1, array2);
        } 

        static int CountEqualElements(string[] array1, string[] array2)
        {
            var count = 0;
            var minimum = Math.Min(array1.Length, array2.Length);
            for (int i = 0; i < minimum; i++)
            {
                if (array1[i] == array2[i])
                {
                    count++;
                }
            }
            return count;
        }

        static void PrintLargesCommonEnd(string[] array1, string[] array2)
        {
            var reversedArray1 = array1.Reverse().ToArray();
            var reversedArray2 = array2.Reverse().ToArray();
            var countArray = CountEqualElements(array1, array2);
            var countReversedArray = CountEqualElements(reversedArray1, reversedArray2);

            if (countArray > countReversedArray)
            {
                Console.WriteLine(countArray);
            }
            else
            {
                Console.WriteLine(countReversedArray);
            }
        }
    }
}
