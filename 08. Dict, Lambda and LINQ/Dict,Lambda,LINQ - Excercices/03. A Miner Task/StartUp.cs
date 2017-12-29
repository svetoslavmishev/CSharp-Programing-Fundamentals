using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class StartUp
    {
        static void Main()
        {
            Dictionary<string, int> resourceQuantity = new Dictionary<string, int>();

            while (true)
            {
                var resources = Console.ReadLine();
                if (resources == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());
                                
                if (resourceQuantity.ContainsKey(resources))
                {
                    resourceQuantity[resources] += quantity;
                }
                else
                {
                    resourceQuantity[resources] = quantity;
                }
            }

            foreach (KeyValuePair<string, int> item in resourceQuantity)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}