using System;

namespace _18.Different_Integers_Size
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string intput = Console.ReadLine();
            
            try
            {
                long num = long.Parse(intput);
                Console.WriteLine($"{intput} can fit in:");
                if (num >= sbyte.MinValue && num <= sbyte.MaxValue)
                {
                    Console.WriteLine("* sbyte");
                }
                if (num >= byte.MinValue && num <= byte.MaxValue)
                {
                    Console.WriteLine("* byte");
                }
                if (num >= short.MinValue && num <= short.MaxValue)
                {
                    Console.WriteLine("* short");
                }
                if (num >= ushort.MinValue && num <= ushort.MaxValue)
                {
                    Console.WriteLine("* ushort");
                }
                if (num >= int.MinValue && num <= int.MaxValue)
                {
                    Console.WriteLine("* int");
                }
                if (num >= uint.MinValue && num <= uint.MaxValue)
                {
                    Console.WriteLine("* uint");
                }
                if (num >= long.MinValue && num <= long.MaxValue)
                {
                    Console.WriteLine("* long");
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"{intput} can't fit in any type");
            }
        }
    }
}
