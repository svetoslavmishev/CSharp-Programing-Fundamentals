using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Working_Days
{
    class Program
    {
        static void Main()
        {
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "d-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "d-MM-yyyy", CultureInfo.InvariantCulture);

            List<DateTime> holiday = new List<DateTime>()
            {
                DateTime.ParseExact("01-01-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("03-03-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-05-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-05-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-05-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-01-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-09-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("22-09-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-11-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-12-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("25-12-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("26-12-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture)
            };

            var count = 0;
            bool isNotHoliday = false;

            for (DateTime currentDate = firstDate; currentDate <= secondDate; currentDate = currentDate.AddDays(1))
            {
                if (currentDate.DayOfWeek != DayOfWeek.Saturday && currentDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    foreach (var days in holiday)
                    {
                        if (days.Day == currentDate.Day && days.Month == currentDate.Month)
                        {
                            isNotHoliday = false;
                            break;
                        }
                        else
                        {
                            isNotHoliday = true;
                        }
                    }
                    if (isNotHoliday)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
