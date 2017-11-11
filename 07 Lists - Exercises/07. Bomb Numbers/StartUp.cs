using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Bomb_Numbers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var bombArgs = Console.ReadLine().Split(' ').Select(int.Parse).ToList();            

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombArgs[0])
                {
                    for (int j = 1; j <= bombArgs[1]; j++) // remove numbers from left of bombArgs[0]
                    {
                        if (i - j < 0)
                        {
                            break;
                        }
                        numbers[i - j] = 0;
                    }

                    for (int k = 0; k <= bombArgs[1]; k++) // remove numbers from right of bombArgs[0]
                    {
                        if (i + k >= numbers.Count)
                        {
                            break;
                        }
                        numbers[i + k] = 0;
                    }
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
