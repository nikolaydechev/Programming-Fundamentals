namespace _04.PopulationAggregation
{
    using System;

    public class SoftuniAirline
    {
        public static void Main()
        {
            decimal numberFlights = decimal.Parse(Console.ReadLine());
            
            decimal totalProfit = 0;
            decimal totalLost = 0;

            for (decimal i = 0; i < numberFlights; i++)
            {
                var adultPassengersCount = decimal.Parse(Console.ReadLine());
                var adultTicketPrice = decimal.Parse(Console.ReadLine());
                var youthPassengersCount = decimal.Parse(Console.ReadLine());
                var youthTicketPrice = decimal.Parse(Console.ReadLine());
                var fuelPricePerHour = decimal.Parse(Console.ReadLine());
                var fuelConsumptionPerHour = decimal.Parse(Console.ReadLine());
                var flightDuration = decimal.Parse(Console.ReadLine());

                var income = (adultPassengersCount * adultTicketPrice) + (youthPassengersCount * youthTicketPrice);
                var expenses = flightDuration * fuelConsumptionPerHour * fuelPricePerHour;
                
                if (income >= expenses)
                {
                    var profit = income - expenses;
                    Console.WriteLine($"You are ahead with {profit:f3}$.");
                    totalProfit += profit;
                }
                else
                {
                    var lostProfit = expenses - income;
                    Console.WriteLine($"We've got to sell more tickets! We've lost -{lostProfit:f3}$.");
                    totalLost += lostProfit;
                }
            }
            Console.WriteLine($"Overall profit -> {(totalProfit - totalLost):f3}$.");
            Console.WriteLine($"Average profit -> {((totalProfit - totalLost) / numberFlights):f3}$.");
            
        }
    }
}
