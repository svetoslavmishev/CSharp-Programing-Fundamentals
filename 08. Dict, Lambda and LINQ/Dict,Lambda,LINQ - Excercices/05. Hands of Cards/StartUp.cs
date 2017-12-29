using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hands_of_Cards
{
    class StartUp
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> gameOfCards = new
                Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

            while (input != "JOKER")
            {
                var line = input.Split(':');
                var name = line[0];
                var cardArgs = line[1].Trim().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                if (!gameOfCards.ContainsKey(name))
                {
                    gameOfCards.Add(name, new Dictionary<string, int>());
                    AddCardsToPlayers(gameOfCards[name], cardArgs);
                }
                else
                {
                    AddCardsToPlayers(gameOfCards[name], cardArgs);
                }
                input = Console.ReadLine();
            }

            foreach (var person in gameOfCards)
            {
                Console.WriteLine($"{person.Key}: {person.Value.Values.Sum()}");
            }
        }

        private static void AddCardsToPlayers(Dictionary<string, int> people, string[] cardArgs)
        {
            foreach (var card in cardArgs)
            {
                if (!people.ContainsKey(card))
                {
                    people.Add(card, CardValue(card));
                }
            }
        }

        private static int CardValue(string card)
        {
            int power = 0;

            switch (card[0])
            {
                case '1':
                    power += 10;
                    break;
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    power += (int)card[0] - 48;
                    break;                
                case 'J':
                    power += 11;
                    break;
                case 'Q':
                    power += 12;
                    break;
                case 'K':
                    power += 13;
                    break;
                case 'A':
                    power += 14;
                    break;
            }

            switch (card[card.Length - 1])
            {
                case 'S':
                    power *= 4;
                    break;
                case 'H':
                    power *= 3;
                    break;
                case 'D':
                    power *= 2;
                    break;
                case 'C':
                    power *= 1;
                    break;
            }
            return power;
        }
    }
}
