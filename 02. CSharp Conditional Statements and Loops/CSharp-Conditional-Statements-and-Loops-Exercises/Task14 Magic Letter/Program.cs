using System;

namespace Task14_Magic_Letter
{
    class StarUp
    {
        static void Main(string[] args)
        {
            var firstLetter = char.Parse(Console.ReadLine());
            var secondLetter = char.Parse(Console.ReadLine());
            var magicLetter = char.Parse(Console.ReadLine());

            for (var i = firstLetter; i <= secondLetter; i++)
            {
                for (var j = firstLetter; j <= secondLetter; j++)
                {
                    for (var k = firstLetter; k <= secondLetter; k++)
                    {
                        string currentSymbol = "" + i + j + k;
                        if (!currentSymbol.Contains(magicLetter + ""))
                        {
                            Console.Write(currentSymbol + " ");
                        }
                    }
                }
            }
        }
    }
}
