using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.Convert_from_Base_N_10
{
    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();

            int baseNumber = int.Parse(input[0]);
            var decNumber = input[1].ToCharArray();
            var numberReverse = input.ToString().Reverse().ToArray();
            BigInteger result = 0;
            
            for (int i = 0; i < decNumber.Length; i++)
            {
                int currentNum = (int)Char.GetNumericValue(decNumber[i]);
                result += currentNum * BigInteger.Pow(baseNumber, decNumber.Length - i - 1);
            }

            Console.WriteLine(result);
        }
    }
}
