using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Convert_from_Base_10_N
{
    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(). Select(BigInteger.Parse).ToArray();

            BigInteger baseNumber = input[0];
            BigInteger decimalNumber = input[1];
            BigInteger rem = 0;
            string result = "";

            while (decimalNumber > 0)
            {
                rem = decimalNumber % baseNumber;
                decimalNumber /= baseNumber;

                result = rem.ToString() + result;
            }

            Console.WriteLine(result);
        }
    }
}
