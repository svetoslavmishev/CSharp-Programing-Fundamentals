using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Logs_Aggregator
{
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, SortedSet<string>> userAndIp =
                new Dictionary<string, SortedSet<string>>();

            Dictionary<string, int> userAndDuration =
               new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string user = input[1];
                string ip = input[0];
                int duration = int.Parse(input[2]);

                if (!userAndDuration.ContainsKey(user) && !userAndIp.ContainsKey(ip))
                {
                    userAndDuration.Add(user, duration);
                    userAndIp.Add(user, new SortedSet<string>());
                    userAndIp[user].Add(ip);
                }
                else
                {
                    userAndDuration[user] += duration;
                    userAndIp[user].Add(ip);
                }
            }

            List<string> ipResult = new List<string>();

            foreach (var user in userAndDuration.OrderBy(x => x.Key))
            {
                Console.Write($"{user.Key}: {user.Value} ");

                foreach (var ip in userAndIp[user.Key])
                {
                    ipResult.Add(ip);
                }

                Console.WriteLine($"[{string.Join(", ", ipResult)}]");
                ipResult.Clear();
            }
        }
    }
}
