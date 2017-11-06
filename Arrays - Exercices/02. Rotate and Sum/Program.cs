using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberOfRotations = int.Parse(Console.ReadLine());
            var sum = new int[array.Length];

            for (int i = 0; i < numberOfRotations; i++)
            {
                RotatedArray(array);

                for (int j = 0; j < sum.Length; j++)
                {
                    sum[j] = sum[j] + array[j];
                }
            }
            Console.WriteLine(string.Join(" ", sum));
        }

        private static void RotatedArray(int[] array)
        {
            int lastIndex = array[array.Length - 1];

            for (int i = array.Length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = lastIndex;
        }
    }
}
