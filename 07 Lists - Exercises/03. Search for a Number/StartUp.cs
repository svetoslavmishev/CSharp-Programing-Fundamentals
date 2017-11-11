using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Search_for_a_Number
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<int> firstRowNnumbers = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            List<int> secondRowNnumbers = Console.ReadLine()
             .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToList();

            List<int> searchList = new List<int>();
            bool isEqual = false;

            for (int i = 0; i < secondRowNnumbers[0]; i++)
            {
                searchList.Add(firstRowNnumbers[i]);
            }

            searchList.RemoveRange(0, secondRowNnumbers[1]);

            for (int j = 0; j < searchList.Count; j++)  // може с метода Contains() и ternary оператор;
            {
                if (searchList[j] == secondRowNnumbers[2])
                {
                    isEqual = true;
                }
            }

            if (isEqual)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
