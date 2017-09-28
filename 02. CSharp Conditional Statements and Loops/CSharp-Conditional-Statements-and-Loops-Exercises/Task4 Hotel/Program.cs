namespace Task4_Hotel
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var months = Console.ReadLine();
            var nightsCount = int.Parse(Console.ReadLine());
            var studioPrice = 0.0;
            var doublePrice = 0.0;
            var suitePrice = 0.0;

            if (months == "May" || months == "October")
            {
                studioPrice = 50;
                doublePrice = 65;
                suitePrice = 75;

                if (nightsCount > 7)
                {
                    studioPrice = studioPrice * 0.95;
                }
            }
            else if (months == "June" || months == "September")
            {
                studioPrice = 60;
                doublePrice = 72;
                suitePrice = 82;

                if (nightsCount > 14)
                {
                    doublePrice = doublePrice * 0.9;
                }
            }
            else if (months == "July" || months == "August" || months == "December")
            {
                studioPrice = 68;
                doublePrice = 77;
                suitePrice = 89;

                if (nightsCount > 14)
                {
                    suitePrice = suitePrice * 0.85;
                }
            }

            var totalStudioPrice = studioPrice * nightsCount;
            var totalDoublePrice = doublePrice * nightsCount;
            var totalSuitePricePrice = suitePrice * nightsCount;

            if ((months == "September" || months == "October") && nightsCount > 7)
            {
                totalStudioPrice -= studioPrice;
            }
            Console.WriteLine($"Studio: {totalStudioPrice:F2} lv.");
            Console.WriteLine($"Double: {totalDoublePrice:F2} lv.");
            Console.WriteLine($"Suite: {totalSuitePricePrice:F2} lv.");
        }
    }
}
