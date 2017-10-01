using System;

namespace _14.Integer_to_Hex_and_Binary
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int decimalValue = int.Parse(Console.ReadLine());
            string hexValue = Convert.ToString(decimalValue, 16);
            string binaryValue = Convert.ToString(decimalValue, 2);
            Console.WriteLine(hexValue.ToUpper() + Environment.NewLine + binaryValue);
        }
    }
}
