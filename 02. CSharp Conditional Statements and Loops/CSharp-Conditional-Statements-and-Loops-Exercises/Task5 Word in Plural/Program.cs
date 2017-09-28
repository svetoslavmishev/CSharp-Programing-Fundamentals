namespace Task5_Word_in_Plural
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string noun = Console.ReadLine();
            bool checkY = noun.EndsWith("y");
            bool checkSomeChar = noun.EndsWith("o") || noun.EndsWith("ch") ||
                noun.EndsWith("s") || noun.EndsWith("sh") || noun.EndsWith("x") || noun.EndsWith("z");
            string stringModify = "";

            if (checkY == true)
            {
                stringModify = noun.Remove(noun.Length - 1);
                Console.WriteLine(stringModify + "ies");
            }
            else if (checkSomeChar == true)
            {
                Console.WriteLine(noun + "es");
            }
            else
            {
                Console.WriteLine(noun + "s");
            }
        }
    }
}
