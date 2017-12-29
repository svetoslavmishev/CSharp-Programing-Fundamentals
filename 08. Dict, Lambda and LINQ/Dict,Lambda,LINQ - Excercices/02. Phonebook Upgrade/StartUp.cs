using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Phonebook_Upgrade
{
    class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine();
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            while (input != "END")
            {
                string[] contacts = input.Split(' ').ToArray();

                switch (contacts[0])
                {
                    case "A":
                        phonebook[contacts[1]] = contacts[2];
                        break;

                    case "S":
                        if (!phonebook.ContainsKey(contacts[1]))
                        {
                            Console.WriteLine($"Contact {contacts[1]} does not exist.");

                        }
                        else
                        {
                            foreach (KeyValuePair<string, string> item in phonebook)
                            {
                                if (item.Key == contacts[1])
                                {
                                    Console.WriteLine(item.Key + " -> " + item.Value);
                                }
                            }
                        }
                        break;

                    case "ListAll":
                        foreach (KeyValuePair<string, string> item in phonebook)
                        {                            
                                Console.WriteLine(item.Key + " -> " + item.Value);
                        }
                        break;
                }
                input = Console.ReadLine();
            }
        }
    }
}
