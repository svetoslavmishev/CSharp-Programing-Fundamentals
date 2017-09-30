using System;

namespace Task6_Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int first = 0; first < n; first++)
            {
                for (int second = 0; second < n; second++)
                {
                    for (int third = 0; third < n; third++)
                    {
                        Console.WriteLine("{0}{1}{2}", (char)('a' + first), (char)('a' + second), (char)('a' + third));
                    }
                }
            }
        }
    }
}
