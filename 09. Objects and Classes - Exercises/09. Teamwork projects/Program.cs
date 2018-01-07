using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Teamwork_projects
{
    class Team
    {
        public string TeamName { get; set; }
        public List<string> Players { get; set; }
        public string Creator { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());
            List<Team> teamList = new List<Team>();

            for (int i = 0; i < countOfTeams; i++)
            {
                bool isValid = true;
                string[] userAndTeam = Console.ReadLine().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

                Team team = new Team();
                team.TeamName = userAndTeam[1];
                team.Creator = userAndTeam[0];
                team.Players = new List<string>();

                if (teamList.Any(t => t.TeamName == userAndTeam[1]))
                {
                    isValid = false;
                    Console.WriteLine($"Team {team.TeamName} was already created!");
                }

                if (teamList.Any(t => t.Creator == userAndTeam[0]))
                {
                    isValid = false;
                    Console.WriteLine($"{team.Creator} cannot create another team!");
                }

                if (isValid)
                {
                    teamList.Add(team);
                    Console.WriteLine($"Team {team.TeamName} has been created by {team.Creator}!");
                }
            }

            var line = Console.ReadLine();

            while (line != "end of assignment")
            {
                bool teameNameExist = false;
                var input = line.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var player = input[0];
                var teamName = input[1];

                if (teamList.Any(t => t.TeamName == input[1]))
                {
                    teameNameExist = true;

                    if (teamList.Any(x => x.Players.Contains(player)))
                    {
                        Console.WriteLine($"Member {player} cannot join team {teamName}!");
                    }
                    else
                    {
                        var existingTeam = teamList.First(t => t.TeamName == teamName);
                        existingTeam.Players.Add(player);
                    }
                }

                if (!teameNameExist)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }

                line = Console.ReadLine();
            }

            var teamsDisband = teamList.Where(t => t.Players.Count == 0).OrderBy(x => x.TeamName).Select(x => x.TeamName).ToList();
            //var teamDisbandList = teamList.Where(x => x.MembersList.Count == 0).ToList();

            foreach (var team in teamList.OrderByDescending(m => m.Players.Count).OrderBy(z => z.TeamName))
            {
                if (team.Players.Count == 0) continue;

                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.Creator}");

                foreach (var pl in team.Players.OrderBy(x => x).ToList())
                {
                    Console.WriteLine($"-- {pl}");
                }

            }
            Console.WriteLine("Teams to disband:");
            foreach (var item in teamsDisband)
            {
                Console.WriteLine(item);
            }
        }
    }
}