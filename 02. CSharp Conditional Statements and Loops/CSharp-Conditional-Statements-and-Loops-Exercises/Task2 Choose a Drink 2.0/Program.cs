using System;

namespace Task2_Choose_a_Drink_2._0
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            string drink = "";
            double price = 0;

            if (profession == "Athlete")
            {
                drink = "Water";
                price = quantity * 0.70;
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                drink = "Coffee";
                price = quantity * 1.00;
            }
            else if (profession == "SoftUni Student")
            {
                drink = "Beer";
                price = quantity * 1.70;
            }
            else
            {
                drink = "Tea";
                price = quantity * 1.20;
            }
            Console.WriteLine($"The {profession} has to pay {price:F2}.");
        }
    }
}
