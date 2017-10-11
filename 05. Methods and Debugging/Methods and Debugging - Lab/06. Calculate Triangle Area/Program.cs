using System;

namespace _06.Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = CalculateTriangleArea(width, height);
            Console.WriteLine("{0}",area);
        }

        static double CalculateTriangleArea(double width, double height)
        {
            double result = width * height / 2;
            return result;
        }
    }
}
