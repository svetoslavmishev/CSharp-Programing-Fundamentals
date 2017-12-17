using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    class StartUp
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] first = input.Take(input.Length / 4).Reverse().ToArray();
            int[] second = input.Reverse().Take(input.Length / 4).ToArray();
            int[] firstRow = first.Concat(second).ToArray();
            int[] secondRow = input.Skip(input.Length / 4).Take(input.Length / 2).ToArray();

            var total = firstRow.Select((x, index) => x + secondRow[index]);

            Console.WriteLine(string.Join(" ", total));
        }
    }
}
