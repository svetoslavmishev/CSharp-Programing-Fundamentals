using System;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            if (figureType == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}", TriangleArea(side, height)); 
            }
            else if (figureType == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}", SquareArea(side));
            }
            else if (figureType == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}",RectangleArea(width, height));
            }
            else if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}", CircleArea(radius));
            }
        }

        static double TriangleArea(double side, double height)
        {
            return (side * height) / 2;
        }

        static double SquareArea(double side)
        {
            return side * side;
        }

        static double RectangleArea(double width, double height)
        {
            return width * height;
        }

        static double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
