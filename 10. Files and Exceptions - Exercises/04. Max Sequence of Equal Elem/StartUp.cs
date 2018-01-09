using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _04.Max_Sequence_of_Equal_Elem
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<int> numbers = File.ReadAllText("../../input.txt")
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            int length = 1;
            int bestStart = 0;
            int bestLength = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i - 1] == numbers[i])
                {
                    length++;
                    if (length > bestLength)
                    {
                        bestLength = length;
                        bestStart = i - bestLength + 1;
                    }
                }
                else
                {
                    length = 1;
                }
            }

            for (int j = bestStart; j < bestLength + bestStart; j++)
            {
                var result = numbers[j].ToString();   
                File.AppendAllText("../../output.txt", result + " ");
            }
        }
    }
}
