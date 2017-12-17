using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences
{
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();
            string[] words = input.Split(' ');
            Dictionary<string, int> count = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (count.ContainsKey(word))
                {
                    count[word]++;
                }
                else
                {
                    count[word] = 1;
                }
            }
            List<string> output = new List<string>();

            foreach (var pair in count)
            {
                if (pair.Value % 2 != 0)
                {
                    output.Add(pair.Key);
                }
            }
            Console.WriteLine(string.Join(", ", output));
        }
    }
}
