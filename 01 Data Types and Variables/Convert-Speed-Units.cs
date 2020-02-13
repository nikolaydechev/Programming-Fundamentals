using System;

namespace Convert_Speed_Units
{
    class Program
    {
        public static void Main(string[] args)
        {
            float distance = Convert.ToSingle(Console.ReadLine());
            float timeTakenHours = Convert.ToSingle(Console.ReadLine());
            float timeTakenMinutes = Convert.ToSingle(Console.ReadLine());
            float timeTakenSeconds = Convert.ToSingle(Console.ReadLine());

            float timeSeconds = (timeTakenHours * 3600) + (timeTakenMinutes * 60) + timeTakenSeconds;

            float distanceKm = distance / 1000.0f;

            float speedMS = distance / timeSeconds;
            float speedKmH = distanceKm / (timeSeconds/3600.0f);
            float speedMpH = speedKmH / 1.609f;

            Console.WriteLine("{0}", speedMS);
            Console.WriteLine("{0}", speedKmH);
            Console.WriteLine("{0}", speedMpH);
            
        }
    }
}
