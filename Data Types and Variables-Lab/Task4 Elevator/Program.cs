using System;

namespace Task4_Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int course = (int)Math.Ceiling((decimal)persons / capacity);
            Console.WriteLine(course);
        }
    }
}
