using System;

namespace _17.Print_Part_of_ASCII_Table
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int finalIndex = int.Parse(Console.ReadLine());
            string result = "";

            for (int i = startIndex; i <= finalIndex; i++)
            {
                result += Convert.ToChar(i) + " ";
            }
            Console.WriteLine(result);
        }
    }
}
