namespace Task8_Calories_Counter
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var totalCalories = 0;            

            for (int i = 0; i < n; i++)
            {
                var ingredients = Console.ReadLine().ToLower();

                if (ingredients == "cheese")
                {
                    totalCalories += 500;                    
                }
                else if (ingredients == "tomato sauce")
                {
                    totalCalories += 150;
                }
                else if (ingredients == "salami")
                {
                    totalCalories += 600;
                }
                else if (ingredients == "pepper")
                {
                    totalCalories += 50;
                }
                else
                {
                    totalCalories += 0;
                }
            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
