using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfMessage = int.Parse(Console.ReadLine());

            string[] phrases = new string[] {"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.",
                "Exceptional product.", "I can’t live without this product."};
            string[] events = new string[]{ "Now I feel good.", "I have succeeded with this product.",
            "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.", "I feel great!"};
            string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random rand = new Random();

            for (int i = 0; i < numberOfMessage; i++)
            {
                var randomPhrases = rand.Next(0, phrases.Length);
                var randomEvents = rand.Next(0, events.Length);
                var randomAuthors = rand.Next(0, authors.Length);
                var randomCities = rand.Next(0, cities.Length);

                Console.WriteLine(phrases[randomPhrases] + " " + events[randomEvents] + " " + authors[randomAuthors] + " - " + cities[randomCities]);
            }
        }
    }
}
