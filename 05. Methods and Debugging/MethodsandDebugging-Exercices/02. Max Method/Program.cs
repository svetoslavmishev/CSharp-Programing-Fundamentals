using System;

namespace _02.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(a, b, c));
        }

        static int GetMax(int a, int b, int c)
        {
            int max = a;
            if (b >= max)
            {
                max = b;
            }
            if (c >= max)
            {
                max = c;
            }
            return max;
        }
    }
}
