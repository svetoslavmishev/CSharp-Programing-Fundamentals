using System;

namespace _04.Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeaderRow(n);
            for (int i = 1; i <= n-2; i++)
            {
                PrintMiddleRow(n);
            }
            PrintHeaderRow(n);
        }

        static void PrintHeaderRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        static void PrintMiddleRow(int n)
        {
            Console.Write("-");
            for (int j = 0; j <= n - 2; j++)
            {
                Console.Write("\\/");
            }
            Console.Write("-");
            Console.WriteLine();
        }
    }
}
