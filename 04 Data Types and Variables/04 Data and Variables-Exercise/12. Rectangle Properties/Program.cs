using System;

namespace _12.Rectangle_Properties
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double perimeter = 2 * (width + length);
            double area = width * length;
            double diagonal = Math.Sqrt(width * width + length * length);
            Console.WriteLine("{0}\r\n{1}\r\n{2}", perimeter, area, diagonal);
        }
    }
}
