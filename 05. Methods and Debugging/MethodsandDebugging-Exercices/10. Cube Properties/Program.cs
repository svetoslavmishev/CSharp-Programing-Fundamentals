using System;

namespace _10.Cube_Properties
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine().ToLower();
            GetCubeProperties(side, parameter);
        }

        static void GetCubeProperties(double side, string parameter)
        {
            if (parameter == "face")
            {
                double faceDiagonal = Math.Sqrt(2 * side * side);
                Console.WriteLine("{0:F2}", faceDiagonal);
            }
            else if (parameter == "space")
            {
                double spaceDiagonal = Math.Sqrt(3 * side * side);
                Console.WriteLine("{0:F2}", spaceDiagonal);
            }
            else if (parameter == "volume")
            {
                double volume = side * side * side;
                Console.WriteLine("{0:F2}", volume);
            }
            else if (parameter == "area")
            {
                double area = 6 * side * side;
                Console.WriteLine("{0:F2}", area);
            }
        }
    }
}
