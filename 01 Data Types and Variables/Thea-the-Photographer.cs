using System;

namespace Thea_the_Photographer
{
    class Program
    {
        public static void Main(string[] args)
        {
            var numberPictures = long.Parse(Console.ReadLine());
            var filterTime = long.Parse(Console.ReadLine());
            double filterFactor = double.Parse(Console.ReadLine());
            var uploadTime = long.Parse(Console.ReadLine());

            double filteredPicures = Math.Ceiling(filterFactor / 100.0 * numberPictures);
            long totalPicsFilterTime = numberPictures * filterTime;
            long filteredPicturesTime = (long)filteredPicures * uploadTime;
            long totalTime = totalPicsFilterTime + filteredPicturesTime;

            TimeSpan t = TimeSpan.FromSeconds(totalTime);
            string answer = string.Format("{0}:{1:D2}:{2:D2}:{3:D2}", t.Days, t.Hours, t.Minutes, t.Seconds);

            Console.WriteLine(answer);
        }
    }
}
