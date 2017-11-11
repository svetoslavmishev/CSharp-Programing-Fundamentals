using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Reversed_Numbers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();
            var reversedArray = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                var element = input[i];
                var reversedElement = element.ToCharArray().Reverse().ToArray();
                reversedArray.Add(int.Parse(string.Join("", reversedElement)));
            }
            Console.WriteLine(reversedArray.Sum());
        }
    }
}
