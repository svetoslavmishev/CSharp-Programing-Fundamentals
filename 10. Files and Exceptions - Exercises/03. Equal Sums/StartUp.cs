using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Equal_Sums
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var array = File.ReadAllText("../../input.txt")
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            bool isEqualSum = false;

            for (int i = 0; i < array.Length; i++)
            {
                int[] leftSide = array.Take(i).ToArray();
                int[] rightSide = array.Skip(i + 1).ToArray();

                if (leftSide.Sum() == rightSide.Sum())
                {
                    isEqualSum = true;
                    File.WriteAllText("../../output.txt", i.ToString());
                    break;
                }
            }

            if (!isEqualSum)
            {
                File.WriteAllText("../../output.txt", "no");
            }
        }
    }
}
