using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Extract_Emails
{
    class StartUp
    {
        static void Main()
        {
            string pattern = @"(\s[\w.-]+@[a-zA-z-]+)(\.[a-zA-z-]+)+";
            string input = Console.ReadLine();

            MatchCollection match = Regex.Matches(input, pattern);

            foreach (Match email in match)
            {
                var mail = email.ToString();
                if (!(mail.StartsWith(".") || mail.StartsWith("_") || mail.StartsWith("-") ||
                    mail.EndsWith(".") || mail.EndsWith("_") || mail.EndsWith("-")))
                {
                    Console.WriteLine("{0}", email.Value, email.Index);
                }
            }
        }
    }
}
