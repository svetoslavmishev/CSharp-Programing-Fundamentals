using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Big_Numbers
{
    public class StartUp
    {
        public static void Main()
        {
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();

            if (firstNumber.Length > secondNumber.Length)
            {
                secondNumber = secondNumber.PadLeft(firstNumber.Length, '0');
            }
            else
            {
                firstNumber = firstNumber.PadLeft(secondNumber.Length, '0');
            }

            StringBuilder result = new StringBuilder();
            var sum = 0;
            var number = 0;
            var rem = 0;

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                sum = firstNumber[i] - 48 + secondNumber[i] - 48 + rem;
                number = sum % 10;
                result.Append(number);
                rem = sum / 10;

                if (rem > 0 && i == 0)
                {
                    result.Append(rem);
                }
            }
            Console.WriteLine(result.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray());
        }
    }
}
