using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Short_Words_Sorted
{
    class StartUp
    {
        static void Main()
        {
            string[] text = Console.ReadLine().ToLower()
                .Split(new char[] { '.', ',', ';', ':', '(', ')', '[', ']', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var result = text.ToArray().Where(x => x.Length < 5).OrderBy(y => y).Distinct();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
