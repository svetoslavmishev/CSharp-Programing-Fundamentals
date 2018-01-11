using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_Substring
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string subString = Console.ReadLine().ToLower();
            int count = 0;
            int firstIndex = input.IndexOf(subString);

            for (int i = 0; i < input.Length; i++)
            {
                if (firstIndex >= 0)
                {
                    count++;
                    firstIndex = input.IndexOf(subString, firstIndex + 1);
                }
            }
            Console.WriteLine(count);
        }
    }
}
