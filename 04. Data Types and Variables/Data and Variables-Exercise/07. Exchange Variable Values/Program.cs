using System;

namespace _07.Exchange_Variable_Values
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int variableA = int.Parse(Console.ReadLine());
            int variableB = int.Parse(Console.ReadLine());
            int temporaryVariable = variableA;
            temporaryVariable = variableB;
            Console.WriteLine($"Before:\r\na = {variableA}\r\nb = {variableB}");
            Console.WriteLine($"After:\r\na = {temporaryVariable}\r\nb = {variableA}");
        }
    }
}
