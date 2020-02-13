using System;

namespace HornetWings
{
    public class HornetWings
    {
        public static void Main()
        {
            var wingFlaps = int.Parse(Console.ReadLine());
            var distanceForThousandFlaps = decimal.Parse(Console.ReadLine());
            var endurance = int.Parse(Console.ReadLine());

            var distance = (wingFlaps / 1000) * distanceForThousandFlaps;
            var hornetFlapsTimeSec = wingFlaps / 100;
            var rest = (wingFlaps / endurance) * 5;
            var totalRest = rest + hornetFlapsTimeSec;

            Console.WriteLine($"{distance:F2} m.");
            Console.WriteLine("{0} s.", totalRest);
            
        }
    }
}
