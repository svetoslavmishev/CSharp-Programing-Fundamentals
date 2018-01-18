using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Command_Interpreter
{
    class Program
    {
        static void Main()
        {
            List<string> items = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                var commandLine = Console.ReadLine();
                if (commandLine == "end")
                {
                    break;
                }
                ProcessItems(items, commandLine);
            }
        }

        static void ProcessItems(List<string> items, string commandLine)
        {
            var commandTokens = commandLine.Split();
            var commandName = commandTokens[0];

            switch (commandName)
            {
                case "reverse":
                    ReverseList(items, commandTokens);
                    break;
                case "sort":
                    SortList(items, commandTokens);
                    break;
                case "rowleft":
                    RowLeftList(items, commandTokens);
                    break;
                case "rowright":
                    RowRightList(items, commandTokens);
                    break;
                default:
                    Console.WriteLine("Invalid command!");
                    break;
            }
        }

        static void RowRightList(List<string> items, string[] commandTokens)
        {

        }

        static void RowLeftList(List<string> items, string[] commandTokens)
        {

        }

        static void SortList(List<string> items, string[] commandTokens)
        {

        }

        static void ReverseList(List<string> items, string[] commandTokens)
        {
            var startIndex = int.Parse(commandTokens[2]);
            var count = int.Parse(commandTokens[4]);
            if (IsValid(startIndex, count))
            {
                ReverseList(items, startIndex, count);
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");
            }
        }

        private static bool IsValid(List<string> items, int startIndex, int count)
        {
            if (startIndex < 0 || count < 0 || startIndex + count -1 < 0)
            {
                return false;
            }
            return true;

            //if (count < 0)
            //{
            //    return false;
            //}
            //if (startIndex + count <= 0)
            //{
            //    return false;
            //}
        }
    }
}