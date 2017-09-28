namespace Task12_Number_Checker
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            try
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input!");         
            }
        }
    }
}
