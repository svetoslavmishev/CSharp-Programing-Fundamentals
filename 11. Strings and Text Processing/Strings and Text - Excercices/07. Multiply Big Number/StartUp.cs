using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _07.Multiply_Big_Number
{
    public class StartUp
    {
        public static void Main()
        {
            var firstNumber = (Console.ReadLine().TrimStart(new char[] { '0' }));
            var secondNumber = byte.Parse(Console.ReadLine().TrimStart(new char[] { '0' }));

            if (firstNumber == "0" || secondNumber == 0 || firstNumber == "" || firstNumber == " ")
            {
                Console.WriteLine(0);
                return;
            }

            StringBuilder result = new StringBuilder();
            byte multilply = 0;
            byte number = 0;
            byte rem = 0;

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                multilply = (byte)(byte.Parse(firstNumber[i].ToString()) * secondNumber + rem);
                number = (byte)(multilply % 10);
                result.Append(number);
                rem = (byte)(multilply / 10);

                if (rem != 0 && i == 0)
                {
                    result.Append(rem);
                }
            }

            Console.WriteLine(string.Join("", result.ToString().ToCharArray().Reverse().SkipWhile(x => x == 0)));
            
        }
    }
}
