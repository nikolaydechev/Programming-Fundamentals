using System;

namespace _01.TheaThePhotographer
{
    public class TheaPhotographer
    {
        public static void Main()
        {
            var totalPictures = double.Parse(Console.ReadLine());
            var filterTime = double.Parse(Console.ReadLine());
            var filterFactor = double.Parse(Console.ReadLine());
            var uploadTime = double.Parse(Console.ReadLine());

            var filteredPictures = Math.Ceiling(totalPictures * (filterFactor / 100));
            var firstTime = totalPictures * filterTime;
            var secondTime = filteredPictures * uploadTime;

            var totalTime = firstTime + secondTime;

            TimeSpan time = TimeSpan.FromSeconds(totalTime);

            string result = string.Format("{0:d1}:{1:d2}:{2:d2}:{3:d2}", time.Days, time.Hours, time.Minutes, time.Seconds);
            
            Console.WriteLine(result);
        }
    }
}
