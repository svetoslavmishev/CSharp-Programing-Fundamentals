using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var emailList = new Dictionary<string, string>();
            var input = File.ReadAllLines("../../input.txt");

            for (int i = 0; i < input.Length; i += 2)
            {
                string name = input[i];

                if (name == "stop")
                {
                    break;
                }
                string email = input[i + 1];

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
                string output = $"{item.Key} -> {item.Value}" + Environment.NewLine;
                File.AppendAllText("../../output.txt", output);
            }
        }
    }
}
