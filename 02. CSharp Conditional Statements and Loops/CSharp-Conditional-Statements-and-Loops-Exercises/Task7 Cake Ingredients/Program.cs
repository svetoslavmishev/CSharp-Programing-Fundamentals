namespace Task7_Cake_Ingredients
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var counter = 0;

            do
            {
                var ingredient = Console.ReadLine();
                
                if (ingredient == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {counter} ingredients.");
                    break;
                }
                counter++;
                Console.WriteLine($"Adding ingredient {ingredient}.");
            } while (true);
        }
    }
}