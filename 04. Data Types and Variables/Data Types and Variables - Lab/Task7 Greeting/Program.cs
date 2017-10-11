using System;

namespace Task7_Greeting
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hello, {firstName} {lastName}." +
                Environment.NewLine +
                $"You are {age} years old.");
        }
    }
}
