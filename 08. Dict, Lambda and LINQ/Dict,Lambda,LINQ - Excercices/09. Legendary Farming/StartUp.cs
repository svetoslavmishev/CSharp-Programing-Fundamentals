using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Legendary_Farming
{
    class StartUp
    {
        static void Main()
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>()
            {
                {"shards", 0 },
                {"fragments", 0 },
                {"motes", 0 }
            };

            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();

            bool tryGetData = true;
            string printKeyMaterial = "";

            while (tryGetData)
            {
                string input = Console.ReadLine();
                string[] data = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < data.Length + 1 / 2; i += 2)
                {
                    string material = data[i + 1].ToLower();
                    int quantity = int.Parse(data[i]);

                    if (keyMaterials.ContainsKey(material))
                    {
                        keyMaterials[material] += quantity;

                        if (keyMaterials[material] >= 250)
                        {
                            foreach (var item in keyMaterials.Where(x => x.Value >= 250))
                            {
                                printKeyMaterial = item.Key;
                            }

                            keyMaterials[material] -= 250;
                            tryGetData = false;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials.Add(material, quantity);
                        }
                        else
                        {
                            junkMaterials[material] += quantity;
                        }
                    }
                }
            }

            switch (printKeyMaterial)
            {
                case "motes":
                    Console.WriteLine("Dragonwrath obtained!");
                    break;
                case "fragments":
                    Console.WriteLine("Valanyr obtained!");
                    break;
                case "shards":
                    Console.WriteLine("Shadowmourne obtained!");
                    break;
            }

            foreach (var k in keyMaterials.OrderByDescending(y => y.Value).ThenBy(z => z.Key))
            {
                Console.WriteLine($"{k.Key}: {k.Value}");
            }

            foreach (var j in junkMaterials.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{j.Key}: {j.Value}");
            }
        }
    }
}
