using System;

namespace _09.Longer_Line
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            GetBiggerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        static void GetBiggerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double firstPointCloser = Math.Sqrt(x1 * x1 + y1 * y1);
            double secondPointCloser = Math.Sqrt(x2 * x2 + y2 * y2);
            double thirdPointCloser = Math.Sqrt(x3 * x3 + y3 * y3);
            double fourthPointCloser = Math.Sqrt(x4 * x4 + y4 * y4);
            double firstLine = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            double secondLine = Math.Sqrt((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3));

            if (firstLine >= secondLine)
            {
                if (firstPointCloser <= secondPointCloser)
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x2, y2);
                }
                else
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x2, y2, x1, y1);
                }
            }
            else if (firstLine < secondLine)
            {
                if (thirdPointCloser <= fourthPointCloser)
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x3, y3, x4, y4);
                }
                else
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x4, y4, x3, y3);
                }
            }
        }
    }
}

