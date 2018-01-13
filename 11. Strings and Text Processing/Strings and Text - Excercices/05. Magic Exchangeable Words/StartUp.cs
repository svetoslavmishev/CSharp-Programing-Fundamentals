using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Magic_Exchangeable_Words
{
    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();

            var word1 = input[0].Distinct().ToArray();
            var word2 = input[1].Distinct().ToArray();
            bool isEqual = (word1.Length == word2.Length);

            Console.WriteLine(isEqual.ToString().ToLower());
        }
    }
}
