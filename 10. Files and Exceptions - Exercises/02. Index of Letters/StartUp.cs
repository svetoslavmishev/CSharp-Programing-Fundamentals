using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Index_of_Letters
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllText("../../input.txt");
            
            for (int i = 0; i < input.Length; i++)
            {
                var res1 = input[i];
                var res2 = input[i] - 97;
                var result = res1 + " -> " + res2 + Environment.NewLine;
                File.AppendAllText("../../output.txt", $"{input[i]} -> {input[i] - 97}" + Environment.NewLine);
            }
        }
    }
}
