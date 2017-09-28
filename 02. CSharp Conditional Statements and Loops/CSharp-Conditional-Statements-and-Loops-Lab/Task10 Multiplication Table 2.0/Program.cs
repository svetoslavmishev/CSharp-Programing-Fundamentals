namespace Task10_Multiplication_Table_2._0
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int start = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{n} X {start} = {n * start}");
                start++;
            } while (start <= 10);
           
        }
    }
}
