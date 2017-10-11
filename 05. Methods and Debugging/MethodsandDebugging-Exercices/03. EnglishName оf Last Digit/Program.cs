using System;

namespace _03.EnglishName_оf_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            Console.WriteLine(GetLastDigitInEnglish(num));
        }

        static string GetLastDigitInEnglish(long num)
        {
            var lastDigit = Math.Abs(num) % 10;
            string digitInEnglish = "";

            switch (lastDigit)
            {
                case 0:
                    digitInEnglish = "zero"; break;
                case 1:
                    digitInEnglish = "one"; break;
                case 2:
                    digitInEnglish = "two"; break;
                case 3:
                    digitInEnglish = "three"; break;
                case 4:
                    digitInEnglish = "four"; break;
                case 5:
                    digitInEnglish = "five"; break;
                case 6:
                    digitInEnglish = "six"; break;
                case 7:
                    digitInEnglish = "seven"; break;
                case 8:
                    digitInEnglish = "eight"; break;
                case 9:
                    digitInEnglish = "nine"; break;
                default:
                    break;
            }
            return digitInEnglish;
        }
    }
}
