namespace Task5_Foreign_Languages
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string counrty = Console.ReadLine();
            switch (counrty)
            {
                case "USA":
                case "England":
                    Console.WriteLine("English");
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}

