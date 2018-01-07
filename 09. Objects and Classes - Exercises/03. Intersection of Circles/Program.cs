using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Intersection_of_Circles
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputFirstRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Circle circle1 = new Circle() { Center = new Point { X = inputFirstRow[0], Y = inputFirstRow[1] }, Radius = inputFirstRow[2] };
            var inputSecondRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Circle circle2 = new Circle() { Center = new Point { X = inputSecondRow[0], Y = inputSecondRow[1] }, Radius = inputSecondRow[2] };

            if (Intersect(circle1, circle2))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        private static bool Intersect(Circle circle1, Circle circle2)
        {
            int deltaX = circle2.Center.X - circle1.Center.X;
            int deltaY = circle2.Center.Y - circle1.Center.Y;
            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            if (distance <= circle1.Radius + circle2.Radius)
            {
                return true;
            }
            return false;
        }

    }
    class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
