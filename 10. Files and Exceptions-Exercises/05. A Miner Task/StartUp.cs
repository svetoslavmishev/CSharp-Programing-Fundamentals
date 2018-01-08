using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.A_Miner_Task
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourceQuantity = new Dictionary<string, int>();

            string[] input = File.ReadAllLines("../../input.txt");

            for (int i = 0; i < input.Length; i += 2)
            {
                var resources = input[i];

               // while (true)
               // {
                    if (resources == "stop")
                    {
                        break;
                    }

                    int quantity = int.Parse(input[i + 1]);

                    if (resourceQuantity.ContainsKey(resources))
                    {
                        resourceQuantity[resources] += quantity;
                    }
                    else
                    {
                        resourceQuantity[resources] = quantity;
                    }
                //}
            }

            foreach (KeyValuePair<string, int> resours in resourceQuantity)
            {
                File.AppendAllText("../../output.txt", $"{resours.Key} -> {resours.Value}");
                File.AppendAllText("../../output.txt", Environment.NewLine);
            }
        }
    }
}
