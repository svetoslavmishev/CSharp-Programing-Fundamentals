using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, double> cityAndTemperature =
                new Dictionary<string, double>();
            Dictionary<string, string> cityAndWeather =
                new Dictionary<string, string>();

            string pattern = @"([A-Z]{2})(\d+\.\d+)([a-zA-Z]+)\|";

            while (input != "end")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);
                    string nameOfTheCity = match.Groups[1].Value;
                    double averageTemperature = double.Parse(match.Groups[2].Value);
                    string typeOfWeather = match.Groups[3].Value;

                    cityAndTemperature[nameOfTheCity] = averageTemperature;
                    cityAndWeather[nameOfTheCity] = typeOfWeather;
                }

                input = Console.ReadLine();
            }

            Dictionary<string, double> temperatureSortedSity =
                cityAndTemperature.OrderBy(c => c.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (var sortCity in temperatureSortedSity)
            {
                Console.WriteLine($"{sortCity.Key} => {sortCity.Value} => {cityAndWeather[sortCity.Key]}");
            }
        }
    }
}
