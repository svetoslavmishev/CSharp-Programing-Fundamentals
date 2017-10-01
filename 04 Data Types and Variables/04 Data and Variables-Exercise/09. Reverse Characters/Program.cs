using System;

namespace _09.Reverse_Characters
{
    public class StartUp
    {
        public static void Main()
        {
            char firstElement = char.Parse(Console.ReadLine());
            char secondElement = char.Parse(Console.ReadLine());
            char thirdElement = char.Parse(Console.ReadLine());
            char[] array = { firstElement, secondElement, thirdElement };
            Array.Reverse(array);
            Console.WriteLine(array);
        }
    }
}