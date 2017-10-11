using System;

namespace _08.Center_Point
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            GetNearToCenter(x1, y1, x2, y2);
        }

        static void GetNearToCenter(double x1, double y1, double x2, double y2)
        {
            double firstDiagonal = Math.Sqrt(x1 * x1 + y1 * y1);
            double secondDiagonal = Math.Sqrt(x2 * x2 + y2 * y2);

            if (firstDiagonal <= secondDiagonal)
            {
                Console.WriteLine("({0}, {1})", x1, y1);
            }
            else
            {
                Console.WriteLine("({0}, {1})", x2, y2);
            }

        }
    }
}