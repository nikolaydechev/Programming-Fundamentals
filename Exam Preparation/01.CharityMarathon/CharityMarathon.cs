using System;

namespace _01.CharityMarathon
{
    public class CharityMarathon
    {
        public static void Main()
        {
            var maratonLengthDays = decimal.Parse(Console.ReadLine());
            var listedRunners = decimal.Parse(Console.ReadLine());
            var lapsNumber = decimal.Parse(Console.ReadLine());
            var lapLength = decimal.Parse(Console.ReadLine());
            var trackCapacity = decimal.Parse(Console.ReadLine());
            var donatedMoneyPerKm = decimal.Parse(Console.ReadLine());

            var maxRunners = trackCapacity * maratonLengthDays;
            if (maxRunners > listedRunners)
            {
                maxRunners = listedRunners;
            }
            decimal totalKM = (maxRunners * lapsNumber * lapLength) / 1000;
            decimal moneyRaised = totalKM * donatedMoneyPerKm;
            Console.WriteLine($"Money raised: {moneyRaised:F2}");
        }
    }
}
