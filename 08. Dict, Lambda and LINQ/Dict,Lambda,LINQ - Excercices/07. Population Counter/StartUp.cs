using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Population_Counter
{
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, long>> populationCounter =
                new Dictionary<string, Dictionary<string, long>>();

            while (input != "report")
            {               
                string[] data = input.Split('|');

                string country = data[1];
                string city = data[0];
                long population = long.Parse(data[2]);

                if (!populationCounter.ContainsKey(country))
                {
                    populationCounter.Add(country, new Dictionary<string, long>());
                }
                populationCounter[country].Add(city, population);

                input = Console.ReadLine();
            }

            foreach (var country in populationCounter.OrderByDescending(c => c.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");

                foreach (var city in country.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
