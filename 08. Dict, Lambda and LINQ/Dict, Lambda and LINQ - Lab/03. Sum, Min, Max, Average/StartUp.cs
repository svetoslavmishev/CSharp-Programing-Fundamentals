using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum__Min__Max__Average
{
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> num = new List<int>();

            for (int i = 0; i < n; i++)
            {
                num.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Sum = " + num.Sum());
            Console.WriteLine("Min = " + num.Min());
            Console.WriteLine("Max = " + num.Max());
            Console.WriteLine("Average = " + num.Average());
        }
    }
}
