using System;

namespace _05.Boolean_Variable
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string value = Console.ReadLine();
            bool toBollean = Convert.ToBoolean(value);
            //bool toBollean = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(toBollean ? "Yes" : "No"); //Or if ...else
        }
    }
}
