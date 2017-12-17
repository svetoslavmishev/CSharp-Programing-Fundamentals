using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest_3_Numbers
{
    class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var getLargest3 = input.OrderByDescending(x => x).Take(3);
            Console.WriteLine(string.Join(" ", getLargest3));
        }
    }
}
