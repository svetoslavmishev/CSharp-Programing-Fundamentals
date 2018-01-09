using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Extract_Sentences_by_Keyword
{
    class StartUp
    {
        static void Main()
        {
            var word = Console.ReadLine();
            var sentences = Console.ReadLine().Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            
            Regex regex = new Regex("\\b" + word + "\\b");

            foreach (var w in sentences)
            {
                if (regex.IsMatch(w))
                {
                    Console.WriteLine(string.Join("",w).Trim());
                }
            }
        }
    }
}