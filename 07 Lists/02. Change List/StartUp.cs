using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_List
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();            

            while (input != "Odd" && input != "Even") // 0 1 2 3 --> Delete 5 Insert 10 1 Delete 5 END
            {
                string[] commandArg = input.Split(' ').ToArray();

                switch (commandArg[0])
                {
                    case "Delete":
                        int number = int.Parse(commandArg[1]);
                        numbers.RemoveAll(i => i == number);
                        break;
                    case "Insert":
                        int element = int.Parse(commandArg[1]);
                        int index = int.Parse(commandArg[2]);
                        numbers.Insert(index, element);
                        break;
                }
                input = Console.ReadLine();                
            }
            
            if (input == "Odd")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 1)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
            }

            if (input == "Even")
            {
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (numbers[j] % 2 == 0)
                    {
                        Console.Write(numbers[j] + " ");
                    }
                }
            }
        }
    }
}
