namespace Task9_Multiplication_Table
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int start = 1;

            while (start <= 10)
            {
                Console.WriteLine($"{n} X {start} = {n*start}");
                start++;
            }            
        }
    }
}
