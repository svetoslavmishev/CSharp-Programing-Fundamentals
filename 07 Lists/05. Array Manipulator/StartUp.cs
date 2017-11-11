using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Array_Manipulator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var input = Console.ReadLine();

            while (input != "print")
            {
                string[] commandArgs = input.Split(' ').ToArray();

                if (commandArgs[0] == "add")
                {
                    numbers.Insert(int.Parse(commandArgs[1]), int.Parse(commandArgs[2]));
                }
                else if (commandArgs[0] == "contains")
                {
                    var element = int.Parse(commandArgs[1]);
                    Console.WriteLine(numbers.Contains(element) ? 0 : -1);
                }
                else if (commandArgs[0] == "remove")
                {
                    numbers.RemoveAt(int.Parse(commandArgs[1]));
                }
                else if (commandArgs[0] == "shift")
                {
                    var positions = int.Parse(commandArgs[1]);

                    for (int i = 0; i < positions; i++)
                    {
                        int lastElement = numbers[0];
                        for (int j = 0; j < numbers.Count - 1; j++)
                        {
                            numbers[j] = numbers[j + 1];
                        }
                        numbers[numbers.Count - 1] = lastElement;
                    }
                }
                else if (commandArgs[0] == "sumPairs")
                {
                    List<int> sumPairs = new List<int>();
                    for (int i = 0; i < numbers.Count - 1; i += 2)
                    {
                        sumPairs.Add(numbers[i] + numbers[i + 1]);
                    }
                    if (numbers.Count % 2 == 1)
                    {
                        sumPairs.Add(numbers[numbers.Count - 1]);
                    }
                    numbers = sumPairs;
                }
                else if (commandArgs[0] == "addMany")
                {
                    var index = int.Parse(commandArgs[1]);
                    List<int> manyElements = commandArgs.Skip(2).Select(int.Parse).ToList();
                    numbers.InsertRange(index, manyElements);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }
    }
}