using System;

namespace _04.Variable_in_Hexadecimal
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string hexadecimal = Console.ReadLine();
            int toDecimal = Convert.ToInt32(hexadecimal, 16);
            Console.WriteLine(toDecimal);
        }
    }
}
