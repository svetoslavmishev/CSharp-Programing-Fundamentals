using System;

namespace Task10_Triangle_Number
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= num; rows++)
            {
                for (int columns = 1; columns <= rows; columns++)
                {
                    Console.Write(rows + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
