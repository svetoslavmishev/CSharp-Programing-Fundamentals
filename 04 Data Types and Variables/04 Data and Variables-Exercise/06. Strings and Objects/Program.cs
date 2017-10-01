using System;

namespace _06.Strings_and_Objects
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();
            object container = firstString + " " + secondString;
            string convertToString = container.ToString();
            Console.WriteLine(convertToString);
        }
    }
}
