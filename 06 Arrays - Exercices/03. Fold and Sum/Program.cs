using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var firstArray = new int[array.Length / 4];
            var secondArray = new int[array.Length / 4];
            var secondRowArray = new int[array.Length / 4 * 2];

            for (int i = 0; i < array.Length / 4; i++)
            {
                firstArray[i] = array[array.Length / 4 - 1 - i];
                secondArray[i] = array[array.Length - 1 - i];
            }

            for (int i = 0; i < array.Length / 4 * 2; i++)
            {
                secondRowArray[i] = array[array.Length / 4 + i];
            }

            var firstRowArray = firstArray.Concat(secondArray).ToArray();
            var sum = new int[firstRowArray.Length];

            for (int i = 0; i < firstRowArray.Length; i++)
            {
                sum[i] = firstRowArray[i] + secondRowArray[i];
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
