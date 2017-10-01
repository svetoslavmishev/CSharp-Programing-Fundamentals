using System;

namespace _11.Convert_Speed_Units
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float timeInSeconds = hours * 3600F + minutes * 60F + seconds;
            float metresPerSecond = distance / timeInSeconds;
            float kilometrePerHour = (distance/1000F)/(timeInSeconds/3600);
            float milesPerHour = (distance / 1609F) / (timeInSeconds / 3600);
            
            Console.WriteLine("{0}\r\n{1}\r\n{2}", metresPerSecond, kilometrePerHour, milesPerHour);
        }
    }
}
