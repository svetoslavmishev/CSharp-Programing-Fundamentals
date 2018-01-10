using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string key1 = @"^[a-zA-Z]+[<|\\]";
            string key2 = @"[<|\\][a-zA-Z]+$";

            var firstKeyMatch = Regex.Match(input, key1).ToString().TrimEnd('<', '|', '\\'); ;
            var secondKeyMatch = Regex.Match(input, key2).ToString().TrimStart('<', '|', '\\'); ;
                        
            var pattern = $"{firstKeyMatch}(.*?){secondKeyMatch}";

            var text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            MatchCollection match = Regex.Matches(text, pattern);

            foreach (Match m in match)
            {
                sb.Append(m.Groups[1].Value);
            }

            if (sb.Length > 1)
            {
                Console.WriteLine(sb.ToString());
            }
            else
            {
                Console.WriteLine("Empty result");
            }
        }
    }
}
