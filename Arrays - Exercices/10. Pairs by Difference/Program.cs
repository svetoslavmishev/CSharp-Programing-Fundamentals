using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var difference = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                int currentNumber = array1[i];
                for (int j = 1 + i; j < array1.Length; j++) //j = 1+i za da vzia vinagi chislata ot dqsno na currentNumber i da ne se dublirat edni i sashti sumi.
                {
                    int secondNumbers = array1[j];

                    if (currentNumber - secondNumbers == difference || secondNumbers - currentNumber == difference)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
