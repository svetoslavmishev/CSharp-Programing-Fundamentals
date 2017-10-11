using System;

namespace _19.Thea_the_Photographer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            long picturesCount = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());

            long filteredPictures = (long)Math.Ceiling(picturesCount * filterFactor / 100.0);
            long filterTimeForPics = filterTime * picturesCount;
            long uploadTimeForFilteredPics = uploadTime * filteredPictures;

            long totalTime = filterTimeForPics + uploadTimeForFilteredPics;
            TimeSpan result = TimeSpan.FromSeconds(totalTime);
            Console.WriteLine("{0}:{1:D2}:{2:D2}:{3:D2}", result.Days, result.Hours, result.Minutes, result.Seconds);
        }
    }
}
