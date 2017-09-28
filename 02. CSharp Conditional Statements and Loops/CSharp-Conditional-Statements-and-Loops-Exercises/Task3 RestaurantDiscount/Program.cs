using System;

namespace Task3_RestaurantDiscount
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var capacity = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();
            var hall = "";
            var priceHall = 0;
            var pricePackage = 0;
            var totalPrice = 0.00;
            if (capacity <= 50)
            {
                priceHall = 2500;
                hall = "Small Hall";
            }
            else if (capacity <= 100)
            {
                priceHall = 5000;
                hall = "Terrace";
            }
            else if (capacity <= 120)
            {
                priceHall = 7500;
                hall = "Great Hall";
            }
            else if (capacity > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            if (package == "Normal")
            {
                pricePackage = 500;
                totalPrice = (priceHall + pricePackage) * 0.95;
            }
            else if (package == "Gold")
            {
                pricePackage = 750;
                totalPrice = (priceHall + pricePackage) * 0.9;
            }
            else if (package == "Platinum")
            {
                pricePackage = 1000;
                totalPrice = (priceHall + pricePackage) * 0.85;
            }
            var pricePerPerson = totalPrice / capacity;
            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
        }
    }
}
