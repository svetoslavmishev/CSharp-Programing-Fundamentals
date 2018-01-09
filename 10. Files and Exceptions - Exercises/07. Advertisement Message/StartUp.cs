using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Advertisement_Message
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var numberOfMessage = int.Parse(Console.ReadLine());

            string[] phrases = File.ReadAllLines("../../phrases.txt");
            string[] events = File.ReadAllLines("../../events.txt");
            string[] authors = File.ReadAllLines("../../authors.txt");
            string[] cities = File.ReadAllLines("../../cities.txt");

            Random rand = new Random();
            File.WriteAllText("../../output.txt", string.Empty);

            for (int i = 0; i < numberOfMessage; i++)
            {
                var randomPhrases = rand.Next(0, phrases.Length);
                var randomEvents = rand.Next(0, events.Length);
                var randomAuthors = rand.Next(0, authors.Length);
                var randomCities = rand.Next(0, cities.Length);

                File.AppendAllText("../../output.txt", $"{phrases[randomPhrases]} {events[randomEvents]} {authors[randomAuthors]} - {cities[randomCities]}{Environment.NewLine}");
            }
        }
    }
}
