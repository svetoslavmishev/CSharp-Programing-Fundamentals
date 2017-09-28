namespace Task8_Sum_of_Odd_Numbers
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int odd = 1;
            int sum = 0;

            for (var i = 1; i <= n; i++)
            {
                sum += odd;
                Console.WriteLine(odd);
                odd += 2;               
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
