using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Phonebook
{
    class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine();
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

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
                }
                input = Console.ReadLine();
            }
        }
    }
}