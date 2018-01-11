using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Strings_and_Text
{
    class StartUp
    {
        static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();
            var reversed = input.Reverse();

            Console.WriteLine(string.Join("",reversed));
        }
    }
}
