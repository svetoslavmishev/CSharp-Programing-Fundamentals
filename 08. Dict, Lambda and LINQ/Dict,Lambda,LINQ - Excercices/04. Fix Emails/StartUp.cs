using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class StartUp
    {
        static void Main()
        {
            var emailList = new Dictionary<string, string>();

            while (true) // безкраен цикъл
            {
                string name = Console.ReadLine();

                if (name == "stop")
                {
                    break;
                }
                string email = Console.ReadLine();

                string domain = email.Substring(email.Length - 2);

                if (domain == "uk" || domain == "us")
                {
                    continue;
                }
                else
                {
                    emailList.Add(name, email);
                }
            }
            foreach (var item in emailList)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}
