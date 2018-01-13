using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Character_Multiplier
{
    public class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            var first = input[0];
            var second = input[1];
            int lengthMin = Math.Min(input[0].Length, input[1].Length);
            int lengthMax = Math.Max(input[0].Length, input[1].Length);
            int sum = 0;

            string longerString = first.Length > second.Length ? longerString = first : longerString = second;

            for (int i = 0; i < lengthMax; i++)
            {
                if (i < lengthMin)
                {
                    sum += first[i] * second[i];
                }
                else
                {
                    sum += longerString[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
