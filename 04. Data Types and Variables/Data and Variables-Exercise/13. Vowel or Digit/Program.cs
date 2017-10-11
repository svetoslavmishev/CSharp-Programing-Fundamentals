using System;

namespace _13.Vowel_or_Digit
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());
            bool isVowel = ("aeiou".IndexOf(input) >= 0);
            bool isdigits = ("0123456789".IndexOf(input) >= 0);

            if (isVowel)
            {
                Console.WriteLine("vowel");
            }
            else if (isdigits)
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
