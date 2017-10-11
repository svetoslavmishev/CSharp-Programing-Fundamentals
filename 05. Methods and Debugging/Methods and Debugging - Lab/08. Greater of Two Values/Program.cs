using System;

namespace _08.Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                GetMaxInt(first, second);
            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                GetMaxChar(first, second);
            }
            else if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                GetMaxString(first, second);
            }
        }

        static void GetMaxInt(int first, int second)
        {
            if (first >= second)
            {
                Console.WriteLine("{0}", first);
            }
            else
            {
                Console.WriteLine("{0}", second);
            }
        }

        static void GetMaxChar(char first, char second)
        {
            if (first >= second)
            {
                Console.WriteLine("{0}", first);
            }
            else
            {
                Console.WriteLine("{0}", second);
            }
        }

        static void GetMaxString(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                Console.WriteLine("{0}", first);
            }
            else
            {
                Console.WriteLine("{0}", second);
            }
        }
    }
}
