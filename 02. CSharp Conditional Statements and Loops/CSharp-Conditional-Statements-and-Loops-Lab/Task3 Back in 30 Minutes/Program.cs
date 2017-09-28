namespace Task3_Back_in_30_Minutes
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;

            if (minutes > 59)
            {
                hours++;
                minutes -= 60;
            }

            if (hours > 23)
            {
                hours -= 24;
            }

            Console.WriteLine("{0}:{1:D2}", hours, minutes);
        }
    }
}
