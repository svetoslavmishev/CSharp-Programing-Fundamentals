using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        List<string> allFiles = new List<string>();
        for (int i = 0; i < n; i++)
        {
            allFiles.Add(Console.ReadLine());
        }
        string filter = Console.ReadLine();
        var filterTokens = Regex.Split(filter, " in ");
        var filterExt = "." + filterTokens[0];
        var filterRoot = filterTokens[1] + @"\";

        Dictionary<string, int> fileSize =
            new Dictionary<string, int>();

        foreach (var f in allFiles) // razbivame na parts
        {
            var filePlusSize = f.Split(';');
            var path = filePlusSize[0];
            var size = int.Parse(filePlusSize[1]);

            if (path.StartsWith(filterRoot) && path.EndsWith(filterExt))
            {
                var tokens = path.Split('\\');
                var filename = tokens[tokens.Length - 1];
                fileSize[filename] = size;
            }
        }

        var sortedItems = fileSize.ToArray()
                .OrderByDescending(fs => fs.Value)
                .ThenBy(fs => fs.Key);

        foreach (var file in sortedItems)
        {
            Console.WriteLine(file.Key + " - " + file.Value + " KB");
        }

        if (sortedItems.Count() == 0)
        {
            Console.WriteLine(0);
        }
    }
}