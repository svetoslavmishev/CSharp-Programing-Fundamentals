using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Max_Sequence_of_Equal_Elements
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int length = 1;
            int bestStart = 0;
            int bestLength = 1; // ако на входа е подаден 1 елемент трябва най-дългата поредица да е 1 а не 0, затова инициализираме bestLength = 1

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
                Console.Write("{0} ", result);
            }
        }
    }
}
 
