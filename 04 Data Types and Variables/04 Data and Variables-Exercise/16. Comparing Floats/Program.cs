using System;

namespace _16.Comparing_Floats
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double difference = 0.000001;

            if (Math.Abs(firstNum - secondNum) >= difference)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
