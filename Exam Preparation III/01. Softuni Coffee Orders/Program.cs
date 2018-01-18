using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        decimal totalPrice = 0;

        for (int i = 0; i < n; i++)
        {
            var price = ReadOrderAndProcessPrice();
            totalPrice += price;
        }
        Console.WriteLine($"Total: ${totalPrice:F2}");
    }

    static decimal ReadOrderAndProcessPrice()
    {
        decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
        
        DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);

        decimal daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);

        decimal capsulesCount = decimal.Parse(Console.ReadLine());

        decimal price = (daysInMonth * capsulesCount) * pricePerCapsule;

        Console.WriteLine($"The price for the coffee is: ${price:F2}");

        return price;
    }
}