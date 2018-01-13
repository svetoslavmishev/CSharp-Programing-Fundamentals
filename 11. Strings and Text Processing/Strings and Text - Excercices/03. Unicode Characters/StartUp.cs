using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Unicode_Characters
{
    class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine().ToCharArray();

            var result = "";

            for (int i = 0; i < input.Length; i++)
            {
                var currentChar = input[i];
                result += "\\u" + ((int)currentChar).ToString("X4").ToLower();
            }
            Console.WriteLine(result);
        }
    }
}
