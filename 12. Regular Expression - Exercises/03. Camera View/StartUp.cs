using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Camera_View
{
    class StartUp
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            int m = numbers[0];
            int n = numbers[1];
            string pattern = $"\\|<(\\w{{{m}}})(\\w{{0,{n}}})";

            MatchCollection matchedResult = Regex.Matches(input, pattern);
            List<string> result = new List<string>();
            foreach (Match match in matchedResult)
            {
                result.Add(match.Groups[2].Value);
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
