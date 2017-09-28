namespace Task_9_Count_Integers
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var counter = 0;

            try
            {
                while (true)
                {
                    var integerNumber = int.Parse(Console.ReadLine());
                    counter++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(counter);
            }
        }
    }
}
