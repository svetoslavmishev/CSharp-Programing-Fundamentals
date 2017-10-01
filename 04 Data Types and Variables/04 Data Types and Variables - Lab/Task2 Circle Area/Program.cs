using System;

namespace Task2_Circle_Area
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("{0:f12}", area);
        }
    }
}
