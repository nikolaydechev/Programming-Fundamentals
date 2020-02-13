namespace _01_SinoTheWalker
{
    using System;
    using System.Globalization;

    public class SinoTheWalker
    {
        public static void Main()
        {
            var inputTime = DateTime.Parse(Console.ReadLine());
            
            var steps = int.Parse(Console.ReadLine())%86400;
            var stepTime = int.Parse(Console.ReadLine())%86400;

            var stepsTime = steps * stepTime;

            var result = inputTime.AddSeconds(stepsTime).ToString("HH:mm:ss");
            Console.WriteLine($"Time Arrival: {result}");
        }
    }
}
