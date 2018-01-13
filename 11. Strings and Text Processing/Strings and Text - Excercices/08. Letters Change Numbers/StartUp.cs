using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Letters_Change_Numbers
{
    public class StartUp
    {
        public static void Main()
        {
            var line = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            double totalSum = 0;

            foreach (var word in line)
            {
                var firstLetter = word.First();//A
                var secondLetter = word.Last();//b
                double number = double.Parse(word.Substring(1, word.Length - 2));//12

                if (char.IsLower(firstLetter))
                {
                    sum = number * (firstLetter - ('a'- 1));  // (97-(97-1))
                }
                else
                {
                    sum = number / (firstLetter - ('A' - 1)); //(65 - (65 - 1))
                }

                if (char.IsLower(secondLetter))
                {
                    sum += secondLetter - ('a' - 1);
                }
                else
                {
                    sum -= secondLetter - ('A' - 1);
                }

                totalSum += sum;

            }
            
            Console.WriteLine("{0:f2}",totalSum);
        }
    }
}
