using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ',', '!', '?', '.', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> palindromes = new List<string>();

            foreach (var word in input)
            {
                if (word == ReverseWord(word))
                {
                    palindromes.Add(word);
                }
            }
            palindromes.Sort();
            Console.WriteLine(String.Join(", ", palindromes.Distinct()));
        }

        public static string ReverseWord(string word)
        {
            char[] reverseWord = word.ToCharArray();
            Array.Reverse(reverseWord);
            return new string(reverseWord);
        }
    }
}