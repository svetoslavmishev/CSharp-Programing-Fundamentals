using System;

namespace _01.Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine(PrintGreeting(name));
        }

        static string PrintGreeting(string name)
        {
            string greeting = ($"Hello, {name}!");
            return greeting;
        }
    }
}
