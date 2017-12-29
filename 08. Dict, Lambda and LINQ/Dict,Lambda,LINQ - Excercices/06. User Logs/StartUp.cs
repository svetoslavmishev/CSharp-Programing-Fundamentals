using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.User_Logs
{
    class StartUp
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> usersWithIp = new
                Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                var formatLine = input.Split(' ');
                var username = formatLine[2].Replace("user=", "");
                var ip = formatLine[0].Replace("IP=", "");

                if (!usersWithIp.ContainsKey(username))
                {
                    usersWithIp.Add(username, new Dictionary<string, int>());
                }

                if (!usersWithIp[username].ContainsKey(ip))
                {
                    usersWithIp[username].Add(ip, 0);
                }
                usersWithIp[username][ip] = usersWithIp[username][ip] + 1;

                input = Console.ReadLine();
            }

            foreach (var user in usersWithIp.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key}: ");

                StringBuilder str = new StringBuilder();

                foreach (var count in user.Value)
                {
                    str.Append(count.Key).Append(" => ")
                        .Append(count.Value + ", ");

                }
                str.Remove(str.Length - 2, 2).Append(".");
                Console.WriteLine(str.ToString());
            }
        }
    }
}
